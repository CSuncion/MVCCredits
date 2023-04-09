using CreditsController.Controller;
using CreditsModel.ModelDto;
using CreditsUtil.Enum;
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

namespace CreditsView.PlanillaDescuentos
{
    public partial class frmRetornoGeneraFileMes : Form
    {
        CreditsGeneralController oGeneralController = new CreditsGeneralController();
        public int _uniDscto = 0;
        public frmRetornoGeneraFileMes()
        {
            InitializeComponent();
        }
        public void NewWindow(int uniDscto)
        {
            this._uniDscto = uniDscto;
            this.TituloEnvio();
            this.CargarMeses();
            this.txtAnio.Text = DateTime.Now.Year.ToString();
            this.cmbMes.SelectedIndex = DateTime.Now.Month - 1;
            this.CargarMora();
            this.CargarComision();
            this.CargarSituacion();
            this.CargarCheqOpe();
            this.CargarFinanBanca();
            this.Show();
        }
        public void TituloEnvio()
        {
            switch (this._uniDscto)
            {
                case (int)CreditsEnum.UndDscto.DirrehumHaberes:
                    this.lblTituloEnvio.Text = "Retorno DIRREHUM Planillas";
                    break;
                case (int)CreditsEnum.UndDscto.CajaPensionesCPMP:
                    this.lblTituloEnvio.Text = "Retorno Caja de Pensiones CPMP";
                    break;
                case (int)CreditsEnum.UndDscto.DirrehumCombustible:
                    this.lblTituloEnvio.Text = "Retorno DIRREHUM Combustible";
                    break;
                case 8:
                    this.lblTituloEnvio.Text = "Retorno Planilla Empleados FONBIEPOL";
                    break;
            }
        }
        public void CargarMeses()
        {
            Cmb.Cargar(this.cmbMes, this.oGeneralController.ListarMeses(), CreditsMesesDto.xIdMes, CreditsMesesDto.xDesMes);
        }
        public void CargarMora()
        {
            this.txtIntMora.Text = this.oGeneralController.ListarMora().FirstOrDefault().PorcentMora.ToString();
        }

        public void CargarComision()
        {
            this.txtComision.Text = this.oGeneralController.ListarComisionPorUndDscto(this._uniDscto.ToString()).FirstOrDefault().ImporteComision.ToString();
        }

        public void CargarFinanBanca()
        {
            Cmb.Cargar(this.cmbFinBca, this.oGeneralController.ListarFinanBanca(), CreditsFinanBancaDto.xIdBca, CreditsFinanBancaDto.xDeBca);
        }
        public void CargarCheqOpe()
        {
            Cmb.Cargar(this.cmbCheqOpe, this.oGeneralController.ListarCheqOper(), CreditsCheqOperDto.xIdChequeOperac, CreditsCheqOperDto.xDeCheqOperac);
        }

        public void CargarSituacion()
        {
            this.cmbSituacion.Items.AddRange(new object[3]
            {
                (object) "",
                (object) "Actividad",
                (object) "Retiro"
            });
        }
    }
}
