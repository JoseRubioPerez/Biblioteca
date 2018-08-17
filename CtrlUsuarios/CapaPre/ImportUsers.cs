using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPre
{
    public partial class ImportUsers : FatherConfig
    {
        Negocio ObjNegocio = new Negocio();

        private Control[] arreglo;
        private byte menu;

        public ImportUsers()
        {
            InitializeComponent();
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
                        OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV | *.csv", ValidateNames = true, Multiselect = false };
                        if(ofd.ShowDialog() == DialogResult.OK)
                        {
                            GridCSV.Columns.Clear();
                            GridCSV.DataSource = ObjNegocio.ReadCSV(ofd.FileName);
                            LabelFile2.Text = "Archivo elegido: " + ofd.FileName;
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        Question pregunta = new Question((byte)TypeIcon.Danger, "Importación Fallida", "No se pudo realizar la importación de los usuarios.", "A ocurrido algún error:\n" + ex.Message + "\nMétodo fallido: " + ex.TargetSite + "\nOrigen del error: " + ex.Source, false);
                        DialogResult dr = pregunta.ShowDialog();
                        if (dr == DialogResult.Yes)
                            pregunta.Close();
                    }
                    break;
            }
            menu = 0;
        }
    }
}
