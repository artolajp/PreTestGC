﻿using System.Collections.Generic;

namespace PreTest
{
    public class Tienda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Prenda> Prendas { get; set; }

        public Tienda(string nombre, string direccion, List<Prenda> prendas) {
            Nombre = nombre;
            Direccion = direccion;
            Prendas = prendas;
        }
    }
}