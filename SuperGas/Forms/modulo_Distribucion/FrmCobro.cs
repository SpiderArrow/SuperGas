
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperGas.Forms.modulo_Distribucion
{
    public partial class FrmCobro : Form
    {     
        //readonly Factura _factura = new Factura();
        //readonly DetalleFactura _detalleFactura = new DetalleFactura();
        //readonly TipoMovimiento _tipoMovimiento = new TipoMovimiento();
        //long IdFactura = 0;

        public FrmCobro()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCobro_Load(object sender, EventArgs e)
        {
            //TxtTotal.Text = _puntoDeVenta.TxtTotal.Text;
            CalcularVuelto();
            CargarTipoMovimiento();
        }

        public void CalcularVuelto() {
            decimal ingreso = Convert.ToDecimal(TxtValor.Text);
            decimal total = Convert.ToDecimal(TxtTotal.Text);
            decimal vuelto = ingreso > 0 ? ingreso - total : 0;            
            if (vuelto < 0)
                ErVuelto.SetError(TxtVuelto, "Cantidad ingresada inválida");
            else
                ErVuelto.SetError(TxtVuelto, "");
            TxtVuelto.Text = vuelto.ToString();
        }

        private void TxtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.')))
            {
                e.Handled = false;
            }
        }

        public void CargarTipoMovimiento()
        {
            //var tipos = _tipoMovimiento.Listado(true);
            //CbTipoMovimiento.DataSource = tipos;
            //if (tipos.Any())
            //{
            //    CbTipoMovimiento.DisplayMember = "Descripcion";
            //    CbTipoMovimiento.ValueMember = "Id";
            //    CbTipoMovimiento.SelectedIndex = 0;
            //    CbTipoMovimiento.Invalidate();
            //}
        }

        private void TxtValor_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularVuelto();
        }

        private void FrmCobro_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (IdFactura > 0)
            //{
            //    _puntoDeVenta.Focus();
            //    _puntoDeVenta.GenerarFactura(IdFactura);
            //}            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //if (Convert.ToDecimal(TxtVuelto.Text) < 0)
            //    MessageBox.Show("¡Valor Ingresado NO Válido!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //else if (CbTipoMovimiento.SelectedItem == null)
            //    MessageBox.Show("¡Tipo de Pago NO Válido!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //else
            //{
            //    var tipom = (TipoMovimiento)CbTipoMovimiento.SelectedItem;
            //    string result = _factura.Insertar(_puntoDeVenta.GetModel(tipom.Id));
            //    if (result == "")
            //    {
            //        IdFactura = _factura.LastIdFactura();
            //        if (IdFactura > 0)
            //        {
            //            var listado = _puntoDeVenta.ListaDetalles(IdFactura);
            //            foreach (var d in listado)
            //            {
            //                result += _detalleFactura.Insertar(d);
            //                long productoId = d.ProductoId != null ? (long)d.ProductoId : 0;
            //                _puntoDeVenta.DescontarStock(productoId, d.Cantidad);
            //            }
                            
            //            if (result == "") {                            
            //                TxtTotal.Text = "0.00";
            //                TxtValor.Text = "0.00";
            //                TxtVuelto.Text = "0.00";
            //                MessageBox.Show("¡Venta Realizada Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                _puntoDeVenta.LimpiarCampos();
            //                _puntoDeVenta.GenerarFactura(IdFactura);
            //                this.Close();
            //            }
            //        }
            //        else
            //            MessageBox.Show("Error en el procesamiento interno.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //        MessageBox.Show(result, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
