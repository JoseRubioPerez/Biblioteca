using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Presentation.Properties;
using Entity;
using Business;
using Options;
using System.Text.RegularExpressions;

namespace Presentation
{
    public partial class LogUser : Form
    {
        private Alerts ObjAlerts = new Alerts("¡Acceso Denegado!", "Verifique los Campos", "Parece ser que el usuario y/o contraseña ingresados, no soy validos. Intenta de nuevo.", 1, "", "", "OK", TypeIcon.Warning);
        private Principal ObjPrincipal;

        private Session ObjSession = new Session();
        private Validations ObjValidations = new Validations();

        private DataTable Tabla1 = new DataTable();
        private Control[] ArrayControl;
        private readonly byte OptionSession;
        private byte Index;

        public LogUser()
        {
            InitializeComponent();
            TextBoxPassword.PasswordTextBox = '*';
            if (OptionSession.Equals(0))
            {
                OptionSession = (byte)TypeSession.LogIn;
                LabelTitle.Text = "Iniciar Sesión";
                LabelSubTitle.Text = "Ingresa tu usuario y contraseña";
            }
            else
            {
                LabelTitle.Text = "Cerrar Sesión";
                LabelSubTitle.Text = string.Empty;
            }
        }

        public LogUser(Session ObjSession, TypeSession Option)
        {
            InitializeComponent();
            this.ObjSession = ObjSession;
            OptionSession = (byte)Option;
            TextBoxPassword.PasswordTextBox = '*';
            if(OptionSession.Equals(TypeSession.LogIn))
            {
                LabelTitle.Text = "Iniciar Sesión";
                LabelSubTitle.Text = "Ingresa tu usuario y contraseña";
            }
            else
            {
                LabelTitle.Text = "Cerrar Sesión";
                LabelSubTitle.Text = string.Empty;
            }
        } //Clave de Constructor: LogUser-C

        private void ClickMethod(object sender, EventArgs e)
        {
            ArrayControl = new Control[] { ButtonShowPassword, ButtonAccept, ButtonCancel, PictureClose };
            for (; Index < ArrayControl.Length; Index++)
                if (ArrayControl[Index] == sender)
                    break;
            switch (Index)
            {
                case 0:
                    {
                        TextBoxPassword.PasswordTextBox = (TextBoxPassword.PasswordTextBox.Equals('*')) ? '\0' : '*';
                        break;
                    }
                case 1:
                    {
                        switch (OptionSession)
                        {
                            case (byte)TypeSession.LogIn:
                                {
                                    Tabla1 = ObjValidations.LogSession(TypeModules.LogUser, TextBoxUser.TextTextBox.Trim(), TextBoxPassword.TextTextBox.Trim());
                                    if (Tabla1 != null)
                                    {
                                        if(Tabla1.Rows.Count > 0)
                                        {
                                            ObjSession.NumControl = Tabla1.Rows[0]["NUMERO DE CONTROL"].ToString();
                                            if (Tabla1.Rows[0]["NOMBRES"].ToString().Split(' ').Length.Equals(2))
                                            {
                                                ObjSession.FirstName = Tabla1.Rows[0]["NOMBRES"].ToString().Split(' ')[0];
                                                ObjSession.SecondName = Tabla1.Rows[0]["NOMBRES"].ToString().Split(' ')[1];
                                            }
                                            else
                                            {
                                                ObjSession.FirstName = Tabla1.Rows[0]["NOMBRES"].ToString();
                                                ObjSession.SecondName = string.Empty;
                                            }
                                            ObjSession.FirstLastName = (string.IsNullOrEmpty(Tabla1.Rows[0]["APELLIDO PATERNO"].ToString())) ? string.Empty : Tabla1.Rows[0]["APELLIDO PATERNO"].ToString();
                                            ObjSession.SecondLastName = (string.IsNullOrEmpty(Tabla1.Rows[0]["APELLIDO MATERNO"].ToString())) ? string.Empty : Tabla1.Rows[0]["APELLIDO MATERNO"].ToString();
                                            ObjSession.Sex = char.Parse(Tabla1.Rows[0]["SEXO"].ToString());
                                            ObjSession.Password = Tabla1.Rows[0]["PASSWORD"].ToString();
                                            ObjSession.Time = TimeSpan.Parse(Tabla1.Rows[0]["HORA"].ToString());
                                            ObjSession.Date = DateTime.Parse(Tabla1.Rows[0]["FECHA"].ToString());
                                            ObjSession.Permissions = char.Parse(Tabla1.Rows[0]["PERMISOS"].ToString());
                                            Hide();
                                            ObjPrincipal = new Principal(ObjSession);
                                            ObjPrincipal.Show();
                                        }
                                        else
                                        {
                                            ObjAlerts.ShowDialog();
                                            Index = 0;
                                            TextBoxUser.Focus();
                                            TextBoxUser.SelectionStartTextBox = 0;
                                            TextBoxUser.SelectionLengthTextBox = TextBoxUser.TextTextBox.Length;
                                        }
                                    }
                                    else
                                    {
                                        ObjAlerts.ShowDialog();
                                        Index = 0;
                                        TextBoxUser.Focus();
                                        TextBoxUser.SelectionStartTextBox = 0;
                                        TextBoxUser.SelectionLengthTextBox = TextBoxUser.TextTextBox.Length;
                                    }
                                    break;
                                }
                            case (byte)TypeSession.LogOut:
                                {
                                    if (TextBoxUser.TextTextBox.Equals(ObjSession.NumControl) && TextBoxPassword.TextTextBox.Equals(ObjSession.Password))
                                    {
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        ObjAlerts.ShowDialog();
                                    }
                                    break;
                                }
                            default:
                                throw new Exception("Exception: LogUsers-CM", new IndexOutOfRangeException());
                        }

                        break;
                    }
                case 2:
                    {
                        TextBoxUser.TextTextBox = string.Empty;
                        TextBoxPassword.TextTextBox = string.Empty;
                        Index = 0;
                        TextBoxUser.Focus();
                        break;
                    }
                case 3:
                    {
                        if (OptionSession.Equals((byte)TypeSession.LogIn))
                        {
                            Application.Exit();
                        }
                        else if (OptionSession.Equals((byte)TypeSession.LogOut))
                        {
                            if (Visible)
                            {
                                Hide();
                            }
                            else
                            {
                                Show();
                                BringToFront();
                            }
                        }
                            break;
                    }
                default:
                    throw new Exception("Exception: LUCM", new IndexOutOfRangeException());
            }
            Index = 0;
        } //Clave de Método: LogUser-CM

        private void EnterTextBoxUI(object sender, EventArgs e)
        {
            ArrayControl = new Control[] { TextBoxUser, TextBoxPassword };
            for (; Index < ArrayControl.Length; Index++)
                if (ArrayControl[Index] == sender)
                    break;
            switch (Index)
            {
                case 0:
                    {
                        PictureUser.Image = Resources.UserWhite;
                        TextBoxUser.BackColorPanel = Color.FromArgb(255, 255, 255);
                        TextBoxUser.ForeColorLabel = Color.FromArgb(255, 255, 255);
                        TextBoxUser.ForeColorTextBox = Color.FromArgb(255, 255, 255);
                        break;
                    }
                case 1:
                    {
                        PictureLPassword.Image = Resources.LockWhite;
                        TextBoxPassword.BackColorPanel = Color.FromArgb(255, 255, 255);
                        TextBoxPassword.ForeColorLabel = Color.FromArgb(255, 255, 255);
                        TextBoxPassword.ForeColorTextBox = Color.FromArgb(255, 255, 255);
                        break;
                    }
                default:
                    throw new Exception("Exception: LUETBUI", new IndexOutOfRangeException());
            }
            Index = 0;
        } //Clave de Método: LogUser-ETBUI

        private void LeaveTextBoxUI(object sender, EventArgs e)
        {
            ArrayControl = new Control[] { TextBoxUser, TextBoxPassword };
            for (; Index < ArrayControl.Length; Index++)
                if (ArrayControl[Index] == sender)
                    break;
            switch (Index)
            {
                case 0:
                    {
                        PictureUser.Image = Resources.UserGray;
                        TextBoxUser.BackColorPanel = Color.FromArgb(158, 158, 158);
                        TextBoxUser.ForeColorLabel = Color.FromArgb(158, 158, 158);
                        TextBoxUser.ForeColorTextBox = Color.FromArgb(158, 158, 158);
                        break;
                    }
                case 1:
                    {
                        PictureLPassword.Image = Resources.LockGray;
                        TextBoxPassword.BackColorPanel = Color.FromArgb(158, 158, 158);
                        TextBoxPassword.ForeColorLabel = Color.FromArgb(158, 158, 158);
                        TextBoxPassword.ForeColorTextBox = Color.FromArgb(158, 158, 158);
                        TextBoxPassword.PasswordTextBox = '*';
                        break;
                    }
                default:
                    throw new Exception("Exception: LULTBUI", new IndexOutOfRangeException());
            }
            Index = 0;
        } //Clave de Método: LogUser-LTBUI

        private void FormClosingMethod(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        } //Clave de Método: LogUsers-FCM
    }
}
