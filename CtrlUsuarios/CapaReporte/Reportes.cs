using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CapaReporte
{
    public class Reportes
    {

        private Document doc;
        private Chunk chunk;
        private SaveFileDialog saveDialog;
        private FileStream file;

        public Reportes()
        {
        }

        public void GenerarDocumento(DataGridView Grid, string usuario)
        {
            doc = new Document(PageSize.A4, 10, 10, 10, 10);
            saveDialog = new SaveFileDialog
            {
                DefaultExt = "pdf",
                Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Guardar reporte de movimientos"
            };
            string fileName = "";
            if (saveDialog.ShowDialog() == DialogResult.OK)
                fileName = saveDialog.FileName;
            if (!string.IsNullOrEmpty(fileName.Trim()))
            {
                file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                chunk = new Chunk("Reporte General de Movimientos", FontFactory.GetFont("ARIAL", 16, Font.UNDERLINE));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("Delicias, Chihuahua, México. Instituto Tecnológico de Delicias, Centro de Información."));
                doc.Add(new Paragraph("Generado por: " + usuario));
                doc.Add(new Paragraph("Fecha: " + DateTime.Now.ToLongDateString().ToUpper() + " A LAS " + DateTime.Now.ToLongTimeString().ToUpper()));
                doc.Add(new Paragraph("Resultados encontrados: " + Grid.Rows.Count.ToString().Trim()));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                LlenarTabla(doc, Grid, Grid.Columns.Count);
                doc.AddCreationDate();
                doc.Close();
                Process.Start(fileName); //Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
            }
        }

        public void ReporteDesglosadoPorSexo(DataGridView GridHombres, DataGridView GridMujeres, string usuario)
        {
            doc = new Document(PageSize.A4, 10, 10, 10, 10);
            saveDialog = new SaveFileDialog
            {
                DefaultExt = "pdf",
                Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Guardar reporte de usuarios desglosado por sexo"
            };
            string fileName = "";
            if (saveDialog.ShowDialog() == DialogResult.OK)
                fileName = saveDialog.FileName;
            if (!string.IsNullOrEmpty(fileName.Trim()))
            {
                file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                chunk = new Chunk("Reporte General de Movimientos", FontFactory.GetFont("ARIAL", 16, Font.UNDERLINE));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("Delicias, Chihuahua, México. Instituto Tecnológico de Delicias, Centro de Información."));
                doc.Add(new Paragraph("Generado por: " + usuario));
                doc.Add(new Paragraph("Fecha: " + DateTime.Now.ToLongDateString().ToUpper() + " A LAS " + DateTime.Now.ToLongTimeString().ToUpper()));
                doc.Add(new Paragraph("Resultados de hombres encontrados: " + GridHombres.Rows.Count.ToString().Trim()));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                LlenarTabla(doc, GridHombres, GridHombres.Columns.Count);
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("Resultados de mujeres encontrados: " + GridMujeres.Rows.Count.ToString().Trim()));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                LlenarTabla(doc, GridMujeres, GridMujeres.Columns.Count);
                doc.AddCreationDate();
                doc.Close();
                Process.Start(fileName);
            }
        }

        private void LlenarTabla(Document documento, DataGridView Grid, int columna)
        {
            PdfPTable datatable = new PdfPTable(Grid.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetSizeColumns(Grid);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            FormatGrid(doc, datatable, Grid, columna);
            doc.Add(datatable);
        }

        private float[] GetSizeColumns(DataGridView Grid)
        {
            float[] values = new float[Grid.ColumnCount];
            for (int i = 0; i < Grid.ColumnCount; i++)
                values[i] = (float)Grid.Columns[i].Width;
            return values;
        }

        private void FormatGrid(Document document, PdfPTable tabla, DataGridView Grid, int columna)
        {
            int i, j;
            string[,] array = new string[Grid.RowCount, Grid.ColumnCount];
            for(i = 0; i < Grid.RowCount; i++)
            {
                for(j = 0; j < Grid.ColumnCount; j++)
                {
                    array[i, j] = Grid[j, i].Value.ToString();
                    array[i, j] = (j == (columna - 1)) ? array[i, j].Substring(0, 10) : array[i, j];
                    array[i, j] = (j == (columna - 2)) ? array[i, j].Substring(0, 5) : array[i, j];
                }
            }
            if(columna == 5)
            {
                tabla.AddCell("#");
                tabla.AddCell("Número de control");
                tabla.AddCell("Servicio Utilizado");
                tabla.AddCell("Hora");
                tabla.AddCell("Fecha");
            }
            else if(columna == 8)
            {
                tabla.AddCell("#");
                tabla.AddCell("Número de control");
                tabla.AddCell("Nombres");
                tabla.AddCell("Apellido Paterno");
                tabla.AddCell("Apellido Materno");
                tabla.AddCell("Servicio Utilizado");
                tabla.AddCell("Hora");
                tabla.AddCell("Fecha");
            }
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