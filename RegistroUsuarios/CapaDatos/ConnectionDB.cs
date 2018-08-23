using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class ConnectionDB
    {
        //Cadena de conexión para biblioteca. Cambiar el nombre de la PC
        //"Data Source=(local);Initial Catalog=biblioteca;User ID=sa;Password=cinformacion;"
        private SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=biblioteca;Integrated Security=True;");

        public SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            return conn;
        }

        public SqlConnection CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return conn;
        }
    }
}
