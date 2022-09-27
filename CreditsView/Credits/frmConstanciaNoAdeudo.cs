﻿using CreditsController.Controller;
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

namespace CreditsView.Credits
{
    public partial class frmConstanciaNoAdeudo : Form
    {
        CreditsSolicitanteController oSolCtrll = new CreditsSolicitanteController();
        int eVaBD = 1;//0 : no , 1 : si
        public frmConstanciaNoAdeudo()
        {
            InitializeComponent();
        }

        public void NewWindow()
        {
            this.Show();
        }
        public void Cerrar()
        {
            frmPrincipal wMen = (frmPrincipal)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.btnNoAdeudo, null);
        }
        public void ActualizarVentana()
        {
            this.ActualizarListaSolicitantesDeBaseDatos();
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
        }
        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConstanciaNoAdeudo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }

        private void txtDocId_Validating(object sender, CancelEventArgs e)
        {
            this.ActualizarVentana();
            eVaBD = 1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.ActualizarVentana();
            eVaBD = 1;
        }
    }
}