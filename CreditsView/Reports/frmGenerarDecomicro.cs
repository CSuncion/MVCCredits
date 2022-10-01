using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsView.MdiPrincipal;
using DeclaracionesUtil.Util;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace CreditsView.Reports
{
    public partial class frmGenerarDecomicro : Form
    {
        Application objApp;
        _Workbook objBook;
        CreditsReportController oRptCtrl = new CreditsReportController();
        public frmGenerarDecomicro()
        {
            InitializeComponent();
        }
        public void NewWindow()
        {
            this.Show();
        }

        public void Cerrar()
        {
            frmPrincipal wMen = (frmPrincipal)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.btnDecomicro, null);
        }
        public void GenerarDecomicro()
        {
            var currentDirectory = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "Plantilla\\Plantilla_Decomicro.xlsx");
            var file = new FileInfo(currentDirectory);

            string nameFile = "Decomicro_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString() + ".xls";
            UtilDirectorio.CrearCarpeta(ConfigurationManager.AppSettings["RutaDecomicro"].ToString());
            string rutaFileNew = ConfigurationManager.AppSettings["RutaDecomicro"].ToString() + @"\" + nameFile;
            UtilDirectorio.ExisteArchivo(rutaFileNew);
            File.Copy(currentDirectory, rutaFileNew);

            Application myexcelApplication = new Application();
            if (myexcelApplication != null)
            {
                Workbook myexcelWorkbook = myexcelApplication.Workbooks.Add(rutaFileNew);
                Worksheet myexcelWorksheet = (Worksheet)myexcelWorkbook.Sheets[1];

                List<CreditsDecomicroDto> listDecomicro = new List<CreditsDecomicroDto>();
                listDecomicro = oRptCtrl.ListarDecomicro();
                int fila = 9;
                foreach (CreditsDecomicroDto deco in listDecomicro)
                {
                    fila++;
                    myexcelWorksheet.Cells[fila, 8] = deco.TipDocId;
                    myexcelWorksheet.Cells[fila, 9] = deco.Dni_Solicitante;
                    myexcelWorksheet.Cells[fila, 11] = deco.Paterno;
                    myexcelWorksheet.Cells[fila, 12] = deco.Materno;
                }

                myexcelApplication.ActiveWorkbook.SaveAs(rutaFileNew, XlFileFormat.xlWorkbookNormal);

                myexcelWorkbook.Close();
                myexcelApplication.Quit();
            }
        }
        private void btnGenDeco_Click(object sender, EventArgs e)
        {
            this.GenerarDecomicro();
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGenerarDecomicro_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }
    }
}
