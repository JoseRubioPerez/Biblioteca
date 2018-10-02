using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Options;
using Business;
using System.Collections;

namespace Presentation
{
    public partial class Principal : Form
    {
        private Users ObjUsers = new Users();
        private Moves ObjMoves = new Moves();
        private Reports ObjReports = new Reports();
        private readonly Session ObjSession = new Session();
        private Validations ObjValidations = new Validations();
        private LogUser ObjLogUser;
        private PictureBox[] ArrayPictureBox;
        private readonly Button[] ArrayButton;
        private readonly string[] ArrayButtonText = new string[] { "Usuarios", "Movimientos", "Reportes", "Bitácoras", "Configuraciones", "Cerrar Sesión" };
        private byte Index;

        public Principal()
        {
            InitializeComponent();
            PanelCanvas.Height = 698;
            PanelCanvas.Width = 90;
            ArrayButton = new Button[] { ButtonUsers, ButtonMoves, ButtonStats, ButtonBinnacle, ButtonConfiguration, ButtonLogOut };
            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        public Principal(Session ObjSession)
        {
            InitializeComponent();
            this.ObjSession = ObjSession;
            ObjLogUser = new LogUser(ObjSession, TypeSession.LogOut);
            PanelCanvas.Height = 698;
            PanelCanvas.Width = 90;
            LabelSubTitle.Text = "Centro de información. Bienvenido(a) " + this.ObjSession.FirstName + " " + this.ObjSession.FirstLastName;
            ArrayButton = new Button[] { ButtonUsers, ButtonMoves, ButtonStats, ButtonBinnacle, ButtonConfiguration, ButtonLogOut };
            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        } //Clave de Constructor: Principal-C

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
                case 0:
                    {
                        MostrarForm(ObjUsers);
                        break;
                    }
                case 1:
                    {
                        MostrarForm(ObjMoves);
                        break;
                    }
                case 2:
                    {
                        MostrarForm(ObjReports);
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        if(ObjLogUser.Visible) ObjLogUser.Hide(); else ObjLogUser.Show();
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: Principal-CM", new IndexOutOfRangeException());
            }
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
            if (!PanelCanvas.Width.Equals(230))
            {
                if (PanelCanvas.Width >= 90)
                {
                    PanelCanvas.Width += 10;
                }
            }
            else
            {
                for (; Index < ArrayButton.Length; Index++)
                    ArrayButton[Index].Text = ArrayButtonText[Index];
                Index = 0;
                TimerSlideEnter.Enabled = false;
            }
        } //Clave de Método: Principal-TESEM

        private void TimerLeaveSlideEffectMethod(object sender, EventArgs e)
        {
            if (!PanelCanvas.Width.Equals(90))
            {
                if (PanelCanvas.Width <= 230)
                {
                    PanelCanvas.Width -= 10;
                }
            }
            else
            {
                for (; Index < ArrayButton.Length; Index++)
                    ArrayButton[Index].Text = string.Empty;
                Index = 0;
                TimerSlideLeave.Enabled = false;
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
