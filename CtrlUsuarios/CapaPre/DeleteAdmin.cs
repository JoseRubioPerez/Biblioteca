using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPre
{
    public partial class DeleteAdmin : FatherConfig
    {
        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        private string[] ColumnasDeleteAdmin = new string[] { "Número de Control", "Nombres", "Apellido Paterno", "Apellido Materno", "Sexo", "Hora de registro (24h)", "Fecha de registro (dd/mm/yyyy)", "Permiso de Super Usuario" };
        private int suma = 0;

        public DeleteAdmin()
        {
            InitializeComponent();
        }

        private void CargarVentana(object sender, EventArgs e)
        {
            gridDeleteAdmin.DataSource = negocio.SelectAll("CargarAdministradores");
            for (byte i = 0; i < gridDeleteAdmin.Columns.Count; i++)
                gridDeleteAdmin.Columns[i].HeaderText = ColumnasDeleteAdmin[i];
        }

        private int NumeroDeSuperUsuarios()
        {
            for (int i = 0; i < gridDeleteAdmin.Rows.Count; i++)
            {
                if (Convert.ToChar(gridDeleteAdmin.Rows[i].Cells[7].Value.ToString()) == 'S')
                    suma++;
            }
            return suma;
        }

        private void EventoClick(object sender, EventArgs e)
        {
            Question pregunta;
            if (Convert.ToChar(gridDeleteAdmin.CurrentRow.Cells[7].Value.ToString()) == 'S')
            {
                NumeroDeSuperUsuarios();
                if (suma > 1)
                {
                    pregunta = new Question((byte)TypeIcon.Warning, "Borrar administrador", "¿Estas seguro en querer borrar el administrador?", "Se esta por borrar a " + gridDeleteAdmin.CurrentRow.Cells[1].Value.ToString() + " " + gridDeleteAdmin.CurrentRow.Cells[2].Value.ToString() + " " + gridDeleteAdmin.CurrentRow.Cells[3].Value.ToString() + ".", true);
                    DialogResult dr = pregunta.ShowDialog();
                    if (dr == DialogResult.Yes)
                    {
                        try { negocio.ExistUserOrAdmin(gridDeleteAdmin.CurrentRow.Cells[0].Value.ToString(), "BorrarAdmin"); } catch (Exception) { Console.WriteLine("Error en la eliminación de un super usuario. Contactar al administrador."); }
                        pregunta = new Question((byte)TypeIcon.Info, "Tarea realizada", "Administrador eliminado", "Se ha eliminado a " + gridDeleteAdmin.SelectedRows[0].Cells[1].Value.ToString() + " " + gridDeleteAdmin.SelectedRows[0].Cells[2].Value.ToString() + " " + gridDeleteAdmin.SelectedRows[0].Cells[3].Value.ToString() + "\nde los administradores super usuarios del sistema.", false);
                        pregunta.Show();
                    }
                }
                else
                {
                    pregunta = new Question((byte)TypeIcon.Warning, "Acción no valida", "No se puede borrar administrador super usuario", "Debe existir como mínimo un administrador super usuario.", false);
                    pregunta.Show();
                }
                suma = 0;
            }
            else if (Convert.ToChar(gridDeleteAdmin.CurrentRow.Cells[7].Value.ToString()) == 'N')
            {
                pregunta = new Question((byte)TypeIcon.Warning, "Borrar administrador", "¿Estas seguroen querer borrar el administrador?", "Se esta por borrar a " + gridDeleteAdmin.CurrentRow.Cells[1].Value.ToString() + " " + gridDeleteAdmin.CurrentRow.Cells[2].Value.ToString() + " " + gridDeleteAdmin.CurrentRow.Cells[3].Value.ToString() + ".", true);
                DialogResult dr = pregunta.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    try { negocio.ExistUserOrAdmin(gridDeleteAdmin.CurrentRow.Cells[0].Value.ToString(), "BorrarAdmin"); } catch (Exception) { Console.WriteLine("Error en la eliminación de un super usuario. Contacttar al administrador."); }
                    pregunta = new Question((byte)TypeIcon.Info, "Tarea realizada", "Administrador eliminado", "Se ha eliminado a " + gridDeleteAdmin.SelectedRows[0].Cells[1].Value.ToString() + " " + gridDeleteAdmin.SelectedRows[0].Cells[2].Value.ToString() + " " + gridDeleteAdmin.SelectedRows[0].Cells[3].Value.ToString() + "\nde los administradores del sistema.", false);
                    pregunta.Show();
                }
            }
            gridDeleteAdmin.DataSource = negocio.SelectAll("CargarAdministradores");
        }
    }
}