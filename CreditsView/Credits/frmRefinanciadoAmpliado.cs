using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsView.MdiPrincipal;
using CreditsView.Reports;
using System;
using System.Collections;
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
    public partial class frmRefinanciadoAmpliado : Form
    {
        Dgv.Franja eFranjaDgvRefAmp = Dgv.Franja.PorIndice;
        public string eClaveDgvRefAmp = string.Empty;
        string eNombreColumnaDgvRefAmp = CreditsOperationsDto.DniSolic;
        public string eTitulo = "Registro Refinanciado o Ampliación";
        int eVaBD = 1;//0 : no , 1 : si
        public List<CreditsOperationsDto> eLisRefAmp = new List<CreditsOperationsDto>();
        public CreditsOperationsController oOpe = new CreditsOperationsController();
        public CreditsRefinanciadoAmpliadoController oRefAmp = new CreditsRefinanciadoAmpliadoController();
        string eEncabezadoColumnaDgvRefAmp = "DNI";
        public frmRefinanciadoAmpliado()
        {
            InitializeComponent();
        }
        public void NewWindow()
        {
            this.Dock = DockStyle.Fill;
            this.Show();
            this.ActualizarVentana();
        }
        public void ActualizarVentana()
        {
            this.ActualizarListaRefinanciadoAmpliadoDeBaseDatos();
            this.ActualizarDgvRefAmp();
            Dgv.HabilitarDesplazadores(this.DgvRefiAmp, this.tsbPrimero, this.tsbAnterior, this.tsbSiguiente, this.tsbUltimo);
            Dgv.ActualizarBarraEstado(this.DgvRefiAmp, this.sst1);
            this.AccionBuscar();
        }

        public void AccionBuscar()
        {
            //this.tstBuscar.Clear();
            this.tstBuscar.ToolTipText = "Ingrese " + this.eEncabezadoColumnaDgvRefAmp;
            this.tstBuscar.Focus();
        }
        public void ActualizarListaRefinanciadoAmpliadoDeBaseDatos()
        {
            //validar si es acto ir a la bd
            if (tstBuscar.Text.Trim() != string.Empty && eVaBD == 0) { return; }

            //ir a la bd
            CreditsOperationsDto iOpEN = new CreditsOperationsDto();
            this.eLisRefAmp = CreditsOperationsController.ListarRefinanciadoAmpliadoPorDni(iOpEN);
        }
        public void ActualizarDgvRefAmp()
        {
            //asignar parametros
            DataGridView iGrilla = this.DgvRefiAmp;
            List<CreditsOperationsDto> iFuenteDatos = this.ObtenerDatosParaGrilla();
            Dgv.Franja iCondicionFranja = eFranjaDgvRefAmp;
            string iClaveBusqueda = eClaveDgvRefAmp;
            string iColumnaPintura = eNombreColumnaDgvRefAmp;
            List<DataGridViewColumn> iListaColumnas = this.ListarColumnasDgvCreOper();
            //ejecutar metodo
            Dgv.RefrescarGrilla(iGrilla, iFuenteDatos, iCondicionFranja, iClaveBusqueda, iColumnaPintura, iListaColumnas);
        }

        public List<CreditsOperationsDto> ObtenerDatosParaGrilla()
        {
            //asignar parametros
            string iValorBusqueda = tstBuscar.Text.Trim();
            string iCampoBusqueda = eNombreColumnaDgvRefAmp;
            List<CreditsOperationsDto> iListaSolicitudPedidoCabes = eLisRefAmp;

            //ejecutar y retornar
            return oOpe.ListarDatosParaGrillaPrincipal(iValorBusqueda, iCampoBusqueda, iListaSolicitudPedidoCabes);
        }

        public List<DataGridViewColumn> ListarColumnasDgvCreOper()
        {
            //lista resultado
            List<DataGridViewColumn> iLisCreOpe = new List<DataGridViewColumn>();

            //agregando las columnas
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
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xDesEstado, "Condición", 70));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xDesSubEstado, "Sub-Condición", 100));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.DniSolic, "Dni_Solicitante", 40, false));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.IdOper, "Id_Operacion", 40, false));

            //devolver
            return iLisCreOpe;
        }
        public void AccionAdicionar()
        {
            //DeclaracionesRegistroCompraDto iRegComDto = this.EsActoAdicionarRegistroCompra();
            //if (iRegComDto.Adicionales.EsVerdad == false) { return; }

            frmEditRefinanciadoAmpliado win = new frmEditRefinanciadoAmpliado();
            win.wRefAmp = this;
            win.eOperacion = Universal.Opera.Adicionar;
            this.eFranjaDgvRefAmp = Dgv.Franja.PorValor;
            TabCtrl.InsertarVentana(this, win);
            win.VentanaAdicionar();
        }

        public void AccionEliminar()
        {
            CreditsOperationsDto iOpeEN = this.EsActoEliminarRefiAmpli();
            //if (iRegComDto.Adicionales.EsVerdad == false) { return; }

            this.EliminarRefinanciamientoAmpliacion(iOpeEN);

            Mensaje.OperacionSatisfactoria("El registro fue eliminado.", this.eTitulo);
            this.ActualizarVentana();
        }
        public CreditsOperationsDto EsActoEliminarRefiAmpli()
        {
            CreditsOperationsDto iOpeEN = new CreditsOperationsDto();
            this.AsignarRefinanciamientoAmpliado(iOpeEN);
            return iOpeEN;
        }
        public void AsignarRefinanciamientoAmpliado(CreditsOperationsDto pOpe)
        {
            pOpe.Id_Operacion = Convert.ToInt32(Dgv.ObtenerValorCelda(this.DgvRefiAmp, CreditsOperationsDto.IdOper));
            pOpe.Dni_Solicitante = Dgv.ObtenerValorCelda(this.DgvRefiAmp, CreditsOperationsDto.DniSolic);
        }

        public void EliminarRefinanciamientoAmpliacion(CreditsOperationsDto iOpeEN)
        {
            CreditsRefinanciadoAmpliadoDto iRefAmpEN = new CreditsRefinanciadoAmpliadoDto();
            iRefAmpEN.IdOperacion = iOpeEN.Id_Operacion;
            oRefAmp.EliminarRefinanciadoAmpliado(iRefAmpEN);
        }

        public void AccionVisualizar()
        {
            CreditsOperationsDto iOpeEN = this.EsActoVisualizarRefiAmpli();
            //if (iRegComDto.Adicionales.EsVerdad == false) { return; }

            frmEditRefinanciadoAmpliado win = new frmEditRefinanciadoAmpliado();
            win.wRefAmp = this;
            win.eOperacion = Universal.Opera.Modificar;
            this.eFranjaDgvRefAmp = Dgv.Franja.PorValor;
            TabCtrl.InsertarVentana(this, win);
            win.VentanaVisualizar(iOpeEN);
        }

        public CreditsOperationsDto EsActoVisualizarRefiAmpli()
        {
            CreditsOperationsDto iOpeEN = new CreditsOperationsDto();
            this.AsignarRefinanciamientoAmpliado(iOpeEN);
            return iOpeEN;
        }


        public CreditsOperationsDto EsActoImprimirRefiAmpli()
        {
            CreditsOperationsDto iOpeEN = new CreditsOperationsDto();
            this.AsignarRefinanciamientoAmpliado(iOpeEN);
            return iOpeEN;
        }

        public void Cerrar()
        {
            frmPrincipal wMen = (frmPrincipal)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.btnRefiAmp, null);
        }

        public void OrdenarPorColumna(int pColumna)
        {
            this.eFranjaDgvRefAmp = Dgv.Franja.PorIndice;
            this.eNombreColumnaDgvRefAmp = this.DgvRefiAmp.Columns[pColumna].Name;
            this.eEncabezadoColumnaDgvRefAmp = this.DgvRefiAmp.Columns[pColumna].HeaderText;
            this.ActualizarVentana();
        }

        public void AccionImprimirRefinanciadoAmpliado()
        {
            CreditsOperationsDto iOpeEN = this.EsActoImprimirRefiAmpli();

            frmReportRefinanciadoAmpliado win = new frmReportRefinanciadoAmpliado();
            win.wRefAmp = this;
            TabCtrl.InsertarVentana(this, win);
            win.NuevaVentana(iOpeEN);

        }


        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRefinanciadoAmpliado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }
        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            this.AccionAdicionar();
        }

        private void tsbActualizarTabla_Click(object sender, EventArgs e)
        {
            this.eFranjaDgvRefAmp = Dgv.Franja.PorIndice;
            this.ActualizarVentana();
        }

        private void tsbPrimero_Click(object sender, EventArgs e)
        {
            Dgv.SeleccionarRegistroXDesplazamiento(this.DgvRefiAmp, Dgv.Desplazar.Primero);
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            Dgv.SeleccionarRegistroXDesplazamiento(this.DgvRefiAmp, Dgv.Desplazar.Anterior);
        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            Dgv.SeleccionarRegistroXDesplazamiento(this.DgvRefiAmp, Dgv.Desplazar.Siguiente);
        }

        private void tsbUltimo_Click(object sender, EventArgs e)
        {
            Dgv.SeleccionarRegistroXDesplazamiento(this.DgvRefiAmp, Dgv.Desplazar.Ultimo);
        }

        private void DgvRefiAmp_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.OrdenarPorColumna(e.ColumnIndex);
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            this.AccionImprimirRefinanciadoAmpliado();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            this.AccionEliminar();
        }

        private void tsbVisualizar_Click(object sender, EventArgs e)
        {
            this.AccionVisualizar();
        }
    }
}
