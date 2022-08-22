namespace CreditsView.Reports
{
    partial class frmReports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.chrCuotas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsTxtBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrCuotas)).BeginInit();
            this.tsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReports
            // 
            this.dgvReports.AllowDrop = true;
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvReports.Location = new System.Drawing.Point(0, 25);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.Size = new System.Drawing.Size(668, 189);
            this.dgvReports.TabIndex = 1;
            this.dgvReports.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReports_ColumnHeaderMouseClick);
            // 
            // chrCuotas
            // 
            chartArea1.Name = "ChartArea1";
            this.chrCuotas.ChartAreas.Add(chartArea1);
            this.chrCuotas.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chrCuotas.Legends.Add(legend1);
            this.chrCuotas.Location = new System.Drawing.Point(0, 214);
            this.chrCuotas.Name = "chrCuotas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Capital";
            this.chrCuotas.Series.Add(series1);
            this.chrCuotas.Size = new System.Drawing.Size(668, 225);
            this.chrCuotas.TabIndex = 1;
            this.chrCuotas.Text = "chart1";
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTxtBusqueda,
            this.toolStripLabel1,
            this.tsBtnSalir});
            this.tsPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(668, 25);
            this.tsPrincipal.Stretch = true;
            this.tsPrincipal.TabIndex = 0;
            // 
            // tsTxtBusqueda
            // 
            this.tsTxtBusqueda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsTxtBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxtBusqueda.Name = "tsTxtBusqueda";
            this.tsTxtBusqueda.Size = new System.Drawing.Size(220, 25);
            this.tsTxtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tsTxtBusqueda_KeyUp);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = global::CreditosView.Properties.Resources._16__Filter_;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            // 
            // tsBtnSalir
            // 
            this.tsBtnSalir.Image = global::CreditosView.Properties.Resources.door_out;
            this.tsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSalir.Name = "tsBtnSalir";
            this.tsBtnSalir.Size = new System.Drawing.Size(49, 22);
            this.tsBtnSalir.Text = "Salir";
            this.tsBtnSalir.Click += new System.EventHandler(this.tsBtnSalir_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 448);
            this.Controls.Add(this.chrCuotas);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.tsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Reportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReports_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrCuotas)).EndInit();
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrCuotas;
        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tsTxtBusqueda;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
    }
}