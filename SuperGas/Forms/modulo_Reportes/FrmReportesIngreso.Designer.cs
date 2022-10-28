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
            this.RVIngresos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RVIngresos
            // 
            this.RVIngresos.AutoScroll = true;
            this.RVIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RVIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RVIngresos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RVIngresos.LocalReport.ReportEmbeddedResource = "SuperGas.Reports.modulo_ventas.Ingresos.rdlc";
            this.RVIngresos.Location = new System.Drawing.Point(0, 0);
            this.RVIngresos.Name = "RVIngresos";
            this.RVIngresos.ServerReport.BearerToken = null;
            this.RVIngresos.Size = new System.Drawing.Size(1048, 588);
            this.RVIngresos.TabIndex = 13;
            // 
            // FrmReportesIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 588);
            this.Controls.Add(this.RVIngresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportesIngreso";
            this.Text = "FrmReportesIngreso";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVIngresos;
    }
}