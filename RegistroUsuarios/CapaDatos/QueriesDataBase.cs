using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class QueriesDataBase
    {
        private static string StringConnection { get; } = ConfigurationManager.ConnectionStrings["ConexDB"].ConnectionString;
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter da;
        private DataTable table;

        /// <summary>
        /// Method for mass queries to the database
        /// </summary>
        /// <param name="StoredProcedure">string Name of the stored procedure</param>
        /// <param name="ValuesForms">List<object> List of values by the user already validated</param>
        /// <param name="Params">List<sttring> Nombres de las variables en el procedimiento almacenado</param>
        /// <returns></returns>
        public DataTable Procedimiento(string StoredProcedure, List<object> ValuesForms, List<string> Params)
        {
            SqlConnection conn = new SqlConnection(StringConnection);
            try
            {
                cmd = new SqlCommand(StoredProcedure, conn) { CommandType = CommandType.StoredProcedure };
                for (int i = 0; i < ValuesForms.Count; i++)
                    cmd.Parameters.AddWithValue(Params[i], ValuesForms[i]);
                conn.Open();
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                table = new DataTable();
                da.Fill(table);
                cmd.Parameters.Clear();
            }
            catch (Exception e) { Console.WriteLine("Error: " + e.ToString()); }
            finally { conn.Close(); }
            return table;
        }

        public void Procedimiento(string nc, byte service)
        {
            SqlConnection conn = new SqlConnection(StringConnection);
            try
            {
                cmd = new SqlCommand("NewMove", conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@nc", nc);
                cmd.Parameters.AddWithValue("@servicio", service);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception e) { Console.WriteLine("Error: " + e.ToString()); }
            finally { conn.Close(); }
        }
    }
}
