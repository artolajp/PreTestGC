using System;
using System.Collections.Generic;
using System.Text;

namespace PreTest
{
    class Cotizacion
    {
        public int ID { get; }
        public DateTime FechaHora { get; set; }
        public Vendedor Vendedor { get; set; }
        public Prenda Prenda { get; set; }


    }
}
