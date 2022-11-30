namespace CreditsView.Reports
{
    partial class frmSaldosFormato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaldosFormato));
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsCmbMes = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtAnio = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsCmbProducto = new System.Windows.Forms.ToolStripComboBox();
            this.tsBtnProcesar = new System.Windows.Forms.ToolStripButton();
            this.DgvSaldosFormato = new System.Windows.Forms.DataGridView();
            this.sst1 = new System.Windows.Forms.StatusStrip();
            this.tssEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaldosFormato)).BeginInit();
            this.sst1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.AutoSize = false;
            this.tsPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSalir,
            this.toolStripLabel1,
            this.tsCmbMes,
            this.toolStripLabel2,
            this.tsTxtAnio,
            this.toolStripLabel3,
            this.tsCmbProducto,
            this.tsBtnProcesar});
            this.tsPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(800, 40);
            this.tsPrincipal.Stretch = true;
            this.tsPrincipal.TabIndex = 3;
            // 
            // tsBtnSalir
            // 
            this.tsBtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnSalir.Image = global::CreditsView.Properties.Resources.door_out;
            this.tsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSalir.Name = "tsBtnSalir";
            this.tsBtnSalir.Size = new System.Drawing.Size(49, 37);
            this.tsBtnSalir.Text = "Salir";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 37);
            this.toolStripLabel1.Text = "Mes:";
            // 
            // tsCmbMes
            // 
            this.tsCmbMes.Name = "tsCmbMes";
            this.tsCmbMes.Size = new System.Drawing.Size(121, 40);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 37);
            this.toolStripLabel2.Text = "Año:";
            // 
            // tsTxtAnio
            // 
            this.tsTxtAnio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxtAnio.Name = "tsTxtAnio";
            this.tsTxtAnio.Size = new System.Drawing.Size(100, 40);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 37);
            this.toolStripLabel3.Text = "Producto:";
            // 
            // tsCmbProducto
            // 
            this.tsCmbProducto.DropDownWidth = 150;
            this.tsCmbProducto.Name = "tsCmbProducto";
            this.tsCmbProducto.Size = new System.Drawing.Size(150, 40);
            // 
            // tsBtnProcesar
            // 
            this.tsBtnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnProcesar.Image")));
            this.tsBtnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnProcesar.Name = "tsBtnProcesar";
            this.tsBtnProcesar.Size = new System.Drawing.Size(56, 37);
            this.tsBtnProcesar.Text = "Procesar";
            this.tsBtnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnProcesar.Click += new System.EventHandler(this.tsBtnProcesar_Click);
            // 
            // DgvSaldosFormato
            // 
            this.DgvSaldosFormato.BackgroundColor = System.Drawing.Color.White;
            this.DgvSaldosFormato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvSaldosFormato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSaldosFormato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSaldosFormato.GridColor = System.Drawing.Color.Silver;
            this.DgvSaldosFormato.Location = new System.Drawing.Point(0, 40);
            this.DgvSaldosFormato.Name = "DgvSaldosFormato";
            this.DgvSaldosFormato.Size = new System.Drawing.Size(800, 388);
            this.DgvSaldosFormato.TabIndex = 111;
            // 
            // sst1
            // 
            this.sst1.BackColor = System.Drawing.SystemColors.Control;
            this.sst1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssEstado});
            this.sst1.Location = new System.Drawing.Point(0, 428);
            this.sst1.Name = "sst1";
            this.sst1.Size = new System.Drawing.Size(800, 22);
            this.sst1.TabIndex = 112;
            this.sst1.Text = "statusStrip1";
            // 
            // tssEstado
            // 
            this.tssEstado.BackColor = System.Drawing.SystemColors.Control;
            this.tssEstado.Name = "tssEstado";
            this.tssEstado.Size = new System.Drawing.Size(10, 17);
            this.tssEstado.Text = ".";
            // 
            // frmSaldosFormato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvSaldosFormato);
            this.Controls.Add(this.sst1);
            this.Controls.Add(this.tsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaldosFormato";
            this.Text = "Saldos Formato";
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaldosFormato)).EndInit();
            this.sst1.ResumeLayout(false);
            this.sst1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.DataGridView DgvSaldosFormato;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tsCmbMes;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tsTxtAnio;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox tsCmbProducto;
        private System.Windows.Forms.ToolStripButton tsBtnProcesar;
        internal System.Windows.Forms.StatusStrip sst1;
        private System.Windows.Forms.ToolStripStatusLabel tssEstado;
    }
}