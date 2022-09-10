using Comun;
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

namespace CreditsView.Credits
{
    public partial class frmEditRefinanciadoAmpliado : Form
    {
        #region Atributos

        public frmRefinanciadoAmpliado wRefAmp;
        #endregion 
        public Universal.Opera eOperacion;
        Masivo eMas = new Masivo();
        public frmEditRefinanciadoAmpliado()
        {
            InitializeComponent();
        }

        List<ControlEditar> ListaCtrls()
        {
            List<ControlEditar> xLis = new List<ControlEditar>();
            ControlEditar xCtrl;


            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtDocId, true, "Documento de Identidad", "vvff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtApeNom, true, "Apellidos y Nombres", "ffff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtGrado, true, "Grado", "ffff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtEMail, true, "E-Mail", "ffff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtCelular, true, "Celular o Tlf.", "ffff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtDepartamento, true, "Departamento", "ffff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtProvincia, true, "Provincia", "ffff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtDistrito, true, "Distrito", "ffff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtNroCredito, false, "Fecha Vencimiento", "vvff", 10);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.dtpFecCredito, false, "Fecha Emision", "vvff", 20);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.Cmb(this.cmbTipoCredito, "vvff");
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtLote, false, "Lote", "ffff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtSaldoPagar, false, "Saldo a Pagar", "vvff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtEstadoCredito, false, "Estado Crédito", "ffff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtCuotaMorosas, false, "Cuotas Morosas", "ffff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtUltimoPago, false, "Último Pago", "ffff", 150);
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.Btn(this.btnAceptar, "vvvf");
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.Btn(this.btnCancelar, "vvvv");
            xLis.Add(xCtrl);

            return xLis;
        }
        public void VentanaAdicionar()
        {
            this.InicializaVentana();
            //this.MostrarRegistroCompra(DeclaracionesRegistroCompraController.EnBlanco());
            eMas.AccionHabilitarControles(0);
            eMas.AccionPasarTextoPrincipal();
            //this.CargarTipoCambio();
            this.txtDocId.Focus();
        }
        public void InicializaVentana()
        {
            //titulo ventana
            this.Text = this.eOperacion.ToString() + Cadena.Espacios(1) + this.wRefAmp.eTitulo;

            //eventos de controles
            eMas.lisCtrls = this.ListaCtrls();
            eMas.EjecutarTodosLosEventos();

            //llenar combos      
            //this.CargarMonedas();

            //valores x defecto
            //this.ValoresXDefecto();

            // Deshabilitar al propietario
            this.wRefAmp.Enabled = false;

            // Mostrar ventana
            this.Show();
        }

        private void txtDocId_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtDocId_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtDocId_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
