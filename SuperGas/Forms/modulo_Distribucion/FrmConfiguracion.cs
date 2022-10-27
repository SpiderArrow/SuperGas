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
using Data.Mapas._helpers;
using Data.Models.Direcciones;
using Data.Models.Gasolineras;
using Data.Models.Asignacion;
using Data.Models.Vehiculos;

namespace SuperGas.Forms.modulo_Distribucion
{
    public partial class FrmConfiguracion : Form
    {
        readonly AsignacionRuta _asignacionRuta = new AsignacionRuta();
        readonly AsignacionZonas _asignacionZonas = new AsignacionZonas();
        readonly Vehiculo _vehiculos = new Vehiculo();
        readonly Rutas _rutas = new Rutas();
        readonly Zonas _zonas = new Zonas();
        public bool CargaAutomatica = false;      
        public MapaAsigna _modelo = null;
        public bool Nuevo = true;
        public int Opc =0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmConfiguracion()
        {
            InitializeComponent();
           
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            CargarComboConfiguracion();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CbConfiguracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Configuracion)CbConfiguracion.ComboBox.SelectedItem;
            Opc = item.Id;
            if (CargaAutomatica)
                CargarDatos(Opc);
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            CargarDatos(Opc);
            CargaAutomatica = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtCodigo.Text = _modelo != null ? _modelo.Entity1 : "";
            Nuevo = false;
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            TxtCodigo.Text = _modelo != null ? _modelo.Entity1 : "";
            _modelo.Estado = "Inactivo";
            var dialog =
                            MessageBox.Show("¡Esta seguro que desea desactivar el elemento seleccionado!", "Desactivación",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                string result = ActualizarEntity();
                if (result == "")
                    MessageBox.Show("¡Elemento desactivado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CargarDatos(Opc);
                LimpiarDatos();
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            TxtCodigo.Text = _modelo != null ? _modelo.Entity1 : "";
            _modelo.Estado = "Activo";
            string result = ActualizarEntity();
            if (result == "")
                MessageBox.Show("¡Elemento Activado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            CargarDatos(Opc);
            LimpiarDatos();
        }

        private void DgvModels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _modelo = (MapaAsigna)DgvModels.CurrentRow.DataBoundItem;
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = ValidarCampos(Opc);
            if (mensaje.Length == 0)
            {
                _modelo = Nuevo ? null : _modelo;
                string result = _modelo == null ? GuardarEntity() : ActualizarEntity();
                if (result == "")
                    MessageBox.Show("¡Cambios guardados exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(result, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarDatos(Opc);
                LimpiarDatos();
                _modelo = null;
            }
            else
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PnlFormulario.Visible = false;
        }

        public void CargarComboConfiguracion()
        {
            List<Configuracion> lista = new List<Configuracion>
            {
                new Configuracion() { Id = 0, Descripcion = "Seleccione una opción" },
                new Configuracion() { Id = 1, Descripcion = "Rutas a Vehiculos" },
                new Configuracion() { Id = 2, Descripcion = "Zonas a Rutas" },
                new Configuracion() { Id = 3, Descripcion = "Ingreso Rutas" }
            };

            CbConfiguracion.ComboBox.DataSource = lista;
            CbConfiguracion.ComboBox.DisplayMember = "Descripcion";
            CbConfiguracion.ComboBox.ValueMember = "Id";
            CbConfiguracion.ComboBox.SelectedItem = 1;
            CbConfiguracion.ComboBox.Invalidate();
        }

        public void CargarDatos(int opcion) {
            PnlFormulario.Visible = true;
            switch (opcion)
            {
                case 1:                    
                    CargarDgv(_asignacionRuta.Listado(), "Asignar Rutas/Vehiculo", true, "Ruta", "Vehiculo");
                    LbCombo1.Text = "Rutas";
                    CargarCombos(CbCombo1, _rutas.Listado(null), "Descripcion");
                    LbCombo2.Text = "Vehiculos";
                    CargarCombos(CbCombo2, _vehiculos.ListadoVehiculos(), "DescripcionVehiculo");
                    ActivarCampos(true);
                    BtnGuardar.Text = "Asignar";
                    TxtCodigo.Text = "";
                    break;
                case 2:
                    CargarDgv(_asignacionZonas.Listado(), "Asignar Zonas/Rutas", true, "Zona", "Ruta");
                    LbCombo1.Text = "Zonas";
                    CargarCombos(CbCombo1, _zonas.Listado(null), "Descripcion");
                    LbCombo2.Text = "Rutas";
                    CargarCombos(CbCombo2, _rutas.Listado(null), "Descripcion");
                    ActivarCampos(true);
                    BtnGuardar.Text = "Asignar";
                    TxtCodigo.Text = "";
                    break;
                case 3:
                    CargarDgv(_rutas.Listado(), "Rutas", false, "Rutas", "");
                    ActivarCampos(false);
                    CbCombo1.Text = "";
                    CbCombo2.Text = "";
                    break;
                default:
                    MessageBox.Show("¡Debe Seleccionar una de las opciones!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        public void CargarDgv(object source,string label, bool visible, string header1, string header2)
        {
            try
            {
                DgvModels.DataSource = source;

                LbEntity.Visible = true;
                LbEntity.Text = label;

                DgvModels.Columns[1].Visible = false;
                DgvModels.Columns[2].Visible = false;

                DgvModels.Columns[3].HeaderText = header1;

                DgvModels.Columns[4].Visible = visible;
                DgvModels.Columns[4].HeaderText = header2;

                DgvModels.Columns[5].Visible = !visible;


            } catch (Exception ex){
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public void CargarCombos(ComboBox cb, object source, string display)
        {  
            cb.DataSource = source;
            cb.DisplayMember = display;
            cb.ValueMember = "Id";
            cb.SelectedItem = 1;
            cb.Invalidate();            
        }

        public string GuardarEntity() {
            switch (Opc)
            {
                case 1:
                    return _asignacionRuta.Insert(new AsignacionRuta()
                    {
                        RutaId = Convert.ToInt32(CbCombo1.SelectedValue),
                        VehiculoId = Convert.ToInt32(CbCombo2.SelectedValue),
                    }); 
                case 2:
                    return _asignacionZonas.Insert(new AsignacionZonas()
                    {
                        ZonaId = Convert.ToInt32(CbCombo1.SelectedValue),
                        RutaId = Convert.ToInt32(CbCombo2.SelectedValue),
                    });
                case 3:
                    return _rutas.Insert(new Rutas()
                    {
                        CodigoRuta = TxtCodigo.Text,
                        IsActive = true
                    });
                default:
                    return "";
            }
        }

        public string ActualizarEntity()
        {
            return _rutas.Update(new Rutas()
            {
                Id = _modelo.Id,
                CodigoRuta = TxtCodigo.Text,
                IsActive = _modelo.Estado == "Activo"
            });
        }

        public void LimpiarDatos() {
            TxtCodigo.Text = "";
            if(CbCombo1.Items.Count > 0)
                CbCombo1.SelectedIndex = 0;
            if(CbCombo2.Items.Count > 0)
                CbCombo2.SelectedIndex = 0;
        }

        public void ActivarCampos(bool activar) {

            LbEntity.Visible = activar;
            LbCombo1.Visible = activar;
            LbCombo2.Visible = activar;

            CbCombo1.Enabled = activar;
            CbCombo2.Enabled = activar;

            TxtCodigo.Enabled = !activar;

            BtnEditar.Enabled = !activar;
            BtnDesactivar.Enabled = !activar;
            BtnActivar.Enabled = !activar;
        }


        public string ValidarCampos(int Opc)
        {
            string mensaje = "";
            switch (Opc) {
                case 1:
                    if (CbCombo1.SelectedValue == null)
                        mensaje = "Debe Seleccionar Ruta";
                    else if (CbCombo2.SelectedValue == null)
                        mensaje = "Debe Seleccionar Vehiculo";
                    break;
                case 2:
                    if (CbCombo1.SelectedValue == null)
                        mensaje = "Debe Seleccionar Zona";
                    else if (CbCombo2.SelectedValue == null)
                        mensaje = "Debe Seleccionar Ruta";
                    break;
                case 3:
                    if (TxtCodigo.Text.Length == 0)
                        mensaje = "Debe ingresar codigo para la ruta";
                    break;
                default:
                    mensaje = "";
                    break;
            }
            return mensaje;
        }
        
    }
}
