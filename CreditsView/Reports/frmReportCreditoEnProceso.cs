using CreditsController.Controller;
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
    public partial class frmReportCreditoEnProceso : Form
    {
        public frmCreditoEnProceso wCredEnPrc;
        CreditsReportController objReportController = new CreditsReportController();
        UtilConvertDataTable utilConvertDataTable = new UtilConvertDataTable();
        public string nombreReporte = "CreditsView.Reports.rptReportCreditoEnProceso.rdlc";
        public string formaReporte = "Horizontal";
        public frmReportCreditoEnProceso()
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
                string desde = this.wCredEnPrc.dtpFecDesde.Value.ToString("yyyyMMdd");
                string hasta = this.wCredEnPrc.dtpFecHasta.Value.ToString("yyyyMMdd");
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsCreditoEnProceso";
                rds.Value = objReportController.ListarCreditoEnProceso(desde, hasta);

                ReportParameter[] rp = new ReportParameter[2];
                rp[0] = new ReportParameter("fecDesde", this.wCredEnPrc.dtpFecDesde.Text);
                rp[1] = new ReportParameter("fecHasta", this.wCredEnPrc.dtpFecHasta.Text);


                this.rvReportTipoCreditosGeneradoDesembolsado.Reset();
                this.rvReportTipoCreditosGeneradoDesembolsado.LocalReport.ReportEmbeddedResource = nombreReporte;
                this.rvReportTipoCreditosGeneradoDesembolsado.LocalReport.SetParameters(rp);
                this.rvReportTipoCreditosGeneradoDesembolsado.LocalReport.EnableExternalImages = true;
                this.rvReportTipoCreditosGeneradoDesembolsado.LocalReport.DataSources.Clear();
                this.rvReportTipoCreditosGeneradoDesembolsado.LocalReport.DataSources.Add(rds);

                PageSettings newPageSettings = new PageSettings();
                newPageSettings.Margins = new Margins(0, 0, 0, 0);

                if (formaReporte == "Horizontal")
                {
                    newPageSettings.Landscape = true;
                }
                this.rvReportTipoCreditosGeneradoDesembolsado.SetPageSettings(newPageSettings);

                this.rvReportTipoCreditosGeneradoDesembolsado.RefreshReport();
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
