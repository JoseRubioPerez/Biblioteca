using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Business;
using Entity;
using Options;
using Presentation.PopUpForms;

namespace Presentation
{
    public partial class Imports : FormFather
    {
        private Validations ObjValidations = new Validations();
        private ModifyUsers ObjModifyUsers = new ModifyUsers();
        private readonly Session ObjSession = new Session();
        private Search ObjSearch = new Search();
        private readonly Control[] ArrayControl;
        private DialogResult ObjDialog;
        private byte Index;

        public Imports(Session ObjSession)
        {
            InitializeComponent();
            this.ObjSession = ObjSession;
            ArrayControl = new Control[] { ButtonExamine, ButtonImportTable };

            DataColumn ColumnaNumControl = new DataColumn("NUMERO DE CONTROL", typeof(string)) { Caption = "NUMERO DE CONTROL", MaxLength = 9, ReadOnly = false, AutoIncrement = false, AllowDBNull = false };
            DataColumn ColumnaNombres = new DataColumn("NOMBRES", typeof(string)) { Caption = "NOMBRES", ReadOnly = false, AutoIncrement = false, AllowDBNull = false };
            DataColumn ColumnaPrimerApellido = new DataColumn("APELLIDO PATERNO", typeof(string)) { Caption = "APELLIDO PATERNO", ReadOnly = false, AutoIncrement = false, AllowDBNull = true };
            DataColumn ColumnaSegundoApellido = new DataColumn("APELLIDO MATERNO", typeof(string)) { Caption = "APELLIDO MATERNO", ReadOnly = false, AutoIncrement = false, AllowDBNull = true };
            DataColumn ColumnaDepartamento = new DataColumn("DEPARTAMENTO O CARRERA", typeof(int)) { Caption = "DEPARTAMENTO / CARRERA", ReadOnly = false, AutoIncrement = false, AllowDBNull = false };
            DataColumn ColumnaSexo = new DataColumn("SEXO", typeof(char)) { Caption = "SEXO", ReadOnly = false, AutoIncrement = false, AllowDBNull = false };
            DataColumn ColumnaStatus = new DataColumn("STATUS", typeof(char)) { Caption = "STATUS", ReadOnly = false, AutoIncrement = false, AllowDBNull = true };

            ObjSearch.Table = new DataTable("Impoorts");
            ObjSearch.Table.Columns.Add(ColumnaNumControl);
            ObjSearch.Table.Columns.Add(ColumnaNombres);
            ObjSearch.Table.Columns.Add(ColumnaPrimerApellido);
            ObjSearch.Table.Columns.Add(ColumnaSegundoApellido);
            ObjSearch.Table.Columns.Add(ColumnaDepartamento);
            ObjSearch.Table.Columns.Add(ColumnaSexo);
            ObjSearch.Table.Columns.Add(ColumnaStatus);
        }

        public void ControlClickMethod(object sender, EventArgs e)
        {
            for (; Index < ArrayControl.Length; Index++)
                if (ArrayControl[Index] == sender)
                    break;
            switch (Index)
            {
                case 0: //ButtonExamine
                    {
                        using (OpenFileDialog ObjFile = new OpenFileDialog())
                        {
                            ObjFile.Title = "Archivo CSV para importación de usuarios";
                            ObjFile.Filter = "CSV Files (*.csv) | *.csv";
                            ObjFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                            ObjDialog = ObjFile.ShowDialog();
                            if(ObjDialog == DialogResult.OK)
                            {
                                string[] ArrayLinea;
                                int x = 0;
                                try
                                {
                                    string[] Lineas = File.ReadAllLines(ObjFile.FileName);
                                    GridSearch.DataSource = null;
                                    if (GridSearch.Columns.Count > 0) GridSearch.Columns.Clear();
                                    if (GridSearch.Rows.Count > 0) GridSearch.Rows.Clear();
                                    foreach (string linea in Lineas)
                                    {
                                        x++;
                                        DataRow Fila = ObjSearch.Table.NewRow();
                                        string temp = ObjValidations.RemoveAccent(linea.ToUpper());
                                        temp = ObjValidations.CleanLineaImport(temp);
                                        ArrayLinea = temp.Split(',');
                                        Fila["NUMERO DE CONTROL"] = ArrayLinea[0];
                                        Fila["NOMBRES"] = ArrayLinea[1];
                                        Fila["APELLIDO PATERNO"] = ArrayLinea[2];
                                        Fila["APELLIDO MATERNO"] = ArrayLinea[3];
                                        Fila["DEPARTAMENTO O CARRERA"] = ArrayLinea[4];
                                        Fila["SEXO"] = (ArrayLinea[5] == "M" || ArrayLinea[5] == "HOMBRE" || ArrayLinea[5] == "MASCULINO") ? "M" : "F";
                                        Fila["STATUS"] = (ArrayLinea[6] == "A" || ArrayLinea[6] == "I" || ArrayLinea[6] == "ACTIVO" || ArrayLinea[6] == "ACT" || ArrayLinea[6] != "EGR" || ArrayLinea[6] != "EGRESADO") ? "A" : "I";
                                        ObjSearch.Table.Rows.Add(Fila);
                                    }
                                    GridSearch.DataSource = ObjSearch.Table;
                                    DataGridViewButtonColumn ObjButtonColumnEdit = new DataGridViewButtonColumn();
                                    {
                                        ObjButtonColumnEdit.Name = "EDITAR";
                                        ObjButtonColumnEdit.HeaderText = "EDITAR";
                                        ObjButtonColumnEdit.Text = "EDITAR";
                                        ObjButtonColumnEdit.FlatStyle = FlatStyle.Flat;
                                        ObjButtonColumnEdit.UseColumnTextForButtonValue = true;
                                        GridSearch.Columns.Add(ObjButtonColumnEdit);
                                    }
                                    GridSearch.CellClick += GridSearchCellClickMethod;
                                    GridSearch.Columns["EDITAR"].DisplayIndex = GridSearch.Columns.Count - 1;
                                }
                                catch (Exception Error)
                                {
                                    MessageBox.Show("Error: " + Error.ToString());
                                }
                            }
                        }
                        if (GridSearch.Rows.Count > 0)
                        {
                            LabelTotal.Text = GridSearch.Rows.Count.ToString();
                            ButtonImportTable.Enabled = true;
                        }
                        else
                        {
                            LabelTotal.Text = "0";
                            ButtonImportTable.Enabled = false;
                        }
                        break;
                    }
                case 1:
                    {
                        if (GridSearch.Rows.Count > 0)
                        {
                            for (int i = 0; i < GridSearch.Rows.Count - 1; i++)
                            {
                                if (ObjValidations.ExistUsuario(TypeModules.Import, GridSearch.Rows[i].Cells["NUMERO DE CONTROL"].Value.ToString()).Rows.Count > 0)
                                {

                                }
                                else
                                {
                                    ObjModifyUsers.NumControl = GridSearch.Rows[i].Cells["NUMERO DE CONTROL"].Value.ToString().Trim();
                                    if (GridSearch.Rows[i].Cells["NOMBRES"].Value.ToString().Contains(" "))
                                    {
                                        ObjModifyUsers.FirstName = GridSearch.Rows[i].Cells["NOMBRES"].Value.ToString().Split(' ')[0].Trim();
                                        ObjModifyUsers.SecondName = GridSearch.Rows[i].Cells["NOMBRES"].Value.ToString().Split(' ')[1].Trim();
                                    }
                                    else
                                    {
                                        ObjModifyUsers.FirstName = GridSearch.Rows[i].Cells["NOMBRES"].Value.ToString().Trim();
                                        ObjModifyUsers.SecondName = string.Empty;
                                    }
                                    ObjModifyUsers.FirstLastName = (string.IsNullOrEmpty(GridSearch.Rows[i].Cells["APELLIDO PATERNO"].Value.ToString().Trim())) ? string.Empty : GridSearch.Rows[i].Cells["APELLIDO PATERNO"].Value.ToString();
                                    ObjModifyUsers.SecondLastName = (string.IsNullOrEmpty(GridSearch.Rows[i].Cells["APELLIDO MATERNO"].Value.ToString().Trim())) ? string.Empty : GridSearch.Rows[i].Cells["APELLIDO MATERNO"].Value.ToString();
                                    ObjModifyUsers.Sex = Convert.ToChar(GridSearch.Rows[i].Cells["SEXO"].Value.ToString());
                                    ObjModifyUsers.IndexDeparment = Convert.ToByte(GridSearch.Rows[i].Cells["DEPARTAMENTO O CARRERA"].Value.ToString());
                                    ObjModifyUsers.Status = Convert.ToChar(GridSearch.Rows[i].Cells["STATUS"].Value.ToString());
                                }
                            }
                        }
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: Imports-CCM");
            }
            Index = 0;
        } //Clave de Método: Imports-CCM

        private void GridSearchCellClickMethod(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridSearch.Columns["EDITAR"].Index)
            {
                ObjModifyUsers.NumControl = GridSearch.Rows[e.RowIndex].Cells["NUMERO DE CONTROL"].Value.ToString().Trim();
                if (GridSearch.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString().Contains(" "))
                {
                    ObjModifyUsers.FirstName = GridSearch.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString().Split(' ')[0].Trim();
                    ObjModifyUsers.SecondName = GridSearch.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString().Split(' ')[1].Trim();
                }
                else
                {
                    ObjModifyUsers.FirstName = GridSearch.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString().Trim();
                    ObjModifyUsers.SecondName = string.Empty;
                }
                ObjModifyUsers.FirstLastName = (string.IsNullOrEmpty(GridSearch.Rows[e.RowIndex].Cells["APELLIDO PATERNO"].Value.ToString().Trim())) ? string.Empty : GridSearch.Rows[e.RowIndex].Cells["APELLIDO PATERNO"].Value.ToString();
                ObjModifyUsers.SecondLastName = (string.IsNullOrEmpty(GridSearch.Rows[e.RowIndex].Cells["APELLIDO MATERNO"].Value.ToString().Trim())) ? string.Empty : GridSearch.Rows[e.RowIndex].Cells["APELLIDO MATERNO"].Value.ToString();
                ObjModifyUsers.Sex = Convert.ToChar(GridSearch.Rows[e.RowIndex].Cells["SEXO"].Value.ToString());
                ObjModifyUsers.IndexDeparment = Convert.ToByte(GridSearch.Rows[e.RowIndex].Cells["DEPARTAMENTO O CARRERA"].Value.ToString());
                ObjModifyUsers.Status = Convert.ToChar(GridSearch.Rows[e.RowIndex].Cells["STATUS"].Value.ToString());
                using (PopUpImports ObjPopUpImports = new PopUpImports(ObjModifyUsers))
                {
                    ObjDialog = ObjPopUpImports.ShowDialog();
                    if (ObjDialog == DialogResult.OK)
                    {
                        if (!string.IsNullOrEmpty(ObjPopUpImports.ObjModifyUsers2.NumControl))
                        {
                            if (!string.IsNullOrEmpty(ObjPopUpImports.ObjModifyUsers2.FirstName))
                            {
                                if (!string.IsNullOrEmpty(ObjPopUpImports.ObjModifyUsers2.FirstLastName) && !string.IsNullOrEmpty(ObjPopUpImports.ObjModifyUsers2.SecondLastName))
                                {
                                    GridSearch.Rows[e.RowIndex].Cells["NUMERO DE CONTROL"].Value = ObjPopUpImports.ObjModifyUsers2.NumControl;
                                    GridSearch.Rows[e.RowIndex].Cells["NOMBRES"].Value = ObjPopUpImports.ObjModifyUsers2.FirstAndSecondName;
                                    GridSearch.Rows[e.RowIndex].Cells["APELLIDO PATERNO"].Value = ObjPopUpImports.ObjModifyUsers2.FirstLastName;
                                    GridSearch.Rows[e.RowIndex].Cells["APELLIDO MATERNO"].Value = ObjPopUpImports.ObjModifyUsers2.SecondLastName;
                                    GridSearch.Rows[e.RowIndex].Cells["DEPARTAMENTO O CARRERA"].Value = ObjPopUpImports.ObjModifyUsers2.IndexDeparment;
                                    GridSearch.Rows[e.RowIndex].Cells["SEXO"].Value = ObjPopUpImports.ObjModifyUsers2.Sex;
                                    GridSearch.Rows[e.RowIndex].Cells["STATUS"].Value = ObjPopUpImports.ObjModifyUsers2.Status;
                                }
                            }
                        }
                    }
                }
            }
        } //Clave de Método: Imports-GSCCM
    }
}
