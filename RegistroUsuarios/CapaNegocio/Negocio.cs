﻿using CapaDatos;
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

        /// <summary>
        /// Inicio de sesión para la aplicación
        /// </summary>
        /// <param name="nc">string Número de control del usuario</param>
        /// <param name="password">string Contraseña del usuario</param>
        /// <returns></returns>
        public DataTable Sesion(string nc, string password)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Valor.Add(password);
            Parametros.Add("@user"); Parametros.Add("@pass");
            data = datos.Procedimiento("Logeo", Valor, Parametros);
            datos.Procedimiento("Logeo",Valor, Parametros);
            return data;
        }

        /// <summary>
        /// Método para registrar un nuevo movimiento en la base de datos
        /// </summary>
        /// <param name="nc">string Número de control</param>
        /// <param name="servicio">byte Clave del servicio que se va a utilizar</param>
        public void Registry(string nc, byte servicio)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Valor.Add(servicio);
            Parametros.Add("@nc"); Parametros.Add("@servicio");
            datos.Insersion("NewMove", Valor, Parametros);
        }

        /// <summary>
        /// Método que registra la entrada de un administrador en el sistema
        /// </summary>
        /// <param name="nc">string Número de control</param>
        /// <param name="sistema">string Sistema al que se esta accediendo</param>
        /// <param name="accion">string Acción que se esta realizando</param>
        public void Bitacora(string nc, string sistema, string accion)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Valor.Add(sistema); Valor.Add(accion);
            Parametros.Add("@nc"); Parametros.Add("@sistema"); Parametros.Add("@accion");
            datos.Insersion("Bitacora", Valor, Parametros);
        }

        /// <summary>
        /// Método que consulta sí existe un usuario en la base de datos
        /// </summary>
        /// <param name="nc">string Número de control</param>
        /// <returns></returns>
        public DataTable ExistUsuario(string nc)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Parametros.Add("@nc");
            data = datos.Procedimiento("ExistUsuario", Valor, Parametros);
            return data;
        }
    }
}
