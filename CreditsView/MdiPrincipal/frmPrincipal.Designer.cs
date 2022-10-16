namespace CreditsView.MdiPrincipal
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.ssStatusBar = new System.Windows.Forms.StatusStrip();
            this.tssStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbcContainer = new System.Windows.Forms.TabControl();
            this.pnlBarTit = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tmOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFinanzas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCreditos = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCreditoOtorgados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaldoFavor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlanillaDecomicro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGeneradoDesembolsado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEnProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCartaNoAdeudo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMorosos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRefAmp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInformatica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSolicitantes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTipoCredito = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCreditoPorAnio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmComCredOtorgado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRespaldoBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAccDir = new System.Windows.Forms.ToolStrip();
            this.tsbCreditos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.pnlMenu.SuspendLayout();
            this.ssStatusBar.SuspendLayout();
            this.pnlBarTit.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tsAccDir.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Name = "pnlMenu";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::CreditsView.Properties.Resources.logo_1;
            resources.ApplyResources(this.pnlLogo, "pnlLogo");
            this.pnlLogo.Name = "pnlLogo";
            // 
            // ssStatusBar
            // 
            this.ssStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatusBar});
            resources.ApplyResources(this.ssStatusBar, "ssStatusBar");
            this.ssStatusBar.Name = "ssStatusBar";
            // 
            // tssStatusBar
            // 
            this.tssStatusBar.BackColor = System.Drawing.Color.Transparent;
            this.tssStatusBar.Name = "tssStatusBar";
            resources.ApplyResources(this.tssStatusBar, "tssStatusBar");
            // 
            // tbcContainer
            // 
            resources.ApplyResources(this.tbcContainer, "tbcContainer");
            this.tbcContainer.Name = "tbcContainer";
            this.tbcContainer.SelectedIndex = 0;
            // 
            // pnlBarTit
            // 
            this.pnlBarTit.BackColor = System.Drawing.Color.OliveDrab;
            this.pnlBarTit.Controls.Add(this.btnRestaurar);
            this.pnlBarTit.Controls.Add(this.btnMinimizar);
            this.pnlBarTit.Controls.Add(this.btnMaximizar);
            this.pnlBarTit.Controls.Add(this.btnCerrar);
            resources.ApplyResources(this.pnlBarTit, "pnlBarTit");
            this.pnlBarTit.Name = "pnlBarTit";
            this.pnlBarTit.DoubleClick += new System.EventHandler(this.pnlBarTit_DoubleClick);
            this.pnlBarTit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarTit_MouseMove);
            // 
            // btnRestaurar
            // 
            resources.ApplyResources(this.btnRestaurar, "btnRestaurar");
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRestaurar.Image = global::CreditsView.Properties.Resources.Icono_Restaurar;
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            resources.ApplyResources(this.btnMinimizar, "btnMinimizar");
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMinimizar.Image = global::CreditsView.Properties.Resources.Icono_Minimizar;
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            resources.ApplyResources(this.btnMaximizar, "btnMaximizar");
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaximizar.Image = global::CreditsView.Properties.Resources.Icono_Maximizar;
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Image = global::CreditsView.Properties.Resources.ICON_CERRARF;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tmOcultarMenu
            // 
            this.tmOcultarMenu.Interval = 15;
            this.tmOcultarMenu.Tick += new System.EventHandler(this.tmOcultarMenu_Tick);
            // 
            // tmMostrarMenu
            // 
            this.tmMostrarMenu.Interval = 15;
            this.tmMostrarMenu.Tick += new System.EventHandler(this.tmMostrarMenu_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFinanzas,
            this.tsmInformatica});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tsmFinanzas
            // 
            this.tsmFinanzas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCreditos,
            this.reportesToolStripMenuItem});
            resources.ApplyResources(this.tsmFinanzas, "tsmFinanzas");
            this.tsmFinanzas.Name = "tsmFinanzas";
            // 
            // tsmCreditos
            // 
            resources.ApplyResources(this.tsmCreditos, "tsmCreditos");
            this.tsmCreditos.Name = "tsmCreditos";
            this.tsmCreditos.Click += new System.EventHandler(this.tsmCreditos_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCreditoOtorgados,
            this.tsmSaldoFavor,
            this.tsmPlanillaDecomicro,
            this.tsmGeneradoDesembolsado,
            this.tsmEnProceso,
            this.tsmCartaNoAdeudo,
            this.tsmMorosos,
            this.tsmRefAmp});
            resources.ApplyResources(this.reportesToolStripMenuItem, "reportesToolStripMenuItem");
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            // 
            // tsmCreditoOtorgados
            // 
            resources.ApplyResources(this.tsmCreditoOtorgados, "tsmCreditoOtorgados");
            this.tsmCreditoOtorgados.Name = "tsmCreditoOtorgados";
            this.tsmCreditoOtorgados.Click += new System.EventHandler(this.tsmCreditoOtorgados_Click);
            // 
            // tsmSaldoFavor
            // 
            resources.ApplyResources(this.tsmSaldoFavor, "tsmSaldoFavor");
            this.tsmSaldoFavor.Name = "tsmSaldoFavor";
            this.tsmSaldoFavor.Click += new System.EventHandler(this.tsmSaldoFavor_Click);
            // 
            // tsmPlanillaDecomicro
            // 
            resources.ApplyResources(this.tsmPlanillaDecomicro, "tsmPlanillaDecomicro");
            this.tsmPlanillaDecomicro.Name = "tsmPlanillaDecomicro";
            this.tsmPlanillaDecomicro.Click += new System.EventHandler(this.tsmPlanillaDecomicro_Click);
            // 
            // tsmGeneradoDesembolsado
            // 
            resources.ApplyResources(this.tsmGeneradoDesembolsado, "tsmGeneradoDesembolsado");
            this.tsmGeneradoDesembolsado.Name = "tsmGeneradoDesembolsado";
            this.tsmGeneradoDesembolsado.Click += new System.EventHandler(this.tsmGeneradoDesembolsado_Click);
            // 
            // tsmEnProceso
            // 
            resources.ApplyResources(this.tsmEnProceso, "tsmEnProceso");
            this.tsmEnProceso.Name = "tsmEnProceso";
            this.tsmEnProceso.Click += new System.EventHandler(this.tsmEnProceso_Click);
            // 
            // tsmCartaNoAdeudo
            // 
            resources.ApplyResources(this.tsmCartaNoAdeudo, "tsmCartaNoAdeudo");
            this.tsmCartaNoAdeudo.Name = "tsmCartaNoAdeudo";
            this.tsmCartaNoAdeudo.Click += new System.EventHandler(this.tsmCartaNoAdeudo_Click);
            // 
            // tsmMorosos
            // 
            resources.ApplyResources(this.tsmMorosos, "tsmMorosos");
            this.tsmMorosos.Name = "tsmMorosos";
            this.tsmMorosos.Click += new System.EventHandler(this.tsmMorosos_Click);
            // 
            // tsmRefAmp
            // 
            resources.ApplyResources(this.tsmRefAmp, "tsmRefAmp");
            this.tsmRefAmp.Name = "tsmRefAmp";
            this.tsmRefAmp.Click += new System.EventHandler(this.tsmRefAmp_Click);
            // 
            // tsmInformatica
            // 
            this.tsmInformatica.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSolicitantes,
            this.tsmTipoCredito,
            this.tsmCreditoPorAnio,
            this.tsmComCredOtorgado,
            this.tsmRespaldoBackup});
            resources.ApplyResources(this.tsmInformatica, "tsmInformatica");
            this.tsmInformatica.Name = "tsmInformatica";
            // 
            // tsmSolicitantes
            // 
            resources.ApplyResources(this.tsmSolicitantes, "tsmSolicitantes");
            this.tsmSolicitantes.Name = "tsmSolicitantes";
            this.tsmSolicitantes.Click += new System.EventHandler(this.tsmSolicitantes_Click);
            // 
            // tsmTipoCredito
            // 
            resources.ApplyResources(this.tsmTipoCredito, "tsmTipoCredito");
            this.tsmTipoCredito.Name = "tsmTipoCredito";
            this.tsmTipoCredito.Click += new System.EventHandler(this.tsmTipoCredito_Click);
            // 
            // tsmCreditoPorAnio
            // 
            resources.ApplyResources(this.tsmCreditoPorAnio, "tsmCreditoPorAnio");
            this.tsmCreditoPorAnio.Name = "tsmCreditoPorAnio";
            this.tsmCreditoPorAnio.Click += new System.EventHandler(this.tsmCreditoPorAño_Click);
            // 
            // tsmComCredOtorgado
            // 
            resources.ApplyResources(this.tsmComCredOtorgado, "tsmComCredOtorgado");
            this.tsmComCredOtorgado.Name = "tsmComCredOtorgado";
            this.tsmComCredOtorgado.Click += new System.EventHandler(this.tsmComCredOtorgado_Click);
            // 
            // tsmRespaldoBackup
            // 
            resources.ApplyResources(this.tsmRespaldoBackup, "tsmRespaldoBackup");
            this.tsmRespaldoBackup.Name = "tsmRespaldoBackup";
            this.tsmRespaldoBackup.Click += new System.EventHandler(this.tsmRespaldoBackup_Click);
            // 
            // tsAccDir
            // 
            resources.ApplyResources(this.tsAccDir, "tsAccDir");
            this.tsAccDir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsAccDir.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsAccDir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCreditos,
            this.toolStripSeparator4,
            this.tsbSalir});
            this.tsAccDir.Name = "tsAccDir";
            // 
            // tsbCreditos
            // 
            resources.ApplyResources(this.tsbCreditos, "tsbCreditos");
            this.tsbCreditos.Name = "tsbCreditos";
            this.tsbCreditos.Click += new System.EventHandler(this.tsbCreditos_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // tsbSalir
            // 
            resources.ApplyResources(this.tsbSalir, "tsbSalir");
            this.tsbSalir.Name = "tsbSalir";
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcContainer);
            this.Controls.Add(this.tsAccDir);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlBarTit);
            this.Controls.Add(this.ssStatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.pnlMenu.ResumeLayout(false);
            this.ssStatusBar.ResumeLayout(false);
            this.ssStatusBar.PerformLayout();
            this.pnlBarTit.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsAccDir.ResumeLayout(false);
            this.tsAccDir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.StatusStrip ssStatusBar;
        internal System.Windows.Forms.ToolStripStatusLabel tssStatusBar;
        internal System.Windows.Forms.TabControl tbcContainer;
        internal System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBarTit;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Timer tmOcultarMenu;
        private System.Windows.Forms.Timer tmMostrarMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFinanzas;
        private System.Windows.Forms.ToolStripMenuItem tsmInformatica;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem tsmCreditos;
        internal System.Windows.Forms.ToolStripMenuItem tsmCreditoOtorgados;
        internal System.Windows.Forms.ToolStripMenuItem tsmSaldoFavor;
        internal System.Windows.Forms.ToolStripMenuItem tsmPlanillaDecomicro;
        internal System.Windows.Forms.ToolStripMenuItem tsmGeneradoDesembolsado;
        internal System.Windows.Forms.ToolStripMenuItem tsmEnProceso;
        internal System.Windows.Forms.ToolStripMenuItem tsmCartaNoAdeudo;
        internal System.Windows.Forms.ToolStripMenuItem tsmMorosos;
        internal System.Windows.Forms.ToolStripMenuItem tsmRefAmp;
        internal System.Windows.Forms.ToolStripMenuItem tsmSolicitantes;
        internal System.Windows.Forms.ToolStripMenuItem tsmTipoCredito;
        internal System.Windows.Forms.ToolStripMenuItem tsmCreditoPorAnio;
        internal System.Windows.Forms.ToolStripMenuItem tsmComCredOtorgado;
        internal System.Windows.Forms.ToolStripMenuItem tsmRespaldoBackup;
        private System.Windows.Forms.ToolStrip tsAccDir;
        internal System.Windows.Forms.ToolStripButton tsbCreditos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbSalir;
    }
}