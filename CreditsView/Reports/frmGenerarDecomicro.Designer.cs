namespace CreditsView.Reports
{
    partial class frmGenerarDecomicro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarDecomicro));
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnGenDeco = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.bwProgress = new System.ComponentModel.BackgroundWorker();
            this.pbExportExcel = new System.Windows.Forms.ProgressBar();
            this.tsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSalir});
            this.tsPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(300, 25);
            this.tsPrincipal.Stretch = true;
            this.tsPrincipal.TabIndex = 428;
            // 
            // tsBtnSalir
            // 
            this.tsBtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnSalir.Image = global::CreditsView.Properties.Resources.door_out;
            this.tsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSalir.Name = "tsBtnSalir";
            this.tsBtnSalir.Size = new System.Drawing.Size(49, 22);
            this.tsBtnSalir.Text = "Salir";
            this.tsBtnSalir.Click += new System.EventHandler(this.tsBtnSalir_Click);
            // 
            // btnGenDeco
            // 
            this.btnGenDeco.Image = ((System.Drawing.Image)(resources.GetObject("btnGenDeco.Image")));
            this.btnGenDeco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenDeco.Location = new System.Drawing.Point(79, 78);
            this.btnGenDeco.Name = "btnGenDeco";
            this.btnGenDeco.Size = new System.Drawing.Size(139, 42);
            this.btnGenDeco.TabIndex = 431;
            this.btnGenDeco.Text = "Generar Decomicro";
            this.btnGenDeco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenDeco.UseVisualStyleBackColor = true;
            this.btnGenDeco.Click += new System.EventHandler(this.btnGenDeco_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 10);
            this.panel1.TabIndex = 433;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 432;
            this.label3.Text = "DECOMICRO";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(129, 152);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(16, 13);
            this.lblProgress.TabIndex = 435;
            this.lblProgress.Text = "...";
            // 
            // bwProgress
            // 
            this.bwProgress.WorkerReportsProgress = true;
            this.bwProgress.WorkerSupportsCancellation = true;
            this.bwProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwProgress_DoWork);
            this.bwProgress.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwProgress_ProgressChanged);
            this.bwProgress.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwProgress_RunWorkerCompleted);
            // 
            // pbExportExcel
            // 
            this.pbExportExcel.Location = new System.Drawing.Point(12, 126);
            this.pbExportExcel.Name = "pbExportExcel";
            this.pbExportExcel.Size = new System.Drawing.Size(276, 23);
            this.pbExportExcel.TabIndex = 434;
            // 
            // frmGenerarDecomicro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 177);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pbExportExcel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenDeco);
            this.Controls.Add(this.tsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGenerarDecomicro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decomicro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGenerarDecomicro_FormClosing);
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.Button btnGenDeco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProgress;
        private System.ComponentModel.BackgroundWorker bwProgress;
        private System.Windows.Forms.ProgressBar pbExportExcel;
    }
}