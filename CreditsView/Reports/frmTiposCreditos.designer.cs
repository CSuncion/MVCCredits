namespace CreditsView.Reports
{
    partial class frmTiposCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposCreditos));
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btnGenerarGrafica = new System.Windows.Forms.Button();
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
            this.tsPrincipal.Size = new System.Drawing.Size(314, 25);
            this.tsPrincipal.Stretch = true;
            this.tsPrincipal.TabIndex = 2;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CRÉDITO OTORGADOS POR TIPOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 5);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Año: ";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(124, 62);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(73, 20);
            this.txtAnio.TabIndex = 6;
            // 
            // btnGenerarGrafica
            // 
            this.btnGenerarGrafica.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarGrafica.Image")));
            this.btnGenerarGrafica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarGrafica.Location = new System.Drawing.Point(89, 88);
            this.btnGenerarGrafica.Name = "btnGenerarGrafica";
            this.btnGenerarGrafica.Size = new System.Drawing.Size(125, 33);
            this.btnGenerarGrafica.TabIndex = 3;
            this.btnGenerarGrafica.Text = "Generar Grafica";
            this.btnGenerarGrafica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarGrafica.UseVisualStyleBackColor = true;
            this.btnGenerarGrafica.Click += new System.EventHandler(this.btnGenerarGrafica_Click);
            // 
            // frmTiposCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 131);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarGrafica);
            this.Controls.Add(this.tsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTiposCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Créditos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTipoCreditos_FormClosing);
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarGrafica;
        internal System.Windows.Forms.TextBox txtAnio;
    }
}