namespace app_Comparador_de_procesadores.Models
{
    public class Benchmark
    {
        public int id { get; set; }
        public int procesador_id { get; set; }
        public string prueba { get; set; }
        public int puntaje { get; set; }
        public string nombre_procesador { get; set; }
    }
}