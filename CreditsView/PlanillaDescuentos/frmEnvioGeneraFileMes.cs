using Comun;
using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsUtil.Enum;
using CreditsUtil.Util;
using CreditsView.MdiPrincipal;
using DeclaracionesUtil.Util;
using Microsoft.Office.Interop.Excel;
using Convertir = Microsoft.VisualBasic.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WinControles;
using WinControles.ControlesWindows;
using Microsoft.VisualBasic;
using static CreditsUtil.Enum.CreditsEnum;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.CompilerServices;

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
            this.TituloEnvio();
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
        public void TituloEnvio()
        {
            switch (this._uniDscto)
            {
                case (int)CreditsEnum.UndDscto.DirrehumHaberes:
                    this.lblTituloEnvio.Text = "Envio DIRREHUM Planillas";
                    break;
                case (int)CreditsEnum.UndDscto.CajaPensionesCPMP:
                    this.lblTituloEnvio.Text = "Envio Caja de Pensiones CPMP";
                    break;
                case (int)CreditsEnum.UndDscto.DirrehumCombustible:
                    this.lblTituloEnvio.Text = "Envio DIRREHUM Combustible";
                    break;
                case 8:
                    this.lblTituloEnvio.Text = "Envio Planilla Empleados FONBIEPOL";
                    break;
            }
        }
        public void NombreArchivo()
        {
            string nombre = string.Empty;
            switch (this._uniDscto)
            {
                case (int)CreditsEnum.UndDscto.DirrehumHaberes:
                    nombre = "-H13280000";
                    break;
                case (int)CreditsEnum.UndDscto.DirrehumCombustible:
                    nombre = "-G13280000";
                    break;
                case (int)CreditsEnum.UndDscto.CajaPensionesCPMP:
                    nombre = "-CAJA";
                    break;
            }
            string mes = Cmb.ObtenerTexto(this.cmbMes);
            string nombreArchivo = DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString().PadLeft(2, '0') + DateTime.Today.Day.ToString().PadLeft(2, '0') + nombre + mes + txtAnio.Text + ".TXT";
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
                        this.ValidaExisteRutaEnvio();
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
                        this.ValidaExisteRutaEnvio();
                    }
                    break;
                case (int)CreditsEnum.UndDscto.DirrehumCombustible:
                    if (Mensaje.DeseasRealizarOperacion("Confirmar. Proceso Envio de Cobranza DIRECFIN Combustible", "Envio DIRECFIN Combustible"))
                    {
                        this.oProcesoEnvioController.InsertarProcesoEnvio(creditsProcesoEnvioDto);
                        this.oPagosController.ActualizaMesAnioImpago(creditsPagosDto);
                        if (this.cbReprogramarMora.Checked)
                            this.ReprogramarImpagos();
                        this.LlenaGrid();
                        this.ValidaExisteRutaEnvio();
                    }
                    break;

            }
            Mensaje.OperacionSatisfactoria("El Proceso ha culminado exitosamente!", "Archivo de ENVIO generado");
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
            eRastreaDeudasImpagas.Periodo = Convert.ToInt32(this.txtAnio.Text.PadLeft(4, '0') + Cmb.ObtenerValor(this.cmbMes).PadLeft(2, '0') + "01");
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
                pagos.Anio = Convert.ToInt32(this.txtAnio.Text);
                pagos.Mes = Convert.ToInt32(Cmb.ObtenerValor(this.cmbMes));
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
            eEnvioMesAnioIdOperacion.Mes = Convert.ToInt32(Cmb.ObtenerValor(this.cmbMes));
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
            if (this._uniDscto == (int)CreditsEnum.UndDscto.DirrehumCombustible || this._uniDscto == (int)CreditsEnum.UndDscto.DirrehumHaberes)
                this.eListPagos = CreditsPagosController.EnvioMesAnioIdOperacion(eEnvioMesAnioIdOperacion);
            else
                this.eListPagos = CreditsPagosController.EnvioMesAnioIdOperacionCaja(eEnvioMesAnioIdOperacion);
            this.lblProgress.Text = this.eListPagos.Count().ToString() + " - Registros";
        }

        public void ActualizarDgvPagos()
        {
            //asignar parametros
            DataGridView iGrilla = this.dgvDirrehumEnvio;
            List<CreditsPagosDto> iFuenteDatos = this.ObtenerDatosParaGrilla();
            Dgv.Franja iCondicionFranja = eFranjaDgvCred;
            string iClaveBusqueda = eClaveDgvPago;
            string iColumnaPintura = this._uniDscto == (int)CreditsEnum.UndDscto.DirrehumHaberes || this._uniDscto == (int)CreditsEnum.UndDscto.DirrehumCombustible ? eNombreColumnaDgvEnvio : CreditsPagosDto.xNRODNI;
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
            if (this._uniDscto == (int)CreditsEnum.UndDscto.DirrehumCombustible || this._uniDscto == (int)CreditsEnum.UndDscto.DirrehumHaberes)
            {
                iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xCODOFIN, "CODOFIN", 90));
                iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xDni, "DNI", 70));
                iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xDni_Ser_Numero, "DNI_SER_NUMERO", 120));
                iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xGrado, "GRADO", 90));
                iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xNOMBRE, "SOLICITANTE", 170));
            }
            else
            {
                iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xCIP, "CIP", 90));
                iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xNRODNI, "NRODNI", 70));
                iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xDni_Ser_Numero, "DNI_SER_NUMERO", 120));
                iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xAPENOM, "SOLICITANTE", 170));
            }

            iLisCrePag.Add(Dgv.NuevaColumnaTextNumerico(CreditsPagosDto.xResultado, "RESULTADO", 80, 2));
            iLisCrePag.Add(Dgv.NuevaColumnaTextNumerico(CreditsPagosDto.xEnvio, "ENVIO", 60, 2));
            iLisCrePag.Add(Dgv.NuevaColumnaTextNumerico(CreditsPagosDto.xInicia, "INICIA", 60, 2));
            iLisCrePag.Add(Dgv.NuevaColumnaTextCadena(CreditsPagosDto.xIdOperacion, "Id_Operacion", 40, false));

            //devolver
            return iLisCrePag;
        }

        public void ValidaExisteRutaEnvio()
        {
            if (this.eListPagos.Count < 1) return;


            UtilDirectorio.CrearCarpeta(this.txtUbicacion.Text);
            UtilDirectorio.ExisteArchivo(this.txtUbicacion.Text + @"\\" + this.txtNombreArchivo.Text);
            string txt = this.txtUbicacion.Text + @"\\" + this.txtNombreArchivo.Text;
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
            this.GeneraTxt(txt);
        }

        public void GeneraTxt(string txt)
        {
            int fila = 0;
            string strCodofin = string.Empty, strQuery = string.Empty, strCip = string.Empty, nroBen = string.Empty, nroDni = string.Empty;
            decimal envio = 0;
            StreamWriter writer = new StreamWriter(txt);
            foreach (CreditsPagosDto pagos in this.eListPagos)
            {
                switch (this._uniDscto)
                {
                    case (int)CreditsEnum.UndDscto.DirrehumHaberes:
                        if (fila == 0)
                        {
                            strCodofin = pagos.CodoFin != null && pagos.CodoFin != string.Empty ? pagos.CodoFin : "0";
                            envio = pagos.Envio != null && pagos.Envio.ToString() != string.Empty ? pagos.Envio : 0;
                            break;
                        }
                        if (pagos.CodoFin != null && pagos.CodoFin != string.Empty)
                        {
                            if (strCodofin == pagos.CodoFin)
                            {
                                envio = pagos.Envio != null && pagos.Envio.ToString() != string.Empty ? envio + pagos.Envio : 0;
                                if (fila == checked(this.eListPagos.Count - 1) && strCodofin != "0")
                                {
                                    writer.WriteLine(Convertir.Val(strCodofin).ToString().PadLeft(9, '0') + "13280000" + Convertir.Val((object)Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(12, '0') + Convertir.Val(Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(24, '0') + "00-00-0000");
                                    strQuery += " INSERT INTO Tb_EnvioDirrehum ( Anio, Mes, Codofin, Cod, Importe12, Importe24 ) ";
                                    strQuery += " VALUES  ( " + this.txtAnio.Text + ", " + Cmb.ObtenerValor(this.cmbMes) + ", '" + strCodofin + "', '13280000', '" + Convertir.Val((object)Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(12, '0') + "', '" + Convertir.Val(Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(24, '0') + "' )";
                                }
                            }
                            else
                            {
                                if (strCodofin != "0")
                                {
                                    writer.WriteLine(Convertir.Val(strCodofin).ToString().PadLeft(9, '0') + "13280000" + Convertir.Val((object)Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(12, '0') + Convertir.Val(Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(24, '0') + "00-00-0000");
                                    strQuery += " INSERT INTO Tb_EnvioDirrehum ( Anio, Mes, Codofin, Cod, Importe12, Importe24 ) ";
                                    strQuery += " VALUES  ( " + this.txtAnio.Text + ", " + Cmb.ObtenerValor(this.cmbMes) + ", '" + strCodofin + "', '13280000', '" + Convertir.Val((object)Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(12, '0') + "', '" + Convertir.Val(Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(24, '0') + "' )";
                                }
                                strCodofin = pagos.CodoFin != null && pagos.CodoFin != string.Empty ? pagos.CodoFin : "0";
                                envio = pagos.Envio != null && pagos.Envio.ToString() != string.Empty ? pagos.Envio : 0;
                                if (fila == checked(this.eListPagos.Count - 1) && strCodofin != "0")
                                {
                                    writer.WriteLine(Convertir.Val(strCodofin).ToString().PadLeft(9, '0') + "13280000" + Convertir.Val((object)Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(12, '0') + Convertir.Val(Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(24, '0') + "00-00-0000");
                                    strQuery += " INSERT INTO Tb_EnvioDirrehum ( Anio, Mes, Codofin, Cod, Importe12, Importe24 ) ";
                                    strQuery += " VALUES  ( " + this.txtAnio.Text + ", " + Cmb.ObtenerValor(this.cmbMes) + ", '" + strCodofin + "', '13280000', '" + Convertir.Val((object)Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(12, '0') + "', '" + Convertir.Val(Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(24, '0') + "' )";
                                }
                            }
                        }
                        break;
                    case (int)CreditsEnum.UndDscto.DirrehumCombustible:
                        if (fila == 0)
                        {
                            strCodofin = pagos.CodoFin != null && pagos.CodoFin != string.Empty ? pagos.CodoFin : "0";
                            envio = pagos.Envio != null && pagos.Envio.ToString() != string.Empty ? pagos.Envio : 0;
                            break;
                        }
                        if (pagos.CodoFin != null && pagos.CodoFin != string.Empty)
                        {
                            if (strCodofin == pagos.CodoFin)
                            {
                                envio = pagos.Envio != null && pagos.Envio.ToString() != string.Empty ? envio + pagos.Envio : 0;
                                if (fila == checked(this.eListPagos.Count - 1) && strCodofin != "0")
                                    writer.WriteLine(Convertir.Val(strCodofin).ToString().PadLeft(9, '0') + "13280000" + Convertir.Val((object)Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(12, '0') + Convertir.Val(Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(24, '0') + "00-00-0000");
                            }
                            else
                            {
                                if (strCodofin != "0")
                                    writer.WriteLine(Convertir.Val(strCodofin).ToString().PadLeft(9, '0') + "13280000" + Convertir.Val((object)Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(12, '0') + Convertir.Val(Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(24, '0') + "00-00-0000");
                                strCodofin = pagos.CodoFin != null && pagos.CodoFin != string.Empty ? pagos.CodoFin : "0";
                                envio = pagos.Envio != null && pagos.Envio.ToString() != string.Empty ? pagos.Envio : 0;
                                if (fila == checked(this.eListPagos.Count - 1) && strCodofin != "0")
                                    writer.WriteLine(Convertir.Val(strCodofin).ToString().PadLeft(9, '0') + "13280000" + Convertir.Val((object)Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(12, '0') + Convertir.Val(Convertir.Str((object)((Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)) * 100.0))).ToString().PadLeft(24, '0') + "00-00-0000");
                            }
                        }
                        break;
                    case (int)CreditsEnum.UndDscto.CajaPensionesCPMP:
                        if (fila == 0)
                        {
                            strCip = pagos.Cip != null && pagos.Cip != string.Empty ? pagos.Cip : "0";
                            nroBen = pagos.NroBen != null && pagos.NroBen != string.Empty ? pagos.NroBen : "0";
                            nroDni = pagos.NroDni != null && pagos.NroDni != string.Empty ? pagos.NroDni : "0";
                            envio = pagos.Envio != null && pagos.Envio.ToString() != string.Empty ? pagos.Envio : 0;
                            break;
                        }
                        double subEnvio;
                        if (pagos.NroDni != null && pagos.NroDni != string.Empty)
                        {
                            if (nroDni == pagos.NroDni)
                            {
                                envio = pagos.Envio != null && pagos.Envio.ToString() != string.Empty ? envio + pagos.Envio : 0;
                                if (fila == checked(this.eListPagos.Count - 1) && strCodofin != "0")
                                {
                                    subEnvio = Convert.ToDouble(Decimal.Subtract(envio, Microsoft.VisualBasic.Conversion.Int(envio)));
                                    writer.WriteLine("01131328800" + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(Strings.Mid(strCip, 3, 8)), "00000000") + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(nroBen), "00") + "LE" + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(nroDni), "00000000") + "  " + Convert.ToString(this.txtAnio.Text) + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(Microsoft.VisualBasic.Conversion.Str(Cmb.ObtenerValor(this.cmbMes))), "00") + Strings.Format((object)(Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)), "0000##0.#0"));
                                }
                                strQuery += " INSERT INTO Tb_EnvioCaja ( Anio, Mes, Cod, Cip, Ben, LE, Dni, AnioMes, Importe ) ";
                                strQuery += " VALUES  ( " + this.txtAnio.Text + ", " + Cmb.ObtenerValor(this.cmbMes) + ", '01131328800', '" + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(Strings.Mid(strCip, 3, 8)), "00000000") + "', '" + nroBen.PadLeft(2, '0') + "', 'LE',  '" + nroDni.PadLeft(8, '0') + "', '" + Convert.ToString(this.txtAnio.Text) + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(Microsoft.VisualBasic.Conversion.Str(Cmb.ObtenerValor(this.cmbMes))), "00") + "', '" + Strings.Format((object)(Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)), "0000##0.#0") + "' )";
                            }
                            else
                            {
                                if (nroDni != "0")
                                {
                                    subEnvio = Convert.ToDouble(Decimal.Subtract(envio, Microsoft.VisualBasic.Conversion.Int(envio)));
                                    writer.WriteLine("01131328800" + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(Strings.Mid(strCip, 3, 8)), "00000000") + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(nroBen), "00") + "LE" + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(nroDni), "00000000") + "  " + Convert.ToString(this.txtAnio.Text) + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(Microsoft.VisualBasic.Conversion.Str(Cmb.ObtenerValor(this.cmbMes))), "00") + Strings.Format((object)(Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)), "0000##0.#0"));
                                    strQuery += " INSERT INTO Tb_EnvioCaja ( Anio, Mes, Cod, Cip, Ben, LE, Dni, AnioMes, Importe ) ";
                                    strQuery += " VALUES  ( " + this.txtAnio.Text + ", " + Cmb.ObtenerValor(this.cmbMes) + ", '01131328800', '" + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(Strings.Mid(strCip, 3, 8)), "00000000") + "','" + nroBen.PadLeft(2, '0') + "', 'LE',  '" + nroDni.PadLeft(8, '0') + "', '" + Convert.ToString(this.txtAnio.Text) + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(Microsoft.VisualBasic.Conversion.Str(Cmb.ObtenerValor(this.cmbMes))), "00") + "', '" + Strings.Format((object)(Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)), "0000##0.#0") + "' )";
                                }
                                strCip = pagos.Cip != null && pagos.Cip != string.Empty ? pagos.Cip : "0";
                                nroBen = pagos.NroBen != null && pagos.NroBen != string.Empty ? pagos.NroBen : "0";
                                nroDni = pagos.NroDni != null && pagos.NroDni != string.Empty ? pagos.NroDni : "0";
                                envio = pagos.Envio != null && pagos.Envio.ToString() != string.Empty ? pagos.Envio : 0;
                                if (fila == checked(this.eListPagos.Count - 1) && strCodofin != "0")
                                {
                                    subEnvio = Convert.ToDouble(Decimal.Subtract(envio, Microsoft.VisualBasic.Conversion.Int(envio)));
                                    writer.WriteLine("01131328800" + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(Strings.Mid(strCip, 3, 8)), "00000000") + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(nroBen), "00") + "LE" + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(nroDni), "00000000") + "  " + Convert.ToString(this.txtAnio.Text) + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(Microsoft.VisualBasic.Conversion.Str(Cmb.ObtenerValor(this.cmbMes))), "00") + Strings.Format((object)(Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)), "0000##0.#0"));
                                    strQuery += " INSERT INTO Tb_EnvioCaja ( Anio, Mes, Cod, Cip, Ben, LE, Dni, AnioMes, Importe ) ";
                                    strQuery += " VALUES  ( " + this.txtAnio.Text + ", " + Cmb.ObtenerValor(this.cmbMes) + ", '01131328800', '" + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(Strings.Mid(strCip, 3, 8)), "00000000") + "', '" + nroBen.PadLeft(2, '0') + "', 'LE',  '" + nroDni.PadLeft(8, '0') + "', '" + Convert.ToString(this.txtAnio.Text) + Strings.Format((object)Microsoft.VisualBasic.Conversion.Val(Microsoft.VisualBasic.Conversion.Str(Cmb.ObtenerValor(this.cmbMes))), "00") + "', '" + Strings.Format((object)(Convert.ToDouble(envio) + Convert.ToDouble(this.txtComision.Text)), "0000##0.#0") + "' )";
                                }
                            }
                        }
                        break;
                }
                fila++;
            }

            if (strQuery != string.Empty)
                oEnvioDirrehumController.InsertarTbEnvioDirrehum(strQuery);

            strQuery = string.Empty;

            writer.Flush();
            writer.Close();
        }

        public void Cerrar()
        {
            frmPrincipal wMen = (frmPrincipal)this.ParentForm;
            switch (this._uniDscto)
            {
                case (int)CreditsEnum.UndDscto.DirrehumHaberes:
                    wMen.CerrarVentanaHijo(this, wMen.tsmDirrehumHaberesEnvioGeneraFile, null);
                    break;
                case (int)CreditsEnum.UndDscto.DirrehumCombustible:
                    wMen.CerrarVentanaHijo(this, wMen.tsmDirrehumCombustibleEnvioGeneraFile, null);
                    break;
                case (int)CreditsEnum.UndDscto.CajaPensionesCPMP:
                    wMen.CerrarVentanaHijo(this, wMen.tsmCajaMilitarEnvioGeneraFileMes, null);
                    break;
            }

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
            {
                Mensaje.OperacionDenegada("Faltan completar datos.", "Generar Envio");
                return;
            }

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
