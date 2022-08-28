﻿using CreditsUtil.Util;
using CreditsView.Login;
using CreditsView.Reports;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinControles.ControlesWindows;
using System.Runtime.InteropServices;

namespace CreditsView.MdiPrincipal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            //this.LoadTheme
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        #region Events
        int lx, ly;
        int sw, sh;
        bool isSize = false;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.NewWindowAccess();
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            this.ShowOptionsReport();
        }
        private void tsSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.MaximizedWindow();

        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.RestoreWindow();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void pnlBarTit_MouseMove(object sender, MouseEventArgs e)
        {
            WinPrincipal.ReleaseCapture();
            WinPrincipal.SendMessage(this.Handle, 0x112, 0xF012, 0);
        }
        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (this.pnlMenu.Width <= 60)
                this.tmOcultarMenu.Enabled = false;
            else
                this.pnlMenu.Width -= 45;
        }
        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (this.pnlMenu.Width >= 285)
                this.tmMostrarMenu.Enabled = false;
            else
                this.pnlMenu.Width += 45;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (this.pnlMenu.Width == 285)
                this.tmOcultarMenu.Enabled = true;
            else if (this.pnlMenu.Width == 60)
                this.tmMostrarMenu.Enabled = true;
        }
        private void pnlBarTit_DoubleClick(object sender, EventArgs e)
        {
            if (this.isSize)
                this.RestoreWindow();
            else
                this.MaximizedWindow();

        }
        private void btnReportApplicant_Click(object sender, EventArgs e)
        {
            this.InstanciarReportApplicant();
        }
        private void frmPrincipal_Resize(object sender, EventArgs e)
        {

        }
        private void btnCreditsGranted_Click(object sender, EventArgs e)
        {
            this.InstanciarReportGranted();
        }
        #endregion

        #region Methods

        private void LoadTheme()
        {
            var themeColor = WinTheme.GetAccentColor();

            pnlLogo.BackColor = themeColor;
            pnlMenu.BackColor = themeColor;

            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.BackColor = themeColor;
            }
            foreach (Button button in this.pnlMenu.Controls.OfType<Button>())
            {
                button.BackColor = themeColor;
            }
        }

        public void NewWindowAccess()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.frmPrincipal = this;
            frmLogin.NewWindow();
        }
        public void RestoreWindow()
        {
            this.isSize = false;
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        public void MaximizedWindow()
        {
            this.btnMaximizar.Visible = false;
            this.btnRestaurar.Visible = true;
            this.isSize = true;
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        public void EliminarTodasLasVentanasAbiertas()
        {
            //obtener la lista de ventanas a eliminar
            List<Form> iLisVenEli = this.ObtenerListaDeVentanasAbiertas();

            //obtener el numero de formularios abiertos
            int iNumeroVentanasAbiertas = iLisVenEli.Count;

            //ir eliminando cada ventana 
            for (int i = 0; i < iNumeroVentanasAbiertas; i++)
            {
                iLisVenEli[i].Close();
            }
        }
        public List<Form> ObtenerListaDeVentanasAbiertas()
        {
            //lista resultado
            List<Form> iLisRes = new List<Form>();

            //solo excepto el wMenu y el wAcceso
            foreach (Form xWin in Application.OpenForms)
            {
                if (xWin.Name != "frmPrincipal" && xWin.Name != "frmLogin")
                {
                    iLisRes.Add(xWin);
                }
            }

            //devolver
            return iLisRes;
        }
        public void EliminarTodosLosTabVentanas()
        {
            int iNroTabPage = this.tbcContainer.TabPages.Count;

            //eliminar todos los tabpage pero desde el indice 1
            for (int i = 0; i < iNroTabPage; i++)
            {
                this.tbcContainer.TabPages.RemoveAt(0);
            }
        }
        public void FormatoVentanaHijoPrincipal(Form pWin, Button pBtn, ToolStripButton pAccDir, int PAncVen, int pAltVen)
        {
            pBtn.Enabled = false;
            if (pAccDir != null) { pAccDir.Enabled = false; }
            this.tbcContainer.Visible = true;
            //this.BackColor = System.Drawing.SystemColors.Control;
            this.BackColor = Color.White;
            TabCtrl.InsertarVentanaConTabPage(this.tbcContainer, pWin, PAncVen, pAltVen);
        }
        public void InstanciarReports()
        {
            frmReports win = new frmReports();
            this.FormatoVentanaHijoPrincipal(win, this.btnReports, null, 0, 0);
            win.NewWindow();
        }
        public void InstanciarReportApplicant()
        {
            frmReportApplicant win = new frmReportApplicant();
            this.FormatoVentanaHijoPrincipal(win, this.btnReportApplicant, null, 0, 0);
            win.NewWindow();
        }
        public void InstanciarReportGranted()
        {
            frmCreditosOtorgados win = new frmCreditosOtorgados();
            this.FormatoVentanaHijoPrincipal(win, this.btnCreditsGranted, null, 0, 0);
            win.NewWindow();
        }
        public void ShowOptionsReport()
        {
            if (this.btnReportApplicant.Visible)
            {
                this.btnReportApplicant.Visible = false;
                this.btnCreditType.Visible = false;
                this.btnCreditsGranted.Visible = false;
                this.btnPositiveBalance.Visible = false;
                this.btnDecomicSheet.Visible = false;
                this.btnCredits.Location = new Point(3, 170);
                this.pnlCredits.Location = new Point(3, 170);
            }
            else
            {
                this.btnReportApplicant.Visible = true;
                this.btnCreditType.Visible = true;
                this.btnCreditsGranted.Visible = true;
                this.btnPositiveBalance.Visible = true;
                this.btnDecomicSheet.Visible = true;
                this.btnCredits.Location = new Point(3, 360);
                this.pnlCredits.Location = new Point(3, 360);
            }
        }

        public void CerrarVentanaHijo(Form pWin, Button pBtn, ToolStripButton pAccDir)
        {
            pBtn.Enabled = true;
            if (pAccDir != null) { pAccDir.Enabled = true; }
            TabCtrl.EliminarTabPageAlCerrarVentana(this.tbcContainer, pWin);
            if (this.tbcContainer.TabPages.Count == 0)
            {
                this.tbcContainer.Visible = false;
                this.BackColor = Color.Gray;
            }
        }
        #endregion
    }
}
