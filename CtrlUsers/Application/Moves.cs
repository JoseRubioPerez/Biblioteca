using System;
using System.Windows.Forms;
using BusinessLayer;

namespace Application
{
    public partial class Moves : FatherConfig
    {
        #region Instancias

        private Business ObjBusiness = new Business();
        private ReportLayer.Reports ObjReports = new ReportLayer.Reports();

        #endregion Instancias

        private string[] Columnas = new string[] { "Número de Registro", "Número de Control", "Servicio Utilizado", "Hora de registro (24h)", "Fecha de registro (dd/mm/yyyy)" };
        private Control[] arreglo;
        public string Usuario;
        private byte menu;

        public Moves()
        {
            InitializeComponent();
            Controles(3, false);
            btnSearch.Visible = false;
        }

        private void RecargarDatos()
        {
            GridSearch.DataSource = ObjBusiness.SelectAll("CargarMovimientos");
        }

        private void Controles(byte index, bool bandera)
        {
            numControl1.Visible = false;
            servicio1.Visible = false;
            fecha1.Visible = false;
            switch (index)
            {
                case 0: numControl1.Visible = bandera; numControl1.txtNumControl.Focus(); numControl1.TabIndex = (numControl1.Visible) ? 2 : 4; break;
                case 1: servicio1.Visible = bandera; servicio1.comboAreas.Focus(); servicio1.TabIndex = (servicio1.Visible) ? 2 : 4; break;
                case 2: fecha1.Visible = bandera; fecha1.dateInicio.Focus(); fecha1.TabIndex = (fecha1.Visible) ? 2 : 4; break;
                default: break;
            }
            btnSearch.Visible = (bandera) ? true : false;
        }

        private void LimpiarCampos()
        {
            numControl1.txtNumControl.Text = "";
            servicio1.comboAreas.SelectedIndex = -1;
            fecha1.dateInicio.Value = DateTime.Now;
            fecha1.dateFin.Value = DateTime.Now;
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { btnSearch, btnAllUsers, btnPDF };
            for (; menu < arreglo.Length; menu++)
                if (arreglo[menu] == sender)
                    break;
            switch (menu)
            {
                case 0:
                    Alerts pregunta;
                    DialogResult dr;
                    try
                    {
                        bool alert = false;
                        string servicio = "";
                        switch (comboTypeMoves.SelectedIndex)
                        {
                            case 0: alert = (numControl1.Visible && numControl1.txtNumControl.Text.Trim() != "") ? true : false; break;
                            case 1:
                                alert = (servicio1.Visible && servicio1.comboAreas.SelectedIndex != -1) ? true : false;
                                servicio = (servicio1.comboAreas.SelectedIndex < 0) ? "" : servicio1.comboAreas.SelectedItem.ToString();
                                break;

                            case 2: alert = (fecha1.Visible) ? true : false; break;
                        }
                        if (alert)
                        {
                            string[] Valor = new string[] { numControl1.txtNumControl.Text.Trim(), servicio, fecha1.dateInicio.Value.ToShortDateString(), fecha1.dateFin.Value.ToShortDateString() };
                            GridSearch.DataSource = ObjBusiness.Moves(Convert.ToByte(comboTypeMoves.SelectedIndex), Valor);
                            for (int i = 0; i < GridSearch.Rows.Count; i++)
                                GridSearch.Rows[i].Cells["hora"].Value = GridSearch.Rows[i].Cells["hora"].Value.ToString().Substring(0, 7);
                        }
                        else
                        {
                            pregunta = new Alerts((byte)TypeIcon.Warning, "Búsqueda vacia", "No se permiten búsquedas vacias", "Por favor, ingrese un rato poder continuar la búsqueda.", false);
                            dr = pregunta.ShowDialog();
                            if (dr == DialogResult.No)
                                pregunta.Close();
                        }
                    }
                    catch (Exception ex) { Console.WriteLine("Ocurrió un error:\n" + ex.ToString()); }
                    break;

                case 1: RecargarDatos(); break;
                case 2:
                    pregunta = new Alerts((byte)TypeIcon.Warning, "Nuevo reporte", "¿De verdad quieres crear un nuevo reporte?", "Sí aceptas, el reporte será llenado con los datos del usuario que inició sesión y con los datos de la tabla.", true);
                    dr = pregunta.ShowDialog();
                    if (dr == DialogResult.Yes)
                    {
                        if (GridSearch.RowCount > 0)
                            ObjReports.GenerarDocumento(GridSearch, Usuario);
                        else
                        {
                            pregunta = new Alerts((byte)TypeIcon.Warning, "Tabla vacía", "No se permiten reportes vacios", "Por favor, una búsqueda para llenar la tabla y, de esa forma, poder solicitar un reporte.", false);
                            dr = pregunta.ShowDialog();
                            if (dr == DialogResult.No)
                                pregunta.Close();
                        }
                    }
                    break;
            }
            LimpiarCampos();
            lbTotal.Text = "Total de registros: " + GridSearch.Rows.Count.ToString().Trim();
            menu = 0;
        }

        private void ValidarCombo(object sender, EventArgs e)
        {
            Controles(Convert.ToByte(comboTypeMoves.SelectedIndex), true);
        }

        private void CargarVentana(object sender, EventArgs e)
        {
            RecargarDatos();
            lbTotal.Text = "Total de registros: " + GridSearch.Rows.Count.ToString().Trim();
        }
    }
}