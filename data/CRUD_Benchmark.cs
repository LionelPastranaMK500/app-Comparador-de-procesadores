using app_Comparador_de_procesadores.Models;
using MySql.Data.MySqlClient;

namespace app_Comparador_de_procesadores.data
{
    public class CRUD_Benchmark
    {
        private Conexion conexion = new Conexion(); // Instancia de conexión

        public List<Benchmark> ObtenerBenchmarks()
        {
            List<Benchmark> lista = new List<Benchmark>();
            MySqlConnection conn = conexion.conectar;

            try
            {
                conn.Open();
                string query = "CALL ObtenerResultadosConNombres()";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Benchmark
                    {
                        id = reader.GetInt32("id"),
                        nombre_procesador = reader.GetString("nombre_procesador"),
                        prueba = reader.GetString("prueba"),
                        puntaje = reader.GetInt32("puntaje")
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al obtener benchmarks: " + ex.Message);
            }
            finally
            {
                conexion.desconectar();
            }

            return lista;
        }
    }
}
