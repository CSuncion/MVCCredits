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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMensajeAdeuda = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNuevoCredito = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnAmpliar = new System.Windows.Forms.Button();
            this.btnRefinanciar = new System.Windows.Forms.Button();
            this.tsPrincipal.SuspendLayout();
            this.gbImpNoAdeu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.txtGrado.Location = new System.Drawing.Point(148, 129);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.ReadOnly = true;
            this.txtGrado.Size = new System.Drawing.Size(135, 20);
            this.txtGrado.TabIndex = 454;
            // 
            // txtApeNom
            // 
            this.txtApeNom.Location = new System.Drawing.Point(148, 103);
            this.txtApeNom.Name = "txtApeNom";
            this.txtApeNom.ReadOnly = true;
            this.txtApeNom.Size = new System.Drawing.Size(242, 20);
            this.txtApeNom.TabIndex = 453;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 452;
            this.label2.Text = "Grado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 106);
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
            this.panel1.Size = new System.Drawing.Size(438, 10);
            this.panel1.TabIndex = 448;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
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
            this.tsPrincipal.Size = new System.Drawing.Size(438, 25);
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
            this.gbImpNoAdeu.Controls.Add(this.dataGridView1);
            this.gbImpNoAdeu.Location = new System.Drawing.Point(15, 192);
            this.gbImpNoAdeu.Name = "gbImpNoAdeu";
            this.gbImpNoAdeu.Size = new System.Drawing.Size(375, 124);
            this.gbImpNoAdeu.TabIndex = 457;
            this.gbImpNoAdeu.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 105);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblMensajeAdeuda
            // 
            this.lblMensajeAdeuda.AutoSize = true;
            this.lblMensajeAdeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeAdeuda.Location = new System.Drawing.Point(12, 172);
            this.lblMensajeAdeuda.Name = "lblMensajeAdeuda";
            this.lblMensajeAdeuda.Size = new System.Drawing.Size(78, 17);
            this.lblMensajeAdeuda.TabIndex = 444;
            this.lblMensajeAdeuda.Text = "CRÉDITOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 10);
            this.panel2.TabIndex = 456;
            // 
            // btnNuevoCredito
            // 
            this.btnNuevoCredito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoCredito.BackgroundImage")));
            this.btnNuevoCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevoCredito.Location = new System.Drawing.Point(397, 208);
            this.btnNuevoCredito.Name = "btnNuevoCredito";
            this.btnNuevoCredito.Size = new System.Drawing.Size(33, 23);
            this.btnNuevoCredito.TabIndex = 458;
            this.btnNuevoCredito.UseVisualStyleBackColor = true;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCobrar.BackgroundImage")));
            this.btnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCobrar.Location = new System.Drawing.Point(397, 237);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(33, 23);
            this.btnCobrar.TabIndex = 459;
            this.btnCobrar.UseVisualStyleBackColor = true;
            // 
            // btnAmpliar
            // 
            this.btnAmpliar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAmpliar.BackgroundImage")));
            this.btnAmpliar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAmpliar.Location = new System.Drawing.Point(397, 266);
            this.btnAmpliar.Name = "btnAmpliar";
            this.btnAmpliar.Size = new System.Drawing.Size(33, 23);
            this.btnAmpliar.TabIndex = 460;
            this.btnAmpliar.UseVisualStyleBackColor = true;
            // 
            // btnRefinanciar
            // 
            this.btnRefinanciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefinanciar.BackgroundImage")));
            this.btnRefinanciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefinanciar.Location = new System.Drawing.Point(396, 295);
            this.btnRefinanciar.Name = "btnRefinanciar";
            this.btnRefinanciar.Size = new System.Drawing.Size(33, 23);
            this.btnRefinanciar.TabIndex = 461;
            this.btnRefinanciar.UseVisualStyleBackColor = true;
            // 
            // frmCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 339);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMensajeAdeuda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNuevoCredito;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnAmpliar;
        private System.Windows.Forms.Button btnRefinanciar;
    }
}