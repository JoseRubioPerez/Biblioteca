using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPre
{
    public partial class DeleteAdmin : UserControl
    {
        #region Instancias

        Negocio negocio = new Negocio();

        #endregion

        private int suma = 0;
        private Control[] arreglo;
        private byte menu;

        public DeleteAdmin()
        {
            InitializeComponent();
            GridAdmin.SelectedRows[0].Selected = false;
        }

        private int NumeroDeSuperUsuarios()
        {
            for (int i = 0; i < GridAdmin.Rows.Count; i++)
            {
                if (Convert.ToChar(GridAdmin.Rows[i].Cells[7].Value.ToString()) == 'S')
                    suma++;
            }
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
                    if (Convert.ToChar(GridAdmin.CurrentRow.Cells[7].Value.ToString()) == 'S')
                    {
                        NumeroDeSuperUsuarios();
                        if (suma > 1)
                        {
                            pregunta = new Question((byte)TipoIcono.Warning, "Borrar administrador", "¿Estas seguroen querer borrar el administrador?", "Se esta por borrar a " + GridAdmin.CurrentRow.Cells[1].Value.ToString() + " " + GridAdmin.CurrentRow.Cells[2].Value.ToString() + " " + GridAdmin.CurrentRow.Cells[3].Value.ToString() + ".", true);
                            DialogResult dr = pregunta.ShowDialog();
                            if (dr == DialogResult.Yes)
                            {
                                try { negocio.ExistUserOrAdmin(GridAdmin.CurrentRow.Cells[0].Value.ToString(), "BorrarAdmin"); }catch(Exception) { Console.WriteLine("Error en la eliminación de un super usuario. Contacttar al administrador."); }
                                pregunta = new Question((byte)TipoIcono.Info, "Tarea realizada", "Administrador eliminado", "Se ha eliminado a " + GridAdmin.SelectedRows[0].Cells[1].Value.ToString() + " " + GridAdmin.SelectedRows[0].Cells[2].Value.ToString() + " " + GridAdmin.SelectedRows[0].Cells[3].Value.ToString() + "\nde los administradores super usuarios del sistema.", false);
                                pregunta.Show();
                            }
                        }
                        else
                        {
                            pregunta = new Question((byte)TipoIcono.Warning, "Acción no valida", "No se puede borrar administrador super usuario", "Debe existir como mínimo un administrador super usuario.", false);
                            pregunta.Show();
                        }
                        suma = 0;
                    }
                    else if(Convert.ToChar(GridAdmin.CurrentRow.Cells[7].Value.ToString()) == 'N')
                    {
                        pregunta = new Question((byte)TipoIcono.Warning, "Borrar administrador", "¿Estas seguroen querer borrar el administrador?", "Se esta por borrar a " + GridAdmin.CurrentRow.Cells[1].Value.ToString() + " " + GridAdmin.CurrentRow.Cells[2].Value.ToString() + " " + GridAdmin.CurrentRow.Cells[3].Value.ToString() + ".", true);
                        DialogResult dr = pregunta.ShowDialog();
                        if (dr == DialogResult.Yes)
                        {
                            try { negocio.ExistUserOrAdmin(GridAdmin.CurrentRow.Cells[0].Value.ToString(), "BorrarAdmin"); } catch (Exception) { Console.WriteLine("Error en la eliminación de un super usuario. Contacttar al administrador."); }
                            pregunta = new Question((byte)TipoIcono.Info, "Tarea realizada", "Administrador eliminado", "Se ha eliminado a " + GridAdmin.SelectedRows[0].Cells[1].Value.ToString() + " " + GridAdmin.SelectedRows[0].Cells[2].Value.ToString() + " " + GridAdmin.SelectedRows[0].Cells[3].Value.ToString() + "\nde los administradores del sistema.", false);
                            pregunta.Show();
                        }
                    }
                    GridAdmin.DataSource = negocio.SelectAll("CargarAdministradores");
                    break;
                case 1:
                    //btnCancelar
                    GridAdmin.SelectedRows[0].Selected = false;
                    break;
            }
            menu = 0;
        }
    }
}
