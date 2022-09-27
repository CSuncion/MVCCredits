using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsView.MdiPrincipal;
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
    public partial class frmReportComparativoCreditosGenerados : Form
    {
        CreditsReportController objReportController = new CreditsReportController();
        public string nombreReporte = "CreditsView.Reports.rptReportComparativoCreditoOtorgados.rdlc";
        public string formaReporte = "Normal";
        public frmReportComparativoCreditosGenerados()
        {
            InitializeComponent();
        }

        private void frmReportComparativoCreditosGenerados_Load(object sender, EventArgs e)
        {

            this.rvComparativoCreditosGenerados.RefreshReport();
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
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsComparativoCreditoOtorgado";
                rds.Value = objReportController.ListarComparativoCreditoOtorgados();

                ReportParameter[] rp = new ReportParameter[1];
                rp[0] = new ReportParameter("userConsulta", Universal.gNombreUsuario);


                this.rvComparativoCreditosGenerados.Reset();
                this.rvComparativoCreditosGenerados.LocalReport.ReportEmbeddedResource = nombreReporte;
                this.rvComparativoCreditosGenerados.LocalReport.SetParameters(rp);
                this.rvComparativoCreditosGenerados.LocalReport.EnableExternalImages = true;
                this.rvComparativoCreditosGenerados.LocalReport.DataSources.Clear();
                this.rvComparativoCreditosGenerados.LocalReport.DataSources.Add(rds);

                PageSettings newPageSettings = new PageSettings();
                newPageSettings.Margins = new Margins(0, 0, 0, 0);

                if (formaReporte == "Horizontal")
                {
                    newPageSettings.Landscape = true;
                }
                this.rvComparativoCreditosGenerados.SetPageSettings(newPageSettings);

                this.rvComparativoCreditosGenerados.RefreshReport();
                this.Show();
            }
            catch (Exception e)
            {
                Mensaje.OperacionDenegada(e.Message, "error");
            }
        }

        public void Cerrar()
        {
            frmPrincipal wMen = (frmPrincipal)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.btnComparativoCreditos, null);
        }
        private void frmReportComparativoCreditosGenerados_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }
    }
}
