namespace SuperGas.Forms.modulo_Reportes
{
    partial class FrmReportesEgresoVehiculo
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
            this.RVEgresoBomba = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RVEgresoBomba
            // 
            this.RVEgresoBomba.AutoScroll = true;
            this.RVEgresoBomba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RVEgresoBomba.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RVEgresoBomba.LocalReport.ReportEmbeddedResource = "SuperGas.Reports.modulo_ventas.EgresosDespachoBomba.rdlc";
            this.RVEgresoBomba.Location = new System.Drawing.Point(0, 0);
            this.RVEgresoBomba.Name = "RVEgresoBomba";
            this.RVEgresoBomba.ServerReport.BearerToken = null;
            this.RVEgresoBomba.Size = new System.Drawing.Size(1064, 627);
            this.RVEgresoBomba.TabIndex = 13;
            // 
            // FrmReportesEgresoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 627);
            this.Controls.Add(this.RVEgresoBomba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportesEgresoVehiculo";
            this.Text = "FrmReportesEgreso";
            this.Load += new System.EventHandler(this.FrmReportesEgresoVehiculo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVEgresoBomba;
    }
}