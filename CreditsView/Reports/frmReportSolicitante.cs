using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditosView.Reports
{
    public partial class frmReportApplicant : Form
    {
        public frmReportApplicant()
        {
            InitializeComponent();
        }

        public void NewWindow()
        {
            this.Dock = DockStyle.Fill;
            this.Show();
            //this.ActualizarVentana();
            //this.fillChart();
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void frmReportApplicant_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
