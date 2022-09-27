namespace CreditsView.Credits
{
    partial class frmConstanciaNoAdeudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConstanciaNoAdeudo));
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApeNom = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.btnImpConsNoAdeu = new System.Windows.Forms.Button();
            this.lblMensajeAdeuda = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbImpNoAdeu = new System.Windows.Forms.GroupBox();
            this.tsPrincipal.SuspendLayout();
            this.gbImpNoAdeu.SuspendLayout();
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
            this.tsPrincipal.Size = new System.Drawing.Size(399, 25);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 10);
            this.panel1.TabIndex = 436;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 435;
            this.label3.Text = "CONSTANCIA DE NO ADEUDO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 13);
            this.label13.TabIndex = 437;
            this.label13.Text = "Documento de Identidad:";
            // 
            // txtDocId
            // 
            this.txtDocId.Location = new System.Drawing.Point(145, 69);
            this.txtDocId.MaxLength = 8;
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.Size = new System.Drawing.Size(135, 20);
            this.txtDocId.TabIndex = 438;
            this.txtDocId.Validating += new System.ComponentModel.CancelEventHandler(this.txtDocId_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 439;
            this.label1.Text = "Apellidos y Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 440;
            this.label2.Text = "Grado:";
            // 
            // txtApeNom
            // 
            this.txtApeNom.Location = new System.Drawing.Point(145, 95);
            this.txtApeNom.Name = "txtApeNom";
            this.txtApeNom.ReadOnly = true;
            this.txtApeNom.Size = new System.Drawing.Size(242, 20);
            this.txtApeNom.TabIndex = 441;
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(145, 121);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.ReadOnly = true;
            this.txtGrado.Size = new System.Drawing.Size(135, 20);
            this.txtGrado.TabIndex = 442;
            // 
            // btnImpConsNoAdeu
            // 
            this.btnImpConsNoAdeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImpConsNoAdeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpConsNoAdeu.Image = ((System.Drawing.Image)(resources.GetObject("btnImpConsNoAdeu.Image")));
            this.btnImpConsNoAdeu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpConsNoAdeu.Location = new System.Drawing.Point(25, 46);
            this.btnImpConsNoAdeu.Name = "btnImpConsNoAdeu";
            this.btnImpConsNoAdeu.Size = new System.Drawing.Size(282, 50);
            this.btnImpConsNoAdeu.TabIndex = 443;
            this.btnImpConsNoAdeu.Text = "IMPRIMIR CONSTANCIA NO ADEUDO";
            this.btnImpConsNoAdeu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpConsNoAdeu.UseVisualStyleBackColor = true;
            this.btnImpConsNoAdeu.Click += new System.EventHandler(this.btnImpConsNoAdeu_Click);
            // 
            // lblMensajeAdeuda
            // 
            this.lblMensajeAdeuda.AutoSize = true;
            this.lblMensajeAdeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeAdeuda.Location = new System.Drawing.Point(22, 26);
            this.lblMensajeAdeuda.Name = "lblMensajeAdeuda";
            this.lblMensajeAdeuda.Size = new System.Drawing.Size(86, 17);
            this.lblMensajeAdeuda.TabIndex = 444;
            this.lblMensajeAdeuda.Text = "FONBIEPOL";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(286, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(22, 22);
            this.btnBuscar.TabIndex = 445;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(0, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 10);
            this.panel2.TabIndex = 437;
            // 
            // gbImpNoAdeu
            // 
            this.gbImpNoAdeu.Controls.Add(this.lblMensajeAdeuda);
            this.gbImpNoAdeu.Controls.Add(this.btnImpConsNoAdeu);
            this.gbImpNoAdeu.Location = new System.Drawing.Point(12, 163);
            this.gbImpNoAdeu.Name = "gbImpNoAdeu";
            this.gbImpNoAdeu.Size = new System.Drawing.Size(375, 102);
            this.gbImpNoAdeu.TabIndex = 446;
            this.gbImpNoAdeu.TabStop = false;
            this.gbImpNoAdeu.Visible = false;
            // 
            // frmConstanciaNoAdeudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 277);
            this.ControlBox = false;
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
            this.Name = "frmConstanciaNoAdeudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constancia No Adeudo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConstanciaNoAdeudo_FormClosing);
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.gbImpNoAdeu.ResumeLayout(false);
            this.gbImpNoAdeu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApeNom;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.Button btnImpConsNoAdeu;
        private System.Windows.Forms.Label lblMensajeAdeuda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbImpNoAdeu;
    }
}