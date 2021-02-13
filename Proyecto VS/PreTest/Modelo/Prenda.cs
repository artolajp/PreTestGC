namespace PreTest
{
    public class Prenda
    {
        public string ID { get; private set; }
        public float Precio { get; set; }
        public string Descripcion { get; set; }
        public bool EsPremiun { get; set; }
        public int Stock { get; set; }

        public Prenda(string iD, float precio, string descripcion, bool esPremiun, int stock) {
            ID = iD;
            Precio = precio;
            Descripcion = descripcion;
            EsPremiun = esPremiun;
            Stock = stock;
        }

        public virtual bool EsEquivalente(Prenda otra) {
            //No se especificó en las prendas del ejemplo la calidad de las mismas,  por lo que se ignora la calidad al momento de filtrar
            return true;    //    EsPremiun == otra.EsPremiun;
        }
    }
}