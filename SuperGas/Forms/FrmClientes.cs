using Data.Mapas.Clientes;
using Data.Models.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperGas.Forms.modulo_Cliente
{
    public partial class FrmClientes : Form
    {
        private Cliente ClienteUpd = null;
        readonly Cliente _cliente = new Cliente();
        readonly TipoCliente _tipoCliente = new TipoCliente();
        readonly CategoriaCliente _categoriaCliente = new CategoriaCliente();
        public List<MapaCliente> listado = new List<MapaCliente>();
        DateTime FechaIng = DateTime.Now;

        public FrmClientes()
        {
            InitializeComponent();
            TxtCodigo.Text = ObtenerNumero(_cliente.LastCodigoCliente(), "CL-");
            CargarTipoClientes();
            CargarCategorias();
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text.ToUpper();
            var filter = listado.Where(x => x.NombreCompleto.ToUpper().Contains(txt1) ||
                                            x.Direccion.Contains(txt1));
            DgvClientes.DataSource = filter.ToList();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvClientes.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un proveedor para editar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rw = (MapaCliente)DgvClientes.CurrentRow.DataBoundItem;
                ClienteUpd = _cliente.GetCliente(rw.Id);
                if (ClienteUpd != null)
                {
                    FechaIng = ClienteUpd.FechaCreacion;
                    TxtDireccion.Text = ClienteUpd.Direccion;
                    TxtNombres.Text = ClienteUpd.Nombres;
                    TxtNit.Text = ClienteUpd.Nit;
                    TxtDPI.Text = ClienteUpd.DPI;
                    TxtApellidos.Text = ClienteUpd.Apellidos;
                    TxtAlias.Text = ClienteUpd.Alias;
                    TxtCodigo.Text = ClienteUpd.CodigoCliente;
                    TxtTelefonos.Text = ClienteUpd.Telefonos;
                    CbTipo.SelectedValue = ClienteUpd.TipoId;
                    CbCategoria.SelectedValue = ClienteUpd.CategoriaId;
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del cliente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvClientes.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un cliente para eliminar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rw = (MapaCliente)DgvClientes.CurrentRow.DataBoundItem;
                var GetCli = _cliente.GetCliente(rw.Id);
                if (GetCli != null)
                {
                    var dialog =
                            MessageBox.Show("¡Esta seguro que desea eliminar el Cliente!", "Eliminar Producto",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        GetCli.IsActive = false;
                        string result = _cliente.Update(GetCli);
                        if (result == "")
                        {
                            MessageBox.Show("¡Cliente eliminado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDgv();
                        }
                        else
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Cliente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (ClienteUpd == null)
                        resultado = _cliente.Inserta(GetModel(0));
                    else
                        resultado = _cliente.Update(GetModel(ClienteUpd.Id));

                    if (resultado == "")
                    {
                        MessageBox.Show("¡Cambios Guardados Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDgv();
                        LimpiarCampos();
                        ActivarCampos(true);
                        ClienteUpd = null;
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
            ClienteUpd = null;
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
            listado = _cliente.Listado();
            BindingSource recurso = new BindingSource
            {
                DataSource = listado
            };
            DgvClientes.DataSource = typeof(List<>);
            DgvClientes.DataSource = recurso;
        }

        public void CargarTipoClientes()
        {
            var listado = _tipoCliente.Listado(true);
            CbTipo.DataSource = listado;
            CbTipo.DisplayMember = "Descripcion";
            CbTipo.ValueMember = "Id";
            if (listado.Any())
                CbTipo.SelectedIndex = 0;
            CbTipo.Invalidate();
        }

        public void CargarCategorias()
        {
            var listado = _categoriaCliente.Listado(true);
            CbCategoria.DataSource = listado;
            CbCategoria.DisplayMember = "Descripcion";
            CbCategoria.ValueMember = "Id";
            if (listado.Any())
                CbCategoria.SelectedIndex = 0;
            CbCategoria.Invalidate();
        }

        private string ObtenerNumero(string noDocumento, string tipo)
        {
            string numero;
            if (noDocumento.Length > 0)
            {
                int max = Convert.ToInt32(noDocumento.Split('-')[1]) + 1;
                if (max < 10)
                    numero = tipo + "00" + max;
                else if (max < 100)
                    numero = tipo + "0" + max;
                else
                    numero = tipo + max;
            }
            else
            {
                numero = tipo + "001";
            }
            return numero;
        }


        public void ActivarCampos(bool activar)
        {
            CbCategoria.Enabled = activar;
            CbTipo.Enabled = activar;
            TxtApellidos.Enabled = activar;
            TxtAlias.Enabled = activar;
            TxtCodigo.Enabled = activar;
            TxtDireccion.Enabled = activar;
            TxtNit.Enabled = activar;
            TxtDPI.Enabled = activar;
            TxtNombres.Enabled = activar;
            TxtTelefonos.Enabled = activar;
            BtnGuardar.Enabled = activar;
            BtnCancelar.Enabled = activar;
        }

        public void LimpiarCampos()
        {
            TxtDireccion.Text = "";
            TxtNombres.Text = "";
            TxtNit.Text = "";
            TxtDPI.Text = "";
            TxtApellidos.Text = "";
            TxtAlias.Text = "";
            TxtCodigo.Text = "";
            TxtTelefonos.Text = "";
        }

        private string ValidarCampos()
        {
            if (CbTipo.SelectedItem == null)
                return "Debe seleccinar un Tipo";
            else if (CbCategoria.SelectedItem == null)
                return "Debe seleccinar una Categoria";
            else if (TxtNombres.Text == "")
                return "Debe ingresar un Nombre";
            else
                return "";
        }

        private Cliente GetModel(long id)
        {
            return new Cliente()
            {
                Id = id,
                TipoId = Convert.ToInt32(CbTipo.SelectedValue),
                CategoriaId = Convert.ToInt32(CbCategoria.SelectedValue),
                CodigoCliente = TxtCodigo.Text,
                Nombres = TxtNombres.Text,
                Apellidos = TxtApellidos.Text,
                Alias = TxtAlias.Text,
                Direccion = TxtDireccion.Text,
                Telefonos = TxtTelefonos.Text,
                Nit = TxtNit.Text,
                DPI = TxtDPI.Text,
                FechaCreacion = FechaIng,
                IsActive = true
            };
        }

 
    }
}
