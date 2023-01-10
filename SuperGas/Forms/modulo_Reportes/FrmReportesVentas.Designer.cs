namespace SuperGas.Forms.modulo_Reportes
{
    partial class FrmReportesVentas
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
            this.RVVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RVVentas
            // 
            this.RVVentas.AutoScroll = true;
            this.RVVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RVVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RVVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RVVentas.LocalReport.ReportEmbeddedResource = "SuperGas.Reports.modulo_ventas.Ventas.rdlc";
            this.RVVentas.Location = new System.Drawing.Point(0, 0);
            this.RVVentas.Name = "RVVentas";
            this.RVVentas.ServerReport.BearerToken = null;
            this.RVVentas.Size = new System.Drawing.Size(1064, 627);
            this.RVVentas.TabIndex = 12;
            // 
            // FrmReportesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 627);
            this.Controls.Add(this.RVVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportesVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmReportesIngresos";
            this.Load += new System.EventHandler(this.FrmReportesIngresos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer RVVentas;
    }
}