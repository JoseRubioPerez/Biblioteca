using System;
using System.Windows.Forms;
using CapaReporte;
using CapaNegocio;

namespace CapaPre
{
    public partial class Reports : Form
    {
        #region Instancias

        private Question pregunta;
        private Reportes reportes = new Reportes();
        private Negocio negocio = new Negocio();

        #endregion
        private string[] Columnas = new string[] { "Número de Registro", "Número de Control", "Servicio Utilizado", "Hora de registro (24h)", "Fecha de registro (dd/mm/yyyy)" };
        private Control[] arreglo;
        public string Usuario;
        private byte menu;
        private DialogResult dr;

        public Reports()
        {
            InitializeComponent();
            GridHombres.Hide();
            GridMujeres.Hide();
        }

        private void RecargarDatos(DataGridView Grid)
        {
            Grid.DataSource = negocio.SelectAll("CargarMovimientos");
            for (byte i = 0; i < Grid.Columns.Count; i++)
                Grid.Columns[i].HeaderText = Columnas[i];
            for (int i = 0; i < Grid.Rows.Count; i++)
                Grid.Rows[i].Cells["hora"].Value = Grid.Rows[i].Cells["hora"].Value.ToString().Substring(0, 7);
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { btnUsuarioSalaPorSexo, btnServicioBanios, btnServicioBD, btnServicioConsulta, btnServicioCubiculos, btnServicioOtros, btnServicioLectura, btnServicioSalaTrabajo };
            for (; menu < arreglo.Length; menu++)
                if (arreglo[menu] == sender)
                    break;
            pregunta = new Question((byte)TypeIcon.Warning, "Nuevo reporte", "¿De verdad quieres crear un nuevo reporte?", "Sí aceptas, el reporte será llenado con los datos del usuario que inició sesión y con los datos de la tabla.", true);
            dr = pregunta.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                if(menu == 0)
                {
                    GridHombres.DataSource = negocio.ReporteModuloUsuarios(2);
                    GridMujeres.DataSource = negocio.ReporteModuloUsuarios(1);
                    reportes.ReporteDesglosadoPorSexo(GridHombres, GridMujeres, Usuario);
                }
                else
                {
                    GridHombres.DataSource = negocio.ReporteModuloServicios((byte)(menu - 1));
                    reportes.GenerarDocumento(GridHombres, Usuario);
                }
            }
            menu = 0;
        }
    }
}
