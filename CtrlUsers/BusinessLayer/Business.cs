using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using Entity;

namespace BusinessLayer
{
    public class Business
    {
        private QueriesDataBase ObjQueryDataBase = new QueriesDataBase();
        private DataTable Table;
        private List<object> Valor = new List<object>();
        private List<string> Parametros = new List<string>();

        public Business()
        {
        }

        public DataTable Sesion(SessionsEntity ObjSession)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(ObjSession.Username); Valor.Add(ObjSession.Password);
            Parametros.Add("@user"); Parametros.Add("@pass");
            Table = ObjQueryDataBase.Procedimiento("Logeo", Valor, Parametros);
            return Table;
        }

        public DataTable Search(byte index, string[] valor)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(valor[0]); Parametros.Add("@nc");
            Valor.Add(valor[1]); Parametros.Add("@nombres");
            Valor.Add(valor[2]); Parametros.Add("@apellidopat");
            Valor.Add(valor[3]); Parametros.Add("@apellidomat");
            Valor.Add(Convert.ToChar(valor[4])); Parametros.Add("@sexo");
            Valor.Add(valor[5]); Parametros.Add("@area");
            Valor.Add(Convert.ToChar(valor[6])); Parametros.Add("@status");
            Valor.Add(index); Parametros.Add("@index");
            Table = ObjQueryDataBase.Procedimiento("Search", Valor, Parametros);
            return Table;
        }

        public DataTable Moves(byte index, string[] valor)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(valor[0]); Parametros.Add("@nc");
            Valor.Add(valor[1]); Parametros.Add("@servicio");
            Valor.Add(ConvertirFecha(valor[2])); Parametros.Add("@fechaI");
            Valor.Add(ConvertirFecha(valor[3])); Parametros.Add("@fechaF");
            Valor.Add(index); Parametros.Add("@index");
            Table = ObjQueryDataBase.Procedimiento("Moves", Valor, Parametros);
            return Table;
        }

        public void ChangePassword(string user, string password, string newpassword)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(user); Valor.Add(password); Valor.Add(newpassword);
            Parametros.Add("@user"); Parametros.Add("@pass"); Parametros.Add("@newpass");
            Table = ObjQueryDataBase.Procedimiento("ChangePassword", Valor, Parametros);
        }

        public void ChangeOthersPassword(string nc, string newpassword)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Valor.Add(newpassword);
            Parametros.Add("@nc"); Parametros.Add("@newpass");
            Table = ObjQueryDataBase.Procedimiento("ChangeOtherPassword", Valor, Parametros);
        }

        public void LlenarCombo(ComboBox combo, string StoredProcedure, byte Opcion)
        {
            try
            {
                combo.Items.Clear(); Valor.Clear(); Parametros.Clear();
                Table = ObjQueryDataBase.Procedimiento(StoredProcedure, Valor, Parametros);
                switch (Opcion)
                {
                    case 0:
                        for (int i = 0; i < Table.Rows.Count; i++)
                            combo.Items.Add(Table.Rows[i][0].ToString() + " " + Table.Rows[i][1].ToString() + " " + Table.Rows[i][2].ToString() + " " + Table.Rows[i][3].ToString());
                        break;
                    case 1:
                        for (int i = 0; i < Table.Rows.Count; i++)
                            combo.Items.Add(Table.Rows[i][0].ToString());
                        break;
                }
            }
            catch (Exception e) { Console.WriteLine("Error:\nMétodo: LC01 en N falló\n" + e.Message); }
        }

        public DataTable SelectAll(string StoredProcedure)
        {
            Valor.Clear(); Parametros.Clear();
            Table = ObjQueryDataBase.Procedimiento(StoredProcedure, Valor, Parametros);
            return Table;
        }

        public DataTable AddNewAdmin(string nc, string nombres, string apellidopat, string apellidomat, char sexo, string password, char supersu)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Valor.Add(nombres); Valor.Add(apellidopat); Valor.Add(apellidomat); Valor.Add(sexo); Valor.Add(password); Valor.Add(supersu);
            Parametros.Add("@nc"); Parametros.Add("@nombres"); Parametros.Add("@apellidopat"); Parametros.Add("@apellidomat"); Parametros.Add("@sexo"); Parametros.Add("@password"); Parametros.Add("@supersu");
            Table = ObjQueryDataBase.Procedimiento("AddNewAdmin", Valor, Parametros);
            return Table;
        }

        public DataTable ExistUserOrAdmin(string nc, string StoredProcedure)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Parametros.Add("@nc");
            Table = ObjQueryDataBase.Procedimiento(StoredProcedure, Valor, Parametros);
            return Table;
        }

        public DataTable UpdatePermissionAdmin(string nc, char permiso)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Parametros.Add("@nc");
            Valor.Add(permiso); Parametros.Add("@supersu");
            Table = ObjQueryDataBase.Procedimiento("UpdateAdmin", Valor, Parametros);
            return Table;
        }

        public void Bitacora(string nc, string sistema, string accion)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(nc); Valor.Add(sistema); Valor.Add(accion);
            Parametros.Add("@nc"); Parametros.Add("@sistema"); Parametros.Add("@accion");
            ObjQueryDataBase.Procedimiento("Bitacora", Valor, Parametros);
        }

        public DataTable ReporteModuloUsuarios(byte index)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(index);
            Parametros.Add("@index");
            Table = ObjQueryDataBase.Procedimiento("ReporteUsuariosSalasPorSexo", Valor, Parametros);
            return Table;
        }

        public DataTable ReporteModuloServicios(byte index, byte sexo)
        {
            Valor.Clear(); Parametros.Clear();
            Valor.Add(index); Valor.Add(sexo);
            Parametros.Add("@index"); Parametros.Add("@sexo");
            Table = ObjQueryDataBase.Procedimiento("ReporteServiciosPorSexo", Valor, Parametros);
            return Table;
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

        public DataTable ReadCSV(string str)
        {
            QueriesOLEDataBase ObjQueryOLEBDataBase = new QueriesOLEDataBase(str);
            return ObjQueryOLEBDataBase.ProcedimientoOLEDB();
        }
    }
}
