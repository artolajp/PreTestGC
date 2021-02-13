using System;
using System.Collections.Generic;
using System.Text;

namespace PreTest
{
    class CotizadorController
    {
        private Vendedor vendedorActual;

        private List<Descuento> descuentos;

        private List<Cotizacion> cotizaciones;

        public CotizadorController(Vendedor vendedorActual) {
            this.vendedorActual = vendedorActual;
            cotizaciones = new List<Cotizacion>();

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


        public float Cotizar(Prenda prenda) {

            float precio = prenda.Precio;

            foreach (Descuento descuento in descuentos) {
                if (descuento.Regla(prenda)) {
                    precio = precio - precio* descuento.Porcentaje / 100;
                }
            }

            cotizaciones.Add(new Cotizacion(NuevoCodigoCotizacion(),System.DateTime.Now,vendedorActual,prenda,precio));

            return precio;
        }

        private string NuevoCodigoCotizacion() {
            return vendedorActual.CodigoVendedor+"-"+(cotizaciones.Count+1);
        } 
    }
}
