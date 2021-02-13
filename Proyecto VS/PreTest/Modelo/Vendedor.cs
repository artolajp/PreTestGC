﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PreTest
{
    class Vendedor
    {  

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CodigoVendedor { get; set; }
        public Tienda Tienda { get; set; }

        public Vendedor(string nombre, string apellido, string codigoVendedor, Tienda tienda) {
            Nombre = nombre;
            Apellido = apellido;
            CodigoVendedor = codigoVendedor;
            Tienda = tienda;
        }

    }
}
