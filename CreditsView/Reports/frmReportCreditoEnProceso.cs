﻿using CreditsController.Controller;
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
    public partial class frmReportCreditoEnProceso : Form
    {
        public frmCreditoEnProceso wCredEnPrc;
        CreditsReportController objReportController = new CreditsReportController();
        UtilConvertDataTable utilConvertDataTable = new UtilConvertDataTable();
        public string nombreReporte = "CreditsView.Reports.rptReportCreditoEnProceso.rdlc";
        public string formaReporte = "Normal";
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

                ReportParameter[] rp = new ReportParameter[3];
                rp[0] = new ReportParameter("fecDesde", this.wCredEnPrc.dtpFecDesde.Text);
                rp[1] = new ReportParameter("fecHasta", this.wCredEnPrc.dtpFecHasta.Text);
                rp[2] = new ReportParameter("userConsulta", Universal.gNombreUsuario);


                this.rvReportCreditoEnProceso.Reset();
                this.rvReportCreditoEnProceso.LocalReport.ReportEmbeddedResource = nombreReporte;
                this.rvReportCreditoEnProceso.LocalReport.SetParameters(rp);
                this.rvReportCreditoEnProceso.LocalReport.EnableExternalImages = true;
                this.rvReportCreditoEnProceso.LocalReport.DataSources.Clear();
                this.rvReportCreditoEnProceso.LocalReport.DataSources.Add(rds);
                this.rvReportCreditoEnProceso.SetDisplayMode(DisplayMode.PrintLayout);
                this.rvReportCreditoEnProceso.ZoomMode = ZoomMode.Percent;
                this.rvReportCreditoEnProceso.ZoomPercent = 100;

                PageSettings newPageSettings = new PageSettings();
                newPageSettings.Margins = new Margins(0, 0, 0, 0);

                if (formaReporte == "Horizontal")
                {
                    newPageSettings.Landscape = true;
                }
                this.rvReportCreditoEnProceso.SetPageSettings(newPageSettings);

                this.rvReportCreditoEnProceso.RefreshReport();
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
