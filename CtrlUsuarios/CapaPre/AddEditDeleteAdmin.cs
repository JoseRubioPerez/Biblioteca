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
    public partial class AddEditDeleteAdmin : FatherConfig
    {
        #region Instancias

        Negocio negocio = new Negocio();
        AddAdmin addAdmin = new AddAdmin();
        EditAdmin editAdmin = new EditAdmin();
        DeleteAdmin deleteAdmin = new DeleteAdmin();

        #endregion

        private Control[] arreglo;
        private byte menu;

        public AddEditDeleteAdmin()
        {
            InitializeComponent();
        }

        public void MostrarForm(Form Formulario)
        {
            Formulario.TopLevel = false;
            Formulario.Parent = panelContenido;
            Formulario.Dock = DockStyle.Fill;
            if (Formulario.Visible == false)
                Formulario.Show();
            Formulario.BringToFront();
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { btnAdd, btnEdit, btnDelete };
            for (; menu < arreglo.Length; menu++)
            {
                if (arreglo[menu] == sender)
                    break;
            }
            switch (menu)
            {
                case 0: MostrarForm(addAdmin); addAdmin.gridAddAdmin.DataSource = negocio.SelectAll("CargarUsuarios"); break;
                case 1: MostrarForm(editAdmin); editAdmin.gridEditAdmin.DataSource = negocio.SelectAll("CargarAdministradores"); break;
                case 2: MostrarForm(deleteAdmin); deleteAdmin.gridDeleteAdmin.DataSource = negocio.SelectAll("CargarAdministradores"); break;
            }
            menu = 0;
        }
    }
}
