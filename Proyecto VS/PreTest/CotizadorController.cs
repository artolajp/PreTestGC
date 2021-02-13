using System;
using System.Collections.Generic;
using System.Text;

namespace PreTest
{
    class CotizadorController
    {
        public Vendedor VendedorActual { get; private set; }

        private List<Descuento> descuentos;

        public List<Cotizacion> Cotizaciones { get; private set; }

        public Prenda PrendaTarget { get; set; } = new Prenda("", 0, "", false, 0);

        public CotizadorController(Vendedor vendedorActual) {
            this.VendedorActual = vendedorActual;
            Cotizaciones = new List<Cotizacion>();

            descuentos = new List<Descuento>();

            //RN 1- Si la camisa es de tipo manga corta, el precio se rebaja en un 10%.
            descuentos.Add(new Descuento(10, (Prenda prenda) => prenda is Camisa camisa && camisa.EsMangaCorta));

            // RN 2- Si la camisa tiene cuello mao, el precio aumenta en un 3%.
            descuentos.Add(new Descuento(-3, (Prenda prenda) => prenda is Camisa camisa && camisa.TieneCuelloMao));

            //RN 3- Si la camisa es de manga corta y cuello mao, deben aplicarse las dos reglas anteriores (en el orden establecido). 

            //RN 4- Si el pantalón es chupín, el precio se rebaja en un 12%.
            descuentos.Add(new Descuento(12, (Prenda prenda) => prenda is Pantalon pantalon && pantalon.EsChupin));

            //N 5- Si la calidad de la prenda es Standard: el precio no se modifica. 

            //RN 6- Si la calidad de la prenda es Premium: el precio aumenta en un 30%.
            descuentos.Add(new Descuento(-30, (Prenda prenda) => prenda is Pantalon && prenda.EsPremiun));

        }

        public float Cotizar(Prenda prenda, float precio, int cantidad) {
            if(prenda == null) {
                throw new Exception("No existe la prenda");
            }
            if (precio <=0) {
                throw new Exception("Precio Invalido");
            }
            if (cantidad <= 0 ) {
                throw new Exception("Cantidad invalida");
            }
            if (cantidad > GetStockPrenda(prenda)) {
                throw new Exception("No hay stock suficiente");
            }

            foreach (Descuento descuento in descuentos) {
                if (descuento.Regla(prenda)) {
                    precio = precio - precio * descuento.Porcentaje / 100;
                }
            }

            precio *= cantidad;

            Cotizaciones.Add(new Cotizacion(NuevoCodigoCotizacion(), System.DateTime.Now, VendedorActual, prenda, precio, cantidad));

            return precio;
        }

        private string NuevoCodigoCotizacion() {
            return VendedorActual.CodigoVendedor + "-" + (Cotizaciones.Count + 1);
        }

        public int GetStockPrenda(Prenda prenda) {
            int stock = 0;
            foreach (Prenda p in VendedorActual.Tienda.Prendas) {
                if (prenda.EsEquivalente(p)) stock += p.Stock;
            }

            return stock;
        }

        public Prenda GetPrendaActual() {
            Prenda prenda = null;
            foreach (Prenda p in VendedorActual.Tienda.Prendas) {
                if (PrendaTarget.EsEquivalente(p)) {
                    prenda = p;
                    break;
                }
            }

            return prenda;
        }
    }
}
