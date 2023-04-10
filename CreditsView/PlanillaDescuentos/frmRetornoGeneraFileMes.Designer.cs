namespace CreditsView.PlanillaDescuentos
{
    partial class frmRetornoGeneraFileMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRetornoGeneraFileMes));
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tsBtnProcesar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExportar = new System.Windows.Forms.ToolStripButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEnvioFiles = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloEnvio = new System.Windows.Forms.Label();
            this.btnActualizarComision = new System.Windows.Forms.Button();
            this.btnActualizarIntMora = new System.Windows.Forms.Button();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIntMora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSituacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecProc = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFinBca = new System.Windows.Forms.ComboBox();
            this.cmbCheqOpe = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCheqOpe = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtImpTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtImpComision = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtImpCheque = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tsPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvioFiles)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tsPrincipal.TabIndex = 448;
            // 
            // tsBtnSalir
            // 
            this.tsBtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnSalir.Image = global::CreditsView.Properties.Resources.door_out;
            this.tsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSalir.Name = "tsBtnSalir";
            this.tsBtnSalir.Size = new System.Drawing.Size(49, 39);
            this.tsBtnSalir.Text = "Salir";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(651, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 493;
            this.label9.Text = "DNI:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(765, 266);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 22);
            this.btnBuscar.TabIndex = 492;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(686, 268);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(73, 20);
            this.txtDni.TabIndex = 491;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(10, 541);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(16, 13);
            this.lblProgress.TabIndex = 490;
            this.lblProgress.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEnvioFiles);
            this.groupBox1.Location = new System.Drawing.Point(13, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 244);
            this.groupBox1.TabIndex = 489;
            this.groupBox1.TabStop = false;
            // 
            // dgvEnvioFiles
            // 
            this.dgvEnvioFiles.BackgroundColor = System.Drawing.Color.White;
            this.dgvEnvioFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvioFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnvioFiles.Location = new System.Drawing.Point(3, 16);
            this.dgvEnvioFiles.Name = "dgvEnvioFiles";
            this.dgvEnvioFiles.Size = new System.Drawing.Size(770, 225);
            this.dgvEnvioFiles.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 16);
            this.panel2.TabIndex = 488;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(322, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 511;
            this.label3.Text = "Datos de la Operación";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblTituloEnvio);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 17);
            this.panel1.TabIndex = 487;
            // 
            // lblTituloEnvio
            // 
            this.lblTituloEnvio.AutoSize = true;
            this.lblTituloEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEnvio.ForeColor = System.Drawing.Color.White;
            this.lblTituloEnvio.Location = new System.Drawing.Point(296, 0);
            this.lblTituloEnvio.Name = "lblTituloEnvio";
            this.lblTituloEnvio.Size = new System.Drawing.Size(218, 17);
            this.lblTituloEnvio.TabIndex = 486;
            this.lblTituloEnvio.Text = "Retorno DIRREHUM Planillas";
            // 
            // btnActualizarComision
            // 
            this.btnActualizarComision.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarComision.BackgroundImage")));
            this.btnActualizarComision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarComision.Location = new System.Drawing.Point(656, 89);
            this.btnActualizarComision.Name = "btnActualizarComision";
            this.btnActualizarComision.Size = new System.Drawing.Size(24, 22);
            this.btnActualizarComision.TabIndex = 508;
            this.btnActualizarComision.UseVisualStyleBackColor = true;
            // 
            // btnActualizarIntMora
            // 
            this.btnActualizarIntMora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarIntMora.BackgroundImage")));
            this.btnActualizarIntMora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarIntMora.Location = new System.Drawing.Point(656, 65);
            this.btnActualizarIntMora.Name = "btnActualizarIntMora";
            this.btnActualizarIntMora.Size = new System.Drawing.Size(24, 22);
            this.btnActualizarIntMora.TabIndex = 507;
            this.btnActualizarIntMora.UseVisualStyleBackColor = true;
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(604, 91);
            this.txtComision.Name = "txtComision";
            this.txtComision.ReadOnly = true;
            this.txtComision.Size = new System.Drawing.Size(45, 20);
            this.txtComision.TabIndex = 506;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 505;
            this.label7.Text = "Comisión:";
            // 
            // txtIntMora
            // 
            this.txtIntMora.Location = new System.Drawing.Point(604, 65);
            this.txtIntMora.Name = "txtIntMora";
            this.txtIntMora.ReadOnly = true;
            this.txtIntMora.Size = new System.Drawing.Size(45, 20);
            this.txtIntMora.TabIndex = 504;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 503;
            this.label6.Text = "IntMora:";
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowser.BackgroundImage")));
            this.btnBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowser.Location = new System.Drawing.Point(490, 122);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(24, 20);
            this.btnBrowser.TabIndex = 502;
            this.btnBrowser.Tag = "Browser";
            this.btnBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(204, 121);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.ReadOnly = true;
            this.txtUbicacion.Size = new System.Drawing.Size(280, 20);
            this.txtUbicacion.TabIndex = 501;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 500;
            this.label4.Text = "Ubicación:";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(204, 95);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.ReadOnly = true;
            this.txtNombreArchivo.Size = new System.Drawing.Size(280, 20);
            this.txtNombreArchivo.TabIndex = 499;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 498;
            this.label2.Text = "Nombre Archivo:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(384, 68);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 497;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 496;
            this.label1.Text = "Año:";
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Location = new System.Drawing.Point(204, 67);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 495;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 494;
            this.label13.Text = "Mes:";
            // 
            // cmbSituacion
            // 
            this.cmbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacion.Location = new System.Drawing.Point(604, 120);
            this.cmbSituacion.Name = "cmbSituacion";
            this.cmbSituacion.Size = new System.Drawing.Size(76, 21);
            this.cmbSituacion.TabIndex = 510;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 509;
            this.label5.Text = "Situación:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 10);
            this.panel3.TabIndex = 512;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 513;
            this.label8.Text = "Fecha Proceso:";
            // 
            // dtpFecProc
            // 
            this.dtpFecProc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecProc.Location = new System.Drawing.Point(115, 170);
            this.dtpFecProc.Name = "dtpFecProc";
            this.dtpFecProc.Size = new System.Drawing.Size(121, 20);
            this.dtpFecProc.TabIndex = 514;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 515;
            this.label10.Text = "Entidad Bancaria:";
            // 
            // cmbFinBca
            // 
            this.cmbFinBca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinBca.Location = new System.Drawing.Point(115, 196);
            this.cmbFinBca.Name = "cmbFinBca";
            this.cmbFinBca.Size = new System.Drawing.Size(280, 21);
            this.cmbFinBca.TabIndex = 516;
            // 
            // cmbCheqOpe
            // 
            this.cmbCheqOpe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheqOpe.Location = new System.Drawing.Point(115, 223);
            this.cmbCheqOpe.Name = "cmbCheqOpe";
            this.cmbCheqOpe.Size = new System.Drawing.Size(121, 21);
            this.cmbCheqOpe.TabIndex = 518;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 517;
            this.label11.Text = "Cheque/Operación:";
            // 
            // txtCheqOpe
            // 
            this.txtCheqOpe.Location = new System.Drawing.Point(515, 224);
            this.txtCheqOpe.Name = "txtCheqOpe";
            this.txtCheqOpe.Size = new System.Drawing.Size(76, 20);
            this.txtCheqOpe.TabIndex = 520;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(398, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 519;
            this.label12.Text = "N° Cheque/Operación:";
            // 
            // txtImpTotal
            // 
            this.txtImpTotal.Location = new System.Drawing.Point(515, 196);
            this.txtImpTotal.Name = "txtImpTotal";
            this.txtImpTotal.Size = new System.Drawing.Size(76, 20);
            this.txtImpTotal.TabIndex = 522;
            this.txtImpTotal.Validated += new System.EventHandler(this.txtImpTotal_Validated);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(437, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 521;
            this.label14.Text = "Importe Total:";
            // 
            // txtImpComision
            // 
            this.txtImpComision.Location = new System.Drawing.Point(693, 196);
            this.txtImpComision.Name = "txtImpComision";
            this.txtImpComision.Size = new System.Drawing.Size(76, 20);
            this.txtImpComision.TabIndex = 524;
            this.txtImpComision.Validated += new System.EventHandler(this.txtImpComision_Validated);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(597, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 523;
            this.label15.Text = "Importe Comisión:";
            // 
            // txtImpCheque
            // 
            this.txtImpCheque.Location = new System.Drawing.Point(693, 222);
            this.txtImpCheque.Name = "txtImpCheque";
            this.txtImpCheque.ReadOnly = true;
            this.txtImpCheque.Size = new System.Drawing.Size(76, 20);
            this.txtImpCheque.TabIndex = 526;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(602, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 525;
            this.label16.Text = "Importe Cheque:";
            // 
            // frmRetornoGeneraFileMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.txtImpCheque);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtImpComision);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtImpTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCheqOpe);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbCheqOpe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbFinBca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpFecProc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmbSituacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnActualizarComision);
            this.Controls.Add(this.btnActualizarIntMora);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIntMora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRetornoGeneraFileMes";
            this.Text = "Retorno Genera File Mes";
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvioFiles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.ToolStripButton tsBtnProcesar;
        private System.Windows.Forms.ToolStripButton tsBtnExportar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEnvioFiles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloEnvio;
        private System.Windows.Forms.Button btnActualizarComision;
        private System.Windows.Forms.Button btnActualizarIntMora;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIntMora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSituacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecProc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFinBca;
        private System.Windows.Forms.ComboBox cmbCheqOpe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCheqOpe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtImpTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtImpComision;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtImpCheque;
        private System.Windows.Forms.Label label16;
    }
}