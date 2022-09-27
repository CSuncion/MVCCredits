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
using WinControles.ControlesWindows;

namespace CreditsView.Reports
{
    public partial class frmReportTipoCredito : Form
    {
        public frmTipoCredito wTipCred;
        CreditsReportController objReportController = new CreditsReportController();
        UtilConvertDataTable utilConvertDataTable = new UtilConvertDataTable();
        public string nombreReporte = "CreditsView.Reports.rptReportTipoCredito.rdlc";
        public string formaReporte = "Horizontal";
        public frmReportTipoCredito()
        {
            InitializeComponent();
        }

        public void MostrarGrafico()
        {
            this.Dock = DockStyle.Fill;
            try
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsTipoCredito";
                rds.Value = objReportController.ListarTipoCreditoPorAnio(Convert.ToInt32(this.wTipCred.txtAnio.Text),
                    Convert.ToInt32(Cmb.ObtenerValor(this.wTipCred.cmbCentroCosto)));

                ReportParameter[] rp = new ReportParameter[3];
                rp[0] = new ReportParameter("txtReportAnio", this.wTipCred.txtAnio.Text);
                rp[1] = new ReportParameter("txtReportTipoCredito", Cmb.ObtenerTexto(this.wTipCred.cmbCentroCosto));
                rp[2] = new ReportParameter("userConsulta", Universal.gNombreUsuario);


                this.rvReportTipoCreditos.Reset();
                this.rvReportTipoCreditos.LocalReport.ReportEmbeddedResource = nombreReporte;
                this.rvReportTipoCreditos.LocalReport.SetParameters(rp);
                this.rvReportTipoCreditos.LocalReport.EnableExternalImages = true;
                this.rvReportTipoCreditos.LocalReport.DataSources.Clear();
                this.rvReportTipoCreditos.LocalReport.DataSources.Add(rds);

                PageSettings newPageSettings = new PageSettings();
                newPageSettings.Margins = new Margins(0, 0, 0, 0);

                if (formaReporte == "Horizontal")
                {
                    newPageSettings.Landscape = true;
                }
                this.rvReportTipoCreditos.SetPageSettings(newPageSettings);

                this.rvReportTipoCreditos.RefreshReport();
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

        private void frmReportTiposCreditos_Load(object sender, EventArgs e)
        {
            this.rvReportTipoCreditos.RefreshReport();
        }
    }
}
