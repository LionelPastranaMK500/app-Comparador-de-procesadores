
using MySql.Data.MySqlClient;

namespace app_Comparador_de_procesadores.data
{
    public class Conexion
    {
        private MySqlConnection cxn = new MySqlConnection
            ("Server=sv-bd-g3.mysql.database.azure.com;" +  // Servidor Web alojado en Azure
             "UserID=BDG3;" +       // Usuario BD de Azure
             "Password=BD-G3-2025;" + // Contraseña de la BD de Azure
             "Database=app_comparador_procesadores;"); // Nombre de la base de datos

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
