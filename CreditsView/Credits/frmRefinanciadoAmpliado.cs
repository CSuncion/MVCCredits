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

namespace CreditsView.Credits
{
    public partial class frmRefinanciadoAmpliado : Form
    {
        Dgv.Franja eFranjaDgvRefAmp = Dgv.Franja.PorIndice;
        public string eTitulo = "Registro Refinanciado o Ampliación";
        public frmRefinanciadoAmpliado()
        {
            InitializeComponent();
        }
        public void NewWindow()
        {
            this.Dock = DockStyle.Fill;
            this.Show();
        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            this.AccionAdicionar();
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
        public void Cerrar()
        {
            frmPrincipal wMen = (frmPrincipal)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.btnRefiAmp, null);
        }
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRefinanciadoAmpliado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }
    }
}
