using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class QueriesDataBase
    {
        private SqlCommand Command;
        private SqlDataAdapter DataAdapter1;
        private DataTable Table1;

        public DataTable Procedimiento(string StoredProcedure, List<object> ValuesForms)
        {
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDataBase"].ConnectionString);
            try
            {
                Command = new SqlCommand(StoredProcedure, conn) { CommandType = CommandType.StoredProcedure };
                for (int i = 0; i < ValuesForms.Count; i++)
                    Command.Parameters.AddWithValue("@p" + (i + 1), ValuesForms[i]);
                conn.Open();
                Command.ExecuteNonQuery();
                DataAdapter1 = new SqlDataAdapter(Command);
                Table1 = new DataTable();
                DataAdapter1.Fill(Table1);
                Command.Parameters.Clear();
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error: " + Error);
            }
            finally { conn.Close(); }
            return Table1;
        }

        public void Procedimiento(string nc, byte service)
        {
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDataBase"].ConnectionString);
            try
            {
                Command = new SqlCommand("NewMove", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.AddWithValue("@p1", nc);
                Command.Parameters.AddWithValue("@p2", service);
                conn.Open();
                Command.ExecuteNonQuery();
                Command.Parameters.Clear();
            }
            catch (Exception e) { Console.WriteLine("Error: " + e.ToString()); }
            finally { conn.Close(); }
        }
    }
}
