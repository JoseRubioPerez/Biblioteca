using BusinessLayer;
using System;
using System.Windows.Forms;

namespace Application
{
    public partial class AddEditDeleteAdmin : FatherConfig
    {
        #region Instancias

        private Business ObjBusiness = new Business();
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
                case 0: MostrarForm(addAdmin); addAdmin.gridAddAdmin.DataSource = ObjBusiness.SelectAll("CargarUsuarios"); break;
                case 1: MostrarForm(editAdmin); editAdmin.gridEditAdmin.DataSource = ObjBusiness.SelectAll("CargarAdministradores"); break;
                case 2: MostrarForm(deleteAdmin); deleteAdmin.gridDeleteAdmin.DataSource = ObjBusiness.SelectAll("CargarAdministradores"); break;
            }
            menu = 0;
        }
    }
}