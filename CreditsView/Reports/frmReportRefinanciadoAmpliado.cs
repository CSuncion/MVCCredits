using CreditsController.Controller;
using CreditsModel.ModelDto;
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
    public partial class frmReportRefinanciadoAmpliado : Form
    {
        public frmRefinanciadoAmpliado wRefAmp;
        CreditsSolicitanteController oSol = new CreditsSolicitanteController();
        CreditsReportController objReportController = new CreditsReportController();
        public string nombreReporte = "CreditsView.Reports.rptReportRefinanciadoAmpliado.rdlc";
        public string formaReporte = "Normal";
        public frmReportRefinanciadoAmpliado()
        {
            InitializeComponent();
        }

        private void frmReportRefinanciadoAmpliado_Load(object sender, EventArgs e)
        {

            this.rvRefinanciadoAmpliado.RefreshReport();
        }
        public void NuevaVentana(CreditsOperationsDto pObj)
        {
            this.Imprimir(pObj);
            this.Show();
        }
        public void Imprimir(CreditsOperationsDto pObj)
        {
            this.Dock = DockStyle.Fill;
            try
            {
                CreditsSolicitantesDto eSol = new CreditsSolicitantesDto();
                eSol.Dni_Solic = pObj.Dni_Solicitante;
                eSol = oSol.ListarSolicitantesPorDni(eSol);

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsOperacionesRefAmp";
                rds.Value = objReportController.ListarOperacionesRefinanciamientoAmpliacion(pObj);

                ReportParameter[] rp = new ReportParameter[4];
                rp[0] = new ReportParameter("txtNomApe", eSol.Paterno.Trim() + " " + eSol.Materno.Trim() + ", " + eSol.Nombres.Trim());
                rp[1] = new ReportParameter("txtGrado", eSol.DesGrado);
                rp[2] = new ReportParameter("txtDniSolicitante", eSol.Dni_Solic);
                rp[3] = new ReportParameter("userConsulta", Universal.gNombreUsuario);

                this.rvRefinanciadoAmpliado.Reset();
                this.rvRefinanciadoAmpliado.LocalReport.ReportEmbeddedResource = nombreReporte;
                this.rvRefinanciadoAmpliado.LocalReport.SetParameters(rp);
                this.rvRefinanciadoAmpliado.LocalReport.EnableExternalImages = true;
                this.rvRefinanciadoAmpliado.LocalReport.DataSources.Clear();
                this.rvRefinanciadoAmpliado.LocalReport.DataSources.Add(rds);

                PageSettings newPageSettings = new PageSettings();
                newPageSettings.Margins = new Margins(0, 0, 0, 0);

                if (formaReporte == "Horizontal")
                {
                    newPageSettings.Landscape = true;
                }
                this.rvRefinanciadoAmpliado.SetPageSettings(newPageSettings);

                this.rvRefinanciadoAmpliado.RefreshReport();
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
