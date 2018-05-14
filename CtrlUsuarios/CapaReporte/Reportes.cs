using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CapaReporte
{
    public class Reportes
    {
        public Reportes()
        {
        }

        public void GenerarDocumento(DataGridView Grid, string usuario)
        {
            Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = Environment.CurrentDirectory;
            saveDialog.Title = "Guardar reporte";
            saveDialog.DefaultExt = "pdf";
            saveDialog.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            string fileName = "";
            if (saveDialog.ShowDialog() == DialogResult.OK)
                fileName = saveDialog.FileName;
            if (!string.IsNullOrEmpty(fileName.Trim()))
            {
                FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();

                Chunk chunk = new Chunk("Reporte General de Movimientos", FontFactory.GetFont("ARIAL", 16, Font.UNDERLINE));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("Delicias, Chihuahua, México. Instituto Tecnológico de Delicias, Centro de Información."));
                doc.Add(new Paragraph("Generado por: " + usuario));
                doc.Add(new Paragraph("Fecha: " + DateTime.Now.ToLongDateString().ToUpper() + " a las " + DateTime.Now.ToLongTimeString().ToUpper()));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));

                PdfPTable datatable = new PdfPTable(Grid.ColumnCount);
                datatable.DefaultCell.Padding = 3;
                float[] headerwidths = GetSizeColumns(Grid);
                datatable.SetWidths(headerwidths);
                datatable.WidthPercentage = 100;
                datatable.DefaultCell.BorderWidth = 2;
                datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                FormatGrid(doc, datatable, Grid);
                doc.Add(datatable);
                doc.AddCreationDate();
                doc.Close();
                Process.Start(fileName); //Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
            }
        }

        private float[] GetSizeColumns(DataGridView Grid)
        {
            float[] values = new float[Grid.ColumnCount];
            for (int i = 0; i < Grid.ColumnCount; i++)
                values[i] = (float)Grid.Columns[i].Width;
            return values;
        }

        private void FormatGrid(Document document, PdfPTable tabla, DataGridView Grid)
        {
            int i, j;
            string[,] array = new string[Grid.RowCount, Grid.ColumnCount];
            for(i = 0; i < Grid.RowCount; i++)
            {
                for(j = 0; j < Grid.ColumnCount; j++)
                {
                    array[i, j] = Grid[j, i].Value.ToString();
                    array[i, j] = (j == 4) ? array[i, j].Substring(0, 10) : array[i, j];
                }
            }
            tabla.AddCell("#"); tabla.AddCell("Número de control"); tabla.AddCell("Servicio Utilizado"); tabla.AddCell("Hora"); tabla.AddCell("Fecha");
            tabla.HeaderRows = 1;
            for (i = 0; i < Grid.RowCount; i++)
            {
                for (j = 0; j < Grid.ColumnCount; j++)
                    tabla.AddCell(new Phrase(array[i, j]));
                tabla.CompleteRow();
            }
        }
    }
}