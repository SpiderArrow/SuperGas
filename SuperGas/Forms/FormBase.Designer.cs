﻿
namespace SuperGas.Forms
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.MenuPrincipal = new System.Windows.Forms.Panel();
            this.SubMenuReportes = new System.Windows.Forms.Panel();
            this.PnlSubMenu = new System.Windows.Forms.Panel();
            this.PnlBotones = new System.Windows.Forms.Panel();
            this.BtnRCaja = new System.Windows.Forms.Button();
            this.BtnRInventario = new System.Windows.Forms.Button();
            this.BtnRClientes = new System.Windows.Forms.Button();
            this.BtnRCompras = new System.Windows.Forms.Button();
            this.BtnRVentas = new System.Windows.Forms.Button();
            this.PnlEspacio = new System.Windows.Forms.Panel();
            this.PnlReportes = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PnlProveedores = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.PnlClientes = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PnlUsuarios = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PnlEntradas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlDistribucion = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.PnlLimpieza = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.Reportes = new System.Windows.Forms.Button();
            this.Proveedores = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.Button();
            this.Entradas = new System.Windows.Forms.Button();
            this.Distribucion = new System.Windows.Forms.Button();
            this.Limpieza = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.PictureBox();
            this.Inicio = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            this.MenuPrincipal.SuspendLayout();
            this.SubMenuReportes.SuspendLayout();
            this.PnlSubMenu.SuspendLayout();
            this.PnlBotones.SuspendLayout();
            this.PnlReportes.SuspendLayout();
            this.PnlProveedores.SuspendLayout();
            this.PnlClientes.SuspendLayout();
            this.PnlUsuarios.SuspendLayout();
            this.PnlEntradas.SuspendLayout();
            this.PnlDistribucion.SuspendLayout();
            this.PnlLimpieza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BarraTitulo.Controls.Add(this.BtnRestaurar);
            this.BarraTitulo.Controls.Add(this.BtnMaximizar);
            this.BarraTitulo.Controls.Add(this.BtnMinimizar);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.MenuVertical.Controls.Add(this.MenuPrincipal);
            this.MenuVertical.Controls.Add(this.BtnSalir);
            this.MenuVertical.Controls.Add(this.Inicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(231, 627);
            this.MenuVertical.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.MenuPrincipal.Controls.Add(this.SubMenuReportes);
            this.MenuPrincipal.Controls.Add(this.PnlReportes);
            this.MenuPrincipal.Controls.Add(this.PnlProveedores);
            this.MenuPrincipal.Controls.Add(this.PnlClientes);
            this.MenuPrincipal.Controls.Add(this.PnlUsuarios);
            this.MenuPrincipal.Controls.Add(this.PnlEntradas);
            this.MenuPrincipal.Controls.Add(this.PnlDistribucion);
            this.MenuPrincipal.Controls.Add(this.PnlLimpieza);
            this.MenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 107);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(231, 469);
            this.MenuPrincipal.TabIndex = 0;
            // 
            // SubMenuReportes
            // 
            this.SubMenuReportes.Controls.Add(this.PnlSubMenu);
            this.SubMenuReportes.Controls.Add(this.PnlEspacio);
            this.SubMenuReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubMenuReportes.Location = new System.Drawing.Point(0, 266);
            this.SubMenuReportes.Name = "SubMenuReportes";
            this.SubMenuReportes.Size = new System.Drawing.Size(231, 203);
            this.SubMenuReportes.TabIndex = 13;
            this.SubMenuReportes.Visible = false;
            // 
            // PnlSubMenu
            // 
            this.PnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.PnlSubMenu.Controls.Add(this.PnlBotones);
            this.PnlSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSubMenu.Location = new System.Drawing.Point(35, 0);
            this.PnlSubMenu.Name = "PnlSubMenu";
            this.PnlSubMenu.Size = new System.Drawing.Size(196, 203);
            this.PnlSubMenu.TabIndex = 1;
            // 
            // PnlBotones
            // 
            this.PnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.PnlBotones.Controls.Add(this.BtnRCaja);
            this.PnlBotones.Controls.Add(this.BtnRInventario);
            this.PnlBotones.Controls.Add(this.BtnRClientes);
            this.PnlBotones.Controls.Add(this.BtnRCompras);
            this.PnlBotones.Controls.Add(this.BtnRVentas);
            this.PnlBotones.Location = new System.Drawing.Point(0, 0);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Size = new System.Drawing.Size(185, 136);
            this.PnlBotones.TabIndex = 18;
            // 
            // BtnRCaja
            // 
            this.BtnRCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.BtnRCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRCaja.FlatAppearance.BorderSize = 0;
            this.BtnRCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BtnRCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRCaja.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRCaja.ForeColor = System.Drawing.Color.White;
            this.BtnRCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRCaja.Location = new System.Drawing.Point(0, 100);
            this.BtnRCaja.Name = "BtnRCaja";
            this.BtnRCaja.Size = new System.Drawing.Size(185, 25);
            this.BtnRCaja.TabIndex = 21;
            this.BtnRCaja.Text = "Reporte Caja";
            this.BtnRCaja.UseVisualStyleBackColor = false;
            // 
            // BtnRInventario
            // 
            this.BtnRInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.BtnRInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRInventario.FlatAppearance.BorderSize = 0;
            this.BtnRInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BtnRInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRInventario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRInventario.ForeColor = System.Drawing.Color.White;
            this.BtnRInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRInventario.Location = new System.Drawing.Point(0, 75);
            this.BtnRInventario.Name = "BtnRInventario";
            this.BtnRInventario.Size = new System.Drawing.Size(185, 25);
            this.BtnRInventario.TabIndex = 20;
            this.BtnRInventario.Text = "Reporte Inventario";
            this.BtnRInventario.UseVisualStyleBackColor = false;
            // 
            // BtnRClientes
            // 
            this.BtnRClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.BtnRClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRClientes.FlatAppearance.BorderSize = 0;
            this.BtnRClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BtnRClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRClientes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRClientes.ForeColor = System.Drawing.Color.White;
            this.BtnRClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRClientes.Location = new System.Drawing.Point(0, 50);
            this.BtnRClientes.Name = "BtnRClientes";
            this.BtnRClientes.Size = new System.Drawing.Size(185, 25);
            this.BtnRClientes.TabIndex = 18;
            this.BtnRClientes.Text = "Reporte Clientes";
            this.BtnRClientes.UseVisualStyleBackColor = false;
            // 
            // BtnRCompras
            // 
            this.BtnRCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.BtnRCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRCompras.FlatAppearance.BorderSize = 0;
            this.BtnRCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BtnRCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRCompras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRCompras.ForeColor = System.Drawing.Color.White;
            this.BtnRCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRCompras.Location = new System.Drawing.Point(0, 25);
            this.BtnRCompras.Name = "BtnRCompras";
            this.BtnRCompras.Size = new System.Drawing.Size(185, 25);
            this.BtnRCompras.TabIndex = 19;
            this.BtnRCompras.Text = "Reporte Compras";
            this.BtnRCompras.UseVisualStyleBackColor = false;
            // 
            // BtnRVentas
            // 
            this.BtnRVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.BtnRVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRVentas.FlatAppearance.BorderSize = 0;
            this.BtnRVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BtnRVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRVentas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRVentas.ForeColor = System.Drawing.Color.White;
            this.BtnRVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRVentas.Location = new System.Drawing.Point(0, 0);
            this.BtnRVentas.Name = "BtnRVentas";
            this.BtnRVentas.Size = new System.Drawing.Size(185, 25);
            this.BtnRVentas.TabIndex = 17;
            this.BtnRVentas.Text = "ReporteVentas";
            this.BtnRVentas.UseVisualStyleBackColor = false;
            // 
            // PnlEspacio
            // 
            this.PnlEspacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.PnlEspacio.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlEspacio.Location = new System.Drawing.Point(0, 0);
            this.PnlEspacio.Name = "PnlEspacio";
            this.PnlEspacio.Size = new System.Drawing.Size(35, 203);
            this.PnlEspacio.TabIndex = 23;
            // 
            // PnlReportes
            // 
            this.PnlReportes.Controls.Add(this.panel6);
            this.PnlReportes.Controls.Add(this.Reportes);
            this.PnlReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlReportes.Location = new System.Drawing.Point(0, 228);
            this.PnlReportes.Name = "PnlReportes";
            this.PnlReportes.Size = new System.Drawing.Size(231, 38);
            this.PnlReportes.TabIndex = 19;
            this.PnlReportes.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(7, 38);
            this.panel6.TabIndex = 12;
            // 
            // PnlProveedores
            // 
            this.PnlProveedores.Controls.Add(this.Proveedores);
            this.PnlProveedores.Controls.Add(this.panel12);
            this.PnlProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlProveedores.Location = new System.Drawing.Point(0, 190);
            this.PnlProveedores.Name = "PnlProveedores";
            this.PnlProveedores.Size = new System.Drawing.Size(231, 38);
            this.PnlProveedores.TabIndex = 21;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(7, 38);
            this.panel12.TabIndex = 2;
            // 
            // PnlClientes
            // 
            this.PnlClientes.Controls.Add(this.panel3);
            this.PnlClientes.Controls.Add(this.Clientes);
            this.PnlClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlClientes.Location = new System.Drawing.Point(0, 152);
            this.PnlClientes.Name = "PnlClientes";
            this.PnlClientes.Size = new System.Drawing.Size(231, 38);
            this.PnlClientes.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 38);
            this.panel3.TabIndex = 6;
            // 
            // PnlUsuarios
            // 
            this.PnlUsuarios.Controls.Add(this.panel4);
            this.PnlUsuarios.Controls.Add(this.Usuarios);
            this.PnlUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUsuarios.Location = new System.Drawing.Point(0, 114);
            this.PnlUsuarios.Name = "PnlUsuarios";
            this.PnlUsuarios.Size = new System.Drawing.Size(231, 38);
            this.PnlUsuarios.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 38);
            this.panel4.TabIndex = 8;
            // 
            // PnlEntradas
            // 
            this.PnlEntradas.Controls.Add(this.panel2);
            this.PnlEntradas.Controls.Add(this.Entradas);
            this.PnlEntradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlEntradas.Location = new System.Drawing.Point(0, 76);
            this.PnlEntradas.Name = "PnlEntradas";
            this.PnlEntradas.Size = new System.Drawing.Size(231, 38);
            this.PnlEntradas.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 38);
            this.panel2.TabIndex = 4;
            // 
            // PnlDistribucion
            // 
            this.PnlDistribucion.Controls.Add(this.panel8);
            this.PnlDistribucion.Controls.Add(this.Distribucion);
            this.PnlDistribucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDistribucion.Location = new System.Drawing.Point(0, 38);
            this.PnlDistribucion.Name = "PnlDistribucion";
            this.PnlDistribucion.Size = new System.Drawing.Size(231, 38);
            this.PnlDistribucion.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(7, 38);
            this.panel8.TabIndex = 6;
            // 
            // PnlLimpieza
            // 
            this.PnlLimpieza.Controls.Add(this.panel7);
            this.PnlLimpieza.Controls.Add(this.Limpieza);
            this.PnlLimpieza.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLimpieza.Location = new System.Drawing.Point(0, 0);
            this.PnlLimpieza.Name = "PnlLimpieza";
            this.PnlLimpieza.Size = new System.Drawing.Size(231, 38);
            this.PnlLimpieza.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(7, 38);
            this.panel7.TabIndex = 6;
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(231, 38);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1069, 627);
            this.PnlContenedor.TabIndex = 2;
            // 
            // Reportes
            // 
            this.Reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reportes.FlatAppearance.BorderSize = 0;
            this.Reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportes.ForeColor = System.Drawing.Color.White;
            this.Reportes.Image = ((System.Drawing.Image)(resources.GetObject("Reportes.Image")));
            this.Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportes.Location = new System.Drawing.Point(0, 0);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(231, 38);
            this.Reportes.TabIndex = 11;
            this.Reportes.Text = "Reportes";
            this.Reportes.UseVisualStyleBackColor = false;
            this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // Proveedores
            // 
            this.Proveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Proveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Proveedores.FlatAppearance.BorderSize = 0;
            this.Proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proveedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedores.ForeColor = System.Drawing.Color.White;
            this.Proveedores.Image = ((System.Drawing.Image)(resources.GetObject("Proveedores.Image")));
            this.Proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Proveedores.Location = new System.Drawing.Point(7, 0);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(224, 38);
            this.Proveedores.TabIndex = 1;
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            this.Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clientes.FlatAppearance.BorderSize = 0;
            this.Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.ForeColor = System.Drawing.Color.White;
            this.Clientes.Image = ((System.Drawing.Image)(resources.GetObject("Clientes.Image")));
            this.Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.Location = new System.Drawing.Point(0, 0);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(231, 38);
            this.Clientes.TabIndex = 5;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = false;
            // 
            // Usuarios
            // 
            this.Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Usuarios.FlatAppearance.BorderSize = 0;
            this.Usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.ForeColor = System.Drawing.Color.White;
            this.Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("Usuarios.Image")));
            this.Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usuarios.Location = new System.Drawing.Point(0, 0);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(231, 38);
            this.Usuarios.TabIndex = 7;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = false;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Entradas
            // 
            this.Entradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Entradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Entradas.FlatAppearance.BorderSize = 0;
            this.Entradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Entradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entradas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entradas.ForeColor = System.Drawing.Color.White;
            this.Entradas.Image = ((System.Drawing.Image)(resources.GetObject("Entradas.Image")));
            this.Entradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Entradas.Location = new System.Drawing.Point(0, 0);
            this.Entradas.Name = "Entradas";
            this.Entradas.Size = new System.Drawing.Size(231, 38);
            this.Entradas.TabIndex = 3;
            this.Entradas.Text = "     Gestión Entradas";
            this.Entradas.UseVisualStyleBackColor = false;
            // 
            // Distribucion
            // 
            this.Distribucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Distribucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Distribucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Distribucion.FlatAppearance.BorderSize = 0;
            this.Distribucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Distribucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Distribucion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distribucion.ForeColor = System.Drawing.Color.White;
            this.Distribucion.Image = ((System.Drawing.Image)(resources.GetObject("Distribucion.Image")));
            this.Distribucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Distribucion.Location = new System.Drawing.Point(0, 0);
            this.Distribucion.Name = "Distribucion";
            this.Distribucion.Size = new System.Drawing.Size(231, 38);
            this.Distribucion.TabIndex = 5;
            this.Distribucion.Text = "         Gestión Distribución";
            this.Distribucion.UseVisualStyleBackColor = false;
            this.Distribucion.Click += new System.EventHandler(this.Distribucion_Click);
            // 
            // Limpieza
            // 
            this.Limpieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Limpieza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limpieza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Limpieza.FlatAppearance.BorderSize = 0;
            this.Limpieza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Limpieza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpieza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpieza.ForeColor = System.Drawing.Color.White;
            this.Limpieza.Image = ((System.Drawing.Image)(resources.GetObject("Limpieza.Image")));
            this.Limpieza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Limpieza.Location = new System.Drawing.Point(0, 0);
            this.Limpieza.Name = "Limpieza";
            this.Limpieza.Size = new System.Drawing.Size(231, 38);
            this.Limpieza.TabIndex = 5;
            this.Limpieza.Text = "     Gestión Limpieza";
            this.Limpieza.UseVisualStyleBackColor = false;
            this.Limpieza.Click += new System.EventHandler(this.Limpieza_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(0, 576);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(231, 51);
            this.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.Inicio.Image = ((System.Drawing.Image)(resources.GetObject("Inicio.Image")));
            this.Inicio.Location = new System.Drawing.Point(0, 0);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(231, 107);
            this.Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Inicio.TabIndex = 0;
            this.Inicio.TabStop = false;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(1223, 4);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(31, 31);
            this.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestaurar.TabIndex = 3;
            this.BtnRestaurar.TabStop = false;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(1223, 4);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(31, 31);
            this.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximizar.TabIndex = 2;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(1186, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(31, 31);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 1;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1260, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(31, 31);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 665);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.MenuVertical.ResumeLayout(false);
            this.MenuPrincipal.ResumeLayout(false);
            this.SubMenuReportes.ResumeLayout(false);
            this.PnlSubMenu.ResumeLayout(false);
            this.PnlBotones.ResumeLayout(false);
            this.PnlReportes.ResumeLayout(false);
            this.PnlProveedores.ResumeLayout(false);
            this.PnlClientes.ResumeLayout(false);
            this.PnlUsuarios.ResumeLayout(false);
            this.PnlEntradas.ResumeLayout(false);
            this.PnlDistribucion.ResumeLayout(false);
            this.PnlLimpieza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Usuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Entradas;
        private System.Windows.Forms.PictureBox Inicio;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Reportes;
        private System.Windows.Forms.Panel SubMenuReportes;
        private System.Windows.Forms.Panel PnlReportes;
        private System.Windows.Forms.Panel PnlBotones;
        private System.Windows.Forms.Button BtnRCaja;
        private System.Windows.Forms.Button BtnRInventario;
        private System.Windows.Forms.Button BtnRClientes;
        private System.Windows.Forms.Button BtnRCompras;
        private System.Windows.Forms.Button BtnRVentas;
        private System.Windows.Forms.Panel PnlUsuarios;
        private System.Windows.Forms.Panel PnlProveedores;
        private System.Windows.Forms.Button Proveedores;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel PnlEntradas;
        private System.Windows.Forms.Panel PnlEspacio;
        private System.Windows.Forms.Panel PnlSubMenu;
        private System.Windows.Forms.Panel MenuPrincipal;
        private System.Windows.Forms.PictureBox BtnSalir;
        private System.Windows.Forms.Panel PnlDistribucion;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button Distribucion;
        private System.Windows.Forms.Panel PnlLimpieza;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Limpieza;
        private System.Windows.Forms.Panel PnlClientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Clientes;
    }
}