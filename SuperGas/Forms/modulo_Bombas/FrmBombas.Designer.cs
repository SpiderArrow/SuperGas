namespace SuperGas.Forms.modulo_Bombas
{
    partial class FrmBombas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBombas));
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.DgvRegistros = new System.Windows.Forms.DataGridView();
            this.TsUsuarios = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TxtBuscador = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnConfiguracion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PnlFormulario = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGlTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtGlDespachado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtGlActuales = new System.Windows.Forms.TextBox();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.CbTipoCombustible = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistros)).BeginInit();
            this.TsUsuarios.SuspendLayout();
            this.PnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Controls.Add(this.DgvRegistros);
            this.PnlPrincipal.Controls.Add(this.TsUsuarios);
            this.PnlPrincipal.Controls.Add(this.splitter1);
            this.PnlPrincipal.Controls.Add(this.PnlFormulario);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(1069, 627);
            this.PnlPrincipal.TabIndex = 8;
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
            this.DgvRegistros.Location = new System.Drawing.Point(0, 349);
            this.DgvRegistros.Name = "DgvRegistros";
            this.DgvRegistros.ReadOnly = true;
            this.DgvRegistros.Size = new System.Drawing.Size(1069, 278);
            this.DgvRegistros.TabIndex = 43;
            // 
            // TsUsuarios
            // 
            this.TsUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.TxtBuscador,
            this.toolStripSeparator5,
            this.BtnCargar,
            this.toolStripSeparator6,
            this.BtnEditar,
            this.toolStripSeparator2,
            this.BtnEliminar,
            this.toolStripSeparator3,
            this.BtnConfiguracion,
            this.toolStripSeparator4});
            this.TsUsuarios.Location = new System.Drawing.Point(0, 322);
            this.TsUsuarios.Name = "TsUsuarios";
            this.TsUsuarios.Size = new System.Drawing.Size(1069, 27);
            this.TsUsuarios.TabIndex = 29;
            this.TsUsuarios.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = global::SuperGas.Properties.Resources.Search_16x;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(94, 24);
            this.toolStripLabel1.Text = "Buscador";
            // 
            // TxtBuscador
            // 
            this.TxtBuscador.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscador.Name = "TxtBuscador";
            this.TxtBuscador.Size = new System.Drawing.Size(250, 27);
            this.TxtBuscador.TextChanged += new System.EventHandler(this.TxtBuscador_TextChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Image = global::SuperGas.Properties.Resources.Refresh_16x;
            this.BtnCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(149, 24);
            this.BtnCargar.Text = "Cargar Registros";
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Image = global::SuperGas.Properties.Resources.EditDocument_16x;
            this.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(70, 24);
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.ToolTipText = "Editar";
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Image = global::SuperGas.Properties.Resources.Close_red_16x;
            this.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(83, 24);
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.ToolTipText = "Eliminar";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
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
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 319);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1069, 3);
            this.splitter1.TabIndex = 42;
            this.splitter1.TabStop = false;
            // 
            // PnlFormulario
            // 
            this.PnlFormulario.AutoScroll = true;
            this.PnlFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.PnlFormulario.Controls.Add(this.label4);
            this.PnlFormulario.Controls.Add(this.TxtGlTotal);
            this.PnlFormulario.Controls.Add(this.label7);
            this.PnlFormulario.Controls.Add(this.TxtGlDespachado);
            this.PnlFormulario.Controls.Add(this.label5);
            this.PnlFormulario.Controls.Add(this.TxtGlActuales);
            this.PnlFormulario.Controls.Add(this.TxtObservaciones);
            this.PnlFormulario.Controls.Add(this.CbTipoCombustible);
            this.PnlFormulario.Controls.Add(this.label1);
            this.PnlFormulario.Controls.Add(this.label12);
            this.PnlFormulario.Controls.Add(this.TxtDescripcion);
            this.PnlFormulario.Controls.Add(this.label15);
            this.PnlFormulario.Controls.Add(this.BtnCancelar);
            this.PnlFormulario.Controls.Add(this.BtnGuardar);
            this.PnlFormulario.Controls.Add(this.pictureBox1);
            this.PnlFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.PnlFormulario.Name = "PnlFormulario";
            this.PnlFormulario.Size = new System.Drawing.Size(1069, 319);
            this.PnlFormulario.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(73, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 159;
            this.label4.Text = "Galones Totales:";
            // 
            // TxtGlTotal
            // 
            this.TxtGlTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGlTotal.Location = new System.Drawing.Point(77, 139);
            this.TxtGlTotal.Name = "TxtGlTotal";
            this.TxtGlTotal.Size = new System.Drawing.Size(315, 26);
            this.TxtGlTotal.TabIndex = 160;
            this.TxtGlTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtGlTotal.TextChanged += new System.EventHandler(this.TxtGlTotal_TextChanged);
            this.TxtGlTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDecimal_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(73, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 21);
            this.label7.TabIndex = 155;
            this.label7.Text = "Galones Despachados:";
            // 
            // TxtGlDespachado
            // 
            this.TxtGlDespachado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGlDespachado.Location = new System.Drawing.Point(77, 212);
            this.TxtGlDespachado.Name = "TxtGlDespachado";
            this.TxtGlDespachado.Size = new System.Drawing.Size(314, 26);
            this.TxtGlDespachado.TabIndex = 158;
            this.TxtGlDespachado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtGlDespachado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDecimal_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(403, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 151;
            this.label5.Text = "Galones Actuales:";
            // 
            // TxtGlActuales
            // 
            this.TxtGlActuales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGlActuales.Location = new System.Drawing.Point(407, 139);
            this.TxtGlActuales.Name = "TxtGlActuales";
            this.TxtGlActuales.Size = new System.Drawing.Size(314, 26);
            this.TxtGlActuales.TabIndex = 154;
            this.TxtGlActuales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtGlActuales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDecimal_KeyPress);
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(737, 58);
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(315, 204);
            this.TxtObservaciones.TabIndex = 150;
            // 
            // CbTipoCombustible
            // 
            this.CbTipoCombustible.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipoCombustible.FormattingEnabled = true;
            this.CbTipoCombustible.Location = new System.Drawing.Point(77, 57);
            this.CbTipoCombustible.Name = "CbTipoCombustible";
            this.CbTipoCombustible.Size = new System.Drawing.Size(315, 28);
            this.CbTipoCombustible.TabIndex = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 145;
            this.label1.Text = "Tipo de Combustible:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(403, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 21);
            this.label12.TabIndex = 142;
            this.label12.Text = "Descripción:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(407, 58);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(315, 26);
            this.TxtDescripcion.TabIndex = 143;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(733, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 21);
            this.label15.TabIndex = 144;
            this.label15.Text = "Observaciones:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Image = global::SuperGas.Properties.Resources.Close_red_16x;
            this.BtnCancelar.Location = new System.Drawing.Point(191, 266);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(108, 35);
            this.BtnCancelar.TabIndex = 140;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Image = global::SuperGas.Properties.Resources.SaveStatusBar1_16x;
            this.BtnGuardar.Location = new System.Drawing.Point(76, 266);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(108, 35);
            this.BtnGuardar.TabIndex = 139;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBombas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 627);
            this.Controls.Add(this.PnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBombas";
            this.Text = "FrmBombas";
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistros)).EndInit();
            this.TsUsuarios.ResumeLayout(false);
            this.TsUsuarios.PerformLayout();
            this.PnlFormulario.ResumeLayout(false);
            this.PnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.DataGridView DgvRegistros;
        private System.Windows.Forms.ToolStrip TsUsuarios;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TxtBuscador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BtnCargar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BtnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtnConfiguracion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel PnlFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtGlTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtGlDespachado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtGlActuales;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.ComboBox CbTipoCombustible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}