using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPre
{
    public partial class Users : FatherConfig
    {
        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        private string[] ColumnasDeleteAdmin = new string[] { "Número de Control", "Nombres", "Apellido Paterno", "Apellido Materno", "Sexo", "Carrera / Departamento", "Activo / Inactivo", "Hora de registro (24h)", "Fecha de registro (dd/mm/yyyy)" };
        private Control[] arreglo;
        private byte menu;

        public Users()
        {
            InitializeComponent();
            Controles(6, false);
            btnSearch.Visible = false;
        }

        private void RecargarDatos()
        {
            GridSearch.DataSource = negocio.SelectAll("CargarUsuarios");
            for (byte i = 0; i < GridSearch.Columns.Count; i++)
                GridSearch.Columns[i].HeaderText = ColumnasDeleteAdmin[i];
            for (int i = 0; i < GridSearch.Rows.Count; i++)
                GridSearch.Rows[i].Cells["hora"].Value = GridSearch.Rows[i].Cells["hora"].Value.ToString().Substring(0, 7);
        }

        private void Controles(byte index, bool bandera)
        {
            numControl1.Visible = false;
            nombres1.Visible = false;
            ambosApellidos1.Visible = false;
            sexo1.Visible = false;
            area1.Visible = false;
            status1.Visible = false;
            switch (index)
            {
                case 0: numControl1.Visible = bandera; numControl1.txtNumControl.Focus(); numControl1.TabIndex = (numControl1.Visible) ? 2 : 4; break;
                case 1: nombres1.Visible = bandera; nombres1.txtNombres.Focus(); nombres1.TabIndex = (nombres1.Visible) ? 2 : 4; break;
                case 2: ambosApellidos1.Visible = bandera; ambosApellidos1.txtApellidoPaterno.Focus(); ambosApellidos1.TabIndex = (ambosApellidos1.Visible) ? 2 : 4; break;
                case 3: sexo1.Visible = bandera; sexo1.radioHombre.Focus(); sexo1.TabIndex = (sexo1.Visible) ? 2 : 4; break;
                case 4: area1.Visible = bandera; area1.comboAreas.Focus(); area1.TabIndex = (area1.Visible) ? 2 : 4; break;
                case 5: status1.Visible = bandera; status1.radioActivo.Focus(); status1.TabIndex = (status1.Visible) ? 2 : 4; break;
                default: break;
            }
            btnSearch.Visible = (bandera) ? true : false;
        }

        private void LimpiarCampos()
        {
            numControl1.txtNumControl.Text = "";
            nombres1.txtNombres.Text = "";
            ambosApellidos1.txtApellidoPaterno.Text = "";
            ambosApellidos1.txtApellidoMaterno.Text = "";
            sexo1.radioMujer.Checked = false;
            sexo1.radioHombre.Checked = false;
            area1.comboAreas.SelectedIndex = -1;
            status1.radioActivo.Checked = false;
            status1.radioInactivo.Checked = false;
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { btnSearch, btnAllUsers };
            for (; menu < arreglo.Length; menu++)
                if (arreglo[menu] == sender)
                    break;
            switch (menu)
            {
                case 0:
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
                    break;

                case 1: RecargarDatos(); break;
            }
            LimpiarCampos();
            lbTotal.Text = "Total de registros: " + GridSearch.Rows.Count.ToString().Trim();
            menu = 0;
        }

        private void ValidarCombo(object sender, EventArgs e)
        {
            Controles(Convert.ToByte(comboTypeSearch.SelectedIndex), true);
        }

        private void CargarVentana(object sender, EventArgs e)
        {
            RecargarDatos();
            lbTotal.Text = "Total de registros: " + GridSearch.Rows.Count.ToString().Trim();
        }
    }
}