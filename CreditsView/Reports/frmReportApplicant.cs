using CreditsUtil.Util;
using CreditsController.Controller;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControles;

namespace CreditsView.Reports
{
    public partial class frmReportApplicant : Form
    {

        CreditsApplicantController objApplicantController = new CreditsApplicantController();
        UtilConvertDataTable utilConvertDataTable = new UtilConvertDataTable();
        public string nombreReporte = "CreditsView.Reports.rptReportApplicant.rdlc";
        public string formaReporte = "Normal";
        public frmReportApplicant()
        {
            InitializeComponent();
        }

        public void NewWindow()
        {
            this.Dock = DockStyle.Fill;
            this.Show();
            this.ActualizarVentana();
            //this.fillChart();
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void frmReportApplicant_Load(object sender, EventArgs e)
        {
            //this.ActualizarVentana();
            this.rvwReportApplicant.RefreshReport();
        }

        public void ActualizarVentana()
        {
            DataTable dt = new DataTable();
            dt = utilConvertDataTable.ToDataTable(objApplicantController.ListarSolicitantes());

            try
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = dt;

                this.rvwReportApplicant.Reset();
                this.rvwReportApplicant.LocalReport.ReportEmbeddedResource = nombreReporte;
                this.rvwReportApplicant.LocalReport.EnableExternalImages = true;
                this.rvwReportApplicant.LocalReport.DataSources.Clear();
                this.rvwReportApplicant.LocalReport.DataSources.Add(rds);

                PageSettings newPageSettings = new PageSettings();
                newPageSettings.Margins = new Margins(0, 0, 0, 0);

                if (formaReporte == "Horizontal")
                {
                    newPageSettings.Landscape = true;
                }
                this.rvwReportApplicant.SetPageSettings(newPageSettings);

                this.rvwReportApplicant.RefreshReport();
            }
            catch (Exception e)
            {
                Mensaje.OperacionDenegada(e.Message, "error");
            }
        }
    }
}
