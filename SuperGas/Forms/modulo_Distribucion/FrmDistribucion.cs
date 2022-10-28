using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models.Despachos;
using Data.Mapas.Despachos;

namespace SuperGas.Forms.modulo_Distribucion
{
    public partial class FrmDistribucion : Form
    {
        public List<MapaDespachosBombas> _listadespachosBombas = new List<MapaDespachosBombas>();
        public List<MapaDespachosVehiculos> _listadepachosVehiculos = new List<MapaDespachosVehiculos>();
        readonly DespachosBombas _despachosBombas = new DespachosBombas();
        readonly DespachosVehiculos _despachosVehiculos = new DespachosVehiculos();

        public FrmDistribucion()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.GestionDistribucion();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.GestionDistribucion();
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmConfiguracion"] == null)
            {
                FrmConfiguracion config = new FrmConfiguracion();
                config.Show();
            }
            else
                Application.OpenForms["FrmConfiguracion"].Activate();
        }

        private void BtnDespachosBomba_Click(object sender, EventArgs e)
        {
            _listadespachosBombas = _despachosBombas.Listado();
            DgvRegistros.DataSource = _listadespachosBombas;
            _listadepachosVehiculos = new List<MapaDespachosVehiculos>();

            if (_listadespachosBombas.Any())
            {
                DgvRegistros.Columns[2].Visible = false;
                DgvRegistros.Columns[3].Visible = false;
                DgvRegistros.Columns[4].Visible = false;
            }
        }

        private void BtnDespachoVehiculo_Click(object sender, EventArgs e)
        {
            _listadepachosVehiculos = _despachosVehiculos.Listado();
            DgvRegistros.DataSource = _listadepachosVehiculos;
            _listadespachosBombas = new List<MapaDespachosBombas>();

            if (_listadepachosVehiculos.Any())
            {
                DgvRegistros.Columns[2].Visible = false;
                DgvRegistros.Columns[3].Visible = false;
                DgvRegistros.Columns[4].Visible = false;
                DgvRegistros.Columns[5].Visible = false;
            }
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text.ToUpper();
            if (_listadespachosBombas.Any())
            {                
                var filter = _listadespachosBombas.Where(x => x.TipoCombustible.ToUpper().Contains(txt1) ||
                                                x.Bomba.Contains(txt1) ||
                                                x.Camion.ToUpper().Contains(txt1));
                DgvRegistros.DataSource = filter.ToList();
            }
            else if (_listadepachosVehiculos.Any())
            {
                var filter = _listadepachosVehiculos.Where(x => x.TipoCombustible.ToUpper().Contains(txt1) ||
                                                x.Camion.Contains(txt1) ||
                                                x.Cisterna.Contains(txt1) ||
                                                x.Gasolinera.ToUpper().Contains(txt1));
                DgvRegistros.DataSource = filter.ToList();
            }
        }
    }
}
