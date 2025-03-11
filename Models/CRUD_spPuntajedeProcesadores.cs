using app_Comparador_de_procesadores.data;
using MySql.Data.MySqlClient;

namespace app_Comparador_de_procesadores.Models
{
    public class CRUD_spPuntajedeProcesadores
    {
        private Conexion conexion = new Conexion();

        public List<spPuntajeProcesadores> ObtenerPuntajeProcesadores()
        {
            List<spPuntajeProcesadores> lista = new List<spPuntajeProcesadores>();
            MySqlConnection conn = conexion.conectar;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("sp_ResumenBenchmarkPorMarca", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new spPuntajeProcesadores
                    {
                        Marca = reader.GetString("marca"),
                        Prueba = reader.GetString("prueba"),
                        Promedio_Puntaje = reader.GetInt32("promedio_puntaje"),
                        Puntaje_Maximo = reader.GetInt32("puntaje_maximo"),
                        Puntaje_Minimo = reader.GetInt32("puntaje_minimo")
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