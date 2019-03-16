using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Connections
{
    public class Queries
    {
        public DataTable ConsultaLeerRegistros(string ProcedimientoAlmacenado, List<object> Valores)
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDataBase"].ConnectionString))
            {
                using (SqlCommand Comando = new SqlCommand(ProcedimientoAlmacenado, Conexion) { CommandType = CommandType.StoredProcedure })
                {
                    Comando.Parameters.Clear();
                    if (Valores.Count > 0) for (int i = 0; i < Valores.Count; i++) Comando.Parameters.AddWithValue("@p" + (i + 1), Valores[i]);
                    Conexion.Open();
                    Comando.Prepare();
                    using (SqlDataReader LeerFilas = Comando.ExecuteReader())
                    {
                        Tabla.Load(LeerFilas);
                    }
                    Conexion.Close();
                }
            }
            return Tabla;
        }

        public int ConsultaCUD(string ProcedimientoAlmacenado, List<object> Valores)
        {
            int Resultado = 0;
            SqlTransaction Transaccion = null;
            using (SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDataBase"].ConnectionString))
            {
                using (SqlCommand Comando = new SqlCommand(ProcedimientoAlmacenado, Conexion, Transaccion) { CommandType = CommandType.StoredProcedure })
                {
                    Comando.Parameters.Clear();
                    for (int i = 0; i < Valores.Count; i++) Comando.Parameters.Add(new SqlParameter("@p" + (i + 1), Valores[i]));
                    Conexion.Open();
                    Transaccion = Conexion.BeginTransaction();
                    Comando.Prepare();
                    Comando.Transaction = Transaccion;
                    Resultado = Comando.ExecuteNonQuery();
                    if (Resultado <= 0)
                    {
                        Transaccion.Rollback();
                    }
                    else if (Resultado > 0)
                    {
                        Transaccion.Commit();
                    }
                    Conexion.Close();
                    Transaccion.Dispose();
                    return Resultado;
                }
            }
        }

    }
}
