using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaCliente
{
    public partial class ReportePreview2 : Form
    {
        public ReportePreview2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XtraReport2 report = new XtraReport2();
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            report.CreateDocument();
            // Save the document to a stream. 
            report.PrintingSystem.SaveDocument(stream);


            // Create a Print Tool with an assigned report instance.
            ReportPrintTool printTool = new ReportPrintTool(new XtraReport1());
            // Access the Print Tool's Printing System and load the report document.
            printTool.PrintingSystem.LoadDocument(stream);
            // Load a Print Preview in a dialog window.
            // printTool.ShowPreviewDialog();
            printTool.ShowRibbonPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveToPDF.ShowDialog() == DialogResult.OK) //filtar archivos tipo pdf  =  Archivos PDF (*.pdf)|*.pdf )
            {
                XtraReport1 report = new XtraReport1();


                string filePath = saveToPDF.FileName;   //obtener el path direccion donde se guarda
                report.CreateDocument(); //CREAR REPORTE                       
                string pdfExportFile = filePath + ".pdf"; //GUARDAR CON EXTENSION 
                report.PrintingSystem.ExportToPdf(pdfExportFile); //EXPORTAR A PDF

                MessageBox.Show("Se ha guardado correctamente", "Exito!!..");
                saveToPDF.FileName = "Reporte de Usuarios"; //REINICIAR EL FILEPATH
                this.Close();
            }
        }
    }
}
