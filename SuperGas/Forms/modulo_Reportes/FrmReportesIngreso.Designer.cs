namespace SuperGas.Forms.modulo_Reportes
{
    partial class FrmReportesIngreso
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RVIngresoCombustible = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MapaEntradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MapaEntradasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RVIngresoCombustible
            // 
            this.RVIngresoCombustible.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetIngresoCombustible";
            reportDataSource1.Value = this.MapaEntradasBindingSource;
            this.RVIngresoCombustible.LocalReport.DataSources.Add(reportDataSource1);
            this.RVIngresoCombustible.LocalReport.ReportEmbeddedResource = "SuperGas.Reports.modulo_ventas.IngresosCombustible.rdlc";
            this.RVIngresoCombustible.Location = new System.Drawing.Point(0, 0);
            this.RVIngresoCombustible.Name = "RVIngresoCombustible";
            this.RVIngresoCombustible.ServerReport.BearerToken = null;
            this.RVIngresoCombustible.Size = new System.Drawing.Size(1048, 588);
            this.RVIngresoCombustible.TabIndex = 0;
            // 
            // MapaEntradasBindingSource
            // 
            this.MapaEntradasBindingSource.DataSource = typeof(Data.Mapas.Entradas.MapaEntradas);
            // 
            // FrmReportesIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 588);
            this.Controls.Add(this.RVIngresoCombustible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportesIngreso";
            this.Text = "FrmReportesIngreso";
            this.Load += new System.EventHandler(this.FrmReportesIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MapaEntradasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVIngresoCombustible;
        private System.Windows.Forms.BindingSource MapaEntradasBindingSource;
    }
}