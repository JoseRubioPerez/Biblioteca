using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaNegocio
{
    internal enum DatoSQL { VarChar = 1, Char = 2, Int = 3, Date = 6, Time = 7, Image = 8 }

    public class Negocio
    {
        #region Instancias

        private Datos datos = new Datos();

        #endregion Instancias

        private DataTable data;
        private List<object> Valor = new List<object>();
        private List<string> Parametros = new List<string>();
        private List<byte> TipoDato = new List<byte>();

        public Negocio()
        {
        }

        public DataTable Sesion(string nc, string password)
        {
            Valor.Clear(); Parametros.Clear(); TipoDato.Clear();
            Valor.Add(nc); Valor.Add(password);
            Parametros.Add("@user"); Parametros.Add("@pass");
            TipoDato.Add((byte)DatoSQL.VarChar); TipoDato.Add((byte)DatoSQL.VarChar);
            data = datos.Procedimiento("Logeo", Valor, Parametros, TipoDato);
            return data;
        }

        public void ChangePassword(string user, string password, string newpassword)
        {
            Valor.Clear(); Parametros.Clear(); TipoDato.Clear();
            Valor.Add(user); Valor.Add(password); Valor.Add(newpassword);
            Parametros.Add("@user"); Parametros.Add("@pass"); Parametros.Add("@newpass");
            TipoDato.Add((byte)DatoSQL.VarChar); TipoDato.Add((byte)DatoSQL.VarChar); TipoDato.Add((byte)DatoSQL.VarChar);
            data = datos.Procedimiento("ChangePassword", Valor, Parametros, TipoDato);
        }

        public void ChangeOthersPassword(string nc, string newpassword)
        {
            Valor.Clear(); Parametros.Clear(); TipoDato.Clear();
            Valor.Add(nc); Valor.Add(newpassword);
            Parametros.Add("@nc"); Parametros.Add("@newpass");
            TipoDato.Add((byte)DatoSQL.VarChar); TipoDato.Add((byte)DatoSQL.VarChar);
            data = datos.Procedimiento("ChangeOtherPassword", Valor, Parametros, TipoDato);
        }

        public void ComboAdministradores(ComboBox combo, string NombreProcedure)
        {
            try
            {
                combo.Items.Clear();
                data = datos.CompletarComboBox(NombreProcedure);
                for (int i = 0; i < data.Rows.Count; i++)
                    combo.Items.Add(data.Rows[i][0].ToString() + " " + data.Rows[i][1].ToString() + " " + data.Rows[i][2].ToString() + " " + data.Rows[i][3].ToString());
            }
            catch (Exception e) { Console.WriteLine("Error:\nMétodo: LC01 en N falló\n" + e.Message); }
        }

        public DataTable SelectAll(string nameProcedure)
        {
            data = datos.Procedimiento(nameProcedure);
            return data;
        }

        /*public void ComboUsuarios(ComboBox combo, string NombreProcedure)
        {
            try
            {
                combo.Items.Clear();
                data = datos.CompletarComboBox(NombreProcedure);
                for (int i = 0; i < data.Rows.Count; i++)
                    combo.Items.Add(data.Rows[i][0].ToString() + " " + data.Rows[i][1].ToString() + " " + data.Rows[i][2].ToString() + " " + data.Rows[i][3].ToString());
            }
            catch (Exception e) { Console.WriteLine("Error:\nMétodo: LC01 en N falló\n" + e.Message); }
        }*/
    }
}