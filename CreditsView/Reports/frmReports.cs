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

namespace CreditsView.Reports
{
    public partial class frmReports : Form
    {
        #region Atributos
        string eNombreColumnaDgvOperations = CreditsOperationsDto.DniSolic;
        public List<CreditsOperationsDto> eLisOperations = new List<CreditsOperationsDto>();
        CreditsOperationsController creditsOperationsController = new CreditsOperationsController();
        Dgv.Franja eFranjaDgvOperations = Dgv.Franja.PorIndice;
        public string eClaveDgvOperations = string.Empty;
        string eEncabezadoColumnaDgvOperations = "IdOperacion";
        #endregion

        public frmReports()
        {
            InitializeComponent();
        }

        #region Methods
        public void NewWindow()
        {
            this.Dock = DockStyle.Fill;
            this.Show();
            this.ActualizarVentana();
            this.fillChart();
        }
        public void Cerrar()
        {
            //obtener al wMenu
            frmPrincipal wMen = (frmPrincipal)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.btnReports, null);
        }

        public void ActualizarVentana()
        {
            this.ActualizarListaOperacionesDeBaseDatos();
            this.ActualizarDgvOperations();
            //Dgv.HabilitarDesplazadores(this.dgvReports, this.tsbPrimero, this.tsbAnterior, this.tsbSiguiente, this.tsbUltimo);
            //this.HabilitarAcciones();
            //Dgv.ActualizarBarraEstado(this.dgvReports, this.sst1);

        }
        public void ActualizarListaOperacionesDeBaseDatos()
        {
            //validar si es acto ir a la bd
            if (tsTxtBusqueda.Text.Trim() != string.Empty) { return; }

            //ir a la bd
            CreditsOperationsDto iOperationsEN = new CreditsOperationsDto();
            iOperationsEN.Additionals.CampoOrden = eNombreColumnaDgvOperations;
            iOperationsEN.DniSolicitante = tsTxtBusqueda.Text.Trim();
            this.eLisOperations = this.creditsOperationsController.TablaOperacDni(iOperationsEN);
        }
        public void ActualizarDgvOperations()
        {
            //asignar parametros
            DataGridView iGrilla = this.dgvReports;
            List<CreditsOperationsDto> iFuenteDatos = this.ObtenerDatosParaGrilla();
            Dgv.Franja iCondicionFranja = eFranjaDgvOperations;
            string iClaveBusqueda = eClaveDgvOperations;
            string iColumnaPintura = eNombreColumnaDgvOperations;
            List<DataGridViewColumn> iListaColumnas = this.ListarColumnasDgvOperations();

            //ejecutar metodo
            Dgv.RefrescarGrilla(iGrilla, iFuenteDatos, iCondicionFranja, iClaveBusqueda, iColumnaPintura, iListaColumnas);
        }

        public List<CreditsOperationsDto> ObtenerDatosParaGrilla()
        {
            //asignar parametros
            string iValorBusqueda = tsTxtBusqueda.Text.Trim();
            string iCampoBusqueda = eNombreColumnaDgvOperations;
            List<CreditsOperationsDto> iListaBancos = this.eLisOperations;

            //ejecutar y retornar
            return this.creditsOperationsController.ListarDatosParaGrillaPrincipal(iValorBusqueda, iCampoBusqueda, iListaBancos);
        }

        public List<DataGridViewColumn> ListarColumnasDgvOperations()
        {
            //lista resultado
            List<DataGridViewColumn> iLisRes = new List<DataGridViewColumn>();

            //agregando las columnas
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Tip, "Tipo", 50));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xSer, "Ser", 50));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Nro, "Número", 90));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Prove, "Proveedor", 90));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Product, "Productos", 100));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Fec, "Fecha", 80));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Aproba, "Cápital", 90));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xCredito, "Crédito", 90));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.Pla, "Plazo", 50));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xInforme, "Informe", 80));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xAnio, "Año", 50));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xVoucher, "Voucher", 80));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xFeDesembolso, "Desembolsa", 80));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.xCondicion, "Condición", 80));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.IdOper, "Clave", 50, false));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(CreditsOperationsDto.DniSolic, "Dni_Solicitante", 50, false));

            //devolver
            return iLisRes;
        }
        public void OrdenarPorColumna(int pColumna)
        {
            this.eFranjaDgvOperations = Dgv.Franja.PorIndice;
            this.eNombreColumnaDgvOperations = this.dgvReports.Columns[pColumna].Name;
            this.eEncabezadoColumnaDgvOperations = this.dgvReports.Columns[pColumna].HeaderText;
            this.ActualizarVentana();
        }
        public void fillChart()
        {

            chrCuotas.Series["Capital"].XValueMember = "Aprobado";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chrCuotas.Series["Capital"].YValueMembers = "Plazo";
            chrCuotas.DataSource = this.ObtenerDatosParaGrilla(); 
            chrCuotas.DataBind();
        }
        public void ActualizarVentanaAlBuscarValor(KeyEventArgs pE)
        {
            //verificar que tecla pulso el usuario
            switch (pE.KeyCode)
            {
                case Keys.Up:
                    {
                        Dgv.SeleccionarRegistroXDesplazamiento(this.dgvReports, WinControles.ControlesWindows.Dgv.Desplazar.Anterior);
                        Txt.CursorAlUltimo(this.tsTxtBusqueda); break;
                    }
                case Keys.Down:
                    {
                        Dgv.SeleccionarRegistroXDesplazamiento(this.dgvReports, WinControles.ControlesWindows.Dgv.Desplazar.Siguiente);
                        Txt.CursorAlUltimo(this.tsTxtBusqueda); break;
                    }
                case Keys.Left:
                case Keys.Right:
                    {
                        break;
                    }
                default:
                    {
                        this.ActualizarVentana();
                        this.fillChart();
                        break;
                    }
            }
        }
        #endregion

        #region Events
        private void frmReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }

        private void dgvReports_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.OrdenarPorColumna(e.ColumnIndex);
        }
        private void tsTxtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            this.ActualizarVentanaAlBuscarValor(e);
        }
        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Cerrar();
        }
        #endregion
    }
}
