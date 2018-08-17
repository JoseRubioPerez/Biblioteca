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
<<<<<<< HEAD
                    try
                    {
                        bool alert = false;
                        string area = "";
                        switch (comboTypeSearch.SelectedIndex)
                        {
                            case 0: alert = (numControl1.Visible && numControl1.txtNumControl.Text.Trim() != "") ? true : false; break;
                            case 1: alert = (nombres1.Visible && nombres1.txtNombres.Text.Trim() != "") ? true : false; break;
                            case 2: alert = (ambosApellidos1.Visible && (ambosApellidos1.txtApellidoPaterno.Text.Trim() != "" || ambosApellidos1.txtApellidoMaterno.Text.Trim() != "")) ? true : false; break;
                            case 3: alert = (sexo1.Visible && (sexo1.sexo == 'M' || sexo1.sexo == 'H')) ? true : false; break;
                            case 4:
                                alert = (area1.Visible && area1.comboAreas.SelectedIndex != -1) ? true : false;
                                area = (area1.comboAreas.SelectedIndex < 0) ? "" : area1.comboAreas.SelectedItem.ToString();
                                break;

                            case 5: alert = (status1.Visible && (status1.status == 'A' || status1.status == 'I')) ? true : false; break;
                        }
                        if (alert)
                        {
                            string[] Valor = new string[] { numControl1.txtNumControl.Text.Trim(), nombres1.txtNombres.Text.Trim(), ambosApellidos1.txtApellidoPaterno.Text.Trim(), ambosApellidos1.txtApellidoMaterno.Text.Trim(), Convert.ToString(sexo1.sexo), area, Convert.ToString(status1.status) };
                            GridSearch.DataSource = negocio.Search(Convert.ToByte(comboTypeSearch.SelectedIndex), Valor);
                            for (int i = 0; i < GridSearch.Rows.Count; i++)
                                GridSearch.Rows[i].Cells["hora"].Value = GridSearch.Rows[i].Cells["hora"].Value.ToString().Substring(0, 7);
                        }
                        else
                        {
                            Question pregunta = new Question((byte)TypeIcon.Warning, "Búsqueda vacia", "No se permiten búsquedas vacias", "Por favor, ingrese un rato poder continuar la búsqueda.", false);
                            DialogResult dr = pregunta.ShowDialog();
                            if (dr == DialogResult.No)
                                pregunta.Close();
                        }
                    }
                    catch (Exception ex) { Console.WriteLine("Ocurrió un error:\n" + ex.ToString()); }
=======
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
>>>>>>> master
                    break;
            }
            menu = 0;
        }
    }
}
