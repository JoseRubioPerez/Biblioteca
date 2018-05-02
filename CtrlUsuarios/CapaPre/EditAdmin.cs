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
    public partial class EditAdmin : FatherConfig
    {
        #region Instancias

        Negocio negocio = new Negocio();

        #endregion

        private string[] ColumnasDeleteAdmin = new string[] { "Número de Control", "Nombres", "Apellido Paterno", "Apellido Materno", "Sexo", "Hora de registro (24h)", "Fecha de registro (dd/mm/yyyy)", "Permiso de Super Usuario" };
        private Control[] arreglo;
        private byte menu;
        private int suma = 0;
        private char supersu = 'N';

        public EditAdmin()
        {
            InitializeComponent();
        }

        private void CargarVentana(object sender, EventArgs e)
        {
            gridEditAdmin.DataSource = negocio.SelectAll("CargarAdministradores");
            for (byte i = 0; i < gridEditAdmin.Columns.Count; i++)
                gridEditAdmin.Columns[i].HeaderText = ColumnasDeleteAdmin[i];
        }

        private int NumeroDeSuperUsuarios()
        {
            for (int i = 0; i < gridEditAdmin.Rows.Count; i++)
                if (Convert.ToChar(gridEditAdmin.Rows[i].Cells[7].Value.ToString()) == 'S')
                    suma++;
            return suma;
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { btnAceptar, btnCancelar };
            for (; menu < arreglo.Length; menu++)
            {
                if (arreglo[menu] == sender)
                    break;
            }
            switch (menu)
            {
                case 0:
                    //btnAceptar
                    Question pregunta;
                    supersu = (!radioS.Checked && !radioN.Checked) ? 'N' : ((radioN.Checked && !radioS.Checked) ? 'N' : ((radioS.Checked && !radioN.Checked) ? 'S' : 'N'));
                    if (Convert.ToChar(gridEditAdmin.CurrentRow.Cells[7].Value.ToString()) == 'S')
                    {
                        NumeroDeSuperUsuarios();
                        if (suma > 1)
                        {
                            pregunta = new Question((byte)TypeIcon.Warning, "Editar administrador", "¿Estas seguro en editar el administrador?", "Se esta por editar los permisos a " + gridEditAdmin.CurrentRow.Cells[1].Value.ToString() + " " + gridEditAdmin.CurrentRow.Cells[2].Value.ToString() + " " + gridEditAdmin.CurrentRow.Cells[3].Value.ToString() + ".", true);
                            DialogResult dr = pregunta.ShowDialog();
                            if (dr == DialogResult.Yes)
                            {
                                try { negocio.UpdatePermissionAdmin(gridEditAdmin.CurrentRow.Cells[0].Value.ToString(), supersu); } catch (Exception) { Console.WriteLine("Error en la edición de un administrador. Contactar al administrador."); }
                                pregunta = new Question((byte)TypeIcon.Info, "Tarea realizada", "Administrador editado", "Se han editado los permisos a " + gridEditAdmin.SelectedRows[0].Cells[1].Value.ToString() + " " + gridEditAdmin.SelectedRows[0].Cells[2].Value.ToString() + " " + gridEditAdmin.SelectedRows[0].Cells[3].Value.ToString() + "\nde los administradores super usuarios del sistema.", false);
                                pregunta.Show();
                            }
                        }
                        else
                        {
                            pregunta = new Question((byte)TypeIcon.Warning, "Acción no valida", "No se puede editar los permisos del administrador", "Debe existir como mínimo un administrador super usuario.", false);
                            pregunta.Show();
                        }
                        suma = 0;
                    }
                    else if (Convert.ToChar(gridEditAdmin.CurrentRow.Cells[7].Value.ToString()) == 'N' && gridEditAdmin.Rows.Count > 1)
                    {
                        pregunta = new Question((byte)TypeIcon.Warning, "Editar administrador", "¿Estas seguro en querer editar los permisos del administrador?", "Se esta por editar a " + gridEditAdmin.CurrentRow.Cells[1].Value.ToString() + " " + gridEditAdmin.CurrentRow.Cells[2].Value.ToString() + " " + gridEditAdmin.CurrentRow.Cells[3].Value.ToString() + ".", true);
                        DialogResult dr = pregunta.ShowDialog();
                        if (dr == DialogResult.Yes)
                        {
                            try { negocio.UpdatePermissionAdmin(gridEditAdmin.CurrentRow.Cells[0].Value.ToString(), supersu); } catch (Exception) { Console.WriteLine("Error en la edición de un administrador. Contactar al administrador."); }
                            pregunta = new Question((byte)TypeIcon.Info, "Tarea realizada", "Administrador editado", "Se han editado los permisos a " + gridEditAdmin.SelectedRows[0].Cells[1].Value.ToString() + " " + gridEditAdmin.SelectedRows[0].Cells[2].Value.ToString() + " " + gridEditAdmin.SelectedRows[0].Cells[3].Value.ToString() + "\nde los administradores del sistema.", false);
                            pregunta.Show();
                        }
                    }
                    gridEditAdmin.DataSource = negocio.SelectAll("CargarAdministradores");
                    break;
            }
            radioS.Checked = false;
            radioN.Checked = false;
            supersu = 'N';
            menu = 0;
        }
    }
}
