using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

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
    }
}
