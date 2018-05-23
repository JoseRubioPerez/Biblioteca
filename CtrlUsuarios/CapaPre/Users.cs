using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPre
{
    public partial class Users : FatherConfig
    {
        #region Instancias

        Negocio negocio = new Negocio();

        #endregion

        private string[] ColumnasDeleteAdmin = new string[] { "Número de Control", "Nombres", "Apellido Paterno", "Apellido Materno", "Sexo", "Carrera / Departamento", "Activo / Inactivo", "Hora de registro (24h)", "Fecha de registro (dd/mm/yyyy)" };
        private Control[] arreglo;
        private byte menu;
        private int suma = 0;
        private char supersu = 'N';

        public Users()
        {
            InitializeComponent();
        }

        private void RecargarDatos()
        {
            GridSearch.DataSource = negocio.SelectAll("CargarUsuarios");
            for (byte i = 0; i < GridSearch.Columns.Count; i++)
                GridSearch.Columns[i].HeaderText = ColumnasDeleteAdmin[i];
            for (int i = 0; i < GridSearch.Rows.Count; i++)
                GridSearch.Rows[i].Cells["hora"].Value = GridSearch.Rows[i].Cells["hora"].Value.ToString().Substring(0, 7);
        }

        private void CargarVentana(object sender, EventArgs e)
        {
            RecargarDatos();
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { btnSearch, btnAllUsers };
            for (; menu < arreglo.Length; menu++)
            {
                if (arreglo[menu] == sender)
                    break;
            }
            switch (menu)
            {
                case 0:
                    /* Número de Control
                       Nombres
                       Apellido Paterno
                       Apellido Materno
                       Carrera o Departamento
                       Status
                       Mujer
                       Hombre
                       Cualquier sexo */
                    break;
                case 1:
                    txtSearch.Text = "";
                    comboTypeSearch.SelectedIndex = -1;
                    RecargarDatos();
                    break;
            }
            menu = 0;
        }
    }
}
