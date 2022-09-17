using Comun;
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
using WinControles.ControlesWindows;

namespace CreditsView.Reports
{
    public partial class frmCreditoMorosos : Form
    {
        public frmCreditoMorosos()
        {
            InitializeComponent();
        }
        public void AccionGenerarInforme()
        {

            if (Conversion.ADateTime(this.dtpFecDesde.Text) > Conversion.ADateTime(this.dtpFecHasta.Text))
            {
                Mensaje.OperacionDenegada("La fecha desde no puede ser mayor a la fecha hasta", this.Text);
                return;
            }

            frmReportCreditoMorosos win = new frmReportCreditoMorosos();
            win.wCredMoro = this;
            TabCtrl.InsertarVentana(this, win);
            win.MostrarInforme();
        }
        public void Cerrar()
        {
            frmPrincipal wMen = (frmPrincipal)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.btnReportMorosos, null);
        }

        public void NewWindow()
        {
            this.Show();
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            this.AccionGenerarInforme();
        }

        private void frmCreditoEnProceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }
    }
}
