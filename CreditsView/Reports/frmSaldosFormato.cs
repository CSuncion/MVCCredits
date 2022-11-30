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
using WinControles.ControlesWindows;

namespace CreditsView.Reports
{
    public partial class frmSaldosFormato : Form
    {
        CreditsGeneralController objGeneralController = new CreditsGeneralController();
        public CreditsReportController oRptCtrl = new CreditsReportController();
        List<CreditsSaldosFormatoDto> eListSalFor = new List<CreditsSaldosFormatoDto>();
        string eNombreColumnaDgvSalFor = CreditsSaldosFormatoDto.xDNI;
        Dgv.Franja eFranjaDgvCred = Dgv.Franja.PorIndice;
        public string eClaveDgvCre = string.Empty;


        int eVaBD = 1;//0 : no , 1 : si
        public frmSaldosFormato()
        {
            InitializeComponent();
        }

        public void NewWindow()
        {
            this.Dock = DockStyle.Fill;
            this.CargarMeses();
            this.CargarCentroCosto();
            this.tsTxtAnio.Text = DateTime.Now.Year.ToString();
            this.Show();
        }
        public void CargarCentroCosto()
        {
            Cmb.Cargar(this.tsCmbProducto, this.objGeneralController.ListarCentroCostos("60"), "CodCosto_CodigoCosto", "Name_Costo");
        }
        public void CargarMeses()
        {
            Cmb.Cargar(this.tsCmbMes, this.objGeneralController.ListarMeses(), "Id_Mes", "Des_Mes");
        }
        public void ActualizarVentana()
        {
            this.ActualizarSaldosFormatoDeBaseDatos();
            this.ActualizarDgvCreditos();
        }
        public void ActualizarSaldosFormatoDeBaseDatos()
        {
            //validar si es acto ir a la bd
            if (this.tsTxtAnio.Text.Trim() != string.Empty && eVaBD == 0) { return; }

            string mes = Cmb.ObtenerValor(this.tsCmbMes.ComboBox, string.Empty);
            string anio = this.tsTxtAnio.Text;
            string producto = Cmb.ObtenerValor(this.tsCmbProducto.ComboBox, string.Empty);
            //ir a la bd
            eListSalFor = CreditsReportController.ListaSaldosFormato(mes, anio, producto);
        }
        public void ActualizarDgvCreditos()
        {
            //asignar parametros
            DataGridView iGrilla = this.DgvSaldosFormato;
            List<CreditsSaldosFormatoDto> iFuenteDatos = this.ObtenerDatosParaGrilla();
            Dgv.Franja iCondicionFranja = eFranjaDgvCred;
            string iClaveBusqueda = eClaveDgvCre;
            string iColumnaPintura = eNombreColumnaDgvSalFor;
            List<DataGridViewColumn> iListaColumnas = this.ListarColumnasDgvCreOper();
            //ejecutar metodo
            Dgv.RefrescarGrilla(iGrilla, iFuenteDatos, iCondicionFranja, iClaveBusqueda, iColumnaPintura, iListaColumnas);
        }
        public List<CreditsSaldosFormatoDto> ObtenerDatosParaGrilla()
        {
            //asignar parametros
            string iValorBusqueda = string.Empty;
            string iCampoBusqueda = eNombreColumnaDgvSalFor;
            List<CreditsSaldosFormatoDto> iListaSolicitudPedidoCabes = eListSalFor;

            //ejecutar y retornar
            return oRptCtrl.ListarDatosParaGrillaPrincipal(iValorBusqueda, iCampoBusqueda, iListaSolicitudPedidoCabes);
        }
        public List<DataGridViewColumn> ListarColumnasDgvCreOper()
        {
            //lista resultado
            List<DataGridViewColumn> iLisCreOpe = new List<DataGridViewColumn>();

            //agregando las columnas
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsSaldosFormatoDto.xConcatenado, "Concatenado.", 110));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsSaldosFormatoDto.xCod, "Cod", 60));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsSaldosFormatoDto.xProducto, "Producto", 90));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsSaldosFormatoDto.xSolicitante, "Solicitante", 150));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsSaldosFormatoDto.xDNI, "DNI", 90));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsSaldosFormatoDto.xSer, "Ser", 70));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsSaldosFormatoDto.xNumero, "Número", 90));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xDec__, "Dec_" + (DateTime.Now.Year - 1).ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xJan_, "Jan_" + DateTime.Now.Year.ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xFeb_, "Feb_" + DateTime.Now.Year.ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xMar_, "Mar_" + DateTime.Now.Year.ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xApr_, "Apr_" + DateTime.Now.Year.ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xMay_, "May_" + DateTime.Now.Year.ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xJun_, "Jun_" + DateTime.Now.Year.ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xJul_, "Jul_" + DateTime.Now.Year.ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xAug_, "Aug_" + DateTime.Now.Year.ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xSep_, "Sep_" + DateTime.Now.Year.ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xOct_, "Oct_" + DateTime.Now.Year.ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xNov_, "Nov_" + DateTime.Now.Year.ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextNumerico(CreditsSaldosFormatoDto.xDec_, "Dec_" + DateTime.Now.Year.ToString(), 70, 2));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsSaldosFormatoDto.xDNI, "Dni_Solicitante", 40, false));
            iLisCreOpe.Add(Dgv.NuevaColumnaTextCadena(CreditsSaldosFormatoDto.xId_Operacion, "Id_Operacion", 40, false));

            //devolver
            return iLisCreOpe;
        }
        private void tsBtnProcesar_Click(object sender, EventArgs e)
        {
            this.ActualizarVentana();
        }
    }
}
