namespace SuperGas.Forms.modulo_Distribucion
{
    partial class FrmDistribucion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDistribucion));
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.DgvRegistros = new System.Windows.Forms.DataGridView();
            this.TsLimpieza = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TxtBuscador = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDespachosBomba = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDespachoVehiculo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnConfiguracion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.PnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistros)).BeginInit();
            this.TsLimpieza.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Controls.Add(this.DgvRegistros);
            this.PnlPrincipal.Controls.Add(this.TsLimpieza);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(1080, 627);
            this.PnlPrincipal.TabIndex = 7;
            // 
            // DgvRegistros
            // 
            this.DgvRegistros.AllowUserToAddRows = false;
            this.DgvRegistros.AllowUserToDeleteRows = false;
            this.DgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvRegistros.BackgroundColor = System.Drawing.Color.LightGray;
            this.DgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRegistros.Location = new System.Drawing.Point(0, 27);
            this.DgvRegistros.Name = "DgvRegistros";
            this.DgvRegistros.ReadOnly = true;
            this.DgvRegistros.Size = new System.Drawing.Size(1080, 600);
            this.DgvRegistros.TabIndex = 38;
            // 
            // TsLimpieza
            // 
            this.TsLimpieza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsLimpieza.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripSeparator7,
            this.toolStripLabel1,
            this.TxtBuscador,
            this.toolStripSeparator5,
            this.BtnDespachosBomba,
            this.toolStripSeparator6,
            this.BtnDespachoVehiculo,
            this.toolStripSeparator2,
            this.BtnNuevo,
            this.toolStripSeparator1,
            this.BtnConfiguracion,
            this.toolStripSeparator4});
            this.TsLimpieza.Location = new System.Drawing.Point(0, 0);
            this.TsLimpieza.Name = "TsLimpieza";
            this.TsLimpieza.Size = new System.Drawing.Size(1080, 27);
            this.TsLimpieza.TabIndex = 29;
            this.TsLimpieza.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(178, 24);
            this.toolStripLabel2.Text = "Gestión de Distribución";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = global::SuperGas.Properties.Resources.Search_16x;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 24);
            this.toolStripLabel1.Text = "Buscador";
            // 
            // TxtBuscador
            // 
            this.TxtBuscador.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscador.Name = "TxtBuscador";
            this.TxtBuscador.Size = new System.Drawing.Size(200, 27);
            this.TxtBuscador.TextChanged += new System.EventHandler(this.TxtBuscador_TextChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnDespachosBomba
            // 
            this.BtnDespachosBomba.Image = global::SuperGas.Properties.Resources.OrderDown_16x;
            this.BtnDespachosBomba.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDespachosBomba.Name = "BtnDespachosBomba";
            this.BtnDespachosBomba.Size = new System.Drawing.Size(191, 24);
            this.BtnDespachosBomba.Text = "Despachos de Bomba";
            this.BtnDespachosBomba.Click += new System.EventHandler(this.BtnDespachosBomba_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnDespachoVehiculo
            // 
            this.BtnDespachoVehiculo.Image = global::SuperGas.Properties.Resources.OrderUp_16x;
            this.BtnDespachoVehiculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDespachoVehiculo.Name = "BtnDespachoVehiculo";
            this.BtnDespachoVehiculo.Size = new System.Drawing.Size(210, 24);
            this.BtnDespachoVehiculo.Text = "Despachos de Vehiculos";
            this.BtnDespachoVehiculo.Click += new System.EventHandler(this.BtnDespachoVehiculo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Image = global::SuperGas.Properties.Resources.Add_16x;
            this.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(79, 24);
            this.BtnNuevo.Text = "Nueva";
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfiguracion.Image")));
            this.BtnConfiguracion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(134, 24);
            this.BtnConfiguracion.Text = "Configuración";
            this.BtnConfiguracion.Click += new System.EventHandler(this.BtnConfiguracion_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // FrmDistribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 627);
            this.Controls.Add(this.PnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDistribucion";
            this.Text = "FrmDistribucion";
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistros)).EndInit();
            this.TsLimpieza.ResumeLayout(false);
            this.TsLimpieza.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.DataGridView DgvRegistros;
        private System.Windows.Forms.ToolStrip TsLimpieza;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TxtBuscador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BtnDespachosBomba;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BtnConfiguracion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton BtnDespachoVehiculo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}