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
using WinControles;
using Comun;
using CreditsModel.ModelDto;
using CreditsController.Controller;
using WinControles.ControlesWindows;
using CreditsUtil.Util;

namespace CreditsView.Login
{
    public partial class frmLogin : Form
    {
        #region Owner
        Masivo eMas = new Masivo();
        public frmPrincipal frmPrincipal;
        CreditsAccessController creditsAccessController = new CreditsAccessController();
        UtilCredits utilCredits = new UtilCredits();
        public int eFlagInvoca = 0;//0: al iniciar el sistema,1: cambio de usuario
        #endregion

        public frmLogin()
        {
            InitializeComponent();
        }

        #region Methods
        List<ControlEditar> ListaCtrls()
        {
            List<ControlEditar> xLis = new List<ControlEditar>();
            ControlEditar xCtrl;

            xCtrl = new ControlEditar();
            xCtrl.txtNoFoco(this.txtNameUsr, this.txtCodUsr, "f");
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.txtNoFoco(this.txtProfile, this.txtCodUsr, "f");
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtCodUsr, true, "Usuario", "f");
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.TxtTodo(this.txtPwd, true, "Contraseña", "f");
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.Btn(this.btnGetInto, "f");
            xLis.Add(xCtrl);

            xCtrl = new ControlEditar();
            xCtrl.Btn(this.btnCancel, "f");
            xLis.Add(xCtrl);

            return xLis;
        }
        public void InitWindow()
        {
            eMas.lisCtrls = this.ListaCtrls();
            eMas.EjecutarTodosLosEventos();
        }
        public void NewWindow()
        {
            this.InitWindow();
            //this.MostrarPersistencia();
            this.ShowDialog();
        }
        public void AccessSystem()
        {
            if (eMas.CamposObligatorios() == false) { return; }

            //chequear si el usuario es valido
            if (this.EsUsuarioValido() == false) { return; }
            //comprobar si la clave es correcta     
            if (this.EsClaveDeUsuario() == false) { return; }

            //aqui paso todas las validaciones
            //pasamos las variables globales
            this.GuardarValoresUniversales();

            //Guardar la persistencia de datos
            this.GrabarPersistencia();

            //barra de estado para el menu         
            this.frmPrincipal.tssStatusBar.Text = Universal.EstadoBarra();

            //eliminar todas las ventanas abiertas
            this.frmPrincipal.EliminarTodasLasVentanasAbiertas();

            //eliminar todos los TabModulos que esten abiertos
            this.frmPrincipal.EliminarTodosLosTabVentanas();

            //habilitar los items del menu
            //MeSt.HabilitarMenu(this.frmPrincipal.msMenu, true);

            //cerrar ventana acceso
            this.Close();
        }
        public bool EsUsuarioValido()
        {
            CreditsAccessDto iUsuEN = new CreditsAccessDto();
            this.AsignarUsuario(iUsuEN);
            iUsuEN = this.creditsAccessController.EsUsuarioValido(iUsuEN);
            if (iUsuEN.Additionals.EsVerdad == false)
            {
                Mensaje.OperacionDenegada(iUsuEN.Additionals.Mensaje, "Usuario");
                this.txtCodUsr.Focus();
            }
            this.txtCodUsr.Text = iUsuEN.Dni_Acceso;
            this.txtNameUsr.Text = iUsuEN.Names_Acceso.Trim() + ' ' + iUsuEN.Paterno_Acceso.Trim() + ' ' + iUsuEN.Materno_Acceso.Trim();
            this.txtProfile.Text = iUsuEN.Cargo_Acceso;
            return iUsuEN.Additionals.EsVerdad;
        }
        public void AsignarUsuario(CreditsAccessDto pUsu)
        {
            pUsu.Dni_Acceso = this.txtCodUsr.Text.Trim();
            pUsu.Names_Acceso = this.txtNameUsr.Text.Trim();
            pUsu.Pass_Acceso = utilCredits.Encripta(this.txtPwd.Text.Trim());
        }

        public bool EsClaveDeUsuario()
        {
            CreditsAccessDto iUsuEN = new CreditsAccessDto();
            this.AsignarUsuario(iUsuEN);
            iUsuEN = this.creditsAccessController.EsContrasenaDeUsuario(iUsuEN);
            if (iUsuEN.Additionals.EsVerdad == false)
            {
                Mensaje.OperacionDenegada(iUsuEN.Additionals.Mensaje, "Clave");
                this.txtPwd.Clear();
                this.txtPwd.Focus();
            }
            return iUsuEN.Additionals.EsVerdad;
        }

        public void GuardarValoresUniversales()
        {
            Universal.gCodigoUsuario = this.txtCodUsr.Text.Trim();
            Universal.gNombreUsuario = this.txtNameUsr.Text.Trim();
            Universal.gNombrePerfil = this.txtProfile.Text.Trim();
        }

        public void GrabarPersistencia()
        {
            //guardando datos usuario
            Properties.Settings.Default.GuardarCheckUsuario = this.ckbUsr.Checked.ToString().ToLower();
            bool iValor = this.ckbUsr.Checked;
            Properties.Settings.Default.GuardarCodigoUsuario = Cadena.ObtenerValor(iValor, this.txtCodUsr.Text);
            Properties.Settings.Default.GuardarNombreUsuario = Cadena.ObtenerValor(iValor, this.txtNameUsr.Text);
            Properties.Settings.Default.GuardarNombrePerfil = Cadena.ObtenerValor(iValor, this.txtProfile.Text);

            //guardando datos clave
            Properties.Settings.Default.GuardarCheckClave = this.ckbPwd.Checked.ToString().ToLower();
            iValor = this.ckbPwd.Checked;
            Properties.Settings.Default.GuardarClaveUsuario = Cadena.ObtenerValor(iValor, this.txtPwd.Text);

            //guardar todos los datos
            Properties.Settings.Default.Save();
        }
        public void Cancelar()
        {
            //segun flag de invocacion de la ventana
            if (this.eFlagInvoca == 0)
            {
                Application.Exit();
            }
            else
            {
                //habilitamos el menu principal
                if (this.frmPrincipal.tbcContainer.TabPages.Count != 0)
                {
                    this.frmPrincipal.tbcContainer.Visible = true;
                    this.frmPrincipal.BackColor = Color.LightYellow;
                }
                this.Close();
            }
        }
        #endregion

        #region Eventos
        private void btnGetInto_Click(object sender, EventArgs e)
        {
            this.AccessSystem();
        }
        #endregion

        private void txtCodUsr_Validating(object sender, CancelEventArgs e)
        {
            this.EsUsuarioValido();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cancelar();
        }
    }
}
