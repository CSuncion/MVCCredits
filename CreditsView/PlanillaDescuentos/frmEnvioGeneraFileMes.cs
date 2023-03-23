using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsUtil.Enum;
using Microsoft.Office.Interop.Excel;
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

namespace CreditsView.PlanillaDescuentos
{
    public partial class frmEnvioGeneraFileMes : Form
    {
        CreditsGeneralController objGeneralController = new CreditsGeneralController();
        CreditsProcesoEnvioController objProcesoEnvioController = new CreditsProcesoEnvioController();
        CreditsPagosController objPagosController = new CreditsPagosController();
        public int _uniDscto = 0;
        public frmEnvioGeneraFileMes()
        {
            InitializeComponent();
        }
        public void NewWindow(int uniDscto)
        {
            //this.Dock = DockStyle.Fill;
            this._uniDscto = uniDscto;
            this.CargarMeses();
            //this.CargarCentroCosto();
            this.txtAnio.Text = DateTime.Now.Year.ToString();
            Cmb.SeleccionarValorItem(this.cmbMes, "1");
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
            Cmb.Cargar(this.cmbMes, this.objGeneralController.ListarMeses(), "Id_Mes", "Des_Mes");
        }

        public void CargarMora()
        {
            this.txtIntMora.Text = this.objGeneralController.ListarMora().FirstOrDefault().PorcentMora.ToString();
        }

        public void CargarIgv()
        {
            this.txtIgv.Text = this.objGeneralController.ListarIgv().FirstOrDefault().De_Igv.ToString();
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
            if (cbReprogramarMora.Checked)
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
            creditsPagosDto.CreditsOperationsDto = new CreditsOperationsDto();
            this.AsignarProcesoEnvioDto(creditsProcesoEnvioDto);
            this.AsignarLimpiarImpagos(creditsPagosDto);
            switch (this._uniDscto)
            {
                case (int)CreditsEnum.UndDscto.DirrehumHaberes:
                    if (Mensaje.DeseasRealizarOperacion("Confirmar. Proceso Envio de Cobranza DIRECFIN Planillas", "Envio DIRECFIN Planillas"))
                    {
                        this.objProcesoEnvioController.InsertarProcesoEnvio(creditsProcesoEnvioDto);
                        this.objPagosController.ActualizaMesAnioImpago(creditsPagosDto);
                        if (this.cbReprogramarMora.Checked)
                            this.ReprogramarImpagos();
                    }
                    break;
                case (int)CreditsEnum.UndDscto.CajaPensionesCPMP:
                    if (Mensaje.DeseasRealizarOperacion("Confirmar. Proceso Envio de Cobranza Caja de Pensiones CPMP", "Envio Caja de Pensiones CPMP"))
                    {
                        this.objProcesoEnvioController.InsertarProcesoEnvio(creditsProcesoEnvioDto);
                        this.objPagosController.ActualizaMesAnioImpago(creditsPagosDto);
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
            creditsPagosDto.Mes = Convert.ToInt32(Cmb.ObtenerValor(this.cmbMes));
            creditsPagosDto.Anio = Convert.ToInt32(this.txtAnio.Text);
            creditsPagosDto.CreditsOperationsDto.UnidDscto = this._uniDscto;
        }

        public void ReprogramarImpagos()
        {
            decimal interes = !cbAplicarInteres.Checked ? 0 : Convert.ToDecimal(this.txtIntMora.Text);
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


    }
}
