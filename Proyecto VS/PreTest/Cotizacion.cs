using System;
using System.Collections.Generic;
using System.Text;

namespace PreTest
{
    class Cotizacion
    {
        public string ID { get; }
        public DateTime FechaHora { get;  }
        public Vendedor Vendedor { get; }
        public Prenda Prenda { get; }
        public float Monto { get; }
        public float Cantidad { get; }

        public Cotizacion(string iD, DateTime fechaHora, Vendedor vendedor, Prenda prenda, float monto, int cantidad) {
            ID = iD;
            FechaHora = fechaHora;
            Vendedor = vendedor;
            Prenda = prenda;
            Monto = monto;
            Cantidad = cantidad;
        }

    }
}
