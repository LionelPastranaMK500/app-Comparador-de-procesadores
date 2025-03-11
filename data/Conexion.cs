
using MySql.Data.MySqlClient;

namespace app_Comparador_de_procesadores.data
{
    public class Conexion
    {
        private MySqlConnection cxn = new MySqlConnection
    ("Server=bd-g3.mysql.database.azure.com;" + " UserID = g3Admin;" + "Password=Serfelizen29;" + "Database=app_comparador_procesadores;");

        public MySqlConnection conectar
        {
            get { return cxn; }

        }

        public void desconectar()
        {
            cxn.Close();
        }

    }
}
