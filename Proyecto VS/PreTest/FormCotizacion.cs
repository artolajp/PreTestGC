using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PreTest
{
    public partial class FormCotizacion : Form
    {
        private CotizadorController cotizador;

        private float precioTarget = 0;
        private int cantidadTarget = 0;
        private float stockPrendaActual = 0;

        internal CotizadorController Cotizador {
            get => cotizador;
            set {
                cotizador = value;
                ActualizarFormulario();
            }
        }

        public FormCotizacion() {
            InitializeComponent();
        }

        private void ActualizarFormulario() {
            VendedorInfoText.Text = cotizador.VendedorActual.Nombre + " " + cotizador.VendedorActual.Apellido + " | " + cotizador.VendedorActual.CodigoVendedor;
            TiendaNombreText.Text = cotizador.VendedorActual.Tienda.Nombre;
            TiendaDireccionText.Text = cotizador.VendedorActual.Tienda.Direccion;

            CamisaMangaCortaBox.Enabled = false;
            CamisaCuelloMaoBox.Enabled = false;
            PantalonChupinBox.Enabled = false;

            PrendaCalidadPremiumToggle.Checked = cotizador.PrendaTarget.EsPremiun;
            PrendaCalidadStandardToggle.Checked = !cotizador.PrendaTarget.EsPremiun;

            CamisaToggle.Checked = cotizador.PrendaTarget is Camisa;
            PantalonToggle.Checked = cotizador.PrendaTarget is Pantalon;

            PrendaCantidadInputText.Text = "0";
            PrendaPrecioInputText.Text = "0";

            OnPrendaChanged();
        }

        private void OnCantidadChanged() {
            int stock = 0;
            if (int.TryParse(PrendaCantidadInputText.Text, out stock) && stock >= 0 && stock <= stockPrendaActual) {
                PrendaCantidadInputText.BackColor = Color.White;
            } else {
                PrendaCantidadInputText.BackColor = Color.Orange;
            }
            cantidadTarget = stock;
        }

        private void OnPrecioChanged() {
            float precio = 0;
            if (float.TryParse(PrendaPrecioInputText.Text, out precio) && precio >= 0) {
                PrendaPrecioInputText.BackColor = Color.White;
            } else {
                PrendaPrecioInputText.BackColor = Color.Orange;
            }
            precioTarget = precio;
        }

        private void OnPrendaChanged() {
            stockPrendaActual = cotizador.GetStockPrenda(cotizador.PrendaTarget);
            PrendaStockText.Text = stockPrendaActual.ToString();
            OnCantidadChanged();

            precioTarget = cotizador.GetPrendaActual().Precio;
            PrendaPrecioInputText.Text = precioTarget.ToString("0.00");
            OnPrecioChanged();
        }

        private void CamisaToggle_CheckedChanged(object sender, EventArgs e) {

            cotizador.PrendaTarget = new Camisa("", 0, "", PrendaCalidadPremiumToggle.Checked, 0, CamisaMangaCortaBox.Checked, CamisaCuelloMaoBox.Checked);

            CamisaMangaCortaBox.Enabled = true;
            CamisaCuelloMaoBox.Enabled = true;
            PantalonChupinBox.Enabled = false;

            OnPrendaChanged();

        }

        private void PantalonToggle_CheckedChanged(object sender, EventArgs e) {

            cotizador.PrendaTarget = new Pantalon("", 0, "", PrendaCalidadPremiumToggle.Checked, 0, PantalonChupinBox.Checked);

            CamisaMangaCortaBox.Enabled = false;
            CamisaCuelloMaoBox.Enabled = false;
            PantalonChupinBox.Enabled = true;

            OnPrendaChanged();
        }

        private void PrendaCalidadStandardToggle_CheckedChanged(object sender, EventArgs e) {
            cotizador.PrendaTarget.EsPremiun = false;

            OnPrendaChanged();
        }

        private void PrendaCalidadPremiumToggle_CheckedChanged(object sender, EventArgs e) {
            cotizador.PrendaTarget.EsPremiun = true;

            OnPrendaChanged();
        }

        private void CamisaMangaCortaBox_CheckedChanged(object sender, EventArgs e) {
            ((Camisa)cotizador.PrendaTarget).EsMangaCorta = CamisaMangaCortaBox.Checked;

            OnPrendaChanged();
        }

        private void CamisaCuelloMaoBox_CheckedChanged(object sender, EventArgs e) {
            ((Camisa)cotizador.PrendaTarget).TieneCuelloMao = CamisaCuelloMaoBox.Checked;

            OnPrendaChanged();
        }

        private void PantalonChupinBox_CheckedChanged(object sender, EventArgs e) {
            ((Pantalon)cotizador.PrendaTarget).EsChupin = PantalonChupinBox.Checked;

            OnPrendaChanged();
        }

        private void PrendaPrecioInputText_TextChanged(object sender, EventArgs e) {
            OnPrecioChanged();
        }

        private void PrendaCantidadInputText_TextChanged(object sender, EventArgs e) {
            OnCantidadChanged();
        }

        private void CotizarButton_Click(object sender, EventArgs e) {
            try {
                Prenda prenda = cotizador.GetPrendaActual();
                prenda.EsPremiun = cotizador.PrendaTarget.EsPremiun;// !!! se va actualizado porque no distinción de la calidad del stock actual

                float cotizacion = cotizador.Cotizar(prenda, precioTarget, cantidadTarget);
                CotizacionMontoText.Text = cotizacion.ToString("0.00");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hubo un error");
            }
        }

        private void CotizacionesHistorialLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {         


            StringBuilder message = new StringBuilder();
            if (cotizador.Cotizaciones.Count > 0) {

                message.Append("ID");
                message.Append("\t");
                message.Append("Fecha y Hora\t");
                message.Append("\t");
                message.Append("Prenda");
                message.Append("\t");
                message.Append("Cantidad");
                message.Append("\t");
                message.Append("Monto total");
                message.Append("\n");

                cotizador.Cotizaciones.ForEach((Cotizacion cotizacion) => {
                    if (cotizacion.Vendedor == cotizador.VendedorActual) {
                        message.Append(cotizacion.ID);
                        message.Append("\t");
                        message.Append(cotizacion.FechaHora);
                        message.Append("\t");
                        message.Append(cotizacion.Prenda.ID);
                        message.Append("\t");
                        message.Append(cotizacion.Cantidad);
                        message.Append("\t");
                        message.Append(cotizacion.Monto);
                        message.Append("\n");
                    }
                });

            } else {
                message.Append("No registra cotizaciones");
            }
            message.Append("\n");

            string title = "Historial de cotizaciones de "+ cotizador.VendedorActual.CodigoVendedor;

            MessageBox.Show(message.ToString(), title);
        }
    }
}
