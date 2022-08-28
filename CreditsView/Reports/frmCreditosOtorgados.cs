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
using CreditsUtil.Util;
using CreditsController.Controller;
using WinControles;

namespace CreditsView.Reports
{
    public partial class frmCreditosOtorgados : Form
    {
        UtilFechas objUtilFechas = new UtilFechas();
        CreditsGeneralController objGeneralController = new CreditsGeneralController();
        public frmCreditosOtorgados()
        {
            InitializeComponent();
        }
        public void NewWindow()
        {
            this.Show();
            this.ActualizarVentana();
            //this.fillChart();
        }
        public void ActualizarVentana()
        {

        }
        public void CargarMes()
        {
            //Cmb.Cargar(this.cmbMes, objGeneralController.ListarMeses(), "Id_Mes", "Des_Mes");
        }

        private void frmReportCreditosOtorgados_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarGrafica_Click(object sender, EventArgs e)
        {
            this.AccionGenerarGrafica();
        }
        public void AccionGenerarGrafica()
        {
            int resultado = 0;

            bool esNumerico = Int32.TryParse(this.txtAnio.Text, out resultado);

            if (!esNumerico)
            {
                Mensaje.OperacionDenegada("Debe ser numerico", this.Text);
                return;
            }

            frmReportCreditosOtorgados win = new frmReportCreditosOtorgados();
            win.wCreOto = this;
            TabCtrl.InsertarVentana(this, win);
            win.MostrarGrafico();

        }
    }
}
