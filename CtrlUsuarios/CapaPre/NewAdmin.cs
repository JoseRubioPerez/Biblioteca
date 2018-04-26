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
    public partial class NewAdmin : UserControl
    {
        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        private Control[] arreglo;
        string[] nombreColumnas = new string[] { "Número de Control", "Nombres", "Apellido Paterno", "Apellido Materno", "Sexo", "Hora de registro (24h)", "Fecha de registro (dd/mm/yyyy)" };
        private byte menu;

        public NewAdmin()
        {
            InitializeComponent();
            OcultarControlUsers();
            panelAddAdmin.Visible = false;
            panelEditAdmin.Visible = false;
        }

        private void ColumnasGridAdd()
        {
            for(byte i = 0; i < addAdmin1.GridAdmin.Columns.Count; i++)
                addAdmin1.GridAdmin.Columns[i].HeaderText = nombreColumnas[i];
        }

        private void ColumnasGridEdit()
        {
            for (byte i = 0; i < addAdmin1.GridAdmin.Columns.Count; i++)
                editAdmin1.GridAdmin.Columns[i].HeaderText = nombreColumnas[i];
            editAdmin1.GridAdmin.Columns[7].HeaderText = "Permiso de Super Usuario";
        }

        private void OcultarControlUsers()
        {
            UserControl[] ctlUser = new UserControl[] { editAdmin1, addAdmin1 };
            for (int i = 0; i < ctlUser.Length; i++)
                ctlUser[i].Visible = false;
        }

        private void MostrarCtrl(UserControl ctlUser, DockStyle Estilo)
        {
            if (ctlUser.Visible)
                ctlUser.BringToFront();
            else
            {
                ctlUser.Show();
                ctlUser.BringToFront();
            }
            ctlUser.Parent = panelContenido;
            ctlUser.Dock = Estilo;
        }

        private void MostrarPanelBorder(byte panel)
        {
            switch (panel)
            {
                case 0:
                    panelAddAdmin.Location = new Point(btnAdd.Location.X, btnAdd.Location.Y + 89);
                    panelAddAdmin.Visible = true;
                    panelEditAdmin.Visible = false;
                    break;
                case 1:
                    panelEditAdmin.Location = new Point(btnEdit.Location.X, btnEdit.Location.Y + 89);
                    panelAddAdmin.Visible = false;
                    panelEditAdmin.Visible = true;
                    break;
            }
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { btnAdd, btnEdit };
            for (; menu < arreglo.Length; menu++)
            {
                if (arreglo[menu] == sender)
                    break;
            }
            switch (menu)
            {
                case 0:
                    MostrarPanelBorder(0);
                    MostrarCtrl(addAdmin1, DockStyle.Fill);
                    addAdmin1.GridAdmin.DataSource = negocio.SelectAll("CargarUsuarios");
                    ColumnasGridAdd();
                    break;
                case 1:
                    MostrarPanelBorder(1);
                    MostrarCtrl(editAdmin1, DockStyle.Fill);
                    editAdmin1.GridAdmin.DataSource = negocio.SelectAll("CargarAdministradores");
                    ColumnasGridEdit();
                    break;
                case 2:
                    Question pregunta = new Question((byte)TipoIcono.Warning, "Salir", "¿Deseas cerrar el programa?", "Sí aceptas, se cerrará tu sesión actual.", true);
                    DialogResult dr = pregunta.ShowDialog();
                    if (dr == DialogResult.Yes)
                    {
                        
                    }
                    break;

                case 3:
                    break;
            }
            menu = 0;
        }
    }
}
