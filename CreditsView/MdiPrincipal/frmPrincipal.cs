using CreditsUtil.Util;
using CreditsView.Login;
using CreditsView.Reports;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinControles.ControlesWindows;
using System.Runtime.InteropServices;
using CreditsView.Credits;
using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsView.Respaldos;
using CreditsView.AcercaDe;

namespace CreditsView.MdiPrincipal
{
    public partial class frmPrincipal : Form
    {
        CreditsAccessController oCredAccCtrl = new CreditsAccessController();
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
            this.AccesoPorPerfiles();
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
            this.btnMaximizar.Visible = false;
            this.btnRestaurar.Visible = true;
            this.isSize = true;
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
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
            //if (this.pnlMenu.Width == 285)
            //{
            //    this.btnMenu.Location = new Point(22, 6);
            //    this.tmOcultarMenu.Enabled = true;
            //}
            //else if (this.pnlMenu.Width == 60)
            //{
            //    this.btnMenu.Location = new Point(247, 6);
            //    this.tmMostrarMenu.Enabled = true;
            //}
        }
        private void pnlBarTit_DoubleClick(object sender, EventArgs e)
        {
            if (this.isSize)
                this.RestoreWindow();
            else
                this.MaximizedWindow();

        }
        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        // Tsm
        private void tsmCreditos_Click(object sender, EventArgs e)
        {
            this.InstanciarCreditos();
        }
        private void tsmCreditoOtorgados_Click(object sender, EventArgs e)
        {
            this.InstanciarReportGranted();
        }
        private void tsmSaldoFavor_Click(object sender, EventArgs e)
        {
            this.InstanciarSaldoFavor();
        }
        private void tsmPlanillaDecomicro_Click(object sender, EventArgs e)
        {
            this.InstanciarDecomicro();
        }
        private void tsmGeneradoDesembolsado_Click(object sender, EventArgs e)
        {
            this.InstanciarGeneradoDesembolsado();
        }
        private void tsmEnProceso_Click(object sender, EventArgs e)
        {
            this.InstanciarCreditoEnProceso();
        }
        private void tsmCartaNoAdeudo_Click(object sender, EventArgs e)
        {
            this.InstanciarConstanciaNoAdeudo();
        }

        private void tsmMorosos_Click(object sender, EventArgs e)
        {
            this.InstanciarCreditoMorosos();
        }
        private void tsmRefAmp_Click(object sender, EventArgs e)
        {
            this.InstanciarRefinanciadoAmpliado();
        }
        private void tsmSolicitantes_Click(object sender, EventArgs e)
        {
            this.InstanciarReportApplicant();
        }
        private void tsmTipoCredito_Click(object sender, EventArgs e)
        {
            this.InstanciarReportTypesCredits();
        }
        private void tsmCreditoPorAño_Click(object sender, EventArgs e)
        {
            this.InstanciarReportTypeCredit();
        }
        private void tsmComCredOtorgado_Click(object sender, EventArgs e)
        {
            this.InstanciarCreditoComparativo();
        }
        private void tsmRespaldoBackup_Click(object sender, EventArgs e)
        {
            this.InstanciarRespaldoBackup();
        }
        private void tsbCreditos_Click(object sender, EventArgs e)
        {
            this.InstanciarCreditos();
        }
        private void tsmAcercaDe_Click(object sender, EventArgs e)
        {
            this.InstanciarAcercaDe();
        }
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmSalFor_Click(object sender, EventArgs e)
        {
            this.InstanciarSaldosFormato();
        }
        #endregion

        #region Methods
        public void AccesoPorPerfiles()
        {
            List<int> listMenu = new List<int>();
            listMenu = oCredAccCtrl.ListarSubPrivilegiosAcceso(Universal.gIdAcceso);
            for (int i = 0; i < listMenu.Count; i++)
            {
                if (listMenu[i] == 1)
                {
                    this.tsmFinanzas.Visible = true;
                    this.tsbCreditos.Visible = true;
                }

                if (listMenu[i] == 2)
                {
                    this.tsmInformatica.Visible = true;
                }
            }
        }
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
        public void FormatoVentanaHijoPrincipal(Form pWin, ToolStripMenuItem pItem, ToolStripButton pAccDir, int PAncVen, int pAltVen)
        {
            pItem.Enabled = false;
            if (pAccDir != null) { pAccDir.Enabled = false; }
            this.tbcContainer.Visible = true;
            //this.BackColor = System.Drawing.SystemColors.Control;
            this.BackColor = Color.White;
            TabCtrl.InsertarVentanaConTabPage(this.tbcContainer, pWin, PAncVen, pAltVen);
        }
        public void InstanciarReportApplicant()
        {
            frmCantidadSolicitantes win = new frmCantidadSolicitantes();
            this.FormatoVentanaHijoPrincipal(win, this.tsmSolicitantes, null, 0, 0);
            win.NewWindow();
        }
        public void InstanciarReportGranted()
        {
            frmCreditosOtorgados win = new frmCreditosOtorgados();
            this.FormatoVentanaHijoPrincipal(win, this.tsmCreditoOtorgados, null, 0, 0);
            win.NewWindow();
        }
        public void InstanciarReportTypesCredits()
        {
            frmTiposCreditos win = new frmTiposCreditos();
            this.FormatoVentanaHijoPrincipal(win, this.tsmTipoCredito, null, 0, 0);
            win.NewWindow();
        }
        public void InstanciarReportTypeCredit()
        {
            frmTipoCredito win = new frmTipoCredito();
            this.FormatoVentanaHijoPrincipal(win, this.tsmCreditoPorAnio, null, 0, 0);
            win.NewWindow();
        }

        public void InstanciarRefinanciadoAmpliado()
        {
            frmRefinanciadoAmpliado win = new frmRefinanciadoAmpliado();
            this.FormatoVentanaHijoPrincipal(win, this.tsmRefAmp, null, 0, 0);
            win.NewWindow();
        }

        public void InstanciarSaldoFavor()
        {
            frmSaldoFavorSolicitante win = new frmSaldoFavorSolicitante();
            this.FormatoVentanaHijoPrincipal(win, this.tsmSaldoFavor, null, 0, 0);
            win.NewWindow();
        }

        public void InstanciarGeneradoDesembolsado()
        {
            frmTipoCreditoGeneradosDesembolsados win = new frmTipoCreditoGeneradosDesembolsados();
            this.FormatoVentanaHijoPrincipal(win, this.tsmGeneradoDesembolsado, null, 0, 0);
            win.NewWindow();
        }

        public void InstanciarCreditoEnProceso()
        {
            frmCreditoEnProceso win = new frmCreditoEnProceso();
            this.FormatoVentanaHijoPrincipal(win, this.tsmEnProceso, null, 0, 0);
            win.NewWindow();
        }

        public void InstanciarCreditoMorosos()
        {
            frmCreditoMorosos win = new frmCreditoMorosos();
            this.FormatoVentanaHijoPrincipal(win, this.tsmMorosos, null, 0, 0);
            win.NewWindow();
        }

        public void InstanciarCreditoComparativo()
        {
            frmReportComparativoCreditosGenerados win = new frmReportComparativoCreditosGenerados();
            this.FormatoVentanaHijoPrincipal(win, this.tsmComCredOtorgado, null, 0, 0);
            win.MostrarInforme();
        }

        public void InstanciarConstanciaNoAdeudo()
        {
            frmConstanciaNoAdeudo win = new frmConstanciaNoAdeudo();
            this.FormatoVentanaHijoPrincipal(win, this.tsmCartaNoAdeudo, null, 0, 0);
            win.NewWindow();
        }

        public void InstanciarDecomicro()
        {
            frmGenerarDecomicro win = new frmGenerarDecomicro();
            this.FormatoVentanaHijoPrincipal(win, this.tsmPlanillaDecomicro, null, 0, 0);
            win.NewWindow();
        }
        public void InstanciarCreditos()
        {
            frmCreditos win = new frmCreditos();
            this.FormatoVentanaHijoPrincipal(win, this.tsmCreditos, tsbCreditos, 0, 0);
            win.NewWindow();
        }
        public void InstanciarRespaldoBackup()
        {
            frmRespaldoBackup win = new frmRespaldoBackup();
            this.FormatoVentanaHijoPrincipal(win, this.tsmRespaldoBackup, null, 0, 0);
            win.abrirVentana();
        }
        public void InstanciarAcercaDe()
        {
            frmAcercaDe win = new frmAcercaDe();
            this.FormatoVentanaHijoPrincipal(win, this.tsmAcercaDe, null, 0, 0);
            win.NewWindow();
        }
        public void InstanciarSaldosFormato()
        {
            frmSaldosFormato win = new frmSaldosFormato();
            this.FormatoVentanaHijoPrincipal(win, this.tsmSalFor, null, 0, 0);
            win.NewWindow();
        }
        public void ShowOptionsReport()
        {
            //if (this.pnlBtnFinanzas.Visible)
            //{
            //    this.pnlBtnFinanzas.Visible = false;
            //    this.btnInformatica.Location = new Point(3, 170);
            //    this.pnlInformatica.Location = new Point(3, 170);
            //    this.pnlBtnInformatica.Location = new Point(0, 208);
            //}
            //else
            //{
            //    this.pnlBtnFinanzas.Visible = true;
            //    this.btnInformatica.Location = new Point(3, 508);
            //    this.pnlInformatica.Location = new Point(3, 508);
            //    this.pnlBtnInformatica.Location = new Point(0, 547);
            //}
        }

        public void ShowOptionsCredits()
        {
            //if (this.pnlBtnInformatica.Visible)
            //{
            //    this.pnlBtnInformatica.Visible = false;
            //this.btnCredits.Location = new Point(3, 170);
            //this.pnlCredits.Location = new Point(3, 170);
            //}
            //else
            //{
            //    this.pnlBtnInformatica.Visible = true;
            //this.btnCredits.Location = new Point(3, 400);
            //this.pnlCredits.Location = new Point(3, 400);
            //}
        }

        public void CerrarVentanaHijo(Form pWin, ToolStripMenuItem pItem, ToolStripButton pAccDir)
        {
            pItem.Enabled = true;
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
