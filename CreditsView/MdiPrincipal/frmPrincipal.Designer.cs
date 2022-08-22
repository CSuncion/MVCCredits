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
            this.Panel10 = new System.Windows.Forms.Panel();
            this.ssStatusBar = new System.Windows.Forms.StatusStrip();
            this.tssStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbcContainer = new System.Windows.Forms.TabControl();
            this.pnlBarTit = new System.Windows.Forms.Panel();
            this.tmOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.btnReports = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.ssStatusBar.SuspendLayout();
            this.pnlBarTit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnlMenu.Controls.Add(this.Panel10);
            this.pnlMenu.Controls.Add(this.btnReports);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Name = "pnlMenu";
            // 
            // Panel10
            // 
            this.Panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(110)))), ((int)(((byte)(21)))));
            resources.ApplyResources(this.Panel10, "Panel10");
            this.Panel10.Name = "Panel10";
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
            this.pnlBarTit.BackColor = System.Drawing.Color.Goldenrod;
            this.pnlBarTit.Controls.Add(this.btnRestaurar);
            this.pnlBarTit.Controls.Add(this.btnMinimizar);
            this.pnlBarTit.Controls.Add(this.btnMaximizar);
            this.pnlBarTit.Controls.Add(this.btnCerrar);
            resources.ApplyResources(this.pnlBarTit, "pnlBarTit");
            this.pnlBarTit.Name = "pnlBarTit";
            this.pnlBarTit.DoubleClick += new System.EventHandler(this.pnlBarTit_DoubleClick);
            this.pnlBarTit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarTit_MouseMove);
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
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(110)))), ((int)(((byte)(21)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            resources.ApplyResources(this.btnReports, "btnReports");
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Name = "btnReports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnMenu
            // 
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::CreditosView.Properties.Resources.logo_1;
            resources.ApplyResources(this.pnlLogo, "pnlLogo");
            this.pnlLogo.Name = "pnlLogo";
            // 
            // btnRestaurar
            // 
            resources.ApplyResources(this.btnRestaurar, "btnRestaurar");
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRestaurar.Image = global::CreditosView.Properties.Resources.Icono_Restaurar;
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
            this.btnMinimizar.Image = global::CreditosView.Properties.Resources.Icono_Minimizar;
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
            this.btnMaximizar.Image = global::CreditosView.Properties.Resources.Icono_Maximizar;
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
            this.btnCerrar.Image = global::CreditosView.Properties.Resources.ICON_CERRARF;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcContainer);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlBarTit);
            this.Controls.Add(this.ssStatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ssStatusBar.ResumeLayout(false);
            this.ssStatusBar.PerformLayout();
            this.pnlBarTit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
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
        internal System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Timer tmOcultarMenu;
        private System.Windows.Forms.Timer tmMostrarMenu;
        internal System.Windows.Forms.Panel Panel10;
        internal System.Windows.Forms.Button btnReports;
    }
}