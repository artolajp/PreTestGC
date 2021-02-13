using System;
using System.Collections.Generic;
using System.Text;

namespace PreTest
{
    class Camisa : Prenda {


        public bool EsMangaCorta {get;set;}
        public bool TieneCuelloMao {get;set; }

        public Camisa(string iD, float precio, string descripcion, bool esPremiun, int stock, bool esMangaCorta, bool tieneCuelloMao) 
            : base(iD, precio, descripcion, esPremiun, stock) {
            EsMangaCorta = esMangaCorta;
            TieneCuelloMao = tieneCuelloMao;
        }

        public override bool EsEquivalente(Prenda otra) {
            return base.EsEquivalente(otra) && otra is Camisa camisa && camisa.EsMangaCorta == EsMangaCorta && camisa.TieneCuelloMao == TieneCuelloMao;
        }
    }
}
