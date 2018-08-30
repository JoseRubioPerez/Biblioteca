using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Entity;

namespace Application
{

    public partial class ImportUsers : FatherConfig
    {
        Business ObjNegocio = new Business();
        ConfigEntity ObjConfig = new ConfigEntity();
        OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV | *.csv", ValidateNames = true, Multiselect = false };

        private Control[] arreglo;
        private byte menu;
        Alerts pregunta;
        DialogResult dr;

        public ImportUsers()
        {
            InitializeComponent();
        }

        public void UserConfigs(ConfigEntity ObjConfig)
        {
            this.ObjConfig = ObjConfig;
            LabelTitle.Text = (this.ObjConfig.TypeImport) ? "Importación de alumnos a la base de datos por medio de archivo de CSV" : "Importación de empleados o docentes a la base de datos por medio de archivo de CSV";
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { ButtonFile, ButtonImportUsers };
            for (; menu < arreglo.Length; menu++)
                if (arreglo[menu] == sender)
                    break;
            switch (menu)
            {
                case 0:
                    try
                    {
                        if(ofd.ShowDialog() == DialogResult.OK)
                        {
                            GridCSV.Columns.Clear();
                            GridCSV.DataSource = ObjNegocio.ReadCSV(ofd.FileName, ObjConfig);
                            LabelRegistros.Text = "Registros encontrados: " + GridCSV.Rows.Count;
                            LabelFile2.Text = "Archivo elegido: " + ofd.FileName.Split('\\')[(ofd.FileName.Split('\\').Length - 1)];
                        }
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        pregunta = new Alerts((byte)TypeIcon.Danger, "Importación Fallida", "No se pudo realizar la importación de los usuarios.", "Recomendaciones:\n1. Revise que NO se tenga abierto el archivo .csv a importar.\n2. Contactar con desarrollador de software sí persisten los problemas.", false);
                        dr = pregunta.ShowDialog();
                        if (dr == DialogResult.Yes)
                            pregunta.Close();
                    }
                    break;
                case 1:
                    pregunta = new Alerts((byte)TypeIcon.Warning, "Confirmación de importación", "No se admiten cambios una vez importados los datos", "Asegurate de que los datos esten bien. La única forma de corregirlos es contactando con el desarrollador de software.", true);
                    dr = pregunta.ShowDialog();
                    if (dr == DialogResult.Yes)
                    {
                        if (GridCSV.Rows.Count <= 0)
                        {
                            pregunta = new Alerts((byte)TypeIcon.Danger, "Importación Fallida", "No se pudo realizar la importación de los usuarios.", "La tabla de importación esta vacía.", false);
                            dr = pregunta.ShowDialog();
                            if (dr == DialogResult.Yes)
                                pregunta.Close();
                        }
                        else if (GridCSV.Rows.Count > 0)
                        {
                            if (ObjNegocio.ImportUsers(GridCSV, ObjConfig) > 0)
                            {
                                pregunta = new Alerts((byte)TypeIcon.Info, "¡Importación exitosa!", "Se han importado los usuarios a la base de datos.", "Los datos de la tabla han sido importados.", false);
                                dr = pregunta.ShowDialog();
                                if (dr == DialogResult.Yes)
                                    pregunta.Close();
                            }
                            else if (ObjNegocio.ImportUsers(GridCSV, ObjConfig) <= 0)
                            {
                                pregunta = new Alerts((byte)TypeIcon.Warning, "Importación Fallida", "No se pudo realizar la importación de los usuarios.", "La tabla de importación no cumple con la validación necesaria de importación.", false);
                                dr = pregunta.ShowDialog();
                                if (dr == DialogResult.Yes)
                                    pregunta.Close();
                            }
                        }
                    }
                    break;
            }
            menu = 0;
        }
    }
}
