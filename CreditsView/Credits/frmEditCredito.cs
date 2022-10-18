using Comun;
using CreditsController.Controller;
using CreditsModel.ModelDto;
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
    public partial class frmEditCredito : Form
    {
        public frmCreditos wCre;
        public Universal.Opera eOperacion;
        Masivo eMas = new Masivo();
        CreditsGeneralController objGeneralController = new CreditsGeneralController();
        CreditsSolicitanteController oSolCtrll = new CreditsSolicitanteController();
        public frmEditCredito()
        {
            InitializeComponent();
        }
        public void VentanaAdicionar()
        {
            this.InicializaVentana();
            eMas.AccionHabilitarControles(0);
            eMas.AccionPasarTextoPrincipal();
            //this.txtDocId.Focus();
        }
        public void InicializaVentana()
        {
            //titulo ventana
            this.Text = this.eOperacion.ToString() + Cadena.Espacios(1) + this.wCre.eTitulo;

            //eventos de controles
            //eMas.lisCtrls = this.ListaCtrls();
            eMas.EjecutarTodosLosEventos();
            //this.ActualizarVentana();
            this.LlenarCombo();
            this.LlenarDatosSolicitante();
            // Deshabilitar al propietario
            this.wCre.Enabled = false;

            // Mostrar ventana
            this.Show();
        }
        public void LlenarCombo()
        {
            Cmb.Cargar(this.cmbPlanillaPago, this.objGeneralController.ListarPlanillaPago(), "IdUnidDscto", "DesCortaUDscto");
            Cmb.Cargar(this.cmbMoneda, this.objGeneralController.ListarMoneda(), "Id_Moneda", "Des_Moneda");
            Cmb.Cargar(this.cmbEntBca, this.objGeneralController.ListaEntidadBancaria(), "Id_Bca", "De_Bca");
            Cmb.Cargar(this.cmbProveedor, this.objGeneralController.ListaProveedor(), "Id_Proveedor", "names");
        }
        public void LlenarDatosSolicitante()
        {
            CreditsSolicitantesDto iSolEN = new CreditsSolicitantesDto();
            iSolEN.Dni_Solic = this.wCre.txtDocId.Text.Trim();
            iSolEN = oSolCtrll.ListarSolicitantesPorDni(iSolEN);
            this.AsignarSolicitantes(iSolEN);
        }
        public void AsignarSolicitantes(CreditsSolicitantesDto iSolEN)
        {
            this.txtDocId.Text = iSolEN.Dni_Solic;
            this.txtApeNom.Text = iSolEN.Paterno.Trim() + " " + iSolEN.Materno.Trim() + ", " + iSolEN.Nombres.Trim();
            this.txtGrado.Text = iSolEN.DesGrado.Trim();
            this.txtSituacion.Text = "ACTIVIDAD";
            Cmb.SeleccionarValorItem(this.cmbEntBca, iSolEN.IdBca);
            this.txtNumCta.Text = iSolEN.NumCta.ToString();
            this.txtCCI.Text = iSolEN.CCI.ToString();
        }
    }
}
