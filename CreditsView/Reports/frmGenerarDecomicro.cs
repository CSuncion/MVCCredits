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
            var currentDirectory = Path.Combine(ConfigurationManager.AppSettings["RutaPlantilla"].ToString(), "Plantilla\\Plantilla_Decomicro.xlsx");
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
                    myexcelWorksheet.Cells[fila, "H"] = deco.TipDocId;
                    myexcelWorksheet.Cells[fila, "I"] = deco.Dni_Solicitante;
                    myexcelWorksheet.Cells[fila, "K"] = deco.Paterno;
                    myexcelWorksheet.Cells[fila, "L"] = deco.Materno;
                    myexcelWorksheet.Cells[fila, "M"] = deco.Nombres;
                    myexcelWorksheet.Cells[fila, "N"] = deco.Tipo_Persona;
                    myexcelWorksheet.Cells[fila, "P"] = deco.Pendiente;
                    myexcelWorksheet.Cells[fila, "AH"] = deco.Estado;
                    myexcelWorksheet.Cells[fila, "AI"] = deco.Dias_Atrasos;
                    myexcelWorksheet.Cells[fila, "AJ"] = deco.Domicilio;
                    myexcelWorksheet.Cells[fila, "AK"] = deco.Distrito;
                    myexcelWorksheet.Cells[fila, "AL"] = deco.Provincia;
                    myexcelWorksheet.Cells[fila, "AM"] = deco.Departamento;
                    myexcelWorksheet.Cells[fila, "AN"] = deco.Movil;
                    myexcelWorksheet.Cells[fila, "AO"] = deco.Vencimiento;
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
