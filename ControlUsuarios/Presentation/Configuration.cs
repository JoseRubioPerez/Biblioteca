using System;
using System.Windows.Forms;
using Business;
using Entity;
using Options;

namespace Presentation
{
    public partial class Configuration : FormFather
    {
        private Validations ObjValidations = new Validations();
        private readonly Session ObjSession = new Session();
        private readonly Control[] ArrayControl;
        private DialogResult ObjDialog;
        private Alerts ObjAlerts;
        private byte Index;

        public Configuration()
        {
            InitializeComponent();
            ArrayControl = new Control[] { ButtonChangeMyPassword, PictureBoxInfo };
            GridSearchLoadDataMethod();
        }

        public Configuration(Session ObjSession)
        {
            InitializeComponent();
            this.ObjSession = ObjSession;
            ArrayControl = new Control[] { ButtonChangeMyPassword, PictureBoxInfo };
            GridSearchLoadDataMethod();
        }

        public void GridSearchLoadDataMethod()
        {
            GridSearch.DataSource = ObjValidations.GridSearchMethod(TypeModules.Configuration, TypeSearch.Admin);
            DataGridViewButtonColumn ObjButtonColumnEdit = new DataGridViewButtonColumn();
            {
                ObjButtonColumnEdit.Name = "EDITAR";
                ObjButtonColumnEdit.HeaderText = "EDITAR";
                ObjButtonColumnEdit.Text = "EDITAR";
                ObjButtonColumnEdit.FlatStyle = FlatStyle.Flat;
                ObjButtonColumnEdit.UseColumnTextForButtonValue = true;
                GridSearch.Columns.Add(ObjButtonColumnEdit);
            }

            DataGridViewButtonColumn ObjButtonColumnDelete = new DataGridViewButtonColumn();
            {
                ObjButtonColumnDelete.Name = "ELIMINAR";
                ObjButtonColumnDelete.HeaderText = "ELIMINAR";
                ObjButtonColumnDelete.Text = "ELIMINAR";
                ObjButtonColumnDelete.FlatStyle = FlatStyle.Flat;
                ObjButtonColumnDelete.UseColumnTextForButtonValue = true;
                GridSearch.Columns.Add(ObjButtonColumnDelete);
            }

            GridSearch.CellClick += GridSearchCellClickMthod;
        } //Clave de Método: Configuration-GSLDM

        private void GridSearchCellClickMthod(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridSearch.Columns["ELIMINAR"].Index && GridSearch.Rows.Count > 1)
            {
                //Hacer algo...
                //GridSearch.Rows[e.RowIndex].Cells["NUMERO DE CONTROL"].Value
            }

            if (e.ColumnIndex == GridSearch.Columns["EDITAR"].Index && ObjSession.NumControl != GridSearch.Rows[e.RowIndex].Cells["NUMERO DE CONTROL"].Value.ToString())
            {

            }
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
                case 3:
                    {
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: Configuration-CCM", new IndexOutOfRangeException());
            }
        } //Clave de Método: Configuration-CCM

        private void DataSourceChangedMethod(object sender, EventArgs e)
        {
            LabelTotalResults.Text = (GridSearch.Rows.Count.Equals(null)) ? "0" : GridSearch.Rows.Count.ToString();
        } //Clave de Método: Configuration-DSCM
    }
}
