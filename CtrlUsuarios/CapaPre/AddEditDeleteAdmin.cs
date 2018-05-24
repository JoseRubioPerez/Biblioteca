using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPre
{
    public partial class AddEditDeleteAdmin : FatherConfig
    {
        #region Instancias

        private Negocio negocio = new Negocio();
        private AddAdmin addAdmin = new AddAdmin();
        private EditAdmin editAdmin = new EditAdmin();
        private DeleteAdmin deleteAdmin = new DeleteAdmin();

        #endregion Instancias

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