
namespace SuperGas.Forms.modulo_Distribucion
{
    partial class FrmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracion));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.TsConfiguracion = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.CbConfiguracion = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDesactivar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnActivar = new System.Windows.Forms.ToolStripButton();
            this.DgvModels = new System.Windows.Forms.DataGridView();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LbEntity = new System.Windows.Forms.Label();
            this.LbCombo2 = new System.Windows.Forms.Label();
            this.LbCombo1 = new System.Windows.Forms.Label();
            this.CbCombo1 = new System.Windows.Forms.ComboBox();
            this.PnlFormulario = new System.Windows.Forms.Panel();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbCombo2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.TsConfiguracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvModels)).BeginInit();
            this.PnlFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(665, 25);
            this.BarraTitulo.TabIndex = 11;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Configuracion Gasolineras";
            this.label1.Visible = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(638, 2);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TsConfiguracion
            // 
            this.TsConfiguracion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsConfiguracion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.CbConfiguracion,
            this.toolStripSeparator1,
            this.BtnCargar,
            this.toolStripSeparator2,
            this.BtnEditar,
            this.toolStripSeparator4,
            this.BtnDesactivar,
            this.toolStripSeparator3,
            this.BtnActivar});
            this.TsConfiguracion.Location = new System.Drawing.Point(0, 25);
            this.TsConfiguracion.Name = "TsConfiguracion";
            this.TsConfiguracion.Size = new System.Drawing.Size(665, 25);
            this.TsConfiguracion.TabIndex = 12;
            this.TsConfiguracion.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel1.Text = "Opciones:";
            // 
            // CbConfiguracion
            // 
            this.CbConfiguracion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbConfiguracion.Name = "CbConfiguracion";
            this.CbConfiguracion.Size = new System.Drawing.Size(180, 25);
            this.CbConfiguracion.SelectedIndexChanged += new System.EventHandler(this.CbConfiguracion_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Image = global::SuperGas.Properties.Resources.Refresh_16x;
            this.BtnCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(74, 22);
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Enabled = false;
            this.BtnEditar.Image = global::SuperGas.Properties.Resources.EditDocument_16x;
            this.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(65, 22);
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.ToolTipText = "Editar";
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.Enabled = false;
            this.BtnDesactivar.Image = global::SuperGas.Properties.Resources.Close_red_16x;
            this.BtnDesactivar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(97, 22);
            this.BtnDesactivar.Text = "Desactivar";
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnActivar
            // 
            this.BtnActivar.Enabled = false;
            this.BtnActivar.Image = global::SuperGas.Properties.Resources.Checkmark_green_12x_16x;
            this.BtnActivar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(74, 22);
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.ToolTipText = "Activar";
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // DgvModels
            // 
            this.DgvModels.AllowUserToAddRows = false;
            this.DgvModels.AllowUserToDeleteRows = false;
            this.DgvModels.AllowUserToResizeRows = false;
            this.DgvModels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvModels.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DgvModels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvModels.Dock = System.Windows.Forms.DockStyle.Left;
            this.DgvModels.Location = new System.Drawing.Point(0, 50);
            this.DgvModels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvModels.Name = "DgvModels";
            this.DgvModels.ReadOnly = true;
            this.DgvModels.Size = new System.Drawing.Size(377, 280);
            this.DgvModels.TabIndex = 13;
            this.DgvModels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModels_CellClick);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Image = global::SuperGas.Properties.Resources.Close_red_16x;
            this.BtnCancelar.Location = new System.Drawing.Point(150, 225);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(108, 29);
            this.BtnCancelar.TabIndex = 34;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardar.Image = global::SuperGas.Properties.Resources.SaveStatusBar1_16x;
            this.BtnGuardar.Location = new System.Drawing.Point(36, 225);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(108, 29);
            this.BtnGuardar.TabIndex = 33;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LbEntity
            // 
            this.LbEntity.AutoSize = true;
            this.LbEntity.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEntity.ForeColor = System.Drawing.Color.Black;
            this.LbEntity.Location = new System.Drawing.Point(16, 10);
            this.LbEntity.Name = "LbEntity";
            this.LbEntity.Size = new System.Drawing.Size(65, 25);
            this.LbEntity.TabIndex = 39;
            this.LbEntity.Text = "Entity";
            this.LbEntity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbEntity.Visible = false;
            // 
            // LbCombo2
            // 
            this.LbCombo2.AutoSize = true;
            this.LbCombo2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCombo2.ForeColor = System.Drawing.Color.Black;
            this.LbCombo2.Location = new System.Drawing.Point(33, 106);
            this.LbCombo2.Name = "LbCombo2";
            this.LbCombo2.Size = new System.Drawing.Size(70, 17);
            this.LbCombo2.TabIndex = 37;
            this.LbCombo2.Text = "Combo2:";
            this.LbCombo2.Visible = false;
            // 
            // LbCombo1
            // 
            this.LbCombo1.AutoSize = true;
            this.LbCombo1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCombo1.ForeColor = System.Drawing.Color.Black;
            this.LbCombo1.Location = new System.Drawing.Point(33, 45);
            this.LbCombo1.Name = "LbCombo1";
            this.LbCombo1.Size = new System.Drawing.Size(70, 17);
            this.LbCombo1.TabIndex = 40;
            this.LbCombo1.Text = "Combo1:";
            this.LbCombo1.Visible = false;
            // 
            // CbCombo1
            // 
            this.CbCombo1.Enabled = false;
            this.CbCombo1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCombo1.FormattingEnabled = true;
            this.CbCombo1.Location = new System.Drawing.Point(36, 66);
            this.CbCombo1.Name = "CbCombo1";
            this.CbCombo1.Size = new System.Drawing.Size(228, 29);
            this.CbCombo1.TabIndex = 41;
            // 
            // PnlFormulario
            // 
            this.PnlFormulario.AutoScroll = true;
            this.PnlFormulario.Controls.Add(this.TxtCodigo);
            this.PnlFormulario.Controls.Add(this.label2);
            this.PnlFormulario.Controls.Add(this.CbCombo2);
            this.PnlFormulario.Controls.Add(this.panel1);
            this.PnlFormulario.Controls.Add(this.LbEntity);
            this.PnlFormulario.Controls.Add(this.CbCombo1);
            this.PnlFormulario.Controls.Add(this.LbCombo1);
            this.PnlFormulario.Controls.Add(this.LbCombo2);
            this.PnlFormulario.Controls.Add(this.BtnCancelar);
            this.PnlFormulario.Controls.Add(this.BtnGuardar);
            this.PnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormulario.Location = new System.Drawing.Point(377, 50);
            this.PnlFormulario.Name = "PnlFormulario";
            this.PnlFormulario.Size = new System.Drawing.Size(288, 280);
            this.PnlFormulario.TabIndex = 42;
            this.PnlFormulario.Visible = false;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(36, 192);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(228, 27);
            this.TxtCodigo.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Código:";
            // 
            // CbCombo2
            // 
            this.CbCombo2.Enabled = false;
            this.CbCombo2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCombo2.FormattingEnabled = true;
            this.CbCombo2.Location = new System.Drawing.Point(36, 130);
            this.CbCombo2.Name = "CbCombo2";
            this.CbCombo2.Size = new System.Drawing.Size(228, 29);
            this.CbCombo2.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(274, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 100);
            this.panel1.TabIndex = 42;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(377, 50);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 280);
            this.splitter1.TabIndex = 43;
            this.splitter1.TabStop = false;
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 330);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PnlFormulario);
            this.Controls.Add(this.DgvModels);
            this.Controls.Add(this.TsConfiguracion);
            this.Controls.Add(this.BarraTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfiguracion";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.TsConfiguracion.ResumeLayout(false);
            this.TsConfiguracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvModels)).EndInit();
            this.PnlFormulario.ResumeLayout(false);
            this.PnlFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.ToolStrip TsConfiguracion;
        private System.Windows.Forms.DataGridView DgvModels;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox CbConfiguracion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnDesactivar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LbEntity;
        private System.Windows.Forms.Label LbCombo2;
        private System.Windows.Forms.Label LbCombo1;
        private System.Windows.Forms.ComboBox CbCombo1;
        private System.Windows.Forms.ToolStripButton BtnCargar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel PnlFormulario;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton BtnActivar;
        private System.Windows.Forms.ComboBox CbCombo2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}