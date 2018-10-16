using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Business;
using Entity;

namespace Presentation
{
    public partial class Binnacle : FormFather
    {
        private Validations ObjValidations = new Validations();
        private readonly Session ObjSession = new Session();
        private DataTable TablaComboSearch = new DataTable();
        private List<string> ListaComboBox = new List<string>();
        private Alerts ObjAlerts;
        private readonly Control[] ArrayControl;
        private byte Index;
        private DialogResult ObjDialog;

        public Binnacle()
        {
            InitializeComponent();
        }

        private void ControlClickMethod(object sender, EventArgs e)
        {
            for (; Index < ArrayControl.Length; Index++)
                if (ArrayControl[Index] == sender)
                    break;
            switch (Index)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: Binnacle-CCM", new IndexOutOfRangeException());
            }
        } //Clave de Método: Reports-CCMs
    }
}
