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
            arreglo = new Control[] { btnUsuarioSalaPorSexo, btnServicioBanios, btnServicioBD, btnServicioConsulta, btnServicioCubiculos, btnServicioLectura, btnServicioOtros, btnServicioSalaTrabajo };
            for (; menu < arreglo.Length; menu++)
                if (arreglo[menu] == sender)
                    break;
            switch (menu)
            {
                case 0:
                    GridHombres.DataSource = negocio.Reportes(2);
                    GridMujeres.DataSource = negocio.Reportes(1);
                    reportes.ReporteDesglosadoPorSexo(GridHombres, GridMujeres, Usuario);
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
            }
            menu = 0;
        }
    }
}
