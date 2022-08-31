﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControles.ControlesWindows;
using CreditsUtil.Util;
using CreditsController.Controller;
using WinControles;
using CreditsView.MdiPrincipal;

namespace CreditsView.Reports
{
    public partial class frmTipoCreditos : Form
    {
        UtilFechas objUtilFechas = new UtilFechas();
        CreditsGeneralController objGeneralController = new CreditsGeneralController();
        public frmTipoCreditos()
        {
            InitializeComponent();
        }
        public void NewWindow()
        {
            this.Show();
        }
        private void frmTipoCreditos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarGrafica_Click(object sender, EventArgs e)
        {
            this.AccionGenerarGrafica();
        }

        public void Cerrar()
        {
            frmPrincipal wMen = (frmPrincipal)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.btnCreditType, null);
        }
        public void AccionGenerarGrafica()
        {
            int resultado = 0;

            bool esNumerico = Int32.TryParse(this.txtAnio.Text, out resultado);

            if (!esNumerico)
            {
                Mensaje.OperacionDenegada("Debe ser numerico", this.Text);
                return;
            }

            if(this.txtAnio.Text.Length < 4)
            {
                Mensaje.OperacionDenegada("Debe ser un año valido", this.Text);
                return;
            }

            frmReportTipoCreditos win = new frmReportTipoCreditos();
            win.wTipCred = this;
            TabCtrl.InsertarVentana(this, win);
            win.MostrarGrafico();

        }
    }
}
