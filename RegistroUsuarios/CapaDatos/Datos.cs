using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Datos
    {
        private SqlConnection conex; private SqlCommand cmd; private SqlDataAdapter da; private DataTable dt;

        public Datos()
        {
            try { conex = new SqlConnection(ConfigurationManager.ConnectionStrings["biblioteca"].ConnectionString); } catch (Exception e) { Console.WriteLine("Error de conexión a base de datos: " + e.Message); }
        }

        public DataTable Procedimiento(string NameProcedure, List<object> ValorTexto, List<string> NombreParametro, List<byte> idDato)
        {
            try
            {
                cmd = new SqlCommand(NameProcedure, conex);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] metodo = new SqlParameter[ValorTexto.Count];
                for (int i = 0; i < metodo.Length; i++)
                {
                    metodo[i] = new SqlParameter();
                    switch (idDato[i])
                    {
                        case 1: metodo[i].SqlDbType = SqlDbType.VarChar; break;
                        case 2: metodo[i].SqlDbType = SqlDbType.Char; break;
                        case 3: metodo[i].SqlDbType = SqlDbType.Int; break;
                        case 4: metodo[i].SqlDbType = SqlDbType.Date; break;
                        case 5: metodo[i].SqlDbType = SqlDbType.Time; break;
                        case 6: metodo[i].SqlDbType = SqlDbType.Image; break;
                    }
                    cmd.Parameters.AddWithValue(NombreParametro[i], ValorTexto[i]);
                }
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                Console.WriteLine("Tarea: \"Procedimiento\" realizada con éxito.");
            }
            catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
            finally { conex.Close(); }
            return dt;
        }
    }
}
