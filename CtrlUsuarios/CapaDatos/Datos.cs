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
            try { conex = new SqlConnection(ConfigurationManager.ConnectionStrings["biblioteca"].ConnectionString); }
            catch (Exception e)
            {
                Console.WriteLine("Error de conexión a base de datos: " + e.Message + "\n1. Verifique que el archivo \"App.config\" de la Capa de " +
                    "Presentación (CapaPre), tenga la cadena de conexión correcta y apunte a su instancia SQL (línea de código 6 a la 8).\n2. Asegurese de tener el nombre de la base de datos como \"pBiblioteca\".");
            }
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
                        case 3: case 4: case 5: metodo[i].SqlDbType = SqlDbType.Int; break;
                        case 6: metodo[i].SqlDbType = SqlDbType.Date; break;
                        case 7: metodo[i].SqlDbType = SqlDbType.Time; break;
                        case 8: metodo[i].SqlDbType = SqlDbType.Image; break;
                    }
                    cmd.Parameters.AddWithValue(NombreParametro[i], ValorTexto[i]);
                }
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                Console.WriteLine("Compilación: \"P01\" realizada con éxito.");
            }
            catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
            finally { conex.Close(); }
            return dt;
        }

        public DataTable Procedimiento(string NameProcedure)
        {
            try
            {
                cmd = new SqlCommand(NameProcedure, conex);
                cmd.CommandType = CommandType.StoredProcedure;
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                Console.WriteLine("Compilación: \"P02\" realizada con éxito.");
            }
            catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
            finally { conex.Close(); }
            return dt;
        }
    }
}