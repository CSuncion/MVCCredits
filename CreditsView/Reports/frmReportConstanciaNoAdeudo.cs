using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsUtil.Util;
using CreditsView.Credits;
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
    public partial class frmReportConstanciaNoAdeudo : Form
    {
        public frmConstanciaNoAdeudo wConsNoAd;
        CreditsReportController oRptCtrl = new CreditsReportController();
        public string nombreReporte = "CreditsView.Reports.rptReportCreditoCartaNoAdeudo.rdlc";
        public string formaReporte = "Normal";
        UtilFechas oUtilFecha = new UtilFechas();
        public frmReportConstanciaNoAdeudo()
        {
            InitializeComponent();
        }

        private void frmReportConstanciaNoAdeudo_Load(object sender, EventArgs e)
        {

            this.rvConstanciaNoAdeudo.RefreshReport();
        }
        public void ImprimirConstanciaNoAdeudo(string correlativo)
        {
            this.Show();
            this.Dock = DockStyle.Fill;
            try
            {
                ReportDataSource rds = new ReportDataSource();
                List<string> listFirma = new List<string>();
                listFirma = oRptCtrl.ListaFirmaGerenteFinanza();
                string userFirma = (string)listFirma[0];
                string cargoAcceso = (string)listFirma[1];

                ReportParameter[] rp = new ReportParameter[10];
                rp[0] = new ReportParameter("nameAnio", oRptCtrl.ListaNameAnio().Trim());
                rp[1] = new ReportParameter("nameSolicitante", this.wConsNoAd.txtApeNom.Text.Trim());
                rp[2] = new ReportParameter("dniSolicitante", this.wConsNoAd.txtDocId.Text.Trim());
                rp[3] = new ReportParameter("strDia", DateTime.Now.Day.ToString());
                rp[4] = new ReportParameter("strMes", oUtilFecha.Mes()[DateTime.Now.Month - 1]);
                rp[5] = new ReportParameter("strAnio", DateTime.Now.Year.ToString());
                rp[6] = new ReportParameter("userFirma", userFirma.Trim());
                rp[7] = new ReportParameter("userCargo", cargoAcceso.Trim());
                rp[8] = new ReportParameter("userConsulta", Universal.gNombreUsuario.Trim());
                rp[9] = new ReportParameter("strCorrelativo", correlativo);


                this.rvConstanciaNoAdeudo.Reset();
                this.rvConstanciaNoAdeudo.LocalReport.ReportEmbeddedResource = nombreReporte;
                this.rvConstanciaNoAdeudo.LocalReport.SetParameters(rp);
                this.rvConstanciaNoAdeudo.LocalReport.EnableExternalImages = true;
                this.rvConstanciaNoAdeudo.LocalReport.DataSources.Clear();
                this.rvConstanciaNoAdeudo.LocalReport.DataSources.Add(rds);

                PageSettings newPageSettings = new PageSettings();
                newPageSettings.Margins = new Margins(0, 0, 0, 0);

                if (formaReporte == "Horizontal")
                {
                    newPageSettings.Landscape = true;
                }
                this.rvConstanciaNoAdeudo.SetPageSettings(newPageSettings);

                this.rvConstanciaNoAdeudo.RefreshReport();
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

        private void frmReportConstanciaNoAdeudo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
