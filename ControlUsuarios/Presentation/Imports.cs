using System;
using System.Data;
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
            ArrayControl = new Control[] { ButtonExamine, ButtonImportTable, ButtonRedo };

            ButtonImportTable.Enabled = false;
            PanelLoad.Visible = false;

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

        public void RedoInterface()
        {
            ButtonImportTable.Enabled = false;
            PanelLoad.Visible = false;
            LabelFinish.Visible = false;
            ObjSearch.Table.Rows.Clear();
            GridSearch.DataSource = null;
            if (GridSearch.Columns.Count > 0) GridSearch.Columns.Clear();
            if (GridSearch.Rows.Count > 0) GridSearch.Rows.Clear();
            LabelCantidadFilas.Text = "0 de 0";
            LabelTotal.Text = "0";
            ButtonExamine.Focus();
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
                                    ObjSearch.Table.Rows.Clear();
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
                case 1: //ButtonImportTable
                    {
                        if (GridSearch.Rows.Count > 0)
                        {
                            using (Alerts ObjAlerts = new Alerts("Confirmación de Importación", "", "Usted está por realizar una importación de usuarios. La cantidad de usuarios a importar es de: " + GridSearch.Rows.Count.ToString() + "\n\n¿Está seguro de importar esta cantidad?", 1, "", "", "OK", TypeIcon.Warning))
                            {
                                if (ObjAlerts.ShowDialog() == DialogResult.OK)
                                {
                                    DataTable TablaAuxiliar;
                                    TablaAuxiliar = ObjSearch.Table.Copy();
                                    TablaAuxiliar.Rows.Clear();
                                    DataColumn ColumnaError = new DataColumn("RESULTADO DE OPERACION", typeof(string)) { Caption = "RESULTADO DE OPERACION", ReadOnly = false, AutoIncrement = false, AllowDBNull = false };
                                    TablaAuxiliar.Columns.Add(ColumnaError);
                                    int Contador = 0;
                                    ProgressBarImport.Value = 0;
                                    ProgressBarImport.Maximum = GridSearch.Rows.Count;
                                    PanelLoad.Visible = true;
                                    foreach (DataRow FilaTabla in ObjSearch.Table.Rows)
                                    {
                                        ObjModifyUsers.NumControl = FilaTabla["NUMERO DE CONTROL"].ToString().Trim();
                                        if (FilaTabla["NOMBRES"].ToString().Contains(" "))
                                        {
                                            ObjModifyUsers.FirstName = FilaTabla["NOMBRES"].ToString().Split(' ')[0].Trim();
                                            ObjModifyUsers.SecondName = FilaTabla["NOMBRES"].ToString().Split(' ')[1].Trim();
                                        }
                                        else
                                        {
                                            ObjModifyUsers.FirstName = FilaTabla["NOMBRES"].ToString().Trim();
                                            ObjModifyUsers.SecondName = string.Empty;
                                        }
                                        ObjModifyUsers.FirstLastName = (string.IsNullOrEmpty(FilaTabla["APELLIDO PATERNO"].ToString().Trim())) ? string.Empty : FilaTabla["APELLIDO PATERNO"].ToString();
                                        ObjModifyUsers.SecondLastName = (string.IsNullOrEmpty(FilaTabla["APELLIDO MATERNO"].ToString().Trim())) ? string.Empty : FilaTabla["APELLIDO MATERNO"].ToString();
                                        ObjModifyUsers.IndexDeparment = Convert.ToByte(FilaTabla["DEPARTAMENTO O CARRERA"].ToString());
                                        ObjModifyUsers.Status = Convert.ToChar(FilaTabla["STATUS"].ToString());
                                        ObjModifyUsers.Sex = Convert.ToChar(FilaTabla["SEXO"].ToString());

                                        DataRow FilaAuxiliar = TablaAuxiliar.NewRow();
                                        FilaAuxiliar["NUMERO DE CONTROL"] = FilaTabla["NUMERO DE CONTROL"];
                                        FilaAuxiliar["NOMBRES"] = FilaTabla["NOMBRES"];
                                        FilaAuxiliar["APELLIDO PATERNO"] = FilaTabla["APELLIDO PATERNO"];
                                        FilaAuxiliar["APELLIDO MATERNO"] = FilaTabla["APELLIDO MATERNO"];
                                        FilaAuxiliar["DEPARTAMENTO O CARRERA"] = FilaTabla["DEPARTAMENTO O CARRERA"];
                                        FilaAuxiliar["SEXO"] = FilaTabla["SEXO"];
                                        FilaAuxiliar["STATUS"] = FilaTabla["STATUS"];

                                        switch (ObjValidations.AddUser(TypeModules.Users, ObjModifyUsers))
                                        {
                                            case Result.Correct:
                                                {
                                                    FilaAuxiliar["RESULTADO DE OPERACION"] = "Registro importado correctamente.";
                                                    Contador++;
                                                    break;
                                                }

                                            case Result.Duplicate:
                                                {
                                                    FilaAuxiliar["RESULTADO DE OPERACION"] = "Ya existe este registro en la base de datos.";
                                                    break;
                                                }
                                            case Result.Invalid:
                                                {
                                                    FilaAuxiliar["RESULTADO DE OPERACION"] = "El número de control no tiene el formato correcto.";
                                                    break;
                                                }
                                            case Result.NullNames:
                                                {
                                                    FilaAuxiliar["RESULTADO DE OPERACION"] = "No existen nombres para este usuario.";
                                                    break;
                                                }
                                            case Result.NullLastNames:
                                                {
                                                    FilaAuxiliar["RESULTADO DE OPERACION"] = "No existen apellidos para este usuario.";
                                                    break;
                                                }
                                            default:
                                                {
                                                    FilaAuxiliar["RESULTADO DE OPERACION"] = "El origen del error es desconocido...";
                                                    break;
                                                }
                                        }
                                        TablaAuxiliar.Rows.Add(FilaAuxiliar);
                                        ProgressBarImport.PerformStep();
                                    }
                                    LabelCantidadFilas.Text = +Contador + " de " + GridSearch.Rows.Count;
                                    LabelFinish.Visible = true;
                                    GridSearch.DataSource = null;
                                    if (GridSearch.Columns.Count > 0) GridSearch.Columns.Clear();
                                    if (GridSearch.Rows.Count > 0) GridSearch.Rows.Clear();
                                    GridSearch.DataSource = TablaAuxiliar;
                                }
                            }
                        }
                        break;
                    }
                case 2: //ButtonRedo
                    {
                        RedoInterface();
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: Imports-CCM");
            }
            Index = 0;
        } //Clave de Método: Imports-CCM

        private void GridSearchCellClickMethod(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        } //Clave de Método: Imports-GSCCM
    }
}
