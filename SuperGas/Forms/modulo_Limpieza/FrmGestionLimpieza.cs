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

namespace SuperGas.Forms.modulo_Limpieza
{
    public partial class FrmGestionLimpieza : Form
    {
        readonly HistorialLimpieza _limpiezaUpd = null;
        readonly HistorialLimpieza _limpieza = new HistorialLimpieza();
        readonly Empleado _empleados = new Empleado();
        readonly Vehiculo _vehiculos = new Vehiculo();
        readonly Gasolinera _gasolinera = new Gasolinera();
        readonly Bombas _bombas = new Bombas();
        readonly Pistas _pistas = new Pistas();
        readonly EstadoLimpieza _estados = new EstadoLimpieza();
        

        public FrmGestionLimpieza(HistorialLimpieza limpieza)
        {
            InitializeComponent();
            CargarEmpleados();
            CargarGasolineras();
            CargarVehiculos();
            CargarBombas();
            CargarPistas();
            CargarEstados();
            _limpiezaUpd = limpieza;
            CargarDatos();
        }

        public void CargarEmpleados()
        {
            var listado = _empleados.ListadoEmp();
            CbEncargado.DataSource = listado;
            CbEncargado.DisplayMember = "NombreCompleto";
            CbEncargado.ValueMember = "Id";
            if (listado.Any())
                CbEncargado.SelectedIndex = 0;
            CbEncargado.Invalidate();
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

        public void CargarPistas()
        {
            var listado = _pistas.Listado();
            CbPistas.DataSource = listado;
            CbPistas.DisplayMember = "Descripcion";
            CbPistas.ValueMember = "Id";
            if (listado.Any())
                CbPistas.SelectedIndex = 0;
            CbPistas.Invalidate();
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

        public void CargarEstados()
        {
            var listado = _estados.Listado(true);
            CbEstado.DataSource = listado;
            CbEstado.DisplayMember = "Descripcion";
            CbEstado.ValueMember = "Id";
            if (listado.Any())
                CbEstado.SelectedIndex = 0;
            CbEstado.Invalidate();
        }

        private void BtnAddGasolinera_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Gasolineras();
        }

        private void BtnAddCamion_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Vehiculos();
        }

        private void BtnAddEncargado_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Empleados();
        }

        private void BtnAddBombas_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Bomba();
        }

        private void BtnAddPistas_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Pistas();
        }


        public void ActivarBombas(bool activar) {
            CbBombas.Enabled = activar;
            BtnAddBombas.Enabled = activar;
        }

        public void ActivarPistas(bool activar)
        {
            CbPistas.Enabled = activar;
            BtnAddPistas.Enabled = activar;
        }

        public void ActivarGasolineras(bool activar)
        {
            CbGasolineras.Enabled = activar;
            BtnAddGasolinera.Enabled = activar;
        }

        public void ActivarVehiculo(bool activar)
        {
            CbCamiones.Enabled = activar;
            BtnAddCamion.Enabled = activar;
        }

        private void RbCamiones_CheckedChanged(object sender, EventArgs e)
        {
            ActivarVehiculo(RbCamiones.Checked);
        }

        private void RbDepositos_CheckedChanged(object sender, EventArgs e)
        {
            ActivarGasolineras(RbDepositos.Checked);
        }

        private void RbPistas_CheckedChanged(object sender, EventArgs e)
        {
            ActivarPistas(RbPistas.Checked);
        }

        private void RbBombas_CheckedChanged(object sender, EventArgs e)
        {
            ActivarBombas(RbBombas.Checked);
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
                    if (_limpiezaUpd.Id == 0)
                        resultado = _limpieza.Inserta(GetModel(0));
                    else
                        resultado = _limpieza.Update(GetModel(_limpiezaUpd.Id));

                    if (resultado == "")
                    {
                        MessageBox.Show("¡Cambios Guardados Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.MLimpieza();
        }

        public void CargarDatos() {
            if (_limpiezaUpd.Id > 0)
            {
                DtpFecha.Value = _limpiezaUpd.FechaLimpieza;
                DtpProxima.Value = _limpiezaUpd.ProximaLimpieza;
                DtpHoraInicio.Value = Convert.ToDateTime(_limpiezaUpd.HoraInicio);
                DtpHoraFinal.Value = Convert.ToDateTime(_limpiezaUpd.HoraFinal);
                TxtObservaciones.Text = _limpiezaUpd.Observaciones;
                CbEstado.SelectedValue = _limpiezaUpd.EstadoLimpiezaId;
                CbEncargado.SelectedValue = _limpiezaUpd.EncargadoId;

                if (int.TryParse(_limpiezaUpd.VehiculoId + "", out _))
                { 
                    RbCamiones.Checked = true;
                    var Id = Convert.ToInt64(_limpiezaUpd.VehiculoId);
                    if (CbCamiones.Items.Count > 0)
                        CbCamiones.SelectedValue = Id;
                } 
                else if (int.TryParse(_limpiezaUpd.GasolineraId + "", out _))
                {
                    RbDepositos.Checked = true;
                    var Id = Convert.ToInt64(_limpiezaUpd.GasolineraId);
                    if (CbGasolineras.Items.Count > 0)
                        CbGasolineras.SelectedValue = Id;
                } 
                else if (int.TryParse(_limpiezaUpd.PistasId + "", out _))
                {
                    RbPistas.Checked = true;
                    var Id = Convert.ToInt64(_limpiezaUpd.PistasId);
                    if (CbPistas.Items.Count > 0)
                        CbPistas.SelectedValue = Id;
                } 
                else if (int.TryParse(_limpiezaUpd.BombasId + "", out _))
                {
                    RbBombas.Checked = true;
                    var Id = Convert.ToInt64(_limpiezaUpd.BombasId);
                    if (CbBombas.Items.Count > 0)
                        CbBombas.SelectedValue = Id;
                }

                MessageBox.Show("¡Datos Cargados Exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private string ValidarCampos()
        {
            if (TxtObservaciones.Text.Length == 0)
                return "Debe ingresar observaciones";
            else if (RbBombas.Checked)
                if (CbBombas.SelectedItem == null)
                    return "Debe seleccionar una Bomba";
            else if (RbPistas.Checked)
                if (CbPistas.SelectedItem == null)
                    return "Debe seleccionar una Pista";
            else if (RbCamiones.Checked)
                if (CbCamiones.SelectedItem == null)
                    return "Debe seleccionar un Camion";
            else if (RbDepositos.Checked)
                if (CbGasolineras.SelectedItem == null)
                    return "Debe seleccionar una Gasolinera";
            else if (CbEstado.SelectedItem == null)
                return "Debe seleccionar un Estado";
            else if (CbEncargado.SelectedItem == null)
                return "Debe seleccionar un Encargado";
           
            return "";
        }

        public void ActivarCampos(bool activar)
        {
            CbBombas.Enabled = activar;
            CbCamiones.Enabled = activar;
            CbEncargado.Enabled = activar;
            CbPistas.Enabled = activar;
            CbGasolineras.Enabled = activar;
            BtnAddBombas.Enabled = activar;
            BtnAddCamion.Enabled = activar;
            BtnAddPistas.Enabled = activar;
            BtnAddEncargado.Enabled = activar;
            BtnAddGasolinera.Enabled = activar;
            DtpHoraFinal.Enabled = activar;
            DtpHoraInicio.Enabled = activar;
            DtpFecha.Enabled = activar;
            DtpProxima.Enabled = activar;
            TxtObservaciones.Enabled = activar;
            RbBombas.Enabled = activar;
            RbCamiones.Enabled = activar;
            RbDepositos.Enabled = activar;
            RbPistas.Enabled = activar;
            CbEstado.Enabled = activar;
        }

        public void LimpiarCampos()
        {
            TxtObservaciones.Text = "";
            DtpFecha.Value = DateTime.Now;
            DtpProxima.Value = DateTime.Now.AddMonths(3);
            DtpHoraInicio.Value = DateTime.Now;
            DtpHoraFinal.Value = DateTime.Now.AddHours(1);

            if (CbBombas.Items.Count > 0)
                CbBombas.SelectedValue = 1;
            if (CbCamiones.Items.Count > 0)
                CbCamiones.SelectedValue = 1;
            if (CbEstado.Items.Count > 0)
                CbEstado.SelectedValue = 1;
            if (CbPistas.Items.Count > 0)
                CbPistas.SelectedValue = 1;
            if (CbGasolineras.Items.Count > 0)
                CbGasolineras.SelectedValue = 1;
            if (CbEncargado.Items.Count > 0)
               CbEncargado.SelectedValue = 1;

            RbBombas.Checked = false;
        }

        private HistorialLimpieza GetModel(long id)
        {
            var limpieza = new HistorialLimpieza()
            {
                Id = id,
                EstadoLimpiezaId = Convert.ToInt32(CbEstado.SelectedValue),
                EncargadoId = Convert.ToInt64(CbEncargado.SelectedValue),
                HoraInicio = DtpHoraInicio.Value.ToString("HH:mm"),
                HoraFinal = DtpHoraFinal.Value.ToString("HH:mm"),
                Observaciones = TxtObservaciones.Text,
                FechaLimpieza = DtpFecha.Value,
                ProximaLimpieza = DtpProxima.Value,
                IsActive = true
            };

            if (RbCamiones.Checked)
            {
                limpieza.VehiculoId = Convert.ToInt64(CbCamiones.SelectedValue);
                limpieza.BombasId = null;
                limpieza.PistasId = null;
                limpieza.GasolineraId = null;
            }
            else if (RbBombas.Checked)
            {
                limpieza.VehiculoId = null;
                limpieza.BombasId = Convert.ToInt32(CbBombas.SelectedValue);
                limpieza.PistasId = null;
                limpieza.GasolineraId = null;
            }
            else if (RbPistas.Checked)
            {
                limpieza.VehiculoId = null;
                limpieza.BombasId = null;
                limpieza.PistasId = Convert.ToInt32(CbPistas.SelectedValue);
                limpieza.GasolineraId = null;
            }
            else if (RbDepositos.Checked)
            {
                limpieza.VehiculoId = null;
                limpieza.BombasId = null;
                limpieza.PistasId = null;
                limpieza.GasolineraId = Convert.ToInt64(CbGasolineras.SelectedValue);
            }

            return limpieza;
        }

        private void DtpHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            DtpHoraFinal.MinDate = DtpHoraInicio.Value;
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {
            DtpProxima.MinDate = DtpFecha.Value;
        }

        
    }
}
