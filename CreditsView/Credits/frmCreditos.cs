using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsView.MdiPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControles.ControlesWindows;

namespace CreditsView.Credits
{
    public partial class frmCreditos : Form
    {
        Dgv.Franja eFranjaDgvCred = Dgv.Franja.PorIndice;
        public string eClaveDgvCre = string.Empty;
        CreditsSolicitanteController oSolCtrll = new CreditsSolicitanteController();
        CreditsOperationsController oOpeCtrll = new CreditsOperationsController();
        public List<CreditsOperationsDto> listOpeEN = new List<CreditsOperationsDto>();
        public CreditsOperationsController oOpe = new CreditsOperationsController();
        public string eTitulo = "Creditos";
        int eVaBD = 1;//0 : no , 1 : si
        string eNombreColumnaDgvRefAmp = CreditsOperationsDto.DniSolic;
        public frmCreditos()
        {
            InitializeComponent();
        }
        public void NewWindow()
        {
            this.Show();
        }
        public void ActualizarVentana()
        {
            this.DeshabilitarBotones();
            this.ActualizarListaSolicitantesDeBaseDatos();
            this.ActualizarListaOperacionesDeBaseDatos();
            this.ActualizarDgvCreditos();
        }
        public void ActualizarListaSolicitantesDeBaseDatos()
        {
            //validar si es acto ir a la bd
            if (this.txtDocId.Text.Trim() != string.Empty && eVaBD == 0) { return; }

            //ir a la bd
            CreditsSolicitantesDto iSolEN = new CreditsSolicitantesDto();
            iSolEN.Dni_Solic = this.txtDocId.Text.Trim();
            iSolEN = oSolCtrll.ListarSolicitantesPorDni(iSolEN);
            this.btnNuevoCredito.Enabled = iSolEN.Id_Solicitante > 0 ? true : false;
            this.AsignarSolicitantes(iSolEN);            
        }
        public void ActualizarListaOperacionesDeBaseDatos()
        {
            //validar si es acto ir a la bd
            if (this.txtDocId.Text.Trim() != string.Empty && eVaBD == 0) { return; }

            //ir a la bd
            CreditsOperationsDto iOpeEN = new CreditsOperationsDto();
            iOpeEN.Dni_Solicitante = this.txtDocId.Text.Trim();
            listOpeEN = CreditsOperationsController.TablaOperacDni(iOpeEN);
        }
        public void ActualizarDgvCreditos()
        {
            //asignar parametros
            DataGridView iGrilla = this.dgvCreditos;
            List<CreditsOperationsDto> iFuenteDatos = this.ObtenerDatosParaGrilla();
            Dgv.Franja iCondicionFranja = eFranjaDgvCred;
            string iClaveBusqueda = eClaveDgvCre;
            string iColumnaPintura = eNombreColumnaDgvRefAmp;
            List<DataGridViewColumn> iListaColumnas = this.ListarColumnasDgvCreOper();
            //ejecutar metodo
            Dgv.RefrescarGrilla(iGrilla, iFuenteDatos, iCondicionFranja, iClaveBusqueda, iColumnaPintura, iListaColumnas);
        }
        public List<CreditsOperationsDto> ObtenerDatosParaGrilla()
        {
            //asignar parametros
            string iValorBusqueda = txtDocId.Text.Trim();
            string iCampoBusqueda = eNombreColumnaDgvRefAmp;
            List<CreditsOperationsDto> iListaSolicitudPedidoCabes = listOpeEN;

            //ejecutar y retornar
            return oOpe.ListarDatosParaGrillaPrincipal(iValorBusqueda, iCampoBusqueda, iListaSolicitudPedidoCabes);
        }
        public void AsignarSolicitantes(CreditsSolicitantesDto iSolEN)
        {
            this.txtApeNom.Text = iSolEN.Paterno.Trim() + " " + iSolEN.Materno.Trim() + ", " + iSolEN.Nombres.Trim();
            this.txtGrado.Text = iSolEN.DesGrado.Trim();
        }
        public List<DataGridViewColumn> ListarColumnasDgvCreOper()
        {
            //lista resultado
            List<DataGridViewColumn> iLisCreOpe = new List<DataGridViewColumn>();

            //agregando las columnas
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xCortaTpOperac, "Tip.", 25));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xSer, "Ser", 35));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Nro, "Número", 60));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xDesProveedor, "Proveedor", 70));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.NameProduct, "Productos", 120));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Fec, "Fecha", 70));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsOperationsDto.Aproba, "Capital", 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsOperationsDto.xCredito, "Crédito", 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Pla, "Plazo", 40));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xInforme, "Informe", 50));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xAnio, "Año", 35));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xDesEstado, "Condición", 70));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xDesSubEstado, "Sub-Condición", 100));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.DniSolic, "Dni_Solicitante", 40, false));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.IdOper, "Id_Operacion", 40, false));

            //devolver
            return iLisCreOpe;
        }
        public void Cerrar()
        {
            frmPrincipal wMen = (frmPrincipal)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.tsmCreditos, wMen.tsbCreditos);
        }
        public void ValidarEstadoCuenta(int pFilaChequeada, int pColumnaChequeada)
        {
            //solo debe actuar cuando la columna sea "0" y la fila diferente de "-1"
            if (pColumnaChequeada == 0 && pFilaChequeada != -1)
            {
                CreditsOperationsDto iCredEN = new CreditsOperationsDto();
                iCredEN.Id_Operacion = Convert.ToInt32(Dgv.ObtenerValorCelda(this.dgvCreditos, CreditsOperationsDto.IdOper));
                List<decimal> montos = CreditsOperationsController.ValidarEstadoDeCuenta(iCredEN);
                this.ValidaMontoActivaBotones(montos);
            }
        }
        public void ValidaMontoActivaBotones(List<decimal> montos)
        {
            this.DeshabilitarBotones();
            this.btnNuevoCredito.Enabled = true;
            if (montos.Count > 0)
            {
                if (montos[2] == 0)
                {
                    this.btnCobrar.Enabled = true;
                    this.btnAmpliar.Enabled = true;
                }
                if (montos[2] > 0)
                {
                    this.btnCobrar.Enabled = true;
                    this.btnRefinanciar.Enabled = true;
                }
            }
        }
        public void DeshabilitarBotones()
        {
            this.btnNuevoCredito.Enabled = false;
            this.btnCobrar.Enabled = false;
            this.btnAmpliar.Enabled = false;
            this.btnRefinanciar.Enabled = false;
        }
        public void AccionAdicionar()
        {
            //DeclaracionesRegistroCompraDto iRegComDto = this.EsActoAdicionarRegistroCompra();
            //if (iRegComDto.Adicionales.EsVerdad == false) { return; }

            frmEditCredito win = new frmEditCredito();
            win.wCre = this;
            win.eOperacion = Universal.Opera.Adicionar;
            this.eFranjaDgvCred = Dgv.Franja.PorValor;
            TabCtrl.InsertarVentana(this, win);
            win.VentanaAdicionar();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.ActualizarVentana();
            eVaBD = 1;
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreditos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }

        private void txtDocId_Validating(object sender, CancelEventArgs e)
        {
            this.ActualizarVentana();
            eVaBD = 1;
        }

        private void dgvCreditos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ValidarEstadoCuenta(e.RowIndex, e.ColumnIndex);
        }

        private void btnNuevoCredito_Click(object sender, EventArgs e)
        {
            this.AccionAdicionar();
        }
    }
}
