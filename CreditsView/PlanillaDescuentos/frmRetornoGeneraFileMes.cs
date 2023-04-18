using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsUtil.Enum;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControles;
using WinControles.ControlesWindows;

namespace CreditsView.PlanillaDescuentos
{
    public partial class frmRetornoGeneraFileMes : Form
    {
        CreditsGeneralController oGeneralController = new CreditsGeneralController();
        CreditsProcesoPagoController oProcesoPagoController = new CreditsProcesoPagoController();
        CreditsRetornoDirrehumController oRetornoDirrehumController = new CreditsRetornoDirrehumController();
        CreditsPagosController oPagosController = new CreditsPagosController();
        public int _uniDscto = 0;
        public int idProcesoPago = 0;
        private OpenFileDialog fileDialog;
        public frmRetornoGeneraFileMes()
        {
            InitializeComponent();
        }
        public void NewWindow(int uniDscto)
        {
            this._uniDscto = uniDscto;
            this.IniciaVentana();
            this.Show();
        }
        public void IniciaVentana()
        {
            this.TituloEnvio();
            this.CargarMeses();
            this.txtAnio.Text = DateTime.Now.Year.ToString();
            this.cmbMes.SelectedIndex = DateTime.Now.Month - 1;
            this.CargarMora();
            this.CargarComision();
            this.CargarSituacion();
            this.CargarCheqOpe();
            this.CargarFinanBanca();
            this.txtImpCheque.Text = "0.0";
            this.txtImpComision.Text = "0.0";
            this.txtImpTotal.Text = "0.0";
        }
        public void TituloEnvio()
        {
            switch (this._uniDscto)
            {
                case (int)CreditsEnum.UndDscto.DirrehumHaberes:
                    this.lblTituloEnvio.Text = "Retorno DIRREHUM Planillas";
                    break;
                case (int)CreditsEnum.UndDscto.CajaPensionesCPMP:
                    this.lblTituloEnvio.Text = "Retorno Caja de Pensiones CPMP";
                    break;
                case (int)CreditsEnum.UndDscto.DirrehumCombustible:
                    this.lblTituloEnvio.Text = "Retorno DIRREHUM Combustible";
                    break;
                case 8:
                    this.lblTituloEnvio.Text = "Retorno Planilla Empleados FONBIEPOL";
                    break;
            }
        }
        public void CargarMeses()
        {
            Cmb.Cargar(this.cmbMes, this.oGeneralController.ListarMeses(), CreditsMesesDto.xIdMes, CreditsMesesDto.xDesMes);
        }
        public void CargarMora()
        {
            this.txtIntMora.Text = this.oGeneralController.ListarMora().FirstOrDefault().PorcentMora.ToString();
        }

        public void CargarComision()
        {
            this.txtComision.Text = this.oGeneralController.ListarComisionPorUndDscto(this._uniDscto.ToString()).FirstOrDefault().ImporteComision.ToString();
        }

        public void CargarFinanBanca()
        {
            Cmb.Cargar(this.cmbFinBca, this.oGeneralController.ListarFinanBanca(), CreditsFinanBancaDto.xIdBca, CreditsFinanBancaDto.xDeBca);
        }
        public void CargarCheqOpe()
        {
            Cmb.Cargar(this.cmbCheqOpe, this.oGeneralController.ListarCheqOper(), CreditsCheqOperDto.xIdChequeOperac, CreditsCheqOperDto.xDeCheqOperac);
        }

        public void CargarSituacion()
        {
            this.cmbSituacion.Items.AddRange(new object[3]
            {
                (object) "",
                (object) "Actividad",
                (object) "Retiro"
            });
        }
        public void UbicacionArchivo()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Text File";
            dlg.Filter = "TXT files|*.txt";
            DialogResult res = dlg.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                this.txtUbicacion.Text = dlg.FileName.Replace(@"\" + dlg.SafeFileName.ToString(), "");
                this.txtNombreArchivo.Text = dlg.SafeFileName.ToString();
            }
        }

        public bool ValidaArchivoProcesar()
        {
            bool archivo = false;

            if (this._uniDscto != (int)CreditsEnum.UndDscto.Fonbiepol)
            {
                if (this.txtNombreArchivo.Text == string.Empty)
                    archivo = true;

                if (this.txtUbicacion.Text == string.Empty)
                    archivo = true;
            }
            return archivo;
        }

        public string ValidarCmbSeleccionados()
        {
            string mensaje = string.Empty;
            if (Cmb.ObtenerTexto(this.cmbFinBca) == string.Empty)
                mensaje = "Seleccionar la Entidad Bancaria";

            if (this._uniDscto == (int)CreditsEnum.UndDscto.DirrehumHaberes && this.cmbSituacion.SelectedIndex == -1)
                mensaje = "Seleccionar la situación";

            if (Cmb.ObtenerTexto(this.cmbCheqOpe) == string.Empty)
                mensaje = "Seleccionar si la Operación es con Cheque u Operación";

            if (this.txtCheqOpe.Text == string.Empty)
                mensaje = "Ingresar el Número de Cheque u Operación";

            if (this.txtImpTotal.Text == "0.0" || Convert.ToDecimal(this.txtImpTotal.Text) == 0)
                mensaje = "Ingresar el Importe de Total Descontado";

            if (this._uniDscto == (int)CreditsEnum.UndDscto.CajaPensionesCPMP && (this.txtImpComision.Text == "0.0" || Convert.ToDecimal(this.txtImpTotal.Text) == 0))
                mensaje = "En caso la Operación corresponda a la Caja de Pensiones, debes ingresar el Importe de Comisión";

            return mensaje;
        }
        public void ProcesoEjecutarSegunUnidadDescuento()
        {
            if (this.ValidaProcesoPagoPorChequeOperacion())
            {
                Mensaje.OperacionDenegada("El Banco, Cheque/Operación y número ya fué procesado anteriormente", "REGISTRO DE PAGOS");
                return;
            }

            switch (this._uniDscto)
            {
                case (int)CreditsEnum.UndDscto.DirrehumHaberes:
                    if (Mensaje.DeseasRealizarOperacion("Confirmar. Proceso de Cobranza DIRECFIN Planillas", "Respuesta DIRECFIN Planillas"))
                    {
                        this.LlenadoRetornos();
                        this.RecojoDineroDirrehum_FI();
                    }
                    else
                        return;
                    break;
            }
        }

        public bool ValidaProcesoPagoPorChequeOperacion()
        {
            bool proceso = false;
            CreditsProcesoPagoDto creditsProcesoPago = new CreditsProcesoPagoDto();
            this.AsignarProcesoPago(creditsProcesoPago);
            if (this.oProcesoPagoController.SelProcesoPago(creditsProcesoPago).Id_ProcesoPagos != 0)
                return true;

            this.AsignarProcesoPago(creditsProcesoPago);
            this.idProcesoPago = this.oProcesoPagoController.ProcesoInsertarProcesoPago(creditsProcesoPago);

            return proceso;
        }
        public void AsignarProcesoPago(CreditsProcesoPagoDto creditsProcesoPago)
        {
            creditsProcesoPago.IdUnidadDscto = this._uniDscto;
            creditsProcesoPago.Situacion = this._uniDscto == (int)CreditsEnum.UndDscto.DirrehumHaberes ? this.cmbSituacion.SelectedIndex : 1;
            creditsProcesoPago.IdBanca = Cmb.ObtenerValor(this.cmbFinBca);
            creditsProcesoPago.IdCheqOpe = Convert.ToInt32(Cmb.ObtenerValor(this.cmbCheqOpe));
            creditsProcesoPago.NumCheqOpe = this.txtCheqOpe.Text;
            creditsProcesoPago.F_Proces = Convert.ToDateTime(this.dtpFecProc.Text);
            creditsProcesoPago.ImporteCheqOpe = Convert.ToDecimal(this.txtImpCheque.Text);
            creditsProcesoPago.Anotacion = "Pago Masivo DIRECFIN Planillas";
            creditsProcesoPago.impbruto = Convert.ToDecimal(this.txtImpTotal.Text);
            creditsProcesoPago.impdscto = Convert.ToDecimal(this.txtImpComision.Text);
            creditsProcesoPago.impneto = Convert.ToDecimal(this.txtImpTotal.Text) - Convert.ToDecimal(this.txtImpComision.Text);


        }
        public void CalculaImporteCheque()
        {
            this.txtImpCheque.Text = (Convert.ToDecimal(this.txtImpTotal.Text) - Convert.ToDecimal(this.txtImpComision.Text)).ToString();
        }

        public void LlenadoRetornos()
        {
            if (this._uniDscto == (int)CreditsEnum.UndDscto.DirrehumHaberes || this._uniDscto == (int)CreditsEnum.UndDscto.DirrehumCombustible)
            {
                List<CreditsRetornoDirrehumDto> lRetornoDirrehum = new List<CreditsRetornoDirrehumDto>();
                //Lee el archivo que vamos a consultar
                StreamReader streamReader = new StreamReader(this.txtUbicacion.Text + @"\" + this.txtNombreArchivo.Text);
                while (streamReader.Peek() != -1)
                {
                    // lee linea por linea del archivo
                    string strLinea = streamReader.ReadLine();
                    if (Versioned.IsNumeric((object)Strings.Mid(strLinea, 1, 9)))
                    {
                        this.AsignarRetornoDirrehum(lRetornoDirrehum, strLinea);
                    }
                }
                this.oRetornoDirrehumController.BuscarProcesoRetornoDirrehum(lRetornoDirrehum);
            }
        }
        public void AsignarRetornoDirrehum(List<CreditsRetornoDirrehumDto> lRetornoDirrehum, string strLinea)
        {
            lRetornoDirrehum.Add(
                new CreditsRetornoDirrehumDto()
                {
                    Codofin = Strings.Mid(strLinea.Trim(), 1, 9).PadLeft(9, '0'),
                    Anio = this.txtAnio.Text,
                    Mes = Cmb.ObtenerValor(this.cmbMes),
                    Situacion = Strings.Mid(strLinea.Trim(), 18, 1),
                    Importe = this._uniDscto == (int)CreditsEnum.UndDscto.DirrehumHaberes ?
                            Convert.ToDecimal(Conversion.Val(Strings.Mid(strLinea.Trim(), 19, 12)) / 100) : Convert.ToDecimal(Conversion.Val(Strings.Mid(strLinea.Trim(), 52, 7)) / 100),
                    Com = Convert.ToDecimal(Conversion.Val(Strings.Mid(strLinea, 54, 4)) / 100),
                });
        }

        public void RecojoDineroDirrehum_FI()
        {
            List<CreditsRetornoDirrehumDto> lRetornoDirrehum = new List<CreditsRetornoDirrehumDto>();
            CreditsRetornoDirrehumDto eRetornoDirrehum = new CreditsRetornoDirrehumDto();
            this.AsignarRetornoDirrehumFI(eRetornoDirrehum, "1");
            lRetornoDirrehum = this.oRetornoDirrehumController.SelRetDirrehumAnioMesTrabajado(eRetornoDirrehum);
            if (lRetornoDirrehum.Count < 1)
                return;

            foreach (CreditsRetornoDirrehumDto retornoDirrehum in lRetornoDirrehum)
            {
                CreditsPagosDto eCreditsPagos = new CreditsPagosDto();
                this.AsignarTablaTotalPagoMesAnioCodofin(eCreditsPagos, retornoDirrehum);
                List<CreditsPagosDto> lTablaCreditsPagos = this.oPagosController.TablaPagosMesAnioCodofin(eCreditsPagos);
                if (lTablaCreditsPagos.Count > 0)
                {
                    decimal total = this.oPagosController.TotalPagosMesAnioCodofin(eCreditsPagos).Total;
                    decimal dFi = retornoDirrehum.Fi;
                    if (total > 0)
                    {
                        foreach (CreditsPagosDto pagos in lTablaCreditsPagos)
                        {
                            decimal sumRetorno = pagos.Ret_Amortizacion + pagos.Ret_Interes + pagos.Ret_Seguro + pagos.Ret_Gastos + pagos.Ret_Comision1 + pagos.Ret_Comision2 + pagos.Ret_Igv;
                            if (sumRetorno == 0)
                            {
                                this.AsignarPagos(pagos, 0, total);
                                pagos.Id_Pago = oPagosController.InsertTbPagos(pagos);
                            }
                            else
                            {
                                this.AsignarPagos(pagos, 1, total);
                                oPagosController.ActualizaTbPagos(pagos);
                            }
                        }
                    }
                }
            }
        }

        public void AsignarPagos(CreditsPagosDto ePagos, int proc, decimal total)
        {
            ePagos.Id_ProcesoPagos = this.idProcesoPago;
            ePagos.Ret_Fecha = this.dtpFecProc.Value;

            if (proc == 0)
                ePagos.Id_Pago = 0;

            if (ePagos.Amortizacion == 0 && ePagos.Ant_Amortizacion == 0)
                ePagos.Ret_Amortizacion = 0;
            else
                ePagos.Ret_Amortizacion = (((ePagos.Amortizacion + ePagos.Ant_Amortizacion) * 100) / total) * 100;

            if (ePagos.Interes == 0 && ePagos.Ant_Interes == 0)
                ePagos.Ret_Interes = 0;
            else
                ePagos.Ret_Interes = (((ePagos.Interes + ePagos.Ant_Interes) * 100) / total) * 100;

            if (ePagos.Seguro == 0 && ePagos.Ant_Seguro == 0)
                ePagos.Ret_Seguro = 0;
            else
                ePagos.Ret_Seguro = (((ePagos.Seguro + ePagos.Ant_Seguro) * 100) / total) * 100;

            if (ePagos.Gastos == 0 && ePagos.Ant_Gastos == 0)
                ePagos.Ret_Gastos = 0;
            else
                ePagos.Ret_Gastos = (((ePagos.Gastos + ePagos.Ant_Gastos) * 100) / total) * 100;

            if (ePagos.Comision1 == 0 && ePagos.Ant_Comision1 == 0)
                ePagos.Ret_Comision1 = 0;
            else
                ePagos.Ret_Comision1 = (((ePagos.Comision1 + ePagos.Ant_Comision1) * 100) / total) * 100;

            if (ePagos.Comision2 == 0 && ePagos.Ant_Comision2 == 0)
                ePagos.Ret_Comision2 = 0;
            else
                ePagos.Ret_Comision2 = (((ePagos.Comision2 + ePagos.Ant_Comision2) * 100) / total) * 100;

            if (ePagos.Igv == 0 && ePagos.Ant_Igv == 0)
                ePagos.Ret_Igv = 0;
            else
                ePagos.Ret_Igv = (((ePagos.Igv + ePagos.Ant_Igv) * 100) / total) * 100;
        }

        public void AsignarTablaTotalPagoMesAnioCodofin(CreditsPagosDto eCreditsPagos, CreditsRetornoDirrehumDto retornoDirrehum)
        {
            eCreditsPagos.CreditsOperationsDto = new CreditsOperationsDto();
            eCreditsPagos.Anio = Convert.ToInt32(this.txtAnio.Text);
            eCreditsPagos.Mes = Convert.ToInt32(Cmb.ObtenerValor(this.cmbMes));
            eCreditsPagos.CreditsOperationsDto.UnidDscto = this._uniDscto;
            eCreditsPagos.CodoFin = retornoDirrehum.Codofin;
        }

        public void AsignarRetornoDirrehumFI(CreditsRetornoDirrehumDto eRetornoDirrehum, string Fico)
        {
            eRetornoDirrehum.Anio = this.txtAnio.Text;
            eRetornoDirrehum.Mes = Cmb.ObtenerValor(this.cmbMes);
            eRetornoDirrehum.Fico = Fico;
        }

        public void RecojoDineroDirrehum_CO()
        {
            List<CreditsRetornoDirrehumDto> lRetornoDirrehum = new List<CreditsRetornoDirrehumDto>();
            CreditsRetornoDirrehumDto eRetornoDirrehum = new CreditsRetornoDirrehumDto();
            this.AsignarRetornoDirrehumFI(eRetornoDirrehum, "2");
            lRetornoDirrehum = this.oRetornoDirrehumController.SelRetDirrehumAnioMesTrabajado(eRetornoDirrehum);
            if (lRetornoDirrehum.Count < 1)
                return;

            foreach (CreditsRetornoDirrehumDto retornoDirrehum in lRetornoDirrehum)
            {

            }

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            this.UbicacionArchivo();
        }

        private void tsBtnProcesar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (this.ValidaArchivoProcesar())
            {
                Mensaje.OperacionDenegada("Cual es el Archivo a Procesar.", "REGISTRO DE PAGOS");
                return;
            }

            mensaje = this.ValidarCmbSeleccionados();
            if (mensaje != string.Empty)
            {
                Mensaje.OperacionDenegada(mensaje, "REGISTRO DE PAGOS");
                return;
            }

            this.ProcesoEjecutarSegunUnidadDescuento();

        }

        private void txtImpTotal_Validated(object sender, EventArgs e)
        {
            this.CalculaImporteCheque();
        }

        private void txtImpComision_Validated(object sender, EventArgs e)
        {
            this.CalculaImporteCheque();
        }
    }
}
