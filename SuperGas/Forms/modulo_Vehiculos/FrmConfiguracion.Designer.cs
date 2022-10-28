
namespace SuperGas.Forms.modulo_Vehiculos
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
            this.components = new System.ComponentModel.Container();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapaEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LbEntity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LbPadre = new System.Windows.Forms.Label();
            this.CbPadre = new System.Windows.Forms.ComboBox();
            this.PnlFormulario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.TsConfiguracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapaEntityBindingSource)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Configuracion Vehiculos";
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
            this.DgvModels.AutoGenerateColumns = false;
            this.DgvModels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvModels.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DgvModels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.DgvModels.DataSource = this.mapaEntityBindingSource;
            this.DgvModels.Dock = System.Windows.Forms.DockStyle.Left;
            this.DgvModels.Location = new System.Drawing.Point(0, 50);
            this.DgvModels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvModels.Name = "DgvModels";
            this.DgvModels.ReadOnly = true;
            this.DgvModels.Size = new System.Drawing.Size(377, 280);
            this.DgvModels.TabIndex = 13;
            this.DgvModels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModels_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 44;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PadreId";
            this.dataGridViewTextBoxColumn2.HeaderText = "PadreId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 79;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Padre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Padre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 68;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 104;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn5.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 73;
            // 
            // mapaEntityBindingSource
            // 
            this.mapaEntityBindingSource.DataSource = typeof(Data.Mapas._helpers.MapaEntity);
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
            this.BtnCancelar.Location = new System.Drawing.Point(150, 173);
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
            this.BtnGuardar.Location = new System.Drawing.Point(36, 173);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Descripción:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(36, 129);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(228, 27);
            this.TxtDescripcion.TabIndex = 38;
            // 
            // LbPadre
            // 
            this.LbPadre.AutoSize = true;
            this.LbPadre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPadre.ForeColor = System.Drawing.Color.Black;
            this.LbPadre.Location = new System.Drawing.Point(33, 45);
            this.LbPadre.Name = "LbPadre";
            this.LbPadre.Size = new System.Drawing.Size(79, 17);
            this.LbPadre.TabIndex = 40;
            this.LbPadre.Text = "Categoria:";
            this.LbPadre.Visible = false;
            // 
            // CbPadre
            // 
            this.CbPadre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPadre.FormattingEnabled = true;
            this.CbPadre.Location = new System.Drawing.Point(36, 66);
            this.CbPadre.Name = "CbPadre";
            this.CbPadre.Size = new System.Drawing.Size(228, 29);
            this.CbPadre.TabIndex = 41;
            this.CbPadre.Visible = false;
            // 
            // PnlFormulario
            // 
            this.PnlFormulario.AutoScroll = true;
            this.PnlFormulario.Controls.Add(this.panel1);
            this.PnlFormulario.Controls.Add(this.LbEntity);
            this.PnlFormulario.Controls.Add(this.CbPadre);
            this.PnlFormulario.Controls.Add(this.TxtDescripcion);
            this.PnlFormulario.Controls.Add(this.LbPadre);
            this.PnlFormulario.Controls.Add(this.label5);
            this.PnlFormulario.Controls.Add(this.BtnCancelar);
            this.PnlFormulario.Controls.Add(this.BtnGuardar);
            this.PnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormulario.Location = new System.Drawing.Point(377, 50);
            this.PnlFormulario.Name = "PnlFormulario";
            this.PnlFormulario.Size = new System.Drawing.Size(288, 280);
            this.PnlFormulario.TabIndex = 42;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.mapaEntityBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LbPadre;
        private System.Windows.Forms.ComboBox CbPadre;
        private System.Windows.Forms.ToolStripButton BtnCargar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel PnlFormulario;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource mapaEntityBindingSource;
        private System.Windows.Forms.ToolStripButton BtnActivar;
    }
}