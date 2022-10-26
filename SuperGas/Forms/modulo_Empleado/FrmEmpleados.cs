using Data.Mapas._helpers;
using Data.Mapas.Empleados;
using Data.Models.Direcciones;
using Data.Models.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperGas.Forms.modulo_Empleado
{
    public partial class FrmEmpleados : Form
    {
        private Empleado EmpleadoUpd = null;
        readonly Empleado _Empleado = new Empleado();
        readonly RolEmpleado _Roles = new RolEmpleado();
        readonly Departamentos _departamentos = new Departamentos();
        readonly Municipios _municipios = new Municipios();
        readonly Zonas _zonas = new Zonas();
        public List<MapaEmpleado> listado = new List<MapaEmpleado>();
        DateTime FechaIng = DateTime.Now;

        public FrmEmpleados()
        {
            InitializeComponent();
            CargarRoles();
            CargarDepartamentos();
            DtpFechaNacimiento.Value = FechaIng;
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text.ToUpper();
            var filter = listado.Where(x => x.Nombres.ToUpper().Contains(txt1) ||
                                            x.Apellidos.Contains(txt1) ||
                                            x.CodigoEmpleado.ToUpper().Contains(txt1));
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un Empleado para editar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rw = (MapaEmpleado)DgvRegistros.CurrentRow.DataBoundItem;
                EmpleadoUpd = _Empleado.GetEmpleado(rw.Id);
                if (EmpleadoUpd != null)
                {
                    FechaIng = EmpleadoUpd.FechaIngreso;
                    DtpFechaNacimiento.Value = EmpleadoUpd.FechaNacimiento;
                    TxtNombre.Text = EmpleadoUpd.Nombres;
                    TxtApellidos.Text = EmpleadoUpd.Apellidos;
                    TxtCorreo.Text = EmpleadoUpd.Correo;
                    TxtCodigo.Text = EmpleadoUpd.CodigoEmpleado;
                    TxtNit.Text = EmpleadoUpd.Nit;
                    TxtDPI.Text = EmpleadoUpd.DPI;
                    TxtObservaciones.Text = EmpleadoUpd.Observaciones;
                    TxtCelular.Text = EmpleadoUpd.Celular;
                    TxtTelefono.Text = EmpleadoUpd.Telefono;
                    TxtDireccion.Text = EmpleadoUpd.Direccion;
                    TxtEdad.Text = EmpleadoUpd.Edad +"";

                    CbDepto.SelectedValue = rw.DeptoId;
                    CbMpio.SelectedValue = rw.MunicipioId;
                    CbZona.SelectedValue = rw.ZonaId;

                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Empleado!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un Empleado para eliminar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rwpro = (MapaEmpleado)DgvRegistros.CurrentRow.DataBoundItem;
                var Getemp = _Empleado.GetEmpleado(rwpro.Id);
                if (Getemp != null)
                {
                    var dialog =
                            MessageBox.Show("¡Esta seguro que desea eliminar el Empleado!", "Eliminar Producto",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        Getemp.IsActive = false;
                        string result = _Empleado.Update(Getemp);
                        if (result == "")
                        {
                            MessageBox.Show("¡Empleado eliminado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDgv();
                        }
                        else
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Empleado!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (EmpleadoUpd == null)
                        resultado = _Empleado.Inserta(GetModel(0));
                    else
                        resultado = _Empleado.Update(GetModel(EmpleadoUpd.Id));

                    if (resultado == "")
                    {
                        MessageBox.Show("¡Cambios Guardados Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDgv();
                        LimpiarCampos();
                        ActivarCampos(true);
                        EmpleadoUpd = null;
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
            EmpleadoUpd = null;
        }

        public void CargarDgv()
        {
            listado = _Empleado.Listado();
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

        public void CargarDepartamentos()
        {
            var listado = _departamentos.Listado(true);
            CbDepto.DataSource = listado;
            CbDepto.DisplayMember = "Descripcion";
            CbDepto.ValueMember = "Id";
            if (listado.Any())
                CbDepto.SelectedIndex = 0;
            CbDepto.Invalidate();
        }

        public void CargarMunicipios()
        {
            var listado = new List<MapaEntity>();
            if (int.TryParse(CbDepto.SelectedValue + "", out int depto))
                listado = _municipios.Listado(depto);

            CbMpio.DataSource = listado;
            CbMpio.DisplayMember = "Descripcion";
            CbMpio.ValueMember = "Id";
            if (listado.Any())
                CbMpio.SelectedIndex = 0;
            CbMpio.Invalidate();

        }

        public void CargarZonas()
        {
            CbZona.Text = "";
            var listado = new List<MapaEntity>();
            if (int.TryParse(CbMpio.SelectedValue + "", out int mpio))
                listado = _zonas.Listado(mpio);

            CbZona.DataSource = listado;
            CbZona.DisplayMember = "Descripcion";
            CbZona.ValueMember = "Id";
            if (listado.Any())
                CbZona.SelectedIndex = 0;
            CbZona.Invalidate();
        }

        public void CargarRoles()
        {
            var listado = _Roles.Listado(true);
            CbRol.DataSource = listado;
            CbRol.DisplayMember = "Descripcion";
            CbRol.ValueMember = "Id";
            if (listado.Any())
                CbRol.SelectedIndex = 0;
            CbRol.Invalidate();
        }


        public void ActivarCampos(bool activar)
        {
            DtpFechaNacimiento.Enabled = activar;
            TxtNombre.Enabled = activar;
            TxtObservaciones.Enabled = activar;
            TxtCodigo.Enabled = activar;
            BtnGuardar.Enabled = activar;
            BtnCancelar.Enabled = activar;

            
            TxtApellidos.Enabled = activar;
            TxtCorreo.Enabled = activar;
            TxtNit.Enabled = activar;
            TxtDPI.Enabled = activar;
            TxtCelular.Enabled = activar;
            TxtTelefono.Enabled = activar;
            TxtDireccion.Enabled = activar;
            TxtEdad.Enabled = activar;

            CbDepto.Enabled = activar;
            CbMpio.Enabled = activar;
            CbZona.Enabled  = activar;
        }

        public void LimpiarCampos()
        {
            FechaIng = DateTime.Now;
            DtpFechaNacimiento.Value = FechaIng;
            TxtNombre.Text = "";
            TxtObservaciones.Text = "";
            TxtCodigo.Text = "";
            TxtApellidos.Text = "";
            TxtCorreo.Text = "";
            TxtNit.Text = "";
            TxtDPI.Text = "";
            TxtCelular.Text = "";
            TxtTelefono.Text = "";
            TxtDireccion.Text = "";
            TxtEdad.Text = "";
        }

        private string ValidarCampos()
        {
            if (CbDepto.SelectedItem == null)
                return "Debe seleccinar un Departamento";
            else if (CbMpio.SelectedItem == null)
                return "Debe seleccinar un Municipio";
            else if (CbZona.SelectedItem == null)
                return "Debe seleccionar una Zona";
            else if (CbRol.SelectedItem == null)
                return "Debe seleccionar un Rol";
            else if (TxtNombre.Text == "")
                return "Debe ingresar un Nombre";
            else
                return "";
        }

        private Empleado GetModel(long id)
        {
            return new Empleado()
            {
                Id = id,
                RolEmpleadoId = Convert.ToInt32(CbRol.SelectedValue),
                ZonaId = Convert.ToInt32(CbZona.SelectedValue),
            
                Nombres = TxtNombre.Text,
                Apellidos = TxtApellidos.Text,
                Correo = TxtCorreo.Text,
                Nit = TxtNit.Text,
                DPI = TxtDPI.Text,
                Direccion = TxtDireccion.Text,
                CodigoEmpleado = TxtCodigo.Text,
                Observaciones = TxtObservaciones.Text,
                Telefono = TxtTelefono.Text,
                Celular = TxtCelular.Text,
                Edad = int.TryParse(TxtEdad.Text, out int k) ? k : 0,
                FechaIngreso = FechaIng,
                FechaNacimiento = DtpFechaNacimiento.Value,
                IsActive = true
            };
        }

        private void CbDepto_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarMunicipios();
        }

        private void CbMpio_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarZonas();
        }

    }
}
