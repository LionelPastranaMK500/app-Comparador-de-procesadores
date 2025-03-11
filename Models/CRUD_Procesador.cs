using app_Comparador_de_procesadores.data;
using MySql.Data.MySqlClient;
namespace app_Comparador_de_procesadores.Models
{
    public class CRUD_Procesador
    {
        private Conexion conexion = new Conexion(); // Instancia de conexión

        public List<Procesador> ObtenerProcesadores()
        {
            List<Procesador> lista = new List<Procesador>();
            MySqlConnection conn = conexion.conectar; // Usar la conexión

            try
            {
                conn.Open();
                string query = "SELECT * FROM procesadores";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Procesador
                    {
                        Id = reader.GetInt32("id"),
                        Nombre = reader.GetString("nombre"),
                        Marca = reader.GetString("marca"),
                        Nucleos = reader.GetInt32("nucleos"),
                        Hilos = reader.GetInt32("hilos"),
                        FrecuenciaBase = reader.GetDecimal("frecuencia_base"),
                        FrecuenciaTurbo = reader.GetDecimal("frecuencia_turbo"),
                        Tdp = reader.GetInt32("tdp"),
                        Lanzamiento = reader.GetInt32("lanzamiento")
                    });
                }
            }
            finally
            {
                conexion.desconectar(); // Cerrar conexión después de usarla
            }

            return lista;
        }
    }
}
