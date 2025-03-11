namespace app_Comparador_de_procesadores.Models
{
    public class Procesador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Nucleos { get; set; }
        public int Hilos { get; set; }
        public decimal FrecuenciaBase { get; set; }
        public decimal FrecuenciaTurbo { get; set; }
        public int Tdp { get; set; }
        public int Lanzamiento { get; set; }
    }
}
