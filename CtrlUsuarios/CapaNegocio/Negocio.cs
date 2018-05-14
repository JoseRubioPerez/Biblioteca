using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaNegocio
{
    internal enum DatoSQL { VarChar = 1, Char = 2, Int = 3, TinyInt = 4, Date = 6, Time = 7, Image = 8 }

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

        public DataTable Search(byte index, string[] valor)
        {
            Valor.Clear(); Parametros.Clear(); TipoDato.Clear();
            Valor.Add(valor[0]); Parametros.Add("@nc"); TipoDato.Add((byte)DatoSQL.VarChar);
            Valor.Add(valor[1]); Parametros.Add("@nombres"); TipoDato.Add((byte)DatoSQL.VarChar);
            Valor.Add(valor[2]); Parametros.Add("@apellidopat"); TipoDato.Add((byte)DatoSQL.VarChar);
            Valor.Add(valor[3]); Parametros.Add("@apellidomat"); TipoDato.Add((byte)DatoSQL.VarChar);
            Valor.Add(Convert.ToChar(valor[4])); Parametros.Add("@sexo"); TipoDato.Add((byte)DatoSQL.Char);
            Valor.Add(valor[5]); Parametros.Add("@area"); TipoDato.Add((byte)DatoSQL.VarChar);
            Valor.Add(Convert.ToChar(valor[6])); Parametros.Add("@status"); TipoDato.Add((byte)DatoSQL.Char);
            Valor.Add(index); Parametros.Add("@index"); TipoDato.Add((byte)DatoSQL.TinyInt);
            data = datos.Procedimiento("Search", Valor, Parametros, TipoDato);
            return data;
        }

        public DataTable Moves(byte index, string[] valor)
        {
            Valor.Clear(); Parametros.Clear(); TipoDato.Clear();
            Valor.Add(valor[0]); Parametros.Add("@nc"); TipoDato.Add((byte)DatoSQL.VarChar);
            Valor.Add(valor[1]); Parametros.Add("@servicio"); TipoDato.Add((byte)DatoSQL.VarChar);
            Valor.Add(ConvertirFecha(valor[2])); Parametros.Add("@fechaI"); TipoDato.Add((byte)DatoSQL.VarChar);
            Valor.Add(ConvertirFecha(valor[3])); Parametros.Add("@fechaF"); TipoDato.Add((byte)DatoSQL.VarChar);
            Valor.Add(index); Parametros.Add("@index"); TipoDato.Add((byte)DatoSQL.TinyInt);
            data = datos.Procedimiento("Moves", Valor, Parametros, TipoDato);
            return data;
        }

        static private object ConvertirFecha(string fecha)
        {
            if (!string.IsNullOrEmpty(fecha))
            {
                string tempYear = fecha[6].ToString() + fecha[7].ToString() + fecha[8].ToString() + fecha[9].ToString();
                string tempMonth = fecha[3].ToString() + fecha[4].ToString();
                string tempDay = fecha[0].ToString() + fecha[1].ToString();
                return fecha = tempYear + "-" + tempMonth + "-" + tempDay;
            }
            else
                return fecha;
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
                data = datos.Procedimiento(NombreProcedure);
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

        public DataTable AddNewAdmin(string nc, string nombres, string apellidopat, string apellidomat, char sexo, string password, char supersu)
        {
            Valor.Clear(); Parametros.Clear(); TipoDato.Clear();
            Valor.Add(nc); Valor.Add(nombres); Valor.Add(apellidopat); Valor.Add(apellidomat); Valor.Add(sexo); Valor.Add(password); Valor.Add(supersu);
            Parametros.Add("@nc"); Parametros.Add("@nombres"); Parametros.Add("@apellidopat"); Parametros.Add("@apellidomat"); Parametros.Add("@sexo"); Parametros.Add("@password"); Parametros.Add("@supersu");
            TipoDato.Add((byte)DatoSQL.VarChar); TipoDato.Add((byte)DatoSQL.VarChar); TipoDato.Add((byte)DatoSQL.VarChar); TipoDato.Add((byte)DatoSQL.VarChar); TipoDato.Add((byte)DatoSQL.Char); TipoDato.Add((byte)DatoSQL.VarChar); TipoDato.Add((byte)DatoSQL.Char);
            data = datos.Procedimiento("AddNewAdmin", Valor, Parametros, TipoDato);
            return data;
        }

        public DataTable ExistUserOrAdmin(string nc, string NameProcedure)
        {
            Valor.Clear(); Parametros.Clear(); TipoDato.Clear();
            Valor.Add(nc); Parametros.Add("@nc"); TipoDato.Add((byte)DatoSQL.VarChar);
            data = datos.Procedimiento(NameProcedure, Valor, Parametros, TipoDato);
            return data;
        }

        public DataTable UpdatePermissionAdmin(string nc, char permiso)
        {
            Valor.Clear(); Parametros.Clear(); TipoDato.Clear();
            Valor.Add(nc); Parametros.Add("@nc"); TipoDato.Add((byte)DatoSQL.VarChar);
            Valor.Add(permiso); Parametros.Add("@supersu"); TipoDato.Add((byte)DatoSQL.Char);
            data = datos.Procedimiento("UpdateAdmin", Valor, Parametros, TipoDato);
            return data;
        }

        public void Bitacora(string nc, string sistema, string accion)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Valor.Add(sistema); Valor.Add(accion);
            Parametros.Add("@nc"); Parametros.Add("@sistema"); Parametros.Add("@accion");
            datos.Insersion("Bitacora", Valor, Parametros);
        }
    }
}