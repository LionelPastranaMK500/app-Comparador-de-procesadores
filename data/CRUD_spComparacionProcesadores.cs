using app_Comparador_de_procesadores.Models;
using MySql.Data.MySqlClient;

namespace app_Comparador_de_procesadores.data
{
    public class CRUD_spComparacionProcesadores
    {
        private Conexion conexion = new Conexion();

        public List<spComparacionProcesadores> ObtenerComparacionProcesadores()
        {
            List<spComparacionProcesadores> lista = new List<spComparacionProcesadores>();
            MySqlConnection conn = conexion.conectar;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("sp_MostrarComparacionProcesadores", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new spComparacionProcesadores
                    {
                        Id = reader.GetInt32("procesador_id"),
                        Nombre = reader.GetString("nombre"),
                        Marca = reader.GetString("marca"),
                        Nucleos = reader.GetInt32("nucleos"),
                        Hilos = reader.GetInt32("hilos"),
                        FrecuenciaBase = reader.GetDecimal("frecuencia_base"),
                        FrecuenciaTurbo = reader.GetDecimal("frecuencia_turbo"),
                        Tdp = reader.GetInt32("tdp"),
                        Lanzamiento = reader.GetInt32("lanzamiento"),
                        Prueba = reader.GetString("prueba"),
                        Puntaje = reader.GetInt32("puntaje")
                    });
                }
            }
            finally
            {
                conexion.desconectar();
            }

            return lista;
        }
    }
}
