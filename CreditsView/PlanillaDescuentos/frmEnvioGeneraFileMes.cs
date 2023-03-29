using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsUtil.Enum;
using CreditsUtil.Util;
using CreditsView.MdiPrincipal;
using DeclaracionesUtil.Util;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WinControles;
using WinControles.ControlesWindows;

namespace CreditsView.PlanillaDescuentos
{
    public partial class frmEnvioGeneraFileMes : Form
    {
        CreditsGeneralController oGeneralController = new CreditsGeneralController();
        CreditsProcesoEnvioController oProcesoEnvioController = new CreditsProcesoEnvioController();
        CreditsPagosController oPagosController = new CreditsPagosController();
        List<CreditsPagosDto> eListPagos = new List<CreditsPagosDto>();
        CreditsEnvioDirrehumController oEnvioDirrehumController = new CreditsEnvioDirrehumController();
        CreditsEnvioCajaController oEnvioCajaController = new CreditsEnvioCajaController();
        string eNombreColumnaDgvEnvio = CreditsPagosDto.xDni;
        public int _uniDscto = 0;
        Dgv.Franja eFranjaDgvCred = Dgv.Franja.PorIndice;
        public string eClaveDgvPago = string.Empty;
        int eVaBD = 1;//0 : no , 1 : si
        public frmEnvioGeneraFileMes()
        {
            InitializeComponent();
        }
        public void NewWindow(int uniDscto)
        {
            //this.Dock = DockStyle.Fill;
            this._uniDscto = uniDscto;
            this.CargarMeses();
            this.txtAnio.Text = DateTime.Now.Year.ToString();
            this.cmbMes.SelectedIndex = DateTime.Now.Month - 1;
            this.NombreArchivo();
            this.CargarTope();
            this.CargarMora();
            this.CargarIgv();
            this.txtComision.Text = "0";
            this.Show();
        }

        public void NombreArchivo()
        {
            string mes = Cmb.ObtenerTexto(this.cmbMes);
            string nombreArchivo = DateTime.Today.Year.ToString() + string.Format("00", DateTime.Today.Month) + string.Format("00", DateTime.Today.Day) + "-H13280000" + mes + txtAnio.Text + ".TXT";
            this.txtNombreArchivo.Text = nombreArchivo;
        }

        public void CargarMeses()
        {
            Cmb.Cargar(this.cmbMes, this.oGeneralController.ListarMeses(), CreditsMesesDto.xIdMes, CreditsMesesDto.xDesMes);
        }

        public void CargarMora()
        {
            this.txtIntMora.Text = this.oGeneralController.ListarMora().FirstOrDefault().PorcentMora.ToString();
        }

        public void CargarIgv()
        {
            this.txtIgv.Text = this.oGeneralController.ListarIgv().FirstOrDefault().De_Igv.ToString();
        }

        public void CargarTope()
        {
            this.cmbTope.Items.AddRange(new object[5]
            {
                (object) "",
                (object) "Cuota y media",
                (object) "Dos cuotas",
                (object) "Tres cuotas",
                (object) "Sin tope (Toda la morosidad)"
            });
        }

        public void UbicacionArchivo()
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                this.txtUbicacion.Text = dlg.SelectedPath;
            }
        }

        public void cambiarCheckedReprogramar()
        {
            this.cbAplicarInteres.Checked = !this.cbAplicarInteres.Checked;
            this.cbAplicarInteres.Enabled = !this.cbAplicarInteres.Enabled;
            this.cmbTope.Enabled = !this.cmbTope.Enabled;
            if (this.cbReprogramarMora.Checked)
                this.cmbTope.SelectedIndex = 1;
            else
                this.cmbTope.SelectedIndex = 0;
        }

        public bool ValidarDatosParaGenerarFile()
        {
            bool valid = false;
            if (Decimal.Compare(Convert.ToDecimal(this.txtAnio.Text), 0) == 0)
                valid = true;

            if (String.Compare(Cmb.ObtenerTexto(this.cmbMes), "") == 0)
                valid = true;

            if (String.Compare(this.txtUbicacion.Text.Trim(), "") == 0)
                valid = true;

            return valid;
        }

        public bool ValidarDatosParaGenerarFileChecked()
        {
            bool valid = false;
            if (this.cbReprogramarMora.Checked && this.cmbTope.SelectedIndex < 1)
                valid = true;

            return valid;
        }

        public void ProcesoEjecutarSegunUnidadDescuento()
        {
            CreditsProcesoEnvioDto creditsProcesoEnvioDto = new CreditsProcesoEnvioDto();
            CreditsPagosDto creditsPagosDto = new CreditsPagosDto();
            this.AsignarProcesoEnvioDto(creditsProcesoEnvioDto);
            this.AsignarLimpiarImpagos(creditsPagosDto);
            switch (this._uniDscto)
            {
                case (int)CreditsEnum.UndDscto.DirrehumHaberes:
                    if (Mensaje.DeseasRealizarOperacion("Confirmar. Proceso Envio de Cobranza DIRECFIN Planillas", "Envio DIRECFIN Planillas"))
                    {
                        this.oProcesoEnvioController.InsertarProcesoEnvio(creditsProcesoEnvioDto);
                        this.oPagosController.ActualizaMesAnioImpago(creditsPagosDto);
                        if (this.cbReprogramarMora.Checked)
                            this.ReprogramarImpagos();
                        this.LlenaGrid();
                    }
                    break;
                case (int)CreditsEnum.UndDscto.CajaPensionesCPMP:
                    if (Mensaje.DeseasRealizarOperacion("Confirmar. Proceso Envio de Cobranza Caja de Pensiones CPMP", "Envio Caja de Pensiones CPMP"))
                    {
                        this.oProcesoEnvioController.InsertarProcesoEnvio(creditsProcesoEnvioDto);
                        this.oPagosController.ActualizaMesAnioImpago(creditsPagosDto);
                        if (this.cbReprogramarMora.Checked)
                            this.ReprogramarImpagos();
                        this.LlenaGrid();
                    }
                    break;
            }
        }

        public void AsignarProcesoEnvioDto(CreditsProcesoEnvioDto creditsProcesoEnvioDto)
        {
            creditsProcesoEnvioDto.Mes = Convert.ToInt32(Cmb.ObtenerValor(this.cmbMes));
            creditsProcesoEnvioDto.Anio = Convert.ToInt32(this.txtAnio.Text);
            creditsProcesoEnvioDto.UnidDscto = this._uniDscto;
            creditsProcesoEnvioDto.Fecha = DateTime.Now;
        }

        public void AsignarLimpiarImpagos(CreditsPagosDto creditsPagosDto)
        {
            creditsPagosDto.CreditsOperationsDto = new CreditsOperationsDto();
            creditsPagosDto.Mes = Convert.ToInt32(Cmb.ObtenerValor(this.cmbMes));
            creditsPagosDto.Anio = Convert.ToInt32(this.txtAnio.Text);
            creditsPagosDto.CreditsOperationsDto.UnidDscto = this._uniDscto;
        }
        public void AsignarPagosReprogramarImpagos(CreditsPagosDto eRastreaDeudasImpagas)
        {
            eRastreaDeudasImpagas.CreditsOperationsDto = new CreditsOperationsDto();
            eRastreaDeudasImpagas.Interes = !this.cbAplicarInteres.Checked ? 0 : Convert.ToDecimal(this.txtIntMora.Text);
            eRastreaDeudasImpagas.Igv = Convert.ToDecimal(this.txtIgv.Text);
            eRastreaDeudasImpagas.Periodo = this.txtAnio.Text.PadLeft(4, '0') + Cmb.ObtenerValor(this.cmbMes).PadLeft(2, '0') + "01";
            eRastreaDeudasImpagas.CreditsOperationsDto.UnidDscto = this._uniDscto;
        }
        public void ReprogramarImpagos()
        {
            CreditsPagosDto eRastreaDeudasImpagas = new CreditsPagosDto();
            this.AsignarPagosReprogramarImpagos(eRastreaDeudasImpagas);
            List<CreditsPagosDto> lRastreaDeudasImpagas = this.oPagosController.RastreaDeudasImpagas(eRastreaDeudasImpagas);
            if (lRastreaDeudasImpagas.Count < 1)
                return;
            foreach (CreditsPagosDto pagos in lRastreaDeudasImpagas)
            {
                this.oPagosController.ProcesoReprogramaPagosMesAnioImpago(pagos);
            }
        }

        public void LlenaGrid()
        {
            this.ActualizarGeneraFilesDeBaseDatos();
            this.ActualizarDgvPagos();
        }

        public void AsignarEnvioMesAnioIdOperacion(CreditsPagosDto eEnvioMesAnioIdOperacion)
        {
            eEnvioMesAnioIdOperacion.CreditsOperationsDto = new CreditsOperationsDto();
            eEnvioMesAnioIdOperacion.Mes = Convert.ToInt32(Cmb.ObtenerValor(this.cmbMes, string.Empty));
            eEnvioMesAnioIdOperacion.Anio = Convert.ToInt32(this.txtAnio.Text);
            eEnvioMesAnioIdOperacion.CreditsOperationsDto.UnidDscto = this._uniDscto;
            eEnvioMesAnioIdOperacion.selTope = this.cmbTope.SelectedIndex;
        }

        public void ActualizarGeneraFilesDeBaseDatos()
        {
            //validar si es acto ir a la bd
            if (this.txtDni.Text.Trim() != string.Empty && eVaBD == 0) { return; }
            CreditsPagosDto eEnvioMesAnioIdOperacion = new CreditsPagosDto();
            this.AsignarEnvioMesAnioIdOperacion(eEnvioMesAnioIdOperacion);
            //ir a la bd
            this.eListPagos = CreditsPagosController.EnvioMesAnioIdOperacion(eEnvioMesAnioIdOperacion);
            this.lblProgress.Text = this.eListPagos.Count().ToString() + " - Registros";
        }

        public void ActualizarDgvPagos()
        {
            //asignar parametros
            DataGridView iGrilla = this.dgvDirrehumEnvio;
            List<CreditsPagosDto> iFuenteDatos = this.ObtenerDatosParaGrilla();
            Dgv.Franja iCondicionFranja = eFranjaDgvCred;
            string iClaveBusqueda = eClaveDgvPago;
            string iColumnaPintura = eNombreColumnaDgvEnvio;
            List<DataGridViewColumn> iListaColumnas = this.ListarColumnasDgvPagos();
            //ejecutar metodo
            Dgv.RefrescarGrilla(iGrilla, iFuenteDatos, iCondicionFranja, iClaveBusqueda, iColumnaPintura, iListaColumnas);
        }
        public List<CreditsPagosDto> ObtenerDatosParaGrilla()
        {
            //asignar parametros
            string iValorBusqueda = string.Empty;
            string iCampoBusqueda = eNombreColumnaDgvEnvio;
            List<CreditsPagosDto> iListaPagos = this.eListPagos;

            //ejecutar y retornar
            return oPagosController.ListarDatosParaGrillaPrincipal(iValorBusqueda, iCampoBusqueda, iListaPagos);
        }

        public List<DataGridViewColumn> ListarColumnasDgvPagos()
        {
            //lista resultado
            List<DataGridViewColumn> iLisCrePag = new List<DataGridViewColumn>();

            //agregando las columnas
            iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xFecha, "FECHA", 70));
            iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xCODOFIN, "CODOFIN", 90));
            iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xDni, "DNI", 70));
            iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xDni_Ser_Numero, "DNI_SER_NUMERO", 120));
            iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xGrado, "GRADO", 90));
            iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xNOMBRE, "SOLICITANTE", 150));
            iLisCrePag.Add(Dgv.NuevaColumnaTextNumerico(CreditsPagosDto.xResultado, "RESULTADO", 60, 2));
            iLisCrePag.Add(Dgv.NuevaColumnaTextNumerico(CreditsPagosDto.xEnvio, "ENVIO", 60, 2));
            iLisCrePag.Add(Dgv.NuevaColumnaTextNumerico(CreditsPagosDto.xInicia, "INICIA", 60, 2));
            iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xIdOperacion, "Id_Operacion", 40, false));

            //devolver
            return iLisCrePag;
        }

        public void ValidaExisteDirrehumCaja()
        {
            if (this.eListPagos.Count < 1) return;

            UtilDirectorio.CrearCarpeta(this.txtUbicacion.Text);
            UtilDirectorio.ExisteArchivo(this.txtUbicacion.Text + @"\\" + this.txtNombreArchivo.Text);
            if (this._uniDscto == 1)
            {
                CreditsEnvioDirrehumDto eEnvioDirrehum = new CreditsEnvioDirrehumDto();
                eEnvioDirrehum.Anio = Convert.ToInt32(this.txtAnio.Text);
                eEnvioDirrehum.Mes = Convert.ToInt32(Cmb.ObtenerValor(this.cmbMes));
                this.oEnvioDirrehumController.EliminaEnvioDirrehum(eEnvioDirrehum);
            }
            else if (this._uniDscto == 2)
            {
                CreditsEnvioCajaDto eEnvioCaja = new CreditsEnvioCajaDto();
                eEnvioCaja.Anio = Convert.ToInt32(this.txtAnio.Text);
                eEnvioCaja.Mes = Convert.ToInt32(Cmb.ObtenerValor(this.cmbMes));
                this.oEnvioCajaController.EliminaEnvioCaja(eEnvioCaja);
            }
            this.GeneraTxt();
        }

        public void GeneraTxt()
        {
            int fila = 0;
            string strCodofin = string.Empty;
            decimal envio = 0;
            foreach (CreditsPagosDto pagos in this.eListPagos)
            {
                switch (this._uniDscto)
                {
                    case (int)CreditsEnum.UndDscto.DirrehumHaberes:
                        if (fila == 0)
                        {
                            strCodofin = pagos.CodoFin != null && pagos.CodoFin != string.Empty ? pagos.CodoFin : "0";
                            envio = pagos.Envio != null & pagos.Envio.ToString() != string.Empty ? pagos.Envio : 0;
                            break;
                        }
                        break;
                }
                fila++;
            }
        }

        public void Cerrar()
        {
            frmPrincipal wMen = (frmPrincipal)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.tsmDirrehumHaberesEnvioGeneraFile, null);
        }
        private void cmbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.NombreArchivo();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            this.UbicacionArchivo();
        }

        private void cbReprogramarMora_CheckedChanged(object sender, EventArgs e)
        {
            this.cambiarCheckedReprogramar();
        }

        private void tsBtnProcesar_Click(object sender, EventArgs e)
        {
            if (this.ValidarDatosParaGenerarFile())
                Mensaje.OperacionDenegada("Faltan completar datos.", "Generar Envio");

            if (this.ValidarDatosParaGenerarFileChecked())
                Mensaje.OperacionDenegada("Debes indicar cual es el tope de cobranza!...", "Reprogramación de Moras");

            this.ProcesoEjecutarSegunUnidadDescuento();

        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEnvioGeneraFileMes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }
    }
}
