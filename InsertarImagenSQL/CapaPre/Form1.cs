using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CapaPre
{
    public partial class Form1 : Form
    {
        char Sexo = 'H';
        char supersu = 'N';
        string ext = ".jpg";
        string BaseDeDatos = "pBiblioteca";
        public Form1()
        {
            InitializeComponent();
        }

        private void Imagen(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
                pictureFoto.Image = Image.FromFile(dialog.FileName);
            ext = System.IO.Path.GetExtension(dialog.FileName);
        }

        public void Limpiar()
        {
            txtNC.Text = "";
            txtNombres.Text = "";
            txtApePat.Text = "";
            txtApeMat.Text = "";
            radioH.Checked = false;
            radioM.Checked = false;
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            pictureFoto.Image = null;
            ext = ".jpg";
        }

        private void CancelarInfo(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar(object sender, EventArgs e)
        {
            try
            {
                if(txtPassword.Text.Trim() == txtConfirmPassword.Text.Trim())
                {
                    if (!(string.IsNullOrEmpty(BaseDeDatos)) || comboBD.SelectedIndex >= 0)
                    {
                        if (comboBD.SelectedIndex == 0)
                            BaseDeDatos = "pBiblioteca";
                        else
                            BaseDeDatos = "biblioteca";
                    }
                    string Tabla = "Administradores";
                    // Objetos de conexión y comando
                    SqlConnection conn = new SqlConnection("Data Source=" + Environment.MachineName + "\\" + Environment.UserName + ";Initial Catalog=" + BaseDeDatos + ";Integrated Security=True");
                    SqlCommand cmd = new SqlCommand();

                    // Estableciento propiedades
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO " + Tabla + " VALUES (@nc, @names, @apepat, @apemat, @sexo, @passwd, @image, @hora, @fecha, @supersu)";

                    // Creando los parámetros necesarios
                    cmd.Parameters.Add("@nc", SqlDbType.VarChar);
                    cmd.Parameters.Add("@names", SqlDbType.VarChar);
                    cmd.Parameters.Add("@apepat", SqlDbType.VarChar);
                    cmd.Parameters.Add("@apemat", SqlDbType.VarChar);
                    cmd.Parameters.Add("@sexo", SqlDbType.Char);
                    cmd.Parameters.Add("@passwd", SqlDbType.VarChar);
                    cmd.Parameters.Add("@image", SqlDbType.Image);
                    cmd.Parameters.Add("@hora", SqlDbType.Time);
                    cmd.Parameters.Add("@fecha", SqlDbType.Date);
                    cmd.Parameters.Add("@supersu", SqlDbType.Char);

                    // Asignando los valores a los atributos
                    cmd.Parameters["@nc"].Value = int.Parse(txtNC.Text);
                    cmd.Parameters["@names"].Value = txtNombres.Text.Trim();
                    cmd.Parameters["@apepat"].Value = txtApePat.Text.Trim();
                    cmd.Parameters["@apemat"].Value = txtApeMat.Text.Trim();
                    cmd.Parameters["@sexo"].Value = Sexo;
                    cmd.Parameters["@passwd"].Value = txtPassword.Text.Trim();
                    cmd.Parameters["@hora"].Value = DateTime.Now.ToShortTimeString();
                    cmd.Parameters["@fecha"].Value = DateTime.Now.ToShortDateString();
                    cmd.Parameters["@supersu"].Value = supersu;

                    System.IO.MemoryStream ms = new System.IO.MemoryStream(); // Asignando el valor de la imagen. Stream usado como buffer
                    if (ext == ".jpg" || ext == ".jpeg") // Se guarda la imagen en el buffer
                        pictureFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    else
                        pictureFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    cmd.Parameters["@image"].Value = ms.GetBuffer(); // Se extraen los bytes del buffer para asignarlos como valor para el parámetro.
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Limpiar();
            }
        }

        private void radioM_CheckedChanged(object sender, EventArgs e)
        {
            if (radioM.Checked)
                Sexo = 'M';
            else
                Sexo = 'H';
        }

        private void SuperUsuario(object sender, EventArgs e)
        {
            if (radioSi.Checked)
                supersu = 'S';
            else
                supersu = 'N';
        }
    }
}
