using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Mapas.Gasolineras;
using Data.Models.Gasolineras;
using Data.Models.Vehiculos;

namespace SuperGas.Forms.modulo_Cisternas
{
    public partial class FrmCisternas : Form
    {
        private Cisternas CisternasUpd = null;
        readonly Cisternas _Cisternas = new Cisternas();
        readonly TipoCombustible _tipoCombustible = new TipoCombustible();
        readonly Gasolinera _gasolineras = new Gasolinera();
        public List<MapaCisterna> listado = new List<MapaCisterna>();

        public FrmCisternas()
        {
            InitializeComponent();
            CargarTipoCombustible();
            CargarGasolineras();
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text.ToUpper();
            var filter = listado.Where(x => x.Nombre.ToUpper().Contains(txt1) ||
                                            x.Gasolinera.ToUpper().Contains(txt1));
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
                MessageBox.Show("¡Debe seleccionar un Cisternas para editar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rw = (MapaCisterna)DgvRegistros.CurrentRow.DataBoundItem;
                CisternasUpd = _Cisternas.GetCisterna(rw.Id);
                if (CisternasUpd != null)
                {
                    CbTipoCombustible.SelectedValue = rw.TipoCombustibleId;
                    CbGasolineras.SelectedValue = rw.GasolineraId;

                    TxtDescripcion.Text = CisternasUpd.Descripcion;
                    TxtGlTotal.Text = CisternasUpd.CantidadGalones + "";
                    TxtGlDespachado.Text = CisternasUpd.GalonesDespachados + "";
                    TxtGlActuales.Text = CisternasUpd.GalonesActuales + "";

                    TxtGlActuales.Enabled = false;
                    TxtGlDespachado.Enabled = false;

                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Cisternas!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un Cisternas para eliminar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rwpro = (MapaCisterna)DgvRegistros.CurrentRow.DataBoundItem;
                var Getveh = _Cisternas.GetCisterna(rwpro.Id);
                if (Getveh != null)
                {
                    var dialog =
                            MessageBox.Show("¡Esta seguro que desea eliminar la Cisterna!", "Eliminar Producto",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        Getveh.IsActive = false;
                        string result = _Cisternas.Update(Getveh);
                        if (result == "")
                        {
                            MessageBox.Show("¡Cisterna eliminado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDgv();
                        }
                        else
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos de la Cisterna!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (CisternasUpd == null)
                        resultado = _Cisternas.Insert(GetModel(0));
                    else
                        resultado = _Cisternas.Update(GetModel(CisternasUpd.Id));

                    if (resultado == "")
                    {
                        MessageBox.Show("¡Cambios Guardados Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDgv();
                        LimpiarCampos();
                        ActivarCampos(true);
                        CisternasUpd = null;
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
            CisternasUpd = null;
        }

        public void CargarDgv()
        {
            listado = _Cisternas.Listado();
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

        public void CargarGasolineras()
        {
            var listado = _gasolineras.ListadoGasolineras();
            CbGasolineras.DataSource = listado;
            CbGasolineras.DisplayMember = "Descripcion";
            CbGasolineras.ValueMember = "Id";
            if (listado.Any())
                CbGasolineras.SelectedIndex = 0;
            CbGasolineras.Invalidate();
        }


        public void ActivarCampos(bool activar)
        {
            CbTipoCombustible.Enabled = activar;
            CbGasolineras.Enabled = activar;
            TxtDescripcion.Enabled = activar;
            TxtObservaciones.Enabled = activar;
            TxtGlActuales.Enabled = activar;
            TxtGlTotal.Enabled = activar;
            TxtGlDespachado.Enabled = activar;
            BtnGuardar.Enabled = activar;
            BtnCancelar.Enabled = activar;
        }

        public void LimpiarCampos()
        {
            TxtDescripcion.Text = "";
            TxtGlTotal.Text = "0";
            TxtObservaciones.Text = "";
            TxtGlActuales.Text = "0";
            TxtGlDespachado.Text = "0";
        }

        private string ValidarCampos()
        {
            if (CbTipoCombustible.SelectedItem == null)
                return "Debe seleccinar un Tipo de Combustible";
            else if (CbGasolineras.SelectedItem == null)
                return "Debe seleccionar una Gasolinera";            
            else if (TxtDescripcion.Text.Length == 0)
                return "Debe ingresar una descripcion";
            else
                return "";
        }

        private Cisternas GetModel(int id)
        {
            return new Cisternas()
            {
                Id = id,
                Descripcion = TxtDescripcion.Text,
                TipoCombustibleId = Convert.ToInt32(CbTipoCombustible.SelectedValue),
                GasolineraId = Convert.ToInt32(CbGasolineras.SelectedValue),
                GalonesActuales = decimal.TryParse(TxtGlActuales.Text, out decimal a) ? a : 0.00m,
                GalonesDespachados = decimal.TryParse(TxtGlDespachado.Text, out decimal d) ? d : 0.00m,
                CantidadGalones = decimal.TryParse(TxtGlTotal.Text, out decimal t) ? t : 0.00m,
                Observaciones = TxtObservaciones.Text,
                IsActive = true
            };
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

        private void TxtGlTotal_TextChanged(object sender, EventArgs e)
        {
            decimal totales = decimal.TryParse(TxtGlTotal.Text, out decimal p) ? p : 0.00m;
            decimal despachados = decimal.TryParse(TxtGlDespachado.Text, out decimal c) ? c : 0.00m;

            TxtGlActuales.Text = decimal.Round(totales - despachados, 2) + "";
        }
    }
}
