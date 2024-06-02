using InicioDeSesionWindowsFormsConTXT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;


namespace InicioDeSesionWindowsFormsConTXT
{
    public partial class reportesForm : Form
    {
        private GestionReportes gestorReportes = new GestionReportes();
        private PrintDocument printDocument = new PrintDocument();

        private string ventasFilePath = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\RegistroVentas.txt";

        private StreamReader reader;


        public reportesForm()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            var ventas = gestorReportes.GenerarReporteVentas(DateTime.MinValue, DateTime.MaxValue);
            dataGridViewReportes.DataSource = ventas;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                reader = new StreamReader(ventasFilePath);
                printDocument.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar imprimir: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font printFont = this.Font;

            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }

            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }
    }
}
