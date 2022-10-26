namespace SuperGas.Forms.modulo_Limpieza
{
    partial class FrmGestionLimpieza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionLimpieza));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.DtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.DtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpProxima = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.BtnAddEncargado = new System.Windows.Forms.Button();
            this.CbEncargado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAddBombas = new System.Windows.Forms.Button();
            this.BtnAddPistas = new System.Windows.Forms.Button();
            this.BtnAddGasolinera = new System.Windows.Forms.Button();
            this.BtnAddCamion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbGasolineras = new System.Windows.Forms.ComboBox();
            this.CbPistas = new System.Windows.Forms.ComboBox();
            this.CbBombas = new System.Windows.Forms.ComboBox();
            this.CbCamiones = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbBombas = new System.Windows.Forms.RadioButton();
            this.RbPistas = new System.Windows.Forms.RadioButton();
            this.RbDepositos = new System.Windows.Forms.RadioButton();
            this.RbCamiones = new System.Windows.Forms.RadioButton();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.DtpFecha);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.DtpHoraFinal);
            this.panel1.Controls.Add(this.DtpHoraInicio);
            this.panel1.Controls.Add(this.DtpProxima);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TxtObservaciones);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CbEstado);
            this.panel1.Controls.Add(this.BtnAddEncargado);
            this.panel1.Controls.Add(this.CbEncargado);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnAddBombas);
            this.panel1.Controls.Add(this.BtnAddPistas);
            this.panel1.Controls.Add(this.BtnAddGasolinera);
            this.panel1.Controls.Add(this.BtnAddCamion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CbGasolineras);
            this.panel1.Controls.Add(this.CbPistas);
            this.panel1.Controls.Add(this.CbBombas);
            this.panel1.Controls.Add(this.CbCamiones);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BtnVolver);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 588);
            this.panel1.TabIndex = 0;
            // 
            // DtpFecha
            // 
            this.DtpFecha.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(909, 165);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(108, 22);
            this.DtpFecha.TabIndex = 43;
            this.DtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(767, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Fecha Limpieza:";
            // 
            // DtpHoraFinal
            // 
            this.DtpHoraFinal.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHoraFinal.CustomFormat = "HH:mm";
            this.DtpHoraFinal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpHoraFinal.Location = new System.Drawing.Point(281, 315);
            this.DtpHoraFinal.Name = "DtpHoraFinal";
            this.DtpHoraFinal.Size = new System.Drawing.Size(166, 26);
            this.DtpHoraFinal.TabIndex = 41;
            // 
            // DtpHoraInicio
            // 
            this.DtpHoraInicio.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHoraInicio.CustomFormat = "HH:mm";
            this.DtpHoraInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpHoraInicio.Location = new System.Drawing.Point(49, 317);
            this.DtpHoraInicio.Name = "DtpHoraInicio";
            this.DtpHoraInicio.Size = new System.Drawing.Size(167, 26);
            this.DtpHoraInicio.TabIndex = 40;
            this.DtpHoraInicio.Value = new System.DateTime(2022, 10, 24, 14, 38, 0, 0);
            this.DtpHoraInicio.ValueChanged += new System.EventHandler(this.DtpHoraInicio_ValueChanged);
            // 
            // DtpProxima
            // 
            this.DtpProxima.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpProxima.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpProxima.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpProxima.Location = new System.Drawing.Point(909, 133);
            this.DtpProxima.Name = "DtpProxima";
            this.DtpProxima.Size = new System.Drawing.Size(108, 22);
            this.DtpProxima.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(767, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Próxima Limpieza:";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(49, 400);
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(925, 155);
            this.TxtObservaciones.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Observaciones:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(744, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Estado";
            // 
            // CbEstado
            // 
            this.CbEstado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(748, 313);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(218, 28);
            this.CbEstado.TabIndex = 34;
            // 
            // BtnAddEncargado
            // 
            this.BtnAddEncargado.FlatAppearance.BorderSize = 0;
            this.BtnAddEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEncargado.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddEncargado.Image")));
            this.BtnAddEncargado.Location = new System.Drawing.Point(695, 306);
            this.BtnAddEncargado.Name = "BtnAddEncargado";
            this.BtnAddEncargado.Size = new System.Drawing.Size(41, 42);
            this.BtnAddEncargado.TabIndex = 33;
            this.BtnAddEncargado.UseVisualStyleBackColor = true;
            this.BtnAddEncargado.Click += new System.EventHandler(this.BtnAddEncargado_Click);
            // 
            // CbEncargado
            // 
            this.CbEncargado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEncargado.FormattingEnabled = true;
            this.CbEncargado.Location = new System.Drawing.Point(519, 313);
            this.CbEncargado.Name = "CbEncargado";
            this.CbEncargado.Size = new System.Drawing.Size(167, 28);
            this.CbEncargado.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(523, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Encargado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Hora Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Hora Inicio:";
            // 
            // BtnAddBombas
            // 
            this.BtnAddBombas.Enabled = false;
            this.BtnAddBombas.FlatAppearance.BorderSize = 0;
            this.BtnAddBombas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddBombas.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddBombas.Image")));
            this.BtnAddBombas.Location = new System.Drawing.Point(925, 219);
            this.BtnAddBombas.Name = "BtnAddBombas";
            this.BtnAddBombas.Size = new System.Drawing.Size(41, 42);
            this.BtnAddBombas.TabIndex = 28;
            this.BtnAddBombas.UseVisualStyleBackColor = true;
            this.BtnAddBombas.Click += new System.EventHandler(this.BtnAddBombas_Click);
            // 
            // BtnAddPistas
            // 
            this.BtnAddPistas.Enabled = false;
            this.BtnAddPistas.FlatAppearance.BorderSize = 0;
            this.BtnAddPistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPistas.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddPistas.Image")));
            this.BtnAddPistas.Location = new System.Drawing.Point(695, 219);
            this.BtnAddPistas.Name = "BtnAddPistas";
            this.BtnAddPistas.Size = new System.Drawing.Size(41, 42);
            this.BtnAddPistas.TabIndex = 27;
            this.BtnAddPistas.UseVisualStyleBackColor = true;
            this.BtnAddPistas.Click += new System.EventHandler(this.BtnAddPistas_Click);
            // 
            // BtnAddGasolinera
            // 
            this.BtnAddGasolinera.Enabled = false;
            this.BtnAddGasolinera.FlatAppearance.BorderSize = 0;
            this.BtnAddGasolinera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddGasolinera.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddGasolinera.Image")));
            this.BtnAddGasolinera.Location = new System.Drawing.Point(461, 219);
            this.BtnAddGasolinera.Name = "BtnAddGasolinera";
            this.BtnAddGasolinera.Size = new System.Drawing.Size(41, 42);
            this.BtnAddGasolinera.TabIndex = 26;
            this.BtnAddGasolinera.UseVisualStyleBackColor = true;
            this.BtnAddGasolinera.Click += new System.EventHandler(this.BtnAddGasolinera_Click);
            // 
            // BtnAddCamion
            // 
            this.BtnAddCamion.Enabled = false;
            this.BtnAddCamion.FlatAppearance.BorderSize = 0;
            this.BtnAddCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddCamion.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddCamion.Image")));
            this.BtnAddCamion.Location = new System.Drawing.Point(224, 219);
            this.BtnAddCamion.Name = "BtnAddCamion";
            this.BtnAddCamion.Size = new System.Drawing.Size(41, 42);
            this.BtnAddCamion.TabIndex = 25;
            this.BtnAddCamion.UseVisualStyleBackColor = true;
            this.BtnAddCamion.Click += new System.EventHandler(this.BtnAddCamion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(744, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Bombas ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pistas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gasolinera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Camiones";
            // 
            // CbGasolineras
            // 
            this.CbGasolineras.Enabled = false;
            this.CbGasolineras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbGasolineras.FormattingEnabled = true;
            this.CbGasolineras.Location = new System.Drawing.Point(281, 226);
            this.CbGasolineras.Name = "CbGasolineras";
            this.CbGasolineras.Size = new System.Drawing.Size(167, 28);
            this.CbGasolineras.TabIndex = 20;
            // 
            // CbPistas
            // 
            this.CbPistas.Enabled = false;
            this.CbPistas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPistas.FormattingEnabled = true;
            this.CbPistas.Location = new System.Drawing.Point(519, 226);
            this.CbPistas.Name = "CbPistas";
            this.CbPistas.Size = new System.Drawing.Size(167, 28);
            this.CbPistas.TabIndex = 19;
            // 
            // CbBombas
            // 
            this.CbBombas.Enabled = false;
            this.CbBombas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBombas.FormattingEnabled = true;
            this.CbBombas.Location = new System.Drawing.Point(747, 226);
            this.CbBombas.Name = "CbBombas";
            this.CbBombas.Size = new System.Drawing.Size(167, 28);
            this.CbBombas.TabIndex = 18;
            // 
            // CbCamiones
            // 
            this.CbCamiones.Enabled = false;
            this.CbCamiones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCamiones.FormattingEnabled = true;
            this.CbCamiones.Location = new System.Drawing.Point(45, 226);
            this.CbCamiones.Name = "CbCamiones";
            this.CbCamiones.Size = new System.Drawing.Size(167, 28);
            this.CbCamiones.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbBombas);
            this.groupBox1.Controls.Add(this.RbPistas);
            this.groupBox1.Controls.Add(this.RbDepositos);
            this.groupBox1.Controls.Add(this.RbCamiones);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 109);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lugar de Limpieza";
            // 
            // RbBombas
            // 
            this.RbBombas.AutoSize = true;
            this.RbBombas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbBombas.Location = new System.Drawing.Point(522, 44);
            this.RbBombas.Name = "RbBombas";
            this.RbBombas.Size = new System.Drawing.Size(168, 21);
            this.RbBombas.TabIndex = 3;
            this.RbBombas.TabStop = true;
            this.RbBombas.Text = "Bombas de despacho";
            this.RbBombas.UseVisualStyleBackColor = true;
            this.RbBombas.CheckedChanged += new System.EventHandler(this.RbBombas_CheckedChanged);
            // 
            // RbPistas
            // 
            this.RbPistas.AutoSize = true;
            this.RbPistas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPistas.Location = new System.Drawing.Point(429, 44);
            this.RbPistas.Name = "RbPistas";
            this.RbPistas.Size = new System.Drawing.Size(61, 21);
            this.RbPistas.TabIndex = 2;
            this.RbPistas.TabStop = true;
            this.RbPistas.Text = "Pistas";
            this.RbPistas.UseVisualStyleBackColor = true;
            this.RbPistas.CheckedChanged += new System.EventHandler(this.RbPistas_CheckedChanged);
            // 
            // RbDepositos
            // 
            this.RbDepositos.AutoSize = true;
            this.RbDepositos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbDepositos.Location = new System.Drawing.Point(217, 44);
            this.RbDepositos.Name = "RbDepositos";
            this.RbDepositos.Size = new System.Drawing.Size(186, 21);
            this.RbDepositos.TabIndex = 1;
            this.RbDepositos.TabStop = true;
            this.RbDepositos.Text = "Depósitos de gasolineras";
            this.RbDepositos.UseVisualStyleBackColor = true;
            this.RbDepositos.CheckedChanged += new System.EventHandler(this.RbDepositos_CheckedChanged);
            // 
            // RbCamiones
            // 
            this.RbCamiones.AutoSize = true;
            this.RbCamiones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbCamiones.Location = new System.Drawing.Point(28, 44);
            this.RbCamiones.Name = "RbCamiones";
            this.RbCamiones.Size = new System.Drawing.Size(167, 21);
            this.RbCamiones.TabIndex = 0;
            this.RbCamiones.TabStop = true;
            this.RbCamiones.Text = "Sisternas de camiones";
            this.RbCamiones.UseVisualStyleBackColor = true;
            this.RbCamiones.CheckedChanged += new System.EventHandler(this.RbCamiones_CheckedChanged);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Image = global::SuperGas.Properties.Resources.Refresh_16x;
            this.BtnVolver.Location = new System.Drawing.Point(909, 79);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(108, 35);
            this.BtnVolver.TabIndex = 15;
            this.BtnVolver.Text = "  Volver";
            this.BtnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Image = global::SuperGas.Properties.Resources.SaveStatusBar1_16x;
            this.BtnGuardar.Location = new System.Drawing.Point(771, 79);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(108, 35);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGestionLimpieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 588);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionLimpieza";
            this.Text = "FrmGestionLimpieza";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.RadioButton RbDepositos;
        private System.Windows.Forms.RadioButton RbCamiones;
        private System.Windows.Forms.RadioButton RbBombas;
        private System.Windows.Forms.RadioButton RbPistas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Button BtnAddEncargado;
        private System.Windows.Forms.ComboBox CbEncargado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAddBombas;
        private System.Windows.Forms.Button BtnAddPistas;
        private System.Windows.Forms.Button BtnAddGasolinera;
        private System.Windows.Forms.Button BtnAddCamion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbGasolineras;
        private System.Windows.Forms.ComboBox CbPistas;
        private System.Windows.Forms.ComboBox CbBombas;
        private System.Windows.Forms.ComboBox CbCamiones;
        private System.Windows.Forms.DateTimePicker DtpHoraFinal;
        private System.Windows.Forms.DateTimePicker DtpHoraInicio;
        private System.Windows.Forms.DateTimePicker DtpProxima;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label11;
    }
}