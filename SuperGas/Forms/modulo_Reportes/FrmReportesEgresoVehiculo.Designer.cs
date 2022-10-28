namespace SuperGas.Forms.modulo_Reportes
{
    partial class FrmReportesEgreso
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
            this.RVEgresoVehiculo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RVEgresoVehiculo
            // 
            this.RVEgresoVehiculo.AutoScroll = true;
            this.RVEgresoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RVEgresoVehiculo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RVEgresoVehiculo.LocalReport.ReportEmbeddedResource = "SuperGas.Reports.modulo_ventas.Ingresos.rdlc";
            this.RVEgresoVehiculo.Location = new System.Drawing.Point(0, 0);
            this.RVEgresoVehiculo.Name = "RVEgresoVehiculo";
            this.RVEgresoVehiculo.ServerReport.BearerToken = null;
            this.RVEgresoVehiculo.Size = new System.Drawing.Size(1064, 627);
            this.RVEgresoVehiculo.TabIndex = 13;
            // 
            // FrmReportesEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 627);
            this.Controls.Add(this.RVEgresoVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportesEgreso";
            this.Text = "FrmReportesEgreso";
            this.Load += new System.EventHandler(this.FrmReportesEgreso_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVEgresoVehiculo;
    }
}