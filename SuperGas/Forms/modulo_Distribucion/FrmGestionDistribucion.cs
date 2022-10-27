using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models.Empleados;
using Data.Models.Gasolineras;
using Data.Models.Vehiculos;
using Data.Models.Limpieza;
using Data.Mapas._helpers;
using Data.Mapas.Vehiculos;
using Data.Mapas.Gasolineras;

namespace SuperGas.Forms.modulo_Distribucion
{
    public partial class FrmGestionDistribucion : Form
    {
        readonly Vehiculo _vehiculos = new Vehiculo();
        readonly Gasolinera _gasolinera = new Gasolinera();
        readonly Bombas _bombas = new Bombas();
        readonly TipoCombustible _tipoCombustible = new TipoCombustible();
        readonly Cisternas _cisternas = new Cisternas();
        readonly Empleado _empleados = new Empleado();
        readonly PrecioGalon _preciosGalon = new PrecioGalon();
        private List<PrecioGalon> _listadoPreciosGalon = new List<PrecioGalon>();
        private DateTime Hoy = new DateTime();

        public FrmGestionDistribucion()
        {
            InitializeComponent();
            EstablecerFecha();
            CargarPreciosGalon();
            CargarTipoCombustible();                   
            CargarBombas();
            CargarVehiculos();
            CargarGasolineras();
            CargarEmpleados();
            
        }

        public void EstablecerFecha() {
            TimeSpan time = new TimeSpan(0, 0, 0);
            Hoy = DateTime.Now.Date + time;
            DtpFechaDespacho.Value = Hoy;
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

        public void CargarBombas()
        {
            var tcId = int.TryParse(CbTipoCombustible.SelectedValue + "", out int tc) ? tc : 1;
            var listado = _bombas.ListadoBombasDespacho(tcId);

            CbBombas.DataSource = listado;
            CbBombas.DisplayMember = "Descripcion";
            CbBombas.ValueMember = "Id";
            if (listado.Any())
                CbBombas.SelectedIndex = 0;
            else
                CbBombas.Text = "";
            CbBombas.Invalidate();
        }

        public void CargarVehiculos()
        {
            var tcId = int.TryParse(CbTipoCombustible.SelectedValue + "", out int tc) ? tc : 1;
            var listado = _vehiculos.ListadoVehiculos(tcId);

            CbCamiones.DataSource = listado;
            CbCamiones.DisplayMember = "DescripcionVehiculo";
            CbCamiones.ValueMember = "Id";
            if (listado.Any())
                CbCamiones.SelectedIndex = 0;
            else
                CbCamiones.Text = "";
            CbCamiones.Invalidate();
        }

        public void CargarGasolineras()
        {
            var listado = _gasolinera.ListadoGasolineras();
            CbGasolineras.DataSource = listado;
            CbGasolineras.DisplayMember = "Descripcion";
            CbGasolineras.ValueMember = "Id";
            if (listado.Any())
                CbGasolineras.SelectedIndex = 0;
            CbGasolineras.Invalidate();
        }

        public void CargarCisternas()
        {
            var gasId = int.TryParse(CbCisternas.SelectedValue + "", out int cs) ? cs : 1;
            var tcId = int.TryParse(CbTipoCombustible.SelectedValue + "", out int tc) ? tc : 1;
            var listado = _cisternas.Listado(gasId, tcId);

            CbCisternas.DataSource = listado;
            CbCisternas.DisplayMember = "Descripcion";
            CbCisternas.ValueMember = "Id";
            if (listado.Any())
                CbCisternas.SelectedIndex = 0;
            else
                CbCisternas.Text = "";
            CbCisternas.Invalidate();

        }

        public void CargarEmpleados()
        {
            var listado = _empleados.ListadoByRol("despacha");
            CbEncargado.DataSource = listado;
            CbEncargado.DisplayMember = "NombreCompleto";
            CbEncargado.ValueMember = "Id";
            if (listado.Any())
                CbEncargado.SelectedIndex = 0;
            CbEncargado.Invalidate();
        }

        public void CargarPreciosGalon()
        {
            _listadoPreciosGalon = _preciosGalon.GetByFecha(Hoy);
        }

        public void IngresoPrecioGalon()
        {
            var tcId = int.TryParse(CbTipoCombustible.SelectedValue + "", out int tc) ? tc : 1;

            if (_listadoPreciosGalon.Any())
            {
                var listatmp = _listadoPreciosGalon.Where(x => x.TipoCombustibleId == tcId).ToList();

                if (!listatmp.Any())
                {
                    var dialog =
                            MessageBox.Show("¡NO se ha ingresado precio de Galón " + CbTipoCombustible.Text + " del dia!, ¿Desea ingresarlo?", "ingreso Precio Galón",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        FormBase parent = this.ParentForm as FormBase;
                        parent.PrecioGalon();
                    }
                }
                else
                {
                    TxtPrecioGal.Text = _listadoPreciosGalon.FirstOrDefault().Precio + "";
                }
            }
        }

        private void CargarDatosFacturacion() {
            var gasId = Int64.TryParse(CbGasolineras.SelectedValue + "", out long g) ? g : 1;
            var Gaso = _gasolinera.GetGasolinera(g);
            if (Gaso != null)
            {
                TxtNombre.Text = Gaso.Nombre;
                TxtNit.Text = Gaso.Nit;
            }

        }

        public void LimpiarDatosFacturacion() {
            TxtNit.Text = "";
            TxtNombre.Text = "";
            TxtDireccion.Text = "";
            TxtTotal.Text = "";
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.MDistribucion();
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

        private void RbBombaCamion_CheckedChanged(object sender, EventArgs e)
        {
            CbBombas.Enabled = RbBombaCamion.Checked;
            CbCamiones.Enabled = RbBombaCamion.Checked;
            LimpiarDatosFacturacion();
        }

        private void RbCamionCisterna_CheckedChanged(object sender, EventArgs e)
        {
            CbCamiones.Enabled = RbCamionCisterna.Checked;
            CbGasolineras.Enabled = RbCamionCisterna.Checked;
            CbCisternas.Enabled = RbCamionCisterna.Checked;
            GbFacturacion.Enabled = RbCamionCisterna.Checked;
            CargarDatosFacturacion();
        }

        private void CbGasolineras_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCisternas();
            CargarDatosFacturacion();
        }

        private void CbBombas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bomba = CbBombas.SelectedItem;
            if (bomba != null)
            {
                var b = (MapaSimple)bomba;
                TxtGalBomba.Text = b.GalonesDisponibles + "";
            }
        }

        private void CbCamiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vehiculo = CbCamiones.SelectedItem;
            if (vehiculo != null)
            {
                var b = (MapaVehiculosSimple)vehiculo;
                TxtGalTanque.Text = b.GalonesDisponibles + "";
            }
        }

        private void CbCisternas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cisterna = CbCisternas.SelectedItem;
            if (cisterna != null)
            {
                var b = (MapaSimple)cisterna;
                TxtGalCisterna.Text = b.GalonesDisponibles + "";
            }
        }

        private void TxtGalDespachar_TextChanged(object sender, EventArgs e)
        {        
            if (RbCamionCisterna.Checked)
            {
                decimal precio = decimal.TryParse(TxtPrecioGal.Text, out decimal p) ? p : 0.00m;
                decimal galones = decimal.TryParse(TxtGalDespachar.Text, out decimal c) ? c : 0.00m;

                TxtTotal.Text = decimal.Round(precio * galones, 2) + "";
            }
        }

        private void CbTipoCombustible_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CbTipoCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCisternas();
            CargarBombas();
            CargarVehiculos();
            IngresoPrecioGalon();
        }
    }
}
