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
    public partial class frmEditRefinanciadoAmpliado : Form
    {
        #region Atributos

        public frmRefinanciadoAmpliado wRefAmp;
        #endregion 
        public Universal.Opera eOperacion;
        Masivo eMas = new Masivo();
        int eVaBD = 1;//0 : no , 1 : si
        string eNombreColumnaDgvCredOper = CreditsOperationsDto.DniSolic;
        public List<CreditsOperationsDto> eListCredOpe = new List<CreditsOperationsDto>();
        CreditsOperationsController oCrOpCtrll = new CreditsOperationsController();
        Dgv.Franja eFranjaDgvCredOpe = Dgv.Franja.PorIndice;
        public string eClaveDgvCredOpe = string.Empty;
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
            xCtrl.Btn(this.btnCancelar, "vvvv");
            xLis.Add(xCtrl);

            return xLis;
        }
        public void VentanaAdicionar()
        {
            this.InicializaVentana();
            eMas.AccionHabilitarControles(0);
            eMas.AccionPasarTextoPrincipal();
            this.txtDocId.Focus();
        }
        public void InicializaVentana()
        {
            //titulo ventana
            this.Text = this.eOperacion.ToString() + Cadena.Espacios(1) + this.wRefAmp.eTitulo;

            //eventos de controles
            eMas.lisCtrls = this.ListaCtrls();
            eMas.EjecutarTodosLosEventos();
            this.ActualizarVentana();
            // Deshabilitar al propietario
            this.wRefAmp.Enabled = false;

            // Mostrar ventana
            this.Show();
        }

        public List<DataGridViewColumn> ListarColumnasDgvCreOper()
        {
            //lista resultado
            List<DataGridViewColumn> iLisCreOpe = new List<DataGridViewColumn>();

            //agregando las columnas
            iLisCreOpe.Add(Dgv.NuevaColumnaCheckBox(CreditsOperationsDto.IdOper, "Ref./Amp.", 70));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xCortaTpOperac, "Tipo", 40));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xSer, "Ser", 50));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Nro, "Número", 60));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xDesProveedor, "Proveedor", 70));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.NameProduct, "Productos", 120));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Fec, "Fecha", 70));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsOperationsDto.Aproba, "Capital", 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsOperationsDto.xCredito, "Crédito", 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Pla, "Plazo", 50));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xInforme, "Informe", 50));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xAnio, "Año", 40));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xVoucher, "Voucher", 70));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xFeDesembolso, "Desembolsa", 70));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xEstado, "Condición", 70));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.IdOper, "IdOperacion", 40, false));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.DniSolic, "Dni_Solicitante", 40, false));

            //devolver
            return iLisCreOpe;
        }

        public void ActualizarListaCreditosOperacionesDeBaseDatos()
        {
            //validar si es acto ir a la bd
            if (this.txtDocId.Text.Trim() != string.Empty && eVaBD == 0) { return; }

            //ir a la bd
            CreditsOperationsDto iCreOpeEN = new CreditsOperationsDto();
            iCreOpeEN.DniSolicitante = this.txtDocId.Text.Trim();
            iCreOpeEN.Additionals.CampoOrden = eNombreColumnaDgvCredOper;
            this.eListCredOpe = oCrOpCtrll.TablaOperacDni(iCreOpeEN);
        }

        public void ActualizarVentana()
        {
            this.ActualizarListaCreditosOperacionesDeBaseDatos();
            this.ActualizarDgvCredOpe();
            //this.AccionBuscar();
        }

        public void ActualizarDgvCredOpe()
        {
            //asignar parametros
            DataGridView iGrilla = this.dgvRefAmp;
            List<CreditsOperationsDto> iFuenteDatos = this.ObtenerDatosParaGrilla();
            Dgv.Franja iCondicionFranja = eFranjaDgvCredOpe;
            string iClaveBusqueda = eClaveDgvCredOpe;
            string iColumnaPintura = eNombreColumnaDgvCredOper;
            List<DataGridViewColumn> iListaColumnas = this.ListarColumnasDgvCreOper();
            //ejecutar metodo
            Dgv.RefrescarGrilla(iGrilla, iFuenteDatos, iCondicionFranja, iClaveBusqueda, iColumnaPintura, iListaColumnas);

        }
        public List<CreditsOperationsDto> ObtenerDatosParaGrilla()
        {
            //asignar parametros
            string iValorBusqueda = this.txtDocId.Text.Trim();
            string iCampoBusqueda = eNombreColumnaDgvCredOper;
            List<CreditsOperationsDto> iListaSolicitudPedidoCabes = eListCredOpe;

            //ejecutar y retornar
            return oCrOpCtrll.ListarDatosParaGrillaPrincipal(iValorBusqueda, iCampoBusqueda, iListaSolicitudPedidoCabes);
        }
        public void AccionBuscar()
        {
            this.txtDocId.Text = "Ingrese " + this.eNombreColumnaDgvCredOper;
            this.txtDocId.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.dgvRefAmp.Rows.Count != 0) { eVaBD = 0; }
            this.ActualizarVentana();
            eVaBD = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditRefinanciadoAmpliado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.wRefAmp.Enabled = true;
        }
    }
}
