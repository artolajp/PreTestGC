using System;
using System.Collections.Generic;
using System.Text;

namespace PreTest
{
    class Pantalon : Prenda
    {
        public bool EsChupin { get; set; }

        public Pantalon(string iD, float precio, string descripcion, bool esPremiun, int stock, bool esChupin) : base(iD, precio, descripcion, esPremiun, stock) {
            EsChupin = esChupin;
        }

        public override bool EsEquivalente(Prenda otra) {
            return base.EsEquivalente(otra) && otra is Pantalon pantalon && pantalon.EsChupin == EsChupin;
        }
    }
}
