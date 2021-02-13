using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreTest
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            List<Prenda> prendas = new List<Prenda>();

            /*
                1000 camisas en total, de las cuales:
                    500 de manga corta
                        200 con cuello mao
                        300 con cuello normal
                    500 de manga larga
                        150 con cuello mao
                        350 con cuello normal

                2000 pantalones en total, de los cuales:
                    1500 son chupines
                    500 son normales
             */

            Prenda prenda = new Camisa("C001",1000,"",false,200,true,true);
            prendas.Add(prenda);
            prenda = new Camisa("C002", 1000, "", false, 300, true, false);
            prendas.Add(prenda);
            prenda = new Camisa("C003", 1000, "", false, 150, false, true);
            prendas.Add(prenda);
            prenda = new Camisa("C004", 1000, "", false, 350, false, false);
            prendas.Add(prenda);

            prenda = new Pantalon("P001", 1500, "", false, 1500, true);
            prendas.Add(prenda);
            prenda = new Pantalon("P002", 1500, "", false, 500, false);
            prendas.Add(prenda);

            Tienda tienda = new Tienda("Principal", "San Martin 10, Ciudad", prendas);

            Vendedor vendedor = new Vendedor("Juan Pablo", "Artola", "A001", tienda);

            CotizadorController cotizadorController = new CotizadorController(vendedor);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormCotizacion form = new FormCotizacion();
            form.Cotizador = cotizadorController;

            Application.Run(form);
        }
    }
}
