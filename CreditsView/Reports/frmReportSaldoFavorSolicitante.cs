using Comun;
using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsUtil.Util;
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
    public partial class frmReportSaldoFavorSolicitante : Form
    {
        public frmSaldoFavorSolicitante wSalFv;
        CreditsReportController objReportController = new CreditsReportController();
        UtilConvertDataTable utilConvertDataTable = new UtilConvertDataTable();
        public string nombreReporte = "CreditsView.Reports.rptReportSaldoFavorSolicitante.rdlc";
        public string formaReporte = "Normal";
        public frmReportSaldoFavorSolicitante()
        {
            InitializeComponent();
        }
        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void MostrarInforme()
        {
            this.Dock = DockStyle.Fill;
            try
            {
                string desde =  this.wSalFv.dtpFecDesde.Value.ToString("yyyyMMdd");
                string hasta = this.wSalFv.dtpFecHasta.Value.ToString("yyyyMMdd"); 
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsSaldoFavorSolicitantes";
                rds.Value = objReportController.ListarSaldoFavorSolicitantes(desde, hasta);

                ReportParameter[] rp = new ReportParameter[3];
                rp[0] = new ReportParameter("fecDesde", this.wSalFv.dtpFecDesde.Text);
                rp[1] = new ReportParameter("fecHasta", this.wSalFv.dtpFecHasta.Text);
                rp[2] = new ReportParameter("userConsulta", Universal.gNombreUsuario);


                this.rvReportSaldoFavorSolicitante.Reset();
                this.rvReportSaldoFavorSolicitante.LocalReport.ReportEmbeddedResource = nombreReporte;
                this.rvReportSaldoFavorSolicitante.LocalReport.SetParameters(rp);
                this.rvReportSaldoFavorSolicitante.LocalReport.EnableExternalImages = true;
                this.rvReportSaldoFavorSolicitante.LocalReport.DataSources.Clear();
                this.rvReportSaldoFavorSolicitante.LocalReport.DataSources.Add(rds);
                this.rvReportSaldoFavorSolicitante.SetDisplayMode(DisplayMode.PrintLayout);
                this.rvReportSaldoFavorSolicitante.ZoomMode = ZoomMode.Percent;
                this.rvReportSaldoFavorSolicitante.ZoomPercent = 100;

                PageSettings newPageSettings = new PageSettings();
                newPageSettings.Margins = new Margins(0, 0, 0, 0);

                if (formaReporte == "Horizontal")
                {
                    newPageSettings.Landscape = true;
                }
                this.rvReportSaldoFavorSolicitante.SetPageSettings(newPageSettings);

                this.rvReportSaldoFavorSolicitante.RefreshReport();
                this.Show();
            }
            catch (Exception e)
            {
                Mensaje.OperacionDenegada(e.Message, "error");
            }
        }

        private void frmReportSaldoFavorSolicitante_Load(object sender, EventArgs e)
        {

        }
    }
}
