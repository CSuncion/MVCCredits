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
using CreditsModel.ModelDto;

namespace CreditsView.Reports
{
    public partial class frmReportApplicant : Form
    {

        CreditsApplicantController objApplicantController = new CreditsApplicantController();
        UtilConvertDataTable utilConvertDataTable = new UtilConvertDataTable();
        public string nombreReporte = "CreditsView.Reports.rptCantidadDeSolicitantes.rdlc";
        public string formaReporte = "Horizontal";
        public frmCantidadSolicitantes wCanSol;
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
            this.Close();
        }

        private void frmReportApplicant_Load(object sender, EventArgs e)
        {
            //this.ActualizarVentana();
            this.rvwReportApplicant.RefreshReport();
        }

        public void ActualizarVentana()
        {
            try
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsSolicitantes";
                rds.Value = objApplicantController.ListarSolicitantes(this.wCanSol.txtAnio.Text);

                ReportParameter[] rp = new ReportParameter[2];
                rp[0] = new ReportParameter("userConsulta", Universal.gNombreUsuario);
                rp[1] = new ReportParameter("strAnio", this.wCanSol.txtAnio.Text);

                this.rvwReportApplicant.Reset();
                this.rvwReportApplicant.LocalReport.ReportEmbeddedResource = nombreReporte;
                this.rvwReportApplicant.LocalReport.EnableExternalImages = true;
                this.rvwReportApplicant.LocalReport.SetParameters(rp);
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
