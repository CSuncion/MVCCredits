using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsView.MdiPrincipal;
using CreditsView.Reports;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControles;
using WinControles.ControlesWindows;

namespace CreditsView.Credits
{
    public partial class frmConstanciaNoAdeudo : Form
    {
        CreditsSolicitanteController oSolCtrll = new CreditsSolicitanteController();
        CreditsReportController oRptCtrll = new CreditsReportController();
        CreditsCorrelativoConstanciaNoAdeudoController oCorrNoAdCtrll = new CreditsCorrelativoConstanciaNoAdeudoController();
        string eTitulo = "Constancia de no Adeudo";
        int eVaBD = 1;//0 : no , 1 : si
        public frmConstanciaNoAdeudo()
        {
            InitializeComponent();
        }

        public void NewWindow()
        {
            this.Show();
        }
        public void Cerrar()
        {
            frmPrincipal wMen = (frmPrincipal)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.tsmCartaNoAdeudo, null);
        }
        public void ActualizarVentana()
        {
            this.ActualizarListaSolicitantesDeBaseDatos();
            this.ActualizarListaConstanciaNoAdeudo();
        }

        public void ActualizarListaSolicitantesDeBaseDatos()
        {
            //validar si es acto ir a la bd
            if (this.txtDocId.Text.Trim() != string.Empty && eVaBD == 0) { return; }

            //ir a la bd
            CreditsSolicitantesDto iSolEN = new CreditsSolicitantesDto();
            iSolEN.Dni_Solic = this.txtDocId.Text.Trim();
            iSolEN = oSolCtrll.ListarSolicitantesPorDni(iSolEN);
            this.AsignarSolicitantes(iSolEN);
        }

        public void ActualizarListaConstanciaNoAdeudo()
        {
            //validar si es acto ir a la bd
            if (this.txtDocId.Text.Trim() != string.Empty && eVaBD == 0) { return; }

            decimal saldo = oRptCtrll.ListarConsultaNoAdeudo(this.txtDocId.Text.Trim());

            if (saldo > 0)
            {
                this.lblMensajeAdeuda.Text = "Tiene una deuda con FONBIEPOL de S/ " + saldo;
                this.btnImpConsNoAdeu.Visible = false;
                this.gbImpNoAdeu.Visible = true;
            }
            else
            {
                this.lblMensajeAdeuda.Text = "No adeuda al FONBIEPOL";
                this.gbImpNoAdeu.Visible = true;
                this.btnImpConsNoAdeu.Visible = true;
            }
        }

        public void AsignarSolicitantes(CreditsSolicitantesDto iSolEN)
        {
            this.txtApeNom.Text = iSolEN.Paterno.Trim() + " " + iSolEN.Materno.Trim() + ", " + iSolEN.Nombres.Trim();
            this.txtGrado.Text = iSolEN.DesGrado.Trim();
        }

        public string GuardarCorrelativoConstanciaNoAdeudo()
        {
            CreditsCorrelativoConstanciaNoAdeudoDto eCCCNoAde = new CreditsCorrelativoConstanciaNoAdeudoDto();
            eCCCNoAde.Correlativo = oRptCtrll.GenerarCorrelativoConstanciaNoAdeudo(DateTime.Now.Year.ToString());
            eCCCNoAde.Periodo = DateTime.Now.Year.ToString();
            eCCCNoAde.FechaCorrelativo = DateTime.Now;
            eCCCNoAde.DniSolicitante = this.txtDocId.Text;
            return oCorrNoAdCtrll.CrearRefinanciadoAmpliado(eCCCNoAde);
        }
        public void AdicionarCorrelativoConstanciaNoAdeudo()
        {
            string correlativo = string.Empty;
            if (oRptCtrll.ValidaImpresionCorrelativoConstanciaNoAdeudo(this.txtDocId.Text) == 1)
            {
                Mensaje.OperacionDenegada("Ya ha generado una constancia de no adeudo", this.eTitulo);
                return;
            }
            if (Mensaje.DeseasRealizarOperacion(this.eTitulo))
                correlativo = this.GuardarCorrelativoConstanciaNoAdeudo();

            Mensaje.OperacionSatisfactoria("Se genero correctamente la constancia no adeudo", this.eTitulo);

            this.AccionImprimirConstanciaNoAdeudo(correlativo);

        }
        public void AccionImprimirConstanciaNoAdeudo(string correlativo)
        {
            frmReportConstanciaNoAdeudo win = new frmReportConstanciaNoAdeudo();
            win.wConsNoAd = this;
            TabCtrl.InsertarVentana(this, win);
            win.ImprimirConstanciaNoAdeudo(correlativo);
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConstanciaNoAdeudo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }

        private void txtDocId_Validating(object sender, CancelEventArgs e)
        {
            this.ActualizarVentana();
            eVaBD = 1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.ActualizarVentana();
            eVaBD = 1;
        }

        private void btnImpConsNoAdeu_Click(object sender, EventArgs e)
        {
            this.AdicionarCorrelativoConstanciaNoAdeudo();
        }

    }
}
