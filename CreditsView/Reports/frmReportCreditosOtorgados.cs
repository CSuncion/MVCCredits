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
    public partial class frmReportCreditosOtorgados : Form
    {
        public frmCreditosOtorgados wCreOto;
        CreditsReportController objReportController = new CreditsReportController();
        UtilConvertDataTable utilConvertDataTable = new UtilConvertDataTable();
        public string nombreReporte = "CreditsView.Reports.rptReportCreditoOtorgados.rdlc";
        public string formaReporte = "Horizontal";
        public frmReportCreditosOtorgados()
        {
            InitializeComponent();
        }

        private void frmReportCreditosOtorgados_Load(object sender, EventArgs e)
        {

            this.rvReportCreditosOtorgados.RefreshReport();
        }

        public void MostrarGrafico()
        {
            this.Dock = DockStyle.Fill;
            try
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsCreditosOtorgados";
                rds.Value = objReportController.ListarCreditosOtorgados(Convert.ToInt32(this.wCreOto.txtAnio.Text));

                ReportParameter[] rp = new ReportParameter[2];
                rp[0] = new ReportParameter("txtReportAnio", this.wCreOto.txtAnio.Text);
                rp[1] = new ReportParameter("userConsulta", Universal.gNombreUsuario);

                this.rvReportCreditosOtorgados.Reset();
                this.rvReportCreditosOtorgados.LocalReport.ReportEmbeddedResource = nombreReporte;
                this.rvReportCreditosOtorgados.LocalReport.SetParameters(rp);
                this.rvReportCreditosOtorgados.LocalReport.EnableExternalImages = true;
                this.rvReportCreditosOtorgados.LocalReport.DataSources.Clear();
                this.rvReportCreditosOtorgados.LocalReport.DataSources.Add(rds);
                this.rvReportCreditosOtorgados.SetDisplayMode(DisplayMode.PrintLayout);
                this.rvReportCreditosOtorgados.ZoomMode = ZoomMode.Percent;
                this.rvReportCreditosOtorgados.ZoomPercent = 100;

                PageSettings newPageSettings = new PageSettings();
                newPageSettings.Margins = new Margins(0, 0, 0, 0);

                if (formaReporte == "Horizontal")
                {
                    newPageSettings.Landscape = true;
                }
                this.rvReportCreditosOtorgados.SetPageSettings(newPageSettings);

                this.rvReportCreditosOtorgados.RefreshReport();
                this.Show();
            }
            catch (Exception e)
            {
                Mensaje.OperacionDenegada(e.Message, "error");
            }
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
