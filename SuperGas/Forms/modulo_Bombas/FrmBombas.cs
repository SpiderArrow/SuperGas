using Data.Mapas.Gasolineras;
using Data.Models.Gasolineras;
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

namespace SuperGas.Forms.modulo_Bombas
{
    public partial class FrmBombas : Form
    {
        private Bombas BombasUpd = null;
        readonly Bombas _Bombas = new Bombas();
        readonly TipoCombustible _tipoCombustible = new TipoCombustible();
        public List<MapaBomba> listado = new List<MapaBomba>();

        public FrmBombas()
        {
            InitializeComponent();
            CargarTipoCombustible();
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text.ToUpper();
            var filter = listado.Where(x => x.Nombre.ToUpper().Contains(txt1));
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
                MessageBox.Show("¡Debe seleccionar un Bombas para editar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rw = (MapaBomba)DgvRegistros.CurrentRow.DataBoundItem;
                BombasUpd = _Bombas.GetBomba(rw.Id);
                if (BombasUpd != null)
                {
                    CbTipoCombustible.SelectedValue = rw.TipoCombustibleId;

                    TxtDescripcion.Text = BombasUpd.Descripcion;
                    TxtGlTotal.Text = BombasUpd.CantidadGalones + "";
                    TxtGlDespachado.Text = BombasUpd.GalonesDespachados +"";
                    TxtGlActuales.Text = BombasUpd.GalonesActuales +"";

                    TxtGlActuales.Enabled = false;
                    TxtGlDespachado.Enabled = false;

                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Bombas!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un Bombas para eliminar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rwpro = (MapaBomba)DgvRegistros.CurrentRow.DataBoundItem;
                var Getveh = _Bombas.GetBomba(rwpro.Id);
                if (Getveh != null)
                {
                    var dialog =
                            MessageBox.Show("¡Esta seguro que desea eliminar la Bomba!", "Eliminar Producto",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        Getveh.IsActive = false;
                        string result = _Bombas.Update(Getveh);
                        if (result == "")
                        {
                            MessageBox.Show("¡Bomba eliminado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDgv();
                        }
                        else
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos de la Bomba!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (BombasUpd == null)
                        resultado = _Bombas.Insert(GetModel(0));
                    else
                        resultado = _Bombas.Update(GetModel(BombasUpd.Id));

                    if (resultado == "")
                    {
                        MessageBox.Show("¡Cambios Guardados Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDgv();
                        LimpiarCampos();
                        ActivarCampos(true);
                        BombasUpd = null;
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
            BombasUpd = null;
        }

        public void CargarDgv()
        {
            listado = _Bombas.Listado();
            BindingSource recurso = new BindingSource
            {
                DataSource = listado
            };
            DgvRegistros.DataSource = typeof(List<>);
            DgvRegistros.DataSource = recurso;

            if (listado.Any())
            {
                DgvRegistros.Columns[1].Visible = false;
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



        public void ActivarCampos(bool activar)
        {
            CbTipoCombustible.Enabled = activar;
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
            TxtGlTotal.Text = "0.0";
            TxtObservaciones.Text = "";
            TxtGlActuales.Text = "0.0";
            TxtGlDespachado.Text = "0.0";
        }

        private string ValidarCampos()
        {
            if (CbTipoCombustible.SelectedItem == null)
                return "Debe seleccinar un Tipo de Combustible";
            else if (TxtDescripcion.Text.Length == 0)
                return "Debe ingresar una descripcion";
            else
                return "";
        }

        private Bombas GetModel(int id)
        {
            return new Bombas()
            {
                Id = id,
                Descripcion = TxtDescripcion.Text,
                TipoCombustibleId = Convert.ToInt32(CbTipoCombustible.SelectedValue),
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
    }
}
