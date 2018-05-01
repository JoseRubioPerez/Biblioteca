using CapaDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class Negocio
    {
        internal enum DatoSQL { VarChar = 1, Char = 2, Int = 3, Date = 4, Time = 5, Image = 6 }

        #region Instancias

        private Datos datos = new Datos();

        #endregion Instancias

        private DataTable data;
        private List<object> Valor = new List<object>();
        private List<string> Parametros = new List<string>();
        private List<byte> TipoDato = new List<byte>();

        public Negocio() { }

        public DataTable Sesion(string nc, string password)
        {
            Valor.Clear(); Parametros.Clear(); TipoDato.Clear();
            Valor.Add(nc); Valor.Add(password);
            Parametros.Add("@user"); Parametros.Add("@pass");
            TipoDato.Add((byte)DatoSQL.VarChar); TipoDato.Add((byte)DatoSQL.VarChar);
            data = datos.Procedimiento("Logeo", Valor, Parametros, TipoDato);
            return data;
        }

        public DataTable Registry(string nc, byte servicio)
        {
            Valor.Clear(); Parametros.Clear(); TipoDato.Clear();
            Valor.Add(nc); Valor.Add(servicio);
            Parametros.Add("@nc"); Parametros.Add("@servicio");
            TipoDato.Add((byte)DatoSQL.VarChar); TipoDato.Add((byte)DatoSQL.Int);
            data = datos.Procedimiento("NewMove", Valor, Parametros, TipoDato);
            return data;
        }
    }
}
