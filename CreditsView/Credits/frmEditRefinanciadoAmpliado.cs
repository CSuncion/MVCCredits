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
        CreditsSolicitanteController oSolCtrll = new CreditsSolicitanteController();
        CreditsRefinanciadoAmpliadoController oRefAmpCtrll = new CreditsRefinanciadoAmpliadoController();
        Dgv.Franja eFranjaDgvCredOpe = Dgv.Franja.PorIndice;
        public string eClaveDgvCredOpe = string.Empty;
        CreditsSolicitantesDto eSol = new CreditsSolicitantesDto();
        int Accion = 0;
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

        public void VentanaModificar(CreditsOperationsDto pOpe)
        {
            this.MostrarRefinanciadoAmpliado(pOpe);
            this.InicializaVentana();
            eMas.AccionHabilitarControles(0);
            eMas.AccionPasarTextoPrincipal();
            this.txtDocId.ReadOnly = true;
            this.btnBuscar.Visible = false;
        }
        public void MostrarRefinanciadoAmpliado(CreditsOperationsDto pOpe)
        {
            this.txtDocId.Text = pOpe.Dni_Solicitante;
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
            iLisCreOpe.Add(Dgv.NuevaColumnaCheckBox(CreditsOperationsDto.VerFal, "Ref./Amp.", 70));
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

        public void ActualizarListaCreditosOperacionesDeBaseDatos()
        {
            //validar si es acto ir a la bd
            if (this.txtDocId.Text.Trim() != string.Empty && eVaBD == 0) { return; }

            //ir a la bd
            CreditsOperationsDto iCreOpeEN = new CreditsOperationsDto();
            iCreOpeEN.Dni_Solicitante = this.txtDocId.Text.Trim();
            iCreOpeEN.Additionals.CampoOrden = eNombreColumnaDgvCredOper;
            this.eListCredOpe = CreditsOperationsController.TablaOperacDni(iCreOpeEN);
        }

        public void ActualizarVentana()
        {
            this.ActualizarListaSolicitantesDeBaseDatos();
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
            List<CreditsOperationsDto> iListaOperationCabes = eListCredOpe;

            //ejecutar y retornar
            return oCrOpCtrll.ListarDatosParaGrillaPrincipal(iValorBusqueda, iCampoBusqueda, iListaOperationCabes);
        }
        public void AccionBuscar()
        {
            this.txtDocId.Text = "Ingrese " + this.eNombreColumnaDgvCredOper;
            this.txtDocId.Focus();
        }

        public void ActualizarListaSolicitantesDeBaseDatos()
        {
            //validar si es acto ir a la bd
            if (this.txtDocId.Text.Trim() != string.Empty && eVaBD == 0) { return; }

            //ir a la bd
            CreditsSolicitantesDto iSolEN = new CreditsSolicitantesDto();
            iSolEN.Dni_Solic = this.txtDocId.Text.Trim();
            iSolEN = oSolCtrll.ListarSolicitantesPorDni(iSolEN);
            this.AsignarSolicitantes(iSolEN);
        }
        public void AsignarSolicitantes(CreditsSolicitantesDto iSolEN)
        {
            this.txtApeNom.Text = iSolEN.Paterno.Trim() + " " + iSolEN.Materno.Trim() + ", " + iSolEN.Nombres.Trim();
            this.txtGrado.Text = iSolEN.DesGrado.Trim();
            this.txtEMail.Text = iSolEN.Mail.Trim();
            this.txtCelular.Text = iSolEN.Movil.Trim();
            this.txtDepartamento.Text = iSolEN.DesDpto.Trim();
            this.txtProvincia.Text = iSolEN.DesProv.Trim();
            this.txtDistrito.Text = iSolEN.DesDist.Trim();
        }

        public void AsignarRefinanciadoAmpliado(int pFilaChequeada, int pColumnaChequeada)
        {
            //solo debe actuar cuando la columna sea "0" y la fila diferente de "-1"
            if ((pColumnaChequeada == 0 && pFilaChequeada != -1))
            {
                //IdOperacion = Dgv.ObtenerValorCelda(this.dgvRefAmp, CreditsOperationsDto.IdOper);
            }
        }

        public int ValidarOperacionSeleccionado()
        {
            int sel = 0;
            for (int i = 0; i < dgvRefAmp.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvRefAmp.Rows[i].Cells[CreditsOperationsDto.VerFal].Value))
                    sel += 1;
            }
            return sel;
        }

        public CreditsRefinanciadoAmpliadoDto ValidarExistenciaRefinanciadoAmpliadoPorOperacion()
        {
            CreditsRefinanciadoAmpliadoDto oRefAmp = new CreditsRefinanciadoAmpliadoDto();
            for (int i = 0; i < dgvRefAmp.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvRefAmp.Rows[i].Cells[CreditsOperationsDto.VerFal].Value))
                {
                    oRefAmp.IdOperacion = Convert.ToInt32(dgvRefAmp.Rows[i].Cells[CreditsOperationsDto.IdOper].Value);
                    oRefAmp = CreditsRefinanciadoAmpliadoController.ListarRefinanciadoAmpliadoPorOperacion(oRefAmp);
                }
            }
            return oRefAmp;
        }

        public int AsignarOperacion()
        {
            int idOperacion = 0;
            for (int i = 0; i < dgvRefAmp.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvRefAmp.Rows[i].Cells[CreditsOperationsDto.VerFal].Value))
                    idOperacion = Convert.ToInt32(dgvRefAmp.Rows[i].Cells[CreditsOperationsDto.IdOper].Value);
            }
            return idOperacion;
        }

        public void GuardarRefinanciamientoAmpliacion(int IdOperacion)
        {
            CreditsRefinanciadoAmpliadoDto oRefAmp = new CreditsRefinanciadoAmpliadoDto();
            oRefAmp.IdOperacion = IdOperacion;
            oRefAmp.Estado = this.Accion;
            oRefAmpCtrll.CrearRefinanciadoAmpliado(oRefAmp);
        }

        public void AdicionarRefinanciadoAmpliado()
        {
            if (this.ValidarOperacionSeleccionado() == 0 || this.ValidarOperacionSeleccionado() > 1)
            {
                Mensaje.OperacionDenegada("Solo debe seleccionar un crédito.", this.wRefAmp.eTitulo);
                return;
            }

            CreditsRefinanciadoAmpliadoDto resultExis = this.ValidarExistenciaRefinanciadoAmpliadoPorOperacion();

            if (resultExis.IdOperacion != 0)
            {
                Mensaje.OperacionDenegada("Ya existe un " + resultExis.DesEstado, this.wRefAmp.eTitulo);
                return;
            }

            this.GuardarRefinanciamientoAmpliacion(this.AsignarOperacion());
            if (this.Accion == 1)
                Mensaje.OperacionSatisfactoria("El Refinanciamiento se adiciono correctamente", this.wRefAmp.eTitulo);
            else
                Mensaje.OperacionSatisfactoria("La Ampliacion se adiciono correctamente", this.wRefAmp.eTitulo);

            this.wRefAmp.ActualizarVentana();
            this.ActualizarVentana();
        }

        public void ModificarRefinanciadoAmpliado()
        {
            if (this.ValidarOperacionSeleccionado() == 0 || this.ValidarOperacionSeleccionado() > 1)
            {
                Mensaje.OperacionDenegada("Solo debe seleccionar un crédito.", this.wRefAmp.eTitulo);
                return;
            }

            CreditsRefinanciadoAmpliadoDto resultExis = this.ValidarExistenciaRefinanciadoAmpliadoPorOperacion();

            if (resultExis.IdOperacion != 0)
            {
                Mensaje.OperacionDenegada("Ya existe un " + resultExis.DesEstado, this.wRefAmp.eTitulo);
                return;
            }

            this.GuardarRefinanciamientoAmpliacion(this.AsignarOperacion());
            if (this.Accion == 1)
                Mensaje.OperacionSatisfactoria("El Refinanciamiento se adiciono correctamente", this.wRefAmp.eTitulo);
            else
                Mensaje.OperacionSatisfactoria("La Ampliacion se adiciono correctamente", this.wRefAmp.eTitulo);
        }

        public void Aceptar()
        {
            switch (this.eOperacion)
            {
                case Universal.Opera.Adicionar: { this.AdicionarRefinanciadoAmpliado(); break; }
                case Universal.Opera.Modificar: { this.ModificarRefinanciadoAmpliado(); break; }
                //case Universal.Opera.Eliminar: { this.Eliminar(); break; }
                default: break;
            }
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

        private void txtDocId_Validating(object sender, CancelEventArgs e)
        {
            if (this.dgvRefAmp.Rows.Count != 0) { eVaBD = 0; }
            this.ActualizarVentana();
            eVaBD = 1;
        }

        private void btnRefinanciado_Click(object sender, EventArgs e)
        {
            this.Accion = 1;
            this.Aceptar();
        }

        private void dgvRefAmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.AsignarRefinanciadoAmpliado(e.RowIndex, e.ColumnIndex);
        }

        private void btnAmpliado_Click(object sender, EventArgs e)
        {
            this.Accion = 2;
            this.Aceptar();
        }
    }
}
