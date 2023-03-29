namespace CreditsView.PlanillaDescuentos
{
    partial class frmEnvioGeneraFileMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvioGeneraFileMes));
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tsBtnProcesar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExportar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fbdUbicacion = new System.Windows.Forms.FolderBrowserDialog();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.cbReprogramarMora = new System.Windows.Forms.CheckBox();
            this.cbAplicarInteres = new System.Windows.Forms.CheckBox();
            this.cmbTope = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIntMora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDirrehumEnvio = new System.Windows.Forms.DataGridView();
            this.btnActualizarIntMora = new System.Windows.Forms.Button();
            this.btnActualizarComision = new System.Windows.Forms.Button();
            this.btnActualizarIGV = new System.Windows.Forms.Button();
            this.bwProgress = new System.ComponentModel.BackgroundWorker();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pbExportExcel = new System.Windows.Forms.ProgressBar();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tsPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirrehumEnvio)).BeginInit();
            this.SuspendLayout();
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.AutoSize = false;
            this.tsPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSalir,
            this.tsBtnProcesar,
            this.tsBtnExportar});
            this.tsPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(800, 42);
            this.tsPrincipal.Stretch = true;
            this.tsPrincipal.TabIndex = 447;
            // 
            // tsBtnSalir
            // 
            this.tsBtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnSalir.Image = global::CreditsView.Properties.Resources.door_out;
            this.tsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSalir.Name = "tsBtnSalir";
            this.tsBtnSalir.Size = new System.Drawing.Size(49, 39);
            this.tsBtnSalir.Text = "Salir";
            this.tsBtnSalir.Click += new System.EventHandler(this.tsBtnSalir_Click);
            // 
            // tsBtnProcesar
            // 
            this.tsBtnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnProcesar.Image")));
            this.tsBtnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnProcesar.Name = "tsBtnProcesar";
            this.tsBtnProcesar.Size = new System.Drawing.Size(56, 39);
            this.tsBtnProcesar.Text = "Procesar";
            this.tsBtnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnProcesar.Click += new System.EventHandler(this.tsBtnProcesar_Click);
            // 
            // tsBtnExportar
            // 
            this.tsBtnExportar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExportar.Image")));
            this.tsBtnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExportar.Name = "tsBtnExportar";
            this.tsBtnExportar.Size = new System.Drawing.Size(55, 39);
            this.tsBtnExportar.Text = "Exportar";
            this.tsBtnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 450;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 449;
            this.label3.Text = "Envio DIRREHUM Planillas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(0, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 10);
            this.panel2.TabIndex = 457;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 458;
            this.label13.Text = "Mes:";
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Location = new System.Drawing.Point(116, 80);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 459;
            this.cmbMes.SelectionChangeCommitted += new System.EventHandler(this.cmbMes_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 460;
            this.label1.Text = "Año:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(296, 81);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 461;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 462;
            this.label2.Text = "Nombre Archivo:";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(116, 108);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(280, 20);
            this.txtNombreArchivo.TabIndex = 463;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 464;
            this.label4.Text = "Ubicación:";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(116, 134);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.ReadOnly = true;
            this.txtUbicacion.Size = new System.Drawing.Size(280, 20);
            this.txtUbicacion.TabIndex = 465;
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowser.BackgroundImage")));
            this.btnBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowser.Location = new System.Drawing.Point(402, 135);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(24, 20);
            this.btnBrowser.TabIndex = 466;
            this.btnBrowser.Tag = "Browser";
            this.btnBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // cbReprogramarMora
            // 
            this.cbReprogramarMora.AutoSize = true;
            this.cbReprogramarMora.Location = new System.Drawing.Point(473, 81);
            this.cbReprogramarMora.Name = "cbReprogramarMora";
            this.cbReprogramarMora.Size = new System.Drawing.Size(118, 17);
            this.cbReprogramarMora.TabIndex = 467;
            this.cbReprogramarMora.Text = "Reprogramar moras";
            this.cbReprogramarMora.UseVisualStyleBackColor = true;
            this.cbReprogramarMora.CheckedChanged += new System.EventHandler(this.cbReprogramarMora_CheckedChanged);
            // 
            // cbAplicarInteres
            // 
            this.cbAplicarInteres.AutoSize = true;
            this.cbAplicarInteres.Enabled = false;
            this.cbAplicarInteres.Location = new System.Drawing.Point(473, 108);
            this.cbAplicarInteres.Name = "cbAplicarInteres";
            this.cbAplicarInteres.Size = new System.Drawing.Size(138, 17);
            this.cbAplicarInteres.TabIndex = 468;
            this.cbAplicarInteres.Text = "Aplicar interes moratorio";
            this.cbAplicarInteres.UseVisualStyleBackColor = true;
            // 
            // cmbTope
            // 
            this.cmbTope.Enabled = false;
            this.cmbTope.FormattingEnabled = true;
            this.cmbTope.Location = new System.Drawing.Point(470, 136);
            this.cmbTope.Name = "cmbTope";
            this.cmbTope.Size = new System.Drawing.Size(121, 21);
            this.cmbTope.TabIndex = 470;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 469;
            this.label5.Text = "Tope:";
            // 
            // txtIntMora
            // 
            this.txtIntMora.Location = new System.Drawing.Point(685, 79);
            this.txtIntMora.Name = "txtIntMora";
            this.txtIntMora.ReadOnly = true;
            this.txtIntMora.Size = new System.Drawing.Size(45, 20);
            this.txtIntMora.TabIndex = 472;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 471;
            this.label6.Text = "IntMora:";
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(685, 105);
            this.txtComision.Name = "txtComision";
            this.txtComision.ReadOnly = true;
            this.txtComision.Size = new System.Drawing.Size(45, 20);
            this.txtComision.TabIndex = 474;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 473;
            this.label7.Text = "Comisión:";
            // 
            // txtIgv
            // 
            this.txtIgv.Location = new System.Drawing.Point(685, 131);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(45, 20);
            this.txtIgv.TabIndex = 476;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 475;
            this.label8.Text = "IGV.:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDirrehumEnvio);
            this.groupBox1.Location = new System.Drawing.Point(15, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 279);
            this.groupBox1.TabIndex = 477;
            this.groupBox1.TabStop = false;
            // 
            // dgvDirrehumEnvio
            // 
            this.dgvDirrehumEnvio.BackgroundColor = System.Drawing.Color.White;
            this.dgvDirrehumEnvio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirrehumEnvio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDirrehumEnvio.Location = new System.Drawing.Point(3, 16);
            this.dgvDirrehumEnvio.Name = "dgvDirrehumEnvio";
            this.dgvDirrehumEnvio.Size = new System.Drawing.Size(770, 260);
            this.dgvDirrehumEnvio.TabIndex = 1;
            // 
            // btnActualizarIntMora
            // 
            this.btnActualizarIntMora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarIntMora.BackgroundImage")));
            this.btnActualizarIntMora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarIntMora.Location = new System.Drawing.Point(737, 79);
            this.btnActualizarIntMora.Name = "btnActualizarIntMora";
            this.btnActualizarIntMora.Size = new System.Drawing.Size(24, 22);
            this.btnActualizarIntMora.TabIndex = 478;
            this.btnActualizarIntMora.UseVisualStyleBackColor = true;
            // 
            // btnActualizarComision
            // 
            this.btnActualizarComision.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarComision.BackgroundImage")));
            this.btnActualizarComision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarComision.Location = new System.Drawing.Point(737, 103);
            this.btnActualizarComision.Name = "btnActualizarComision";
            this.btnActualizarComision.Size = new System.Drawing.Size(24, 22);
            this.btnActualizarComision.TabIndex = 479;
            this.btnActualizarComision.UseVisualStyleBackColor = true;
            // 
            // btnActualizarIGV
            // 
            this.btnActualizarIGV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarIGV.BackgroundImage")));
            this.btnActualizarIGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarIGV.Location = new System.Drawing.Point(737, 129);
            this.btnActualizarIGV.Name = "btnActualizarIGV";
            this.btnActualizarIGV.Size = new System.Drawing.Size(24, 22);
            this.btnActualizarIGV.TabIndex = 480;
            this.btnActualizarIGV.UseVisualStyleBackColor = true;
            // 
            // bwProgress
            // 
            this.bwProgress.WorkerReportsProgress = true;
            this.bwProgress.WorkerSupportsCancellation = true;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(12, 508);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(16, 13);
            this.lblProgress.TabIndex = 482;
            this.lblProgress.Text = "...";
            // 
            // pbExportExcel
            // 
            this.pbExportExcel.Location = new System.Drawing.Point(15, 482);
            this.pbExportExcel.Name = "pbExportExcel";
            this.pbExportExcel.Size = new System.Drawing.Size(276, 23);
            this.pbExportExcel.TabIndex = 481;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(685, 179);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(73, 20);
            this.txtDni.TabIndex = 483;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(764, 177);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 22);
            this.btnBuscar.TabIndex = 484;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(650, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 485;
            this.label9.Text = "DNI:";
            // 
            // frmEnvioGeneraFileMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pbExportExcel);
            this.Controls.Add(this.btnActualizarIGV);
            this.Controls.Add(this.btnActualizarComision);
            this.Controls.Add(this.btnActualizarIntMora);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIgv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIntMora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTope);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAplicarInteres);
            this.Controls.Add(this.cbReprogramarMora);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnvioGeneraFileMes";
            this.Text = "Genera File del Mes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEnvioGeneraFileMes_FormClosing);
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirrehumEnvio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog fbdUbicacion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.CheckBox cbReprogramarMora;
        private System.Windows.Forms.CheckBox cbAplicarInteres;
        private System.Windows.Forms.ComboBox cmbTope;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIntMora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDirrehumEnvio;
        private System.Windows.Forms.ToolStripButton tsBtnProcesar;
        private System.Windows.Forms.ToolStripButton tsBtnExportar;
        private System.Windows.Forms.Button btnActualizarIntMora;
        private System.Windows.Forms.Button btnActualizarComision;
        private System.Windows.Forms.Button btnActualizarIGV;
        private System.ComponentModel.BackgroundWorker bwProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar pbExportExcel;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label9;
    }
}