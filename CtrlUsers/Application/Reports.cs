using System;
using System.Data;
using System.Windows.Forms;
using BusinessLayer;
using Entity;

namespace Application
{
    public partial class Reports : Form
    {
        #region Instancias

        private Alerts pregunta;
        private ReportLayer.Reports ObjReports = new ReportLayer.Reports();
        private Business ObjBusiness = new Business();
        AdminEntity ObjSession = new AdminEntity();

        #endregion
        private string[] Columnas = new string[] { "Número de Registro", "Número de Control", "Servicio Utilizado", "Hora de registro (24h)", "Fecha de registro (dd/mm/yyyy)" };
        private Control[] arreglo;
        public string Usuario;
        private byte menu;
        private DialogResult dr;

        public Reports()
        {
            InitializeComponent();
        }

        public void UserSession(AdminEntity ObjSession)
        {
            this.ObjSession = ObjSession;
        }

        private void RecargarDatos(DataGridView Grid)
        {
            Grid.DataSource = ObjBusiness.SelectAll("CargarMovimientos");
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { ButtonReport, ButtonClean };
            for (; menu < arreglo.Length; menu++)
                if (arreglo[menu] == sender)
                    break;
            switch (menu)
            {
                case 0:
                    if(ComboServicios.SelectedIndex >= 0)
                    {
                        DataGridView GridHombres = new DataGridView();
                        GridHombres.Columns.Add("Registro", "REGISTRO");
                        GridHombres.Columns.Add("NumControl", "NUMERO DE CONTROL");
                        GridHombres.Columns.Add("Nombres", "NOMBRES");
                        GridHombres.Columns.Add("ApellidoPaterno", "APELLIDO PATERNO");
                        GridHombres.Columns.Add("ApellidoMaterno", "APELLIDO MATERNO");
                        GridHombres.Columns.Add("Servicio", "SERVICIO");
                        GridHombres.Columns.Add("Hora", "HORA");
                        GridHombres.Columns.Add("Fecha", "FECHA");
                        DataGridView GridMujeres = new DataGridView();
                        GridMujeres.Columns.Add("Registro", "REGISTRO");
                        GridMujeres.Columns.Add("NumControl", "NUMERO DE CONTROL");
                        GridMujeres.Columns.Add("Nombres", "NOMBRES");
                        GridMujeres.Columns.Add("ApellidoPaterno", "APELLIDO PATERNO");
                        GridMujeres.Columns.Add("ApellidoMaterno", "APELLIDO MATERNO");
                        GridMujeres.Columns.Add("Servicio", "SERVICIO");
                        GridMujeres.Columns.Add("Hora", "HORA");
                        GridMujeres.Columns.Add("Fecha", "FECHA");
                        GridHombres.DataSource = ObjBusiness.ReporteDeServicios(Convert.ToByte(ComboServicios.SelectedIndex),'H');
                        GridMujeres.DataSource = ObjBusiness.ReporteDeServicios(Convert.ToByte(ComboServicios.SelectedIndex), 'F');
                        DataRow row = ObjBusiness.ExistUserOrAdmin(this.ObjSession.NumControl, "ExistAdmin").Rows[0];
                        string UserFull = row.ItemArray[1].ToString() + " " + row.ItemArray[2].ToString() + " " + row.ItemArray[3].ToString();
                        ObjReports.GenerarReportePDF(GridHombres, GridMujeres, UserFull);
                    }
                    else
                    {
                        pregunta = new Alerts((byte)TypeIcon.Warning, "Servicio no elegido", "Es necesario que eligas un servicio", "Para generar el reporte, es obligatorio que eligas el servicio del reporte que necesitas.", false);
                        dr = pregunta.ShowDialog();
                        if (dr == DialogResult.Yes)
                            pregunta.Close();
                    }
                    break;
                case 1:
                    ComboServicios.SelectedIndex = -1;
                    ComboServicios.Focus();
                    break;
            }
            menu = 0;
        }
    }
}
