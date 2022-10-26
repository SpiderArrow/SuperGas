using Data.Mapas.Vehiculos;
using Data.Models.Empleados;
using Data.Models.Vehiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperGas.Forms.modulo_Vehiculos
{
    public partial class FrmCamiones : Form
    {
        private Vehiculo VehiculoUpd = null;
        readonly Vehiculo _Vehiculo = new Vehiculo();
        readonly TipoCombustible _tipoCombustible = new TipoCombustible();
        readonly Marca _marcas = new Marca();
        readonly Empleado _empleados = new Empleado();
        public List<MapaVehiculos> listado = new List<MapaVehiculos>();
       
        public FrmCamiones()
        {
            InitializeComponent();
            CargarTipoCombustible();
            CargarMarcas();
            CargarEmpleados();
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text.ToUpper();
            var filter = listado.Where(x => x.Nombre.ToUpper().Contains(txt1) ||
                                            x.Codigo.Contains(txt1) ||
                                            x.Placa.ToUpper().Contains(txt1));
            DgvRegistros.DataSource = filter.ToList();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un Vehiculo para editar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rw = (MapaVehiculos)DgvRegistros.CurrentRow.DataBoundItem;
                VehiculoUpd = _Vehiculo.GetVehiculo(rw.Id);
                if (VehiculoUpd != null)
                {
                    CbTipoCombustible.SelectedValue = rw.TipoCombustibleId;
                    CbMarca.SelectedValue = rw.MarcaId;
                    CbEncargado.SelectedValue = rw.EmpleadoId;

                    TxtNombre.Text = VehiculoUpd.Nombre;
                    TxtKilometraje.Text = VehiculoUpd.Kilometraje+"";
                    TxtPlaca.Text = VehiculoUpd.Placa;
                    TxtCodigo.Text = VehiculoUpd.Codigo;
                    TxtModelo.Text = VehiculoUpd.Modelo;
                    TxtNoMotor.Text = VehiculoUpd.NumeroMotor;
                    TxtObservaciones.Text = VehiculoUpd.Observaciones;
                    TxtActuales.Text = VehiculoUpd.GalonesActuales+"";
                    TxtGalones.Text = VehiculoUpd.CantidadGalones+"";
                    TxtGlDespachados.Text = VehiculoUpd.GalonesDespachados+"";

                    TxtGlDespachados.Enabled = true;
                    TxtActuales.Enabled = true;

                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Vehiculo!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un Vehiculo para eliminar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rwpro = (MapaVehiculos)DgvRegistros.CurrentRow.DataBoundItem;
                var Getveh = _Vehiculo.GetVehiculo(rwpro.Id);
                if (Getveh != null)
                {
                    var dialog =
                            MessageBox.Show("¡Esta seguro que desea eliminar el Vehiculo!", "Eliminar Producto",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        Getveh.IsActive = false;
                        string result = _Vehiculo.Update(Getveh);
                        if (result == "")
                        {
                            MessageBox.Show("¡Vehiculo eliminado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDgv();
                        }
                        else
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Vehiculo!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (VehiculoUpd == null)
                        resultado = _Vehiculo.Insert(GetModel(0));
                    else
                        resultado = _Vehiculo.Update(GetModel(VehiculoUpd.Id));

                    if (resultado == "")
                    {
                        MessageBox.Show("¡Cambios Guardados Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDgv();
                        LimpiarCampos();
                        ActivarCampos(true);
                        VehiculoUpd = null;
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
            VehiculoUpd = null;
        }

        public void CargarDgv()
        {
            listado = _Vehiculo.Listado();
            BindingSource recurso = new BindingSource
            {
                DataSource = listado
            };
            DgvRegistros.DataSource = typeof(List<>);
            DgvRegistros.DataSource = recurso;

            if (listado.Any())
            {
                DgvRegistros.Columns[1].Visible = false;
                DgvRegistros.Columns[2].Visible = false;
                DgvRegistros.Columns[3].Visible = false;
            }
        }

        public void CargarTipoCombustible()
        {
            var listado = _tipoCombustible.Listado(true);
            CbTipoCombustible.DataSource = listado;
            CbTipoCombustible.DisplayMember = "Descripcion";
            CbTipoCombustible.ValueMember = "Id";
            if (listado.Any())
                CbTipoCombustible.SelectedIndex = 0;
            CbTipoCombustible.Invalidate();
        }

        public void CargarMarcas()
        {
            var listado = _marcas.Listado(true);
            CbMarca.DataSource = listado;
            CbMarca.DisplayMember = "Descripcion";
            CbMarca.ValueMember = "Id";
            if (listado.Any())
                CbMarca.SelectedIndex = 0;
            CbMarca.Invalidate();
        }

        public void CargarEmpleados()
        {
            var listado = _empleados.ListadoConductor();
            CbEncargado.DataSource = listado;
            CbEncargado.DisplayMember = "NombreCompleto";
            CbEncargado.ValueMember = "Id";
            if (listado.Any())
                CbEncargado.SelectedIndex = 0;
            CbEncargado.Invalidate();
        }

        public void ActivarCampos(bool activar)
        {
            CbTipoCombustible.Enabled = activar;
            CbMarca.Enabled = activar;
            CbEncargado.Enabled = activar;
            TxtNombre.Enabled = activar;
            TxtKilometraje.Enabled = activar;
            TxtPlaca.Enabled = activar;
            TxtObservaciones.Enabled = activar;
            TxtCodigo.Enabled = activar;
            TxtModelo.Enabled = activar;
            TxtNoMotor.Enabled = activar;
            BtnGuardar.Enabled = activar;
            BtnCancelar.Enabled = activar;
        }

        public void LimpiarCampos()
        {
            TxtNombre.Text = "";
            TxtKilometraje.Text = "0";
            TxtPlaca.Text = "";
            TxtObservaciones.Text = "";
            TxtCodigo.Text = "";
            TxtModelo.Text = "";
            TxtNoMotor.Text = "";
        }

        private string ValidarCampos()
        {
            if (CbTipoCombustible.SelectedItem == null)
                return "Debe seleccinar un Tipo de Combustible";
            else if (CbMarca.SelectedItem == null)
                return "Debe seleccinar un Marca";
            else if (CbEncargado.SelectedItem == null)
                return "Debe seleccionar una Encargado";    
            else
                return "";
        }

        private Vehiculo GetModel(long id)
        {
            return new Vehiculo()
            {
                Id = id,
                TipoCombustibleId = Convert.ToInt32(CbTipoCombustible.SelectedValue),
                MarcaId = Convert.ToInt32(CbMarca.SelectedValue),
                EmpleadoId = Convert.ToInt32(CbEncargado.SelectedValue),
                Nombre = TxtNombre.Text,
                Kilometraje = int.TryParse(TxtKilometraje.Text, out int k) ? k : 0,
                CantidadGalones = int.TryParse(TxtGalones.Text, out int g) ? g : 0,
                GalonesActuales = int.TryParse(TxtActuales.Text, out int ga) ? ga : 0,
                GalonesDespachados = int.TryParse(TxtGlDespachados.Text, out int gd) ? gd : 0,
                Placa = TxtPlaca.Text,
                Codigo = TxtCodigo.Text,
                Modelo = TxtModelo.Text,
                NumeroMotor = TxtNoMotor.Text,
                Observaciones = TxtObservaciones.Text,
                IsActive = true
            };
        }

        private void TsUsuarios_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
