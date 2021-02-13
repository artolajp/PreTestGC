namespace PreTest
{
    class Descuento
    {

        public delegate bool ReglaDescuento(Prenda prenda);

        public float Porcentaje { get; set; }

        public ReglaDescuento Regla { get; }


        public Descuento(float porcentaje, ReglaDescuento regla) {
            Porcentaje = porcentaje;
            Regla = regla;
        }



    }
}