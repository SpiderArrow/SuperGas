using Data.Mapas._helpers;
using Data.Mapas.Gasolineras;
using Data.Models.Direcciones;
using Data.Models.Gasolineras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperGas.Forms.modulo_Gasolineras
{
    public partial class FrmGasolineras : Form
    {
        private Gasolinera GasolineraUpd = null;
        readonly Gasolinera _Gasolinera = new Gasolinera();
        readonly Departamentos _departamentos = new Departamentos();
        readonly Municipios _municipios = new Municipios();
        readonly Zonas _zonas = new Zonas();
        readonly Empresas _empresas = new Empresas();
        public List<MapaGasolinera> listado = new List<MapaGasolinera>();
        DateTime FechaIng = DateTime.Now;



        public FrmGasolineras()
        {
            InitializeComponent();
            CargarDepartamentos();
            CargarEmpresas();
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text.ToUpper();
            var filter = listado.Where(x => x.Nombre.ToUpper().Contains(txt1) ||
                                            x.Direccion.Contains(txt1) ||
                                            x.Correo.ToUpper().Contains(txt1));
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
                MessageBox.Show("¡Debe seleccionar un Gasolinera para editar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rw = (MapaGasolinera)DgvRegistros.CurrentRow.DataBoundItem;
                GasolineraUpd = _Gasolinera.GetGasolinera(rw.Id);
                if (GasolineraUpd != null)
                {
                    FechaIng = GasolineraUpd.FechaIngreso;
                    TxtNombre.Text = GasolineraUpd.Nombre;
                    TxtCorreo.Text = GasolineraUpd.Correo;
                    TxtNit.Text = GasolineraUpd.Nit;
                    TxtObservaciones.Text = GasolineraUpd.Observaciones;
                    TxtCelular1.Text = GasolineraUpd.Celular1;
                    TxtCelular2.Text = GasolineraUpd.Celular2;
                    TxtTelefono1.Text = GasolineraUpd.Telefonos1;
                    TxtTelefono2.Text = GasolineraUpd.Telefonos2;
                    CbEmpresa.SelectedValue = GasolineraUpd.EmpresaId;

                    CbDepto.SelectedValue = rw.DeptoId;
                    CbMpio.SelectedValue = rw.MunicipioId;
                    CbZona.SelectedValue = rw.ZonaId;
                
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Gasolinera!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un Gasolinera para eliminar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rwpro = (MapaGasolinera)DgvRegistros.CurrentRow.DataBoundItem;
                var GetGas = _Gasolinera.GetGasolinera(rwpro.Id);
                if (GetGas != null)
                {
                    var dialog =
                            MessageBox.Show("¡Esta seguro que desea eliminar el Gasolinera!", "Eliminar Producto",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        GetGas.IsActive = false;
                        string result = _Gasolinera.Update(GetGas);
                        if (result == "")
                        {
                            MessageBox.Show("¡Gasolinera eliminado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDgv();
                        }
                        else
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Gasolinera!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (GasolineraUpd == null)
                        resultado = _Gasolinera.Inserta(GetModel(0));
                    else
                        resultado = _Gasolinera.Update(GetModel(GasolineraUpd.Id));

                    if (resultado == "")
                    {
                        MessageBox.Show("¡Cambios Guardados Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDgv();
                        LimpiarCampos();
                        ActivarCampos(true);
                        GasolineraUpd = null;
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
            GasolineraUpd = null;
        }

        public void CargarDgv()
        {
            listado = _Gasolinera.Listado();
            BindingSource recurso = new BindingSource
            {
                DataSource = listado
            };
            DgvRegistros.DataSource = typeof(List<>);
            DgvRegistros.DataSource = recurso;

            if (listado.Any()) {
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

        public void CargarEmpresas()
        {
            var listado = _empresas.Listado(true);
            CbEmpresa.DataSource = listado;
            CbEmpresa.DisplayMember = "Descripcion";
            CbEmpresa.ValueMember = "Id";
            if (listado.Any())
                CbEmpresa.SelectedIndex = 0;
            CbEmpresa.Invalidate();
        }

        public void ActivarCampos(bool activar)
        {
            CbMpio.Enabled = activar;
            CbDepto.Enabled = activar;
            CbZona.Enabled = activar;
            TxtNombre.Enabled = activar;
            TxtCorreo.Enabled = activar;
            TxtNit.Enabled = activar;
            TxtObservaciones.Enabled = activar;
            TxtCelular1.Enabled = activar;
            TxtCelular2.Enabled = activar;
            TxtTelefono1.Enabled = activar;
            TxtTelefono2.Enabled = activar;
            BtnGuardar.Enabled = activar;
            BtnCancelar.Enabled = activar;
            CbDepto.Enabled = activar;
            CbMpio.Enabled = activar;
            CbZona.Enabled = activar;
        }

        public void LimpiarCampos()
        {
            TxtNombre.Text = "";
            TxtCorreo.Text = "";
            TxtNit.Text = "";
            TxtObservaciones.Text = "";
            TxtCelular1.Text = "";
            TxtCelular2.Text = "";
            TxtTelefono1.Text = "";
            TxtTelefono2.Text = "";
        }

        private string ValidarCampos()
        {
            if (CbDepto.SelectedItem == null)
                return "Debe seleccinar un Departamento";
            else if (CbMpio.SelectedItem == null)
                return "Debe seleccinar un Municipio";
            else if (CbZona.SelectedItem == null)
                return "Debe seleccionar una Zona";
            else if (CbEmpresa.SelectedItem == null)
                return "Debe seleccionar una Empresa";
            else if (TxtNombre.Text == "")
                return "Debe ingresar un Nombre";
            else
                return "";
        }

        private Gasolinera GetModel(long id)
        {
            return new Gasolinera()
            {
                Id = id,
                ZonaId = Convert.ToInt32(CbZona.SelectedValue),
                EmpresaId = Convert.ToInt32(CbEmpresa.SelectedValue),
                Nombre = TxtNombre.Text,
                Correo = TxtCorreo.Text,
                Telefonos1 = TxtTelefono1.Text,
                Telefonos2 = TxtTelefono2.Text,
                Celular1 = TxtCelular1.Text,
                Celular2 = TxtCelular2.Text,
                Nit = TxtNit.Text,
                Observaciones = TxtObservaciones.Text,
                FechaIngreso = FechaIng,
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
