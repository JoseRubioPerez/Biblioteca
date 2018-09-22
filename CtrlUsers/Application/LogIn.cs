using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;
using Entity;

namespace Application
{
    public partial class LogIn : Form
    {
        private AdminEntity ObjSession = new AdminEntity();
        private Business ObjBusiness = new Business();

        private DataTable Table1;
        private Control[] ArrayControl;
        private byte Index;

        public LogIn()
        {
            InitializeComponent();
        }

        public LogIn(AdminEntity ObjSession)
        {
            InitializeComponent();
            this.ObjSession = ObjSession;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            TextBoxUser.Text = "Número de Control";
            TextBoxPassword.Text = "Contraseña";
        }

        private void EventoClick(object sender, EventArgs e)
        {
            ArrayControl = new Control[] { ButtonAccept, ButtonCancelar, PictureClose };
            for (; Index < ArrayControl.Length; Index++)
            {
                if (ArrayControl[Index] == sender)
                    break;
            }
            switch (Index)
            {
                case 0:
                    ObjSession.NumControl = TextBoxUser.Text.Trim();
                    ObjSession.Password = TextBoxPassword.Text.Trim();
                    Table1 = ObjBusiness.Sesion(ObjSession);
                    try
                    {
                        if (Table1.Rows.Count > 0 && Table1.Columns.Count == 3)
                        {
                            ObjSession.NumControl = Table1.Rows[0]["nc"].ToString();
                            ObjSession.Password = Table1.Rows[0]["password"].ToString();
                            ObjSession.SuperSu = Convert.ToChar(Table1.Rows[0]["superus"].ToString());
                            ObjBusiness.Bitacora(TextBoxUser.Text.Trim(), "Control de Usuarios", "Entrada");
                            Main main = new Main(ObjSession);
                            main.Show();
                            Hide();
                        }
                        else
                        {
                            Alerts pregunta = new Alerts((byte)TypeIcon.Danger, "Inicio de Sesión", "Usuario o contraseña incorrecta", "Verifica que el usuario y\ncontraseña sean correctos.", false);
                            pregunta.Show();
                            pregunta.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        Alerts pregunta = new Alerts((byte)TypeIcon.Danger, "Error de conexión", "Error al conectar a la base de datos", "1. Asegurse de que en su manejador de base de datos tenga la base de datos \"biblioteca\".", false);
                        MessageBox.Show(ex.ToString());
                        pregunta.Show();
                        pregunta.Focus();
                    }
                    TextBoxUser.Text = "";
                    TextBoxPassword.Text = "";
                    break;

                case 1:
                case 2:
                    Close();
                    ButtonCancelar.DialogResult = DialogResult.No;
                    break;
            }
            Index = 0;
        }

        private void TextUserEnter(object sender, EventArgs e)
        {
            TextBoxUser.Text = (TextBoxUser.Text == "Número de Control" || TextBoxUser.Text == string.Empty) ? "" : TextBoxUser.Text;
        }

        private void TextUserLeave(object sender, EventArgs e)
        {
            TextBoxUser.Text = (TextBoxUser.Text == "Número de Control" || TextBoxUser.Text == string.Empty) ? "Número de Control" : TextBoxUser.Text;
        }

        private void TextPasswordEnter(object sender, EventArgs e)
        {
            TextBoxPassword.Text = (TextBoxPassword.Text == "Contraseña" || TextBoxPassword.Text == string.Empty) ? "" : TextBoxPassword.Text;
        }

        private void TextPasswordLeave(object sender, EventArgs e)
        {
            TextBoxPassword.Text = (TextBoxPassword.Text == "Contraseña" || TextBoxPassword.Text == string.Empty) ? "Contraseña" : TextBoxPassword.Text;
        }

        private void TextBoxPasswordKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                ButtonAccept.PerformClick();
        }
    }
}