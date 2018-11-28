using System;
using System.Drawing;
using System.Windows.Forms;
using Entity;
using Options;
using Business;

namespace Presentation
{
    public partial class Principal : Form
    {
        private LogUser ObjLogUser;
        private Users ObjUsers;
        private Moves ObjMoves;
        private Stats ObjStats;
        private Imports ObjImports;
        private Configuration ObjConfiguration;
        private readonly Session ObjSession = new Session();
        private Validations ObjValidations = new Validations();
        private PictureBox[] ArrayPictureBox;
        private readonly Button[] ArrayButton;
        private readonly string[] ArrayButtonText = new string[] { "Usuarios", "Movimientos", "Reportes", "Bitácoras", "Importar Usuarios", "Configuraciones", "Cerrar Sesión" };
        private byte Index;

        public Principal(Session ObjSession)
        {
            InitializeComponent();
            ButtonBinnacle.Visible = false;
            ButtonConfiguration.Visible = false;
            this.ObjSession = ObjSession;
            ObjLogUser = new LogUser(ObjSession, TypeSession.LogOut);
            PanelCanvas.Height = 698;
            PanelCanvas.Width = 90;
            LabelSubTitle.Text = "Centro de información. Bienvenido(a) " + this.ObjSession.FirstName + " " + this.ObjSession.FirstLastName;
            ArrayButton = new Button[] { ButtonUsers, ButtonMoves, ButtonStats, ButtonBinnacle, ButtonImportUsers, ButtonConfiguration, ButtonLogOut };
            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        } //Clave de Constructor: Principal-C1

        public void MostrarForm(Form Formulario)
        {
            Formulario.TopLevel = false;
            Formulario.Parent = PanelContent;
            Formulario.Dock = DockStyle.Fill;
            if (!Formulario.Visible) Formulario.Show();
            Formulario.BringToFront();
        } //Clave de Método: Principal-MF

        private void ClickMethod(object sender, EventArgs e)
        {
            for (; Index < ArrayButton.Length; Index++)
                if (ArrayButton[Index] == sender)
                    break;
            switch (Index)
            {
                case 0: //ButtonUsers
                    {
                        try
                        {
                            MostrarForm(ObjUsers);
                        }catch(NullReferenceException)
                        {
                            ObjUsers = new Users(ObjSession);
                            MostrarForm(ObjUsers);
                        }
                        break;
                    }
                case 1: //ButtonMoves
                    {
                        try
                        {
                            MostrarForm(ObjMoves);
                        }
                        catch (NullReferenceException)
                        {
                            ObjMoves = new Moves(ObjSession);
                            MostrarForm(ObjMoves);
                        }
                        break;
                    }
                case 2: //ButtonStats
                    {
                        try
                        {
                            MostrarForm(ObjStats);
                        }
                        catch (NullReferenceException)
                        {
                            ObjStats = new Stats(ObjSession);
                            MostrarForm(ObjStats);
                        }
                        break;
                    }
                case 3: //ButtonBinnacle
                    {
                        break;
                    }
                case 4: //ButtonImportUsers
                    {
                        try
                        {
                            MostrarForm(ObjImports);
                        }
                        catch (NullReferenceException)
                        {
                            ObjImports = new Imports(ObjSession);
                            MostrarForm(ObjImports);
                        }
                        break;
                    }
                case 5: //ButtonConfiguration
                    {
                        try
                        {
                            MostrarForm(ObjConfiguration);
                        }
                        catch (NullReferenceException)
                        {
                            ObjConfiguration = new Configuration(ObjSession);
                            MostrarForm(ObjConfiguration);
                        }
                        break;
                    }
                case 6: //ButtonLogOut
                    {
                        if(ObjLogUser.Visible) ObjLogUser.Hide(); else ObjLogUser.Show();
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: Principal-CM", new IndexOutOfRangeException());
            }
            Index = 0;
        } //Clave de Método: Principal-CM

        public void PictureClickMethod(object sender, EventArgs e)
        {
            ArrayPictureBox = new PictureBox[] { PictureMinimize, PictureClose };
            for (; Index < ArrayPictureBox.Length; Index++)
                if (ArrayPictureBox[Index] == sender)
                    break;
            switch (Index)
            {
                case 0:
                    {
                        if (WindowState == FormWindowState.Normal)
                        {
                            WindowState = FormWindowState.Minimized;
                        }
                        else
                        {
                            WindowState = FormWindowState.Normal;
                            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                        }
                        break;
                    }
                case 1:
                    {
                        if (ObjLogUser.Visible)
                        {
                            ObjLogUser.Hide();
                        }
                        else
                        {
                            ObjLogUser.Show();
                            ObjLogUser.BringToFront();
                        }
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: PCM", new IndexOutOfRangeException());
            }
            Index = 0;
        } //Clave de Método: Principal-PCM

        private void TimerEnterSlideEffectMethod(object sender, EventArgs e)
        {
            if (PanelCanvas.Width == 230)
            {
                for (; Index < ArrayButton.Length; Index++)
                    ArrayButton[Index].Text = ArrayButtonText[Index];
                Index = 0;
                TimerSlideEnter.Enabled = false;
            }
            else if (PanelCanvas.Width >= 90)
            {
                PanelCanvas.Width += 20;
            }
        } //Clave de Método: Principal-TESEM

        private void TimerLeaveSlideEffectMethod(object sender, EventArgs e)
        {
            if (PanelCanvas.Width == 90)
            {
                for (; Index < ArrayButton.Length; Index++)
                    ArrayButton[Index].Text = string.Empty;
                Index = 0;
                TimerSlideLeave.Enabled = false;
            }
            else if(PanelCanvas.Width <= 230)
            {
                PanelCanvas.Width -= 20;
            }
        } //Clave de Método: Principal-TLSEM

        private void MouseEnterTimerSlide(object sender, EventArgs e)
        {
            TimerSlideLeave.Enabled = false;
            TimerSlideEnter.Enabled = true;
        } //Clave de Método: Principal-METS

        private void MouseLeaveTimerSlide(object sender, EventArgs e)
        {
            TimerSlideEnter.Enabled = false;
            TimerSlideLeave.Enabled = true;
        } //Clave de Método: Principal-MLTS

        private void FormClosingMethod(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                if (ObjLogUser.Visible)
                {
                    ObjLogUser.Hide();
                }
                else
                {
                    ObjLogUser.Show();
                    ObjLogUser.BringToFront();
                }
            }
        } //Clave de Método: Principal-FCM
    }
}
