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
using Data.Mapas.Despachos;
using Data.Models.Despachos;
using SuperGas.Globals;
using Data.Models.Facturas;

namespace SuperGas.Forms.modulo_Distribucion
{
    public partial class FrmGestionDistribucion : Form
    {
        readonly DespachosBombas _despachosBombas = new DespachosBombas();
        readonly DespachosVehiculos _despachosVehiculos = new DespachosVehiculos();
        readonly Vehiculo _vehiculos = new Vehiculo();
        readonly Gasolinera _gasolinera = new Gasolinera();
        readonly Bombas _bombas = new Bombas();
        readonly TipoCombustible _tipoCombustible = new TipoCombustible();
        readonly Cisternas _cisternas = new Cisternas();
        readonly Empleado _empleados = new Empleado();
        readonly PrecioGalon _preciosGalon = new PrecioGalon();
        readonly Factura _factura = new Factura();
        readonly DetalleFactura _detalleFactura = new DetalleFactura();
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
            CbTipoCombustible.Enabled = RbBombaCamion.Checked;
            DtpFechaDespacho.Enabled = RbBombaCamion.Checked;
            CbEncargado.Enabled = RbBombaCamion.Checked;
            LimpiarDatosFacturacion();
            ActivarTC();

            LbglBombas.Text = "gal. Disp. Despachar:";
            LbglCamion.Text = "gal. Disp. Llenar: ";
            LbglCisterna.Text = "gal. Disponibles:";
        }

        private void RbCamionCisterna_CheckedChanged(object sender, EventArgs e)
        {
            CbCamiones.Enabled = RbCamionCisterna.Checked;
            CbGasolineras.Enabled = RbCamionCisterna.Checked;
            CbCisternas.Enabled = RbCamionCisterna.Checked;
            GbFacturacion.Enabled = RbCamionCisterna.Checked;
            DtpFechaDespacho.Enabled = RbCamionCisterna.Checked;
            CbEncargado.Enabled = RbCamionCisterna.Checked;
            CargarDatosFacturacion();
            ActivarTC();

            LbglBombas.Text = "gal. Disponibles:";
            LbglCamion.Text = "gal. Disp. Despachar: ";
            LbglCisterna.Text = "gal. Disp. Llenar:";
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
                decimal galBomba = 0.00m;

                if (RbBombaCamion.Checked)
                {
                    galBomba = b.GalonesActuales;
                    if (galBomba == 0.00m)
                        BtnDespachar.Enabled = false;
                    else
                        BtnDespachar.Enabled = true;
                }                

                TxtGalBomba.Text = decimal.Round(galBomba, 2) + "";
            }
        }

        private void CbCamiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vehiculo = CbCamiones.SelectedItem;
            if (vehiculo != null)
            {
                var b = (MapaVehiculosSimple)vehiculo;

                decimal galCamion = 0.00m;

                if (RbBombaCamion.Checked)
                {
                    galCamion = b.Galones - b.GalonesActuales;
                }
                else if (RbCamionCisterna.Checked)
                {
                    galCamion = b.GalonesActuales;
                }

                if (galCamion == 0.00m)
                    BtnDespachar.Enabled = false;
                else
                    BtnDespachar.Enabled = true;

                TxtGalTanque.Text = decimal.Round(galCamion, 2) + "";

            }
        }

        private void CbCisternas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cisterna = CbCisternas.SelectedItem;
            if (cisterna != null)
            {
                var b = (MapaSimple)cisterna;

                decimal galCist = 0.00m;

                if (RbCamionCisterna.Checked)
                {
                    galCist = b.Galones - b.GalonesActuales;
                    if (galCist == 0.00m)
                        BtnDespachar.Enabled = false;
                    else
                        BtnDespachar.Enabled = true;
                }

                TxtGalCisterna.Text = decimal.Round(galCist, 2) + "";
            }

            if (CbCisternas.Text.Length == 0) TxtGalCisterna.Text = "";
        }

        private void TxtGalDespachar_TextChanged(object sender, EventArgs e)
        {        
            if (RbCamionCisterna.Checked)
            {
                decimal precio = decimal.TryParse(TxtPrecioGal.Text, out decimal p) ? p : 0.00m;
                decimal galones = decimal.TryParse(TxtGalDespachar.Text, out decimal c) ? c : 0.00m;
                decimal disponibles = decimal.TryParse(TxtGalTanque.Text, out decimal i) ? i : 0.00m;

                TxtTotal.Text = decimal.Round(precio * galones, 2) + "";

                if (galones > disponibles)
                {
                    MessageBox.Show("Los galones ingresados no pueden exceder a los disponibles en Bomba", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtGalDespachar.Text = "0.00";
                }                   
                
            } 
            else if (RbBombaCamion.Checked)
            {
                decimal galones = decimal.TryParse(TxtGalDespachar.Text, out decimal c) ? c : 0.00m;
                decimal disponibles = decimal.TryParse(TxtGalBomba.Text, out decimal i) ? i : 0.00m;             

                if (galones > disponibles)
                {
                    MessageBox.Show("Los galones ingresados no pueden exceder a los disponibles en Bomba", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtGalDespachar.Text = "0.00";
                }

            }
        }

        private void CbTipoCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCisternas();
            CargarBombas();
            CargarVehiculos();
            IngresoPrecioGalon();
        }

        private void BtnDespachar_Click(object sender, EventArgs e)
        {
            if (RbBombaCamion.Checked)
            {
                GuardarDespachoBomba();
            }
            else if (RbCamionCisterna.Checked) 
            {
                GuardarDespachoVehiculos();
               
            }
        }

      

        public void GuardarDespachoBomba() {

            try
            {
                string mensaje = ValidarCamposDespachoBomba();
                if (mensaje == "")
                {
                    var modelodespacho = GetModelDespachoBomba(0);
                    string resultado = _despachosBombas.Insert(modelodespacho);

                    if (resultado == "")
                    {
                        var vehiculo = _vehiculos.GetVehiculo(modelodespacho.VehiculoId);
                        var bomba = _bombas.GetBomba(modelodespacho.BombaId);

                        vehiculo.GalonesActuales += modelodespacho.GalonesDespachados;
                        bomba.GalonesActuales -= modelodespacho.GalonesDespachados;
                        bomba.GalonesDespachados += modelodespacho.GalonesDespachados;

                        resultado = _vehiculos.Update(vehiculo) + "-" + _bombas.Update(bomba);

                        if (resultado == "-")
                        {
                            MessageBox.Show("¡Cambios Guardados Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                            
                        else
                            MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                DesactivarCampos();
                LbMensajeFactura.Visible = false;
            }
            catch (Exception ex)
            {
                DesactivarCampos();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private DespachosBombas GetModelDespachoBomba(int id)
        {
            return new DespachosBombas()
            {
                Id = id,
                FechaDespacho = DtpFechaDespacho.Value,
                EmpleadoId = Convert.ToInt64(CbEncargado.SelectedValue),
                BombaId = Convert.ToInt32(CbBombas.SelectedValue),
                VehiculoId = Convert.ToInt64(CbCamiones.SelectedValue),
                TipoCombustibleId = Convert.ToInt32(CbTipoCombustible.SelectedValue),
                GalonesDespachados = decimal.TryParse(TxtGalDespachar.Text, out decimal gd) ? gd : 0,
                Observaciones = TxtObservaciones.Text,
                UsuarioIngreso = UserLogIn.User.Id
            };
        }

        private string ValidarCamposDespachoBomba() {
            decimal gal = decimal.TryParse(TxtGalDespachar.Text, out decimal gd) ? gd : 0.00m;
            if (CbTipoCombustible.SelectedItem == null)
                return "Debe seleccinar un Tipo de Combustible";
            else if (CbEncargado.SelectedItem == null)
                return "Debe seleccionar una Encargado";
            else if (CbBombas.SelectedItem == null)
                return "Debe seleccionar una Bomba";
            else if (CbCamiones.SelectedItem == null)
                return "Debe seleccionar un Camion";            
            else if (gal == 0.00m)
                return "Galones despachados debe ser mayor a 0.00";
            else
                return "";

        }

        public void DesactivarCampos() {
            RbBombaCamion.Checked = false;
            RbCamionCisterna.Checked = false;


        }

        public void ActivarTC() {

            if (RbBombaCamion.Checked || RbCamionCisterna.Checked)
            {
                CbTipoCombustible.Enabled = true;
                TxtGalDespachar.Enabled = true;
                TxtObservaciones.Enabled = true;
                BtnDespachar.Enabled = true;
            }
            else
            {
                CbTipoCombustible.Enabled = false;
                TxtGalDespachar.Enabled = false;
                TxtObservaciones.Enabled = false;
                BtnDespachar.Enabled = false;
            }          
                
        }

        private void GuardarDespachoVehiculos()
        {

            try
            {
                string mensaje = ValidarCamposDespachoVehiculo();
                if (mensaje == "")
                {
                    var modelodespacho = GetModelDespachoVehiculo(0);
                    string resultado = _despachosVehiculos.Insert(modelodespacho);

                    if (resultado == "")
                    {
                        var vehiculo = _vehiculos.GetVehiculo(modelodespacho.VehiculoId);
                        var Cisterna = _cisternas.GetCisterna(modelodespacho.CisternaId);

                        Cisterna.GalonesActuales += modelodespacho.GalonesDespachados;

                        vehiculo.GalonesActuales -= modelodespacho.GalonesDespachados;
                        vehiculo.GalonesDespachados += modelodespacho.GalonesDespachados;

                        resultado = _vehiculos.Update(vehiculo) + "-" + _cisternas.Update(Cisterna);

                        if (resultado == "-")
                        {
                            MessageBox.Show("¡Cambios Guardados Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GenerarFactura();
                            LbMensajeFactura.Visible = true;
                        }
                            
                        else
                            MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                DesactivarCampos();
                LbMensajeFactura.Visible = false;
            }
            catch (Exception ex)
            {
                DesactivarCampos();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DespachosVehiculos GetModelDespachoVehiculo(int id)
        {
            return new DespachosVehiculos()
            {
                Id = id,
                FechaDespacho = DtpFechaDespacho.Value,
                EmpleadoId = Convert.ToInt64(CbEncargado.SelectedValue),
                CisternaId = Convert.ToInt32(CbCisternas.SelectedValue),
                VehiculoId = Convert.ToInt64(CbCamiones.SelectedValue),
                TipoCombustibleId = Convert.ToInt32(CbTipoCombustible.SelectedValue),
                GalonesDespachados = decimal.TryParse(TxtGalDespachar.Text, out decimal gd) ? gd : 0.00m,
                Observaciones = TxtObservaciones.Text,
                UsuarioIngreso = UserLogIn.User.Id
            };
        }

        private string ValidarCamposDespachoVehiculo()
        {
            decimal gal = decimal.TryParse(TxtGalDespachar.Text, out decimal gd) ? gd : 0.00m;
            decimal galcist = decimal.TryParse(TxtGalCisterna.Text, out decimal gc) ? gc : 0.00m;
            decimal galtan = decimal.TryParse(TxtGalTanque.Text, out decimal gt) ? gt : 0.00m;
            if (gal == 0.00m)
                return "Galones despachados debe ser mayor a 0.00";
            else if (galcist == 0.00m)
                return "La cisterna no tiene galones disponibles para llenar";
            else if (galtan == 0.00m)
                return "El camion no tiene galones disponibles para despachar";
            else if (CbTipoCombustible.SelectedItem == null)
                return "Debe seleccinar un Tipo de Combustible";
            else if (CbEncargado.SelectedItem == null)
                return "Debe seleccionar una Encargado";
            else if (CbCisternas.SelectedItem == null)
                return "Debe seleccionar una Cisterna";
            else if (CbCamiones.SelectedItem == null)
                return "Debe seleccionar un Camion";
            else if (TxtDireccion.Text == "")
                return "Debe ingresar una direccion";
            else if (TxtNit.Text == "")
                return "Debe ingresar un Nit";
            else if (TxtNombre.Text == "")
                return "Debe seleccionar un Nombre";
            else
                return "";

        }

        public void GenerarFactura() {

            try
            {
                var Factura = GetModelFactura();
                string result = _factura.Insertar(Factura);

                var Detalle = GetModelDetalle();
                string result2 = _detalleFactura.Insertar(Detalle);

                if (result == "" && result2 == "")
                {

                    if (Application.OpenForms["FrmFactura"] == null)
                    {
                        FrmFactura factura = new FrmFactura(Detalle.FacturaId);
                        factura.Show();
                    }
                    else
                        Application.OpenForms["FrmFactura"].Activate();
                    
                }
                else
                {

                    MessageBox.Show(result + "-" + result2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public Factura GetModelFactura()
        {
            string txt = ObtenerNumero(_factura.LastNoFactura(), "FC-");
            var idDespacho = _despachosVehiculos.LastIdDespacho();

            return new Factura()
            {
                DespachosVehiculoId = idDespacho,
                GasolineraId = Convert.ToInt64(CbGasolineras.SelectedValue),
                //UserId = UserLogIn.User.Id,
                NoFactura = txt,
                Serie = "A",
                FechaVenta = DtpFechaDespacho.Value,
                Nombre = TxtNombre.Text,
                Direccion = TxtDireccion.Text,
                NIT = TxtNit.Text,
                TotalFactura = Convert.ToDecimal(TxtTotal.Text),
               
            };
        }

        private string ObtenerNumero(string noDocumento, string tipo)
        {
            string numero;
            if (noDocumento.Length > 0)
            {
                int maxsol = Convert.ToInt32(noDocumento.Split('-')[1]) + 1;
                if (maxsol < 10)
                    numero = tipo + "00" + maxsol;
                else if (maxsol < 100)
                    numero = tipo + "0" + maxsol;
                else
                    numero = tipo + maxsol;
            }
            else
            {
                numero = tipo + "001";
            }
            return numero;
        }

        public DetalleFactura GetModelDetalle()
        {
            var idFactura = _factura.LastIdFactura();
            int tcid = Convert.ToInt32(CbTipoCombustible.SelectedValue);
            var precioGalon = _listadoPreciosGalon.Where(x => x.TipoCombustibleId == tcid).FirstOrDefault();

            return new DetalleFactura()
            {
                FacturaId = idFactura,
                CantidadGalones = decimal.TryParse(TxtGalDespachar.Text, out decimal gd) ? gd : 0.00m,
                Costo = precioGalon.Costo,
                Precio = precioGalon.Precio,
                Utilidad = (precioGalon.Precio - precioGalon.Utilidad),
                SubTotal = Convert.ToDecimal(TxtTotal.Text),

            };
        }

    }
}
