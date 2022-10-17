using Comun;
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

namespace CreditsView.Credits
{
    public partial class frmEditCredito : Form
    {
        public frmCreditos wCre;
        public Universal.Opera eOperacion;
        Masivo eMas = new Masivo();
        public frmEditCredito()
        {
            InitializeComponent();
        }
        public void VentanaAdicionar()
        {
            this.InicializaVentana();
            eMas.AccionHabilitarControles(0);
            eMas.AccionPasarTextoPrincipal();
            //this.txtDocId.Focus();
        }
        public void InicializaVentana()
        {
            //titulo ventana
            this.Text = this.eOperacion.ToString() + Cadena.Espacios(1) + this.wCre.eTitulo;

            //eventos de controles
            //eMas.lisCtrls = this.ListaCtrls();
            eMas.EjecutarTodosLosEventos();
            //this.ActualizarVentana();
            // Deshabilitar al propietario
            this.wCre.Enabled = false;

            // Mostrar ventana
            this.Show();
        }
    }
}
