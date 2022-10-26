namespace SaleAdmin.Forms.modulo_ventas
{
    partial class FrmVentasRealizadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mapaDetalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TsFactura = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.TxtBuscadorFact = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnIrPOS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDocumento = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PnlDetalles = new System.Windows.Forms.Panel();
            this.PnlDgvDetalles = new System.Windows.Forms.Panel();
            this.DgvDetalles = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlToolDetalles = new System.Windows.Forms.Panel();
            this.TsDetalles = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.LbNoFactura = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.TxtBuscadorDetalles = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PnlFacturas = new System.Windows.Forms.Panel();
            this.PnlDgv = new System.Windows.Forms.Panel();
            this.DgvFacturas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapaFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PnlTool = new System.Windows.Forms.Panel();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.LbItems = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.mapaDetalleFacturaBindingSource)).BeginInit();
            this.TsFactura.SuspendLayout();
            this.PnlDetalles.SuspendLayout();
            this.PnlDgvDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalles)).BeginInit();
            this.PnlToolDetalles.SuspendLayout();
            this.TsDetalles.SuspendLayout();
            this.PnlFacturas.SuspendLayout();
            this.PnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapaFacturaBindingSource)).BeginInit();
            this.PnlTool.SuspendLayout();
            this.PnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapaDetalleFacturaBindingSource
            // 
            this.mapaDetalleFacturaBindingSource.DataSource = typeof(Data.Mapas.Ventas.MapaDetalleFactura);
            // 
            // TsFactura
            // 
            this.TsFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TsFactura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsFactura.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.TxtBuscadorFact,
            this.toolStripSeparator4,
            this.BtnIrPOS,
            this.toolStripSeparator5,
            this.BtnDocumento});
            this.TsFactura.Location = new System.Drawing.Point(0, 0);
            this.TsFactura.Name = "TsFactura";
            this.TsFactura.Size = new System.Drawing.Size(1080, 28);
            this.TsFactura.TabIndex = 1;
            this.TsFactura.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(141, 25);
            this.toolStripLabel1.Text = "Ventas Realizadas";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Image = global::SaleAdmin.Properties.Resources.Search_16x;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(94, 25);
            this.toolStripLabel4.Text = "Buscador";
            // 
            // TxtBuscadorFact
            // 
            this.TxtBuscadorFact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBuscadorFact.Name = "TxtBuscadorFact";
            this.TxtBuscadorFact.Size = new System.Drawing.Size(200, 28);
            this.TxtBuscadorFact.TextChanged += new System.EventHandler(this.TxtBuscadorFact_TextChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // BtnIrPOS
            // 
            this.BtnIrPOS.Image = global::SaleAdmin.Properties.Resources.OrderUp_16x;
            this.BtnIrPOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnIrPOS.Name = "BtnIrPOS";
            this.BtnIrPOS.Size = new System.Drawing.Size(86, 25);
            this.BtnIrPOS.Text = "Ir a POS";
            this.BtnIrPOS.Click += new System.EventHandler(this.BtnIrPOS_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // BtnDocumento
            // 
            this.BtnDocumento.Image = global::SaleAdmin.Properties.Resources.UserTask_16x;
            this.BtnDocumento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDocumento.Name = "BtnDocumento";
            this.BtnDocumento.Size = new System.Drawing.Size(182, 25);
            this.BtnDocumento.Text = "Generar Documento";
            this.BtnDocumento.Click += new System.EventHandler(this.BtnDocumento_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 294);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1080, 3);
            this.splitter1.TabIndex = 43;
            this.splitter1.TabStop = false;
            // 
            // PnlDetalles
            // 
            this.PnlDetalles.Controls.Add(this.PnlDgvDetalles);
            this.PnlDetalles.Controls.Add(this.PnlToolDetalles);
            this.PnlDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDetalles.Location = new System.Drawing.Point(0, 294);
            this.PnlDetalles.Name = "PnlDetalles";
            this.PnlDetalles.Size = new System.Drawing.Size(1080, 333);
            this.PnlDetalles.TabIndex = 44;
            // 
            // PnlDgvDetalles
            // 
            this.PnlDgvDetalles.Controls.Add(this.DgvDetalles);
            this.PnlDgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDgvDetalles.Location = new System.Drawing.Point(0, 28);
            this.PnlDgvDetalles.Name = "PnlDgvDetalles";
            this.PnlDgvDetalles.Size = new System.Drawing.Size(1080, 305);
            this.PnlDgvDetalles.TabIndex = 6;
            // 
            // DgvDetalles
            // 
            this.DgvDetalles.AllowUserToAddRows = false;
            this.DgvDetalles.AllowUserToDeleteRows = false;
            this.DgvDetalles.AllowUserToResizeRows = false;
            this.DgvDetalles.AutoGenerateColumns = false;
            this.DgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvDetalles.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.facturaIdDataGridViewTextBoxColumn,
            this.productoIdDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn});
            this.DgvDetalles.DataSource = this.mapaDetalleFacturaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDetalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDetalles.Location = new System.Drawing.Point(0, 0);
            this.DgvDetalles.Name = "DgvDetalles";
            this.DgvDetalles.ReadOnly = true;
            this.DgvDetalles.Size = new System.Drawing.Size(1080, 305);
            this.DgvDetalles.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 44;
            // 
            // facturaIdDataGridViewTextBoxColumn
            // 
            this.facturaIdDataGridViewTextBoxColumn.DataPropertyName = "FacturaId";
            this.facturaIdDataGridViewTextBoxColumn.HeaderText = "FacturaId";
            this.facturaIdDataGridViewTextBoxColumn.Name = "facturaIdDataGridViewTextBoxColumn";
            this.facturaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.facturaIdDataGridViewTextBoxColumn.Visible = false;
            this.facturaIdDataGridViewTextBoxColumn.Width = 90;
            // 
            // productoIdDataGridViewTextBoxColumn
            // 
            this.productoIdDataGridViewTextBoxColumn.DataPropertyName = "ProductoId";
            this.productoIdDataGridViewTextBoxColumn.HeaderText = "ProductoId";
            this.productoIdDataGridViewTextBoxColumn.Name = "productoIdDataGridViewTextBoxColumn";
            this.productoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoIdDataGridViewTextBoxColumn.Visible = false;
            this.productoIdDataGridViewTextBoxColumn.Width = 99;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreProductoDataGridViewTextBoxColumn.Width = 104;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 89;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoDataGridViewTextBoxColumn.Width = 68;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 71;
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            this.descuentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descuentoDataGridViewTextBoxColumn.Width = 98;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.subTotalDataGridViewTextBoxColumn.Width = 84;
            // 
            // PnlToolDetalles
            // 
            this.PnlToolDetalles.Controls.Add(this.TsDetalles);
            this.PnlToolDetalles.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlToolDetalles.Location = new System.Drawing.Point(0, 0);
            this.PnlToolDetalles.Name = "PnlToolDetalles";
            this.PnlToolDetalles.Size = new System.Drawing.Size(1080, 28);
            this.PnlToolDetalles.TabIndex = 5;
            // 
            // TsDetalles
            // 
            this.TsDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TsDetalles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsDetalles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.LbNoFactura,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.LbItems,
            this.toolStripSeparator2,
            this.toolStripLabel5,
            this.TxtBuscadorDetalles,
            this.toolStripSeparator6});
            this.TsDetalles.Location = new System.Drawing.Point(0, 0);
            this.TsDetalles.Name = "TsDetalles";
            this.TsDetalles.Size = new System.Drawing.Size(1080, 28);
            this.TsDetalles.TabIndex = 3;
            this.TsDetalles.Text = "Detalle No. Factura: ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(129, 25);
            this.toolStripLabel2.Text = "Detalle Factura: ";
            // 
            // LbNoFactura
            // 
            this.LbNoFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNoFactura.Name = "LbNoFactura";
            this.LbNoFactura.Size = new System.Drawing.Size(66, 25);
            this.LbNoFactura.Text = "No. 001";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Image = global::SaleAdmin.Properties.Resources.Search_16x;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(94, 25);
            this.toolStripLabel5.Text = "Buscador";
            // 
            // TxtBuscadorDetalles
            // 
            this.TxtBuscadorDetalles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBuscadorDetalles.Name = "TxtBuscadorDetalles";
            this.TxtBuscadorDetalles.Size = new System.Drawing.Size(200, 28);
            this.TxtBuscadorDetalles.TextChanged += new System.EventHandler(this.TxtBuscadorDetalles_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // PnlFacturas
            // 
            this.PnlFacturas.Controls.Add(this.PnlDgv);
            this.PnlFacturas.Controls.Add(this.PnlTool);
            this.PnlFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlFacturas.Location = new System.Drawing.Point(0, 0);
            this.PnlFacturas.Name = "PnlFacturas";
            this.PnlFacturas.Size = new System.Drawing.Size(1080, 294);
            this.PnlFacturas.TabIndex = 45;
            // 
            // PnlDgv
            // 
            this.PnlDgv.Controls.Add(this.DgvFacturas);
            this.PnlDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDgv.Location = new System.Drawing.Point(0, 28);
            this.PnlDgv.Name = "PnlDgv";
            this.PnlDgv.Size = new System.Drawing.Size(1080, 266);
            this.PnlDgv.TabIndex = 1;
            // 
            // DgvFacturas
            // 
            this.DgvFacturas.AllowUserToAddRows = false;
            this.DgvFacturas.AllowUserToDeleteRows = false;
            this.DgvFacturas.AllowUserToResizeRows = false;
            this.DgvFacturas.AutoGenerateColumns = false;
            this.DgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvFacturas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fechaVentaDataGridViewTextBoxColumn,
            this.vendedorDataGridViewTextBoxColumn,
            this.noFacturaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.nITDataGridViewTextBoxColumn,
            this.movimientoDataGridViewTextBoxColumn,
            this.totalFacturaDataGridViewTextBoxColumn});
            this.DgvFacturas.DataSource = this.mapaFacturaBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvFacturas.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvFacturas.Location = new System.Drawing.Point(0, 0);
            this.DgvFacturas.Name = "DgvFacturas";
            this.DgvFacturas.ReadOnly = true;
            this.DgvFacturas.Size = new System.Drawing.Size(1080, 266);
            this.DgvFacturas.TabIndex = 5;
            this.DgvFacturas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvFacturas_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 44;
            // 
            // fechaVentaDataGridViewTextBoxColumn
            // 
            this.fechaVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.HeaderText = "Fecha de Venta";
            this.fechaVentaDataGridViewTextBoxColumn.Name = "fechaVentaDataGridViewTextBoxColumn";
            this.fechaVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVentaDataGridViewTextBoxColumn.Width = 129;
            // 
            // vendedorDataGridViewTextBoxColumn
            // 
            this.vendedorDataGridViewTextBoxColumn.DataPropertyName = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.Name = "vendedorDataGridViewTextBoxColumn";
            this.vendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendedorDataGridViewTextBoxColumn.Width = 93;
            // 
            // noFacturaDataGridViewTextBoxColumn
            // 
            this.noFacturaDataGridViewTextBoxColumn.DataPropertyName = "NoFactura";
            this.noFacturaDataGridViewTextBoxColumn.HeaderText = "No. Factura";
            this.noFacturaDataGridViewTextBoxColumn.Name = "noFacturaDataGridViewTextBoxColumn";
            this.noFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.noFacturaDataGridViewTextBoxColumn.Width = 102;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 81;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 91;
            // 
            // nITDataGridViewTextBoxColumn
            // 
            this.nITDataGridViewTextBoxColumn.DataPropertyName = "NIT";
            this.nITDataGridViewTextBoxColumn.HeaderText = "NIT";
            this.nITDataGridViewTextBoxColumn.Name = "nITDataGridViewTextBoxColumn";
            this.nITDataGridViewTextBoxColumn.ReadOnly = true;
            this.nITDataGridViewTextBoxColumn.Width = 50;
            // 
            // movimientoDataGridViewTextBoxColumn
            // 
            this.movimientoDataGridViewTextBoxColumn.DataPropertyName = "Movimiento";
            this.movimientoDataGridViewTextBoxColumn.HeaderText = "Movimiento";
            this.movimientoDataGridViewTextBoxColumn.Name = "movimientoDataGridViewTextBoxColumn";
            this.movimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.movimientoDataGridViewTextBoxColumn.Width = 105;
            // 
            // totalFacturaDataGridViewTextBoxColumn
            // 
            this.totalFacturaDataGridViewTextBoxColumn.DataPropertyName = "TotalFactura";
            this.totalFacturaDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalFacturaDataGridViewTextBoxColumn.Name = "totalFacturaDataGridViewTextBoxColumn";
            this.totalFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalFacturaDataGridViewTextBoxColumn.Width = 62;
            // 
            // mapaFacturaBindingSource
            // 
            this.mapaFacturaBindingSource.DataSource = typeof(Data.Mapas.Ventas.MapaFactura);
            // 
            // PnlTool
            // 
            this.PnlTool.Controls.Add(this.TsFactura);
            this.PnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTool.Location = new System.Drawing.Point(0, 0);
            this.PnlTool.Name = "PnlTool";
            this.PnlTool.Size = new System.Drawing.Size(1080, 28);
            this.PnlTool.TabIndex = 0;
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Controls.Add(this.splitter1);
            this.PnlPrincipal.Controls.Add(this.PnlDetalles);
            this.PnlPrincipal.Controls.Add(this.PnlFacturas);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(1080, 627);
            this.PnlPrincipal.TabIndex = 46;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(56, 25);
            this.toolStripLabel3.Text = "Items: ";
            // 
            // LbItems
            // 
            this.LbItems.Name = "LbItems";
            this.LbItems.Size = new System.Drawing.Size(17, 25);
            this.LbItems.Text = "0";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // FrmVentasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 627);
            this.Controls.Add(this.PnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentasRealizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentasRealizadas";
            this.Load += new System.EventHandler(this.FrmVentasRealizadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapaDetalleFacturaBindingSource)).EndInit();
            this.TsFactura.ResumeLayout(false);
            this.TsFactura.PerformLayout();
            this.PnlDetalles.ResumeLayout(false);
            this.PnlDgvDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalles)).EndInit();
            this.PnlToolDetalles.ResumeLayout(false);
            this.PnlToolDetalles.PerformLayout();
            this.TsDetalles.ResumeLayout(false);
            this.TsDetalles.PerformLayout();
            this.PnlFacturas.ResumeLayout(false);
            this.PnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapaFacturaBindingSource)).EndInit();
            this.PnlTool.ResumeLayout(false);
            this.PnlTool.PerformLayout();
            this.PnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip TsFactura;
        private System.Windows.Forms.BindingSource mapaDetalleFacturaBindingSource;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox TxtBuscadorFact;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtnIrPOS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BtnDocumento;
        private System.Windows.Forms.Panel PnlDetalles;
        private System.Windows.Forms.Panel PnlDgvDetalles;
        private System.Windows.Forms.DataGridView DgvDetalles;
        private System.Windows.Forms.Panel PnlToolDetalles;
        private System.Windows.Forms.ToolStrip TsDetalles;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel LbNoFactura;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TxtBuscadorDetalles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel PnlFacturas;
        private System.Windows.Forms.Panel PnlDgv;
        private System.Windows.Forms.Panel PnlTool;
        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DgvFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mapaFacturaBindingSource;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel LbItems;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}