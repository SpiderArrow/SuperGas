using Data.Models.Facturas;
using Data.Models.Usuarios;
using Data.Models.Productos;
using SaleAdmin.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Mapas.Productos;
using Data.Mapas.Ventas;

namespace SaleAdmin.Forms.modulo_ventas
{
    public partial class POS : Form
    {
        readonly Producto _productos = new Producto();
        readonly Factura _factura = new Factura();
        readonly User _usuario = new User();      

        public POS()
        {
            InitializeComponent();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            LbNoFactura.Text = ObtenerNumero(_factura.LastNoFactura(), "FC-");
            CargarCbVendedores();
            //CargarCbProductos();
        }

        private string ObtenerNumero(string noDocumento, string tipo)
        {
            string numero;
            if (noDocumento.Length > 0)
            {
                int maxsol = Convert.ToInt32(noDocumento.Split('-')[1]) + 1;
                if (maxsol < 10)
                    numero = tipo + "00" + maxsol;
                else if (maxsol < 100)
                    numero = tipo + "0" + maxsol;
                else
                    numero = tipo + maxsol;
            }
            else
            {
                numero = tipo + "001";
            }
            return numero;
        }

        private void CargarCbVendedores() {
            var listado = _usuario.Listado().Where(x => x.Privilegios == "Administrador" || 
                                                        x.Privilegios == "Vendedor" &&
                                                        x.Estado == "Activo").ToList();
            CbVendedor.DataSource = listado;
            CbVendedor.DisplayMember = "NombreCompleto";
            CbVendedor.ValueMember = "Id";     
            if(UserLogIn.User != null)
                CbVendedor.SelectedValue = UserLogIn.User.Id;
            CbVendedor.Invalidate();
        }

        public void CargarCbProductos()
        {
            var listado = _productos.Listado();
            CbProductos.ComboBox.DataSource = listado;
            CbProductos.ComboBox.DisplayMember = "NombreProducto";
            CbProductos.ComboBox.ValueMember = "Id";
            if (listado.Any())
                CbProductos.ComboBox.SelectedIndex = 0;
            CbProductos.ComboBox.Invalidate();
        }

        private void BtnSalirPOS_Click(object sender, EventArgs e)
        {
            FormBase parent =  this.ParentForm as FormBase;
            parent.Inicio_Click(sender, null);
        }

        private void BtnVerVentas_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.VerVentas();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarCbProductos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var row = (MapaDetalleFactura)DgvDetalleFacturas.CurrentRow.DataBoundItem;
            mapaDetalleFacturaBindingSource.Remove(row);
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (CbProductos.SelectedItem != null)
            {
                int cantidad = TxtCantidad.Text != "" ? Convert.ToInt32(TxtCantidad.Text) : 1;
                var producto = (MapaProductos)CbProductos.ComboBox.SelectedItem;
                var mapaDetalleFac = new MapaDetalleFactura() {
                    Id = 0,
                    FacturaId = 0,
                    ProductoId = producto.Id,
                    NombreProducto = producto.NombreProducto,
                    Cantidad = cantidad,
                    Costo = producto.Coste,
                    Precio = producto.PrecioVenta,
                    Descuento = 0.00m,
                    SubTotal = producto.PrecioVenta * cantidad
                };

                mapaDetalleFacturaBindingSource.Add(mapaDetalleFac);
                CalcularSubtotales();
            }
            else
                MessageBox.Show("Debe seleccionar un producto para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void TxtEntero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void DgvDetalleFacturas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = (MapaDetalleFactura)DgvDetalleFacturas.CurrentRow.DataBoundItem;
            row.SubTotal = (row.Precio - row.Descuento) * row.Cantidad;
            CalcularSubtotales();
        }

        private void CalcularSubtotales() {            
            decimal descuento = 0.00m;
            decimal total = 0.00m;
            decimal unidades = 0;
       
            foreach (var row in mapaDetalleFacturaBindingSource) {
                MapaDetalleFactura mapa = (MapaDetalleFactura)row;
                descuento += (mapa.Descuento * mapa.Cantidad);
                total += mapa.SubTotal;
                unidades += mapa.Cantidad;
            }

            decimal iva = decimal.Round(total * 0.12m, 2);
            decimal subtotal = total - iva;

            LbCantidadProductos.Text = DgvDetalleFacturas.Rows.Count.ToString();
            LbUnidades.Text = unidades.ToString();
            TxtDescuento.Text = descuento.ToString();
            TxtSubtotal.Text = subtotal.ToString();
            TxtTotal.Text = total.ToString();
            TxtIVA.Text = iva.ToString();
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            string mensaje = ValidarCampos();
            if (mensaje == "") {
                FrmCobro cobrar = new FrmCobro(this);
                cobrar.Show();
            } else
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public string ValidarCampos()
        {
            if (TxtNombre.Text == "")
                return "Debe ingresar NOMBRE para cobrar.";
            else if (TxtDireccion.Text == "")
                return "Debe ingresar DIRECCIÓN para cobrar.";
            else if (TxtNit.Text == "")
                return "Debe ingresar NIT para cobrar.";
            else if (DgvDetalleFacturas.Rows.Count == 0)
                return "Debe ingresar al menos 1 producto para realizar venta.";
            else
                return "";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (DgvDetalleFacturas.Rows.Count > 0)
            {
                var dialog =
                            MessageBox.Show("¡Esta seguro que desea cancelar la Venta!", "Cancelar Venta",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    LimpiarCampos();
                    MessageBox.Show("¡Venta Cancelada!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                }
            }
            else
                LimpiarCampos();
        }

        public void LimpiarCampos() {
            DtpFechaVenta.Value = DateTime.Now;
            CargarCbProductos();
            CargarCbVendedores();
            TxtNombre.Text = "";
            TxtDireccion.Text = "";
            TxtNit.Text = "";
            TxtCantidad.Text = "1";
            mapaDetalleFacturaBindingSource.Clear();
            TxtDescuento.Text = "0.00";
            TxtSubtotal.Text = "0.00";
            TxtIVA.Text = "0.00";
            TxtTotal.Text = "0.00";
            LbUnidades.Text = "0";
            LbCantidadProductos.Text = "0";            

        }

        private void BtnLlenarCF_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "C. F.";
            TxtDireccion.Text = "Ciudad";
            TxtNit.Text = "CF";
        }

        public Factura GetModel(int idMovimiento)
        {
            return new Factura()
            {
                TipoMovimientoId = idMovimiento,
                UserId = UserLogIn.User.Id,
                NoFactura = LbNoFactura.Text,
                Serie = "A",
                FechaVenta = DtpFechaVenta.Value,
                Nombre = TxtNombre.Text,
                Direccion = TxtDireccion.Text,
                NIT = TxtNit.Text,
                TotalFactura = Convert.ToDecimal(TxtTotal.Text),
                Pagada = true
            };
        }

        public List<DetalleFactura> ListaDetalles(long idFactura) {
            List<DetalleFactura> listado = new List<DetalleFactura>();

            foreach (var row in mapaDetalleFacturaBindingSource)
            {
                MapaDetalleFactura mapa = (MapaDetalleFactura)row;

                listado.Add( new DetalleFactura() { 
                    FacturaId = idFactura,
                    ProductoId = mapa.ProductoId,
                    Cantidad = mapa.Cantidad,
                    Precio = mapa.Precio,
                    Descuento = mapa.Descuento,
                    SubTotal = mapa.SubTotal,
                    Utilidad = (mapa.Precio - mapa.Descuento - mapa.Costo) * mapa.Cantidad
                    
                });
            }

            return listado;
        }

        public void GenerarFactura(long IdFactura) {
            FrmFactura factura = new FrmFactura(IdFactura);
            factura.Show();
        }

        public void DescontarStock(long idProducto, int cantidad) {
            try
            {
                if (idProducto > 0) {
                    var prod = _productos.GetProducto(idProducto);
                    if (prod.ControlStock)
                    {
                        prod.Stock -= cantidad;
                        _productos.Update(prod);
                    }
                }                
            }
            catch { 
            }
        }
    }
}
