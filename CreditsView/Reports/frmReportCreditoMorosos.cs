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
    public partial class frmReportCreditoMorosos : Form
    {
        public frmCreditoMorosos wCredMoro;
        CreditsReportController objReportController = new CreditsReportController();
        UtilConvertDataTable utilConvertDataTable = new UtilConvertDataTable();
        public string nombreReporte = "CreditsView.Reports.rptReportCreditoMorosos.rdlc";
        public string formaReporte = "Normal";
        public frmReportCreditoMorosos()
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
                string hasta = this.wCredMoro.dtpFecHasta.Value.ToString("yyyyMMdd");
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsCreditosMorosos";
                rds.Value = objReportController.ListarCreditoMorosos(hasta);

                ReportParameter[] rp = new ReportParameter[2];
                rp[0] = new ReportParameter("fecHasta", this.wCredMoro.dtpFecHasta.Text);
                rp[1] = new ReportParameter("userConsulta", Universal.gNombreUsuario);


                this.rvReportCreditoMorosos.Reset();
                this.rvReportCreditoMorosos.LocalReport.ReportEmbeddedResource = nombreReporte;
                this.rvReportCreditoMorosos.LocalReport.SetParameters(rp);
                this.rvReportCreditoMorosos.LocalReport.EnableExternalImages = true;
                this.rvReportCreditoMorosos.LocalReport.DataSources.Clear();
                this.rvReportCreditoMorosos.LocalReport.DataSources.Add(rds);

                PageSettings newPageSettings = new PageSettings();
                newPageSettings.Margins = new Margins(0, 0, 0, 0);

                if (formaReporte == "Horizontal")
                {
                    newPageSettings.Landscape = true;
                }
                this.rvReportCreditoMorosos.SetPageSettings(newPageSettings);

                this.rvReportCreditoMorosos.RefreshReport();
                this.Show();
            }
            catch (Exception e)
            {
                Mensaje.OperacionDenegada(e.Message, "error");
            }
        }

        private void frmReportTipoCreditoGeneradoDesembolsado_Load(object sender, EventArgs e)
        {

        }
    }
}
