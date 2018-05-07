using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class Negocio
    {
        internal enum DatoSQL { VarChar = 1, Char = 2, Int = 3, TinyInt = 4, Date = 5, Time = 6, Image = 7 }

        #region Instancias

        private Datos datos = new Datos();

        #endregion Instancias

        private DataTable data;
        private List<object> Valor = new List<object>();
        private List<string> Parametros = new List<string>();

        public Negocio() { }

        public DataTable Sesion(string nc, string password)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Valor.Add(password);
            Parametros.Add("@user"); Parametros.Add("@pass");
            data = datos.Procedimiento("Logeo", Valor, Parametros);
            datos.Procedimiento("Logeo",Valor, Parametros);
            return data;
        }

        public void Registry(string nc, byte servicio)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Valor.Add(servicio);
            Parametros.Add("@nc"); Parametros.Add("@servicio");
            datos.Insersion("NewMove", Valor, Parametros);
        }

        public void Bitacora(string nc, string sistema, string accion)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Valor.Add(sistema); Valor.Add(accion);
            Parametros.Add("@nc"); Parametros.Add("@sistema"); Parametros.Add("@accion");
            datos.Insersion("Bitacora", Valor, Parametros);
        }

        public DataTable ExistUsuario(string nc)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Parametros.Add("@nc");
            data = datos.Procedimiento("ExistUsuario", Valor, Parametros);
            return data;
        }
    }
}
