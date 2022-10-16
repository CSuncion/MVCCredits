namespace CreditsView.Credits
{
    partial class frmCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditos));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtApeNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.gbImpNoAdeu = new System.Windows.Forms.GroupBox();
            this.dgvCreditos = new System.Windows.Forms.DataGridView();
            this.lblMensajeAdeuda = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNuevoCredito = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnAmpliar = new System.Windows.Forms.Button();
            this.btnRefinanciar = new System.Windows.Forms.Button();
            this.tsPrincipal.SuspendLayout();
            this.gbImpNoAdeu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(289, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(22, 22);
            this.btnBuscar.TabIndex = 455;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(148, 103);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.ReadOnly = true;
            this.txtGrado.Size = new System.Drawing.Size(135, 20);
            this.txtGrado.TabIndex = 454;
            // 
            // txtApeNom
            // 
            this.txtApeNom.Location = new System.Drawing.Point(428, 77);
            this.txtApeNom.Name = "txtApeNom";
            this.txtApeNom.ReadOnly = true;
            this.txtApeNom.Size = new System.Drawing.Size(316, 20);
            this.txtApeNom.TabIndex = 453;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 452;
            this.label2.Text = "Grado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 451;
            this.label1.Text = "Apellidos y Nombres:";
            // 
            // txtDocId
            // 
            this.txtDocId.Location = new System.Drawing.Point(148, 77);
            this.txtDocId.MaxLength = 8;
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.Size = new System.Drawing.Size(135, 20);
            this.txtDocId.TabIndex = 450;
            this.txtDocId.Validating += new System.ComponentModel.CancelEventHandler(this.txtDocId_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 13);
            this.label13.TabIndex = 449;
            this.label13.Text = "Documento de Identidad:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 10);
            this.panel1.TabIndex = 448;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 447;
            this.label3.Text = "DATOS DE SOLICITANTE";
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSalir});
            this.tsPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(758, 25);
            this.tsPrincipal.Stretch = true;
            this.tsPrincipal.TabIndex = 446;
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
            // gbImpNoAdeu
            // 
            this.gbImpNoAdeu.Controls.Add(this.dgvCreditos);
            this.gbImpNoAdeu.Location = new System.Drawing.Point(12, 165);
            this.gbImpNoAdeu.Name = "gbImpNoAdeu";
            this.gbImpNoAdeu.Size = new System.Drawing.Size(632, 201);
            this.gbImpNoAdeu.TabIndex = 457;
            this.gbImpNoAdeu.TabStop = false;
            // 
            // dgvCreditos
            // 
            this.dgvCreditos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCreditos.Location = new System.Drawing.Point(3, 16);
            this.dgvCreditos.Name = "dgvCreditos";
            this.dgvCreditos.Size = new System.Drawing.Size(626, 182);
            this.dgvCreditos.TabIndex = 0;
            this.dgvCreditos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreditos_CellContentClick);
            // 
            // lblMensajeAdeuda
            // 
            this.lblMensajeAdeuda.AutoSize = true;
            this.lblMensajeAdeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeAdeuda.Location = new System.Drawing.Point(12, 145);
            this.lblMensajeAdeuda.Name = "lblMensajeAdeuda";
            this.lblMensajeAdeuda.Size = new System.Drawing.Size(78, 17);
            this.lblMensajeAdeuda.TabIndex = 444;
            this.lblMensajeAdeuda.Text = "CRÉDITOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 10);
            this.panel2.TabIndex = 456;
            // 
            // btnNuevoCredito
            // 
            this.btnNuevoCredito.Enabled = false;
            this.btnNuevoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCredito.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCredito.Image")));
            this.btnNuevoCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCredito.Location = new System.Drawing.Point(650, 181);
            this.btnNuevoCredito.Name = "btnNuevoCredito";
            this.btnNuevoCredito.Size = new System.Drawing.Size(94, 38);
            this.btnNuevoCredito.TabIndex = 458;
            this.btnNuevoCredito.Text = "Nuevo";
            this.btnNuevoCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoCredito.UseVisualStyleBackColor = true;
            this.btnNuevoCredito.Click += new System.EventHandler(this.btnNuevoCredito_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCobrar.Enabled = false;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCobrar.Image")));
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.Location = new System.Drawing.Point(650, 225);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(94, 38);
            this.btnCobrar.TabIndex = 459;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCobrar.UseVisualStyleBackColor = true;
            // 
            // btnAmpliar
            // 
            this.btnAmpliar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAmpliar.Enabled = false;
            this.btnAmpliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmpliar.Image = ((System.Drawing.Image)(resources.GetObject("btnAmpliar.Image")));
            this.btnAmpliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAmpliar.Location = new System.Drawing.Point(650, 269);
            this.btnAmpliar.Name = "btnAmpliar";
            this.btnAmpliar.Size = new System.Drawing.Size(94, 38);
            this.btnAmpliar.TabIndex = 460;
            this.btnAmpliar.Text = "Ampliar";
            this.btnAmpliar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAmpliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAmpliar.UseVisualStyleBackColor = true;
            // 
            // btnRefinanciar
            // 
            this.btnRefinanciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefinanciar.Enabled = false;
            this.btnRefinanciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefinanciar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefinanciar.Image")));
            this.btnRefinanciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefinanciar.Location = new System.Drawing.Point(650, 313);
            this.btnRefinanciar.Name = "btnRefinanciar";
            this.btnRefinanciar.Size = new System.Drawing.Size(94, 38);
            this.btnRefinanciar.TabIndex = 461;
            this.btnRefinanciar.Text = "Refin.";
            this.btnRefinanciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefinanciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefinanciar.UseVisualStyleBackColor = true;
            // 
            // frmCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 378);
            this.Controls.Add(this.btnRefinanciar);
            this.Controls.Add(this.btnAmpliar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnNuevoCredito);
            this.Controls.Add(this.lblMensajeAdeuda);
            this.Controls.Add(this.gbImpNoAdeu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.txtApeNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreditos";
            this.Text = "Créditos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreditos_FormClosing);
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.gbImpNoAdeu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtGrado;
        internal System.Windows.Forms.TextBox txtApeNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.GroupBox gbImpNoAdeu;
        private System.Windows.Forms.DataGridView dgvCreditos;
        private System.Windows.Forms.Label lblMensajeAdeuda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnAmpliar;
        private System.Windows.Forms.Button btnRefinanciar;
        private System.Windows.Forms.Button btnNuevoCredito;
    }
}