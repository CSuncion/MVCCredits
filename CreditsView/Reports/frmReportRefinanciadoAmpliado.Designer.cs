namespace CreditsView.Reports
{
    partial class frmReportRefinanciadoAmpliado
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
            this.rvRefinanciadoAmpliado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rvRefinanciadoAmpliado
            // 
            this.rvRefinanciadoAmpliado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvRefinanciadoAmpliado.LocalReport.ReportEmbeddedResource = "CreditsView.Reports.rptReportRefinanciadoAmpliado.rdlc";
            this.rvRefinanciadoAmpliado.Location = new System.Drawing.Point(0, 25);
            this.rvRefinanciadoAmpliado.Name = "rvRefinanciadoAmpliado";
            this.rvRefinanciadoAmpliado.ServerReport.BearerToken = null;
            this.rvRefinanciadoAmpliado.Size = new System.Drawing.Size(800, 425);
            this.rvRefinanciadoAmpliado.TabIndex = 0;
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSalir});
            this.tsPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(800, 25);
            this.tsPrincipal.Stretch = true;
            this.tsPrincipal.TabIndex = 4;
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
            // frmReportRefinanciadoAmpliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.rvRefinanciadoAmpliado);
            this.Controls.Add(this.tsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportRefinanciadoAmpliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refinanciado o Ampliado";
            this.Load += new System.EventHandler(this.frmReportRefinanciadoAmpliado_Load);
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvRefinanciadoAmpliado;
        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
    }
}