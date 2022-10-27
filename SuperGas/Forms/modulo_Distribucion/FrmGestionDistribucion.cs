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

namespace SuperGas.Forms.modulo_Distribucion
{
    public partial class FrmGestionDistribucion : Form
    {
        readonly Vehiculo _vehiculos = new Vehiculo();
        readonly Gasolinera _gasolinera = new Gasolinera();
        readonly Bombas _bombas = new Bombas();
        readonly TipoCombustible _tipoCombustible = new TipoCombustible();
        readonly Cisternas _cisternas = new Cisternas();

        public FrmGestionDistribucion()
        {
            InitializeComponent();
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
            var listado = _bombas.ListadoBombasDespacho();
            CbBombas.DataSource = listado;
            CbBombas.DisplayMember = "Descripcion";
            CbBombas.ValueMember = "Id";
            if (listado.Any())
                CbBombas.SelectedIndex = 0;
            CbBombas.Invalidate();
        }

        public void CargarVehiculos()
        {
            var listado = _vehiculos.ListadoVehiculos();
            CbCamiones.DataSource = listado;
            CbCamiones.DisplayMember = "DescripcionVehiculo";
            CbCamiones.ValueMember = "Id";
            if (listado.Any())
                CbCamiones.SelectedIndex = 0;
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
            var listado = new List<MapaEntity>();
            if (int.TryParse(CbCisternas.SelectedValue + "", out int cs))
                listado = _cisternas.Listado(cs);

            CbCisternas.DataSource = listado;
            CbCisternas.DisplayMember = "Descripcion";
            CbCisternas.ValueMember = "Id";
            if (listado.Any())
                CbCisternas.SelectedIndex = 0;
            CbCisternas.Invalidate();

        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.MDistribucion();
        }

        private void RbBombaCamion_CheckedChanged(object sender, EventArgs e)
        {
            CbBombas.Enabled = RbBombaCamion.Checked;
            CbCamiones.Enabled = RbBombaCamion.Checked;
        }

        private void RbCamionCisterna_CheckedChanged(object sender, EventArgs e)
        {
            CbCamiones.Enabled = RbCamionCisterna.Checked;
            CbGasolineras.Enabled = RbCamionCisterna.Checked;
            CbCisternas.Enabled = RbCamionCisterna.Checked;
            GbFacturacion.Enabled = RbCamionCisterna.Checked;
        }

        private void CbGasolineras_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCisternas();
        }

    }
}
