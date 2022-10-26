using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Mapas.Proveedores;
using Data.Models.Proveedores;

namespace SaleAdmin.Forms.modulo_proveedores
{
    public partial class FrmProveedores : Form
    {
        private Proveedor ProveedorUpd = null;
        readonly Proveedor _proveedor = new Proveedor();
        readonly TipoProveedor _tipoProveedor = new TipoProveedor();
        readonly Frecuencia _frecuencia = new Frecuencia();
        readonly Rubro _rubro = new Rubro();
        public List<MapaProveedor> listado = new List<MapaProveedor>();
        DateTime FechaIng = DateTime.Now;

        public FrmProveedores()
        {
            InitializeComponent();
            CargarTipoProveedores();
            CargarFrecuencia();
            CargarRubros();
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text.ToUpper();
            var filter = listado.Where(x => x.Nombre.ToUpper().Contains(txt1) ||
                                            x.Direccion.Contains(txt1) ||
                                            x.Correo.ToUpper().Contains(txt1));
            DgvProveedores.DataSource = filter.ToList();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvProveedores.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un proveedor para editar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rwprov = (MapaProveedor)DgvProveedores.CurrentRow.DataBoundItem;
                ProveedorUpd = _proveedor.GetProveedor(rwprov.Id);
                if (ProveedorUpd != null)
                {
                    FechaIng = ProveedorUpd.FechaIngreso;
                    TxtSaldo.Text = ProveedorUpd.Saldo.ToString();
                    TxtDireccion.Text = ProveedorUpd.Direccion;
                    TxtNombre.Text = ProveedorUpd.Nombre;
                    TxtCorreo.Text = ProveedorUpd.Correo;
                    TxtNit.Text = ProveedorUpd.Nit;
                    TxtNoCuenta.Text = ProveedorUpd.NoCuentaBancaria;
                    TxtEntidad.Text = ProveedorUpd.EntidadBancaria;
                    TxtObservaciones.Text = ProveedorUpd.Observaciones;
                    TxtCelular1.Text = ProveedorUpd.Celular;
                    TxtCelular2.Text = ProveedorUpd.Celular2;
                    TxtTelefono1.Text = ProveedorUpd.Telefonos;
                    TxtTelefono2.Text = ProveedorUpd.Telefonos2;
                    CbFrecuencia.SelectedValue = ProveedorUpd.FrecuenciaId;
                    CbRubro.SelectedValue = ProveedorUpd.RubroId;
                    CbTipoProveedor.SelectedValue = ProveedorUpd.TipoProveedorId;                    
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del proveedor!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvProveedores.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un proveedor para eliminar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rwpro = (MapaProveedor)DgvProveedores.CurrentRow.DataBoundItem;
                var GetProv = _proveedor.GetProveedor(rwpro.Id);
                if (GetProv != null)
                {
                    var dialog =
                            MessageBox.Show("¡Esta seguro que desea eliminar el Proveedor!", "Eliminar Producto",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        GetProv.IsActive = false;
                        string result = _proveedor.Update(GetProv);
                        if (result == "")
                        {
                            MessageBox.Show("¡Proveedor eliminado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDgv();
                        }
                        else
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Proveedor!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmConfiguracion"] == null)
            {
                FrmConfiguracion config = new FrmConfiguracion(this);
                config.Show();
            }
            else
                Application.OpenForms["FrmConfiguracion"].Activate();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = ValidarCampos();
                if (mensaje == "")
                {
                    string resultado;
                    ActivarCampos(false);
                    if (ProveedorUpd == null)
                        resultado = _proveedor.Inserta(GetModel(0));
                    else
                        resultado = _proveedor.Update(GetModel(ProveedorUpd.Id));

                    if (resultado == "")
                    {
                        MessageBox.Show("¡Cambios Guardados Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDgv();
                        LimpiarCampos();
                        ActivarCampos(true);
                        ProveedorUpd = null;
                    }
                    else
                    {
                        ActivarCampos(true);
                        MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ActivarCampos(true);
                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ActivarCampos(true);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ProveedorUpd = null;
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
        }

        public void CargarDgv()
        {
            listado = _proveedor.Listado();
            BindingSource recurso = new BindingSource
            {
                DataSource = listado
            };
            DgvProveedores.DataSource = typeof(List<>);
            DgvProveedores.DataSource = recurso;
        }

        public void CargarTipoProveedores()
        {
            var listado = _tipoProveedor.Listado(true);
            CbTipoProveedor.DataSource = listado;
            CbTipoProveedor.DisplayMember = "Descripcion";
            CbTipoProveedor.ValueMember = "Id";
            if (listado.Any())
                CbTipoProveedor.SelectedIndex = 0;
            CbTipoProveedor.Invalidate();
        }

        public void CargarFrecuencia() {
            var listado = _frecuencia.Listado(true);
            CbFrecuencia.DataSource = listado;
            CbFrecuencia.DisplayMember = "Descripcion";
            CbFrecuencia.ValueMember = "Id";
            if(listado.Any())
                CbFrecuencia.SelectedIndex = 0;
            CbFrecuencia.Invalidate();
        }

        public void CargarRubros()
        {
            var listado = _rubro.Listado(true);
            CbRubro.DataSource = listado;
            CbRubro.DisplayMember = "Descripcion";
            CbRubro.ValueMember = "Id";
            if (listado.Any())
                CbRubro.SelectedIndex = 0;
            CbRubro.Invalidate();
        }

        public void ActivarCampos(bool activar)
        {
            CbFrecuencia.Enabled = activar;
            CbRubro.Enabled = activar;
            CbTipoProveedor.Enabled = activar;
            TxtSaldo.Enabled = activar;
            TxtDireccion.Enabled = activar;
            TxtNombre.Enabled = activar;
            TxtCorreo.Enabled = activar;
            TxtNit.Enabled = activar;
            TxtNoCuenta.Enabled = activar;
            TxtEntidad.Enabled = activar;
            TxtObservaciones.Enabled = activar;
            TxtCelular1.Enabled = activar;
            TxtCelular2.Enabled = activar;
            TxtTelefono1.Enabled = activar;
            TxtTelefono2.Enabled = activar;
            BtnGuardar.Enabled = activar;
            BtnCancelar.Enabled = activar;
        }

        public void LimpiarCampos()
        {
            TxtSaldo.Text = "0.00";
            TxtDireccion.Text = "";
            TxtNombre.Text = "";
            TxtCorreo.Text = "";
            TxtNit.Text = "";
            TxtNoCuenta.Text = "";
            TxtEntidad.Text = "";
            TxtObservaciones.Text = "";
            TxtCelular1.Text = "";
            TxtCelular2.Text = "";
            TxtTelefono1.Text = "";
            TxtTelefono2.Text = "";
        }

        private string ValidarCampos()
        {
            if (CbFrecuencia.SelectedItem == null)
                return "Debe seleccinar una Frecuencia";
            else if (CbRubro.SelectedItem == null)
                return "Debe seleccinar un Rubro";
            else if (CbTipoProveedor.SelectedItem == null)
                return "Debe seleccionar un Tipo de Proveedor";            
            else if (TxtNombre.Text == "")
                return "Debe ingresar un Nombre";
            else
                return "";
        }

        private Proveedor GetModel(long id)
        {
            return new Proveedor()
            {
                Id = id,
                RubroId = Convert.ToInt32(CbRubro.SelectedValue),
                FrecuenciaId = Convert.ToInt32(CbFrecuencia.SelectedValue),
                TipoProveedorId = Convert.ToInt32(CbTipoProveedor.SelectedValue),
                Nombre = TxtNombre.Text,
                Direccion = TxtDireccion.Text,
                Correo = TxtCorreo.Text,
                Telefonos = TxtTelefono1.Text,
                Telefonos2 = TxtTelefono2.Text,
                Celular = TxtCelular1.Text,
                Celular2 = TxtCelular2.Text,
                Nit = TxtNit.Text,
                NoCuentaBancaria = TxtNoCuenta.Text,
                EntidadBancaria = TxtEntidad.Text,
                Saldo = TxtSaldo.Text != "" ? Convert.ToDecimal(TxtSaldo.Text) : 0.00m,
                Observaciones = TxtObservaciones.Text,
                FechaIngreso = FechaIng,
                IsActive = true
            };
        }
    }
}
