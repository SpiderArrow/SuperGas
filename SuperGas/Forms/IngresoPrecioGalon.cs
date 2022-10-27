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
using Data.Models.Gasolineras;
using Data.Models.Vehiculos;
using Data.Mapas.Gasolineras;

namespace SuperGas.Forms
{
    public partial class IngresoPrecioGalon : Form
    {
        readonly DateTime Hoy = new DateTime();
        readonly PrecioGalon _precioGalon = new PrecioGalon();
        readonly TipoCombustible _tipoCombustible = new TipoCombustible();
        public List<MapaPrecioGalon> listado = new List<MapaPrecioGalon>();
        public decimal Precio = 0.00m;


        public IngresoPrecioGalon()
        {
            InitializeComponent();
            CargarTipoCombustible();
            PreciosAyer();
            TimeSpan time = new TimeSpan(0, 0, 0);
            Hoy = DateTime.Now.Date + time;
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text.ToUpper();
            var filter = listado.Where(x => x.TipoCombustible.ToUpper().Contains(txt1));
            DgvRegistros.DataSource = filter.ToList();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            CargarDgv();
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try {
                if (!ValidarPrecioGalon())
                {
                    string mensaje = ValidarCampos();
                    if (mensaje.Length == 0)
                    {
                        ActivarCampos(false);
                        Precio = Convert.ToDecimal(TxtPrecio.Text);
                        string result = _precioGalon.Insert(new PrecioGalon
                        {
                            TipoCombustibleId = Convert.ToInt32(CbTipoCombustible.SelectedValue),
                            FechaPrecio = Hoy,
                            Precio = Precio,
                            Costo = Convert.ToDecimal(TxtCosto.Text),
                            Utilidad = Convert.ToDecimal(TxtUtilidad.Text)
                        });
                        if (result == "")
                        {
                            MessageBox.Show("¡Cambios guardados exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            ResetCombo();
                            CargarDgv();
                        }
                        else
                            MessageBox.Show(result, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ActivarCampos(true);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un precio de Galón para el tipo de combustible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch {
                MessageBox.Show("Error interno, revise los datos ingresados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public bool ValidarPrecioGalon()
        {
            int tcId = int.TryParse(CbTipoCombustible.SelectedValue + "", out int id) ? id : 0;
            var preciogalon = _precioGalon.GetByFechaTipo(Hoy, tcId);

            if (preciogalon != null)
                return true;
            else
                return false;

        }

        private void CheckAyer_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAyer.Checked)
            {
                int tcId = int.TryParse(CbTipoCombustible.SelectedValue + "", out int id) ? id : 0;
                var preciogalon = _precioGalon.GetByFechaTipo(Hoy.AddDays(-1), tcId);

                if (preciogalon != null)
                {
                    TxtPrecio.Text = preciogalon.Precio + "";
                    TxtCosto.Text = preciogalon.Costo + "";
                    TxtUtilidad.Text = preciogalon.Utilidad + "";
                }

            }
        }

        public void CargarDgv()
        {
            listado = _precioGalon.Listado();
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

        public void LimpiarCampos() {
            TxtCosto.Text = "";
            TxtPrecio.Text = "";
            TxtUtilidad.Text = "";
        }

        public void ResetCombo()
        {
            if (CbTipoCombustible.Items.Count > 0)
                CbTipoCombustible.SelectedIndex = 0;
            CbTipoCombustible.Invalidate();
        }

        public void ActivarCampos(bool activar)
        {
            TxtCosto.Enabled = activar;
            TxtPrecio.Enabled = activar;
            CbTipoCombustible.Enabled = activar;
            BtnGuardar.Enabled = activar;
        }

        public string ValidarCampos() {
            decimal precio = decimal.TryParse(TxtPrecio.Text, out decimal p) ? p : 0.00m;
            decimal costo = decimal.TryParse(TxtCosto.Text, out decimal c) ? c : 0.00m;

            if (TxtCosto.Text.Length == 0)
                return "Debe ingresar un costo de galón";
            else if (TxtPrecio.Text.Length == 0)
                return "Debe ingresar un precio de galón";
            else if (CbTipoCombustible.SelectedValue == null)
                return "Debe seleccionar un tipo de Combustible";
            else if (costo > precio)
                return "El costo no puede ser mayor que el precio";
            else
                return "";
        
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un Precio de Galon para eliminar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rwpro = (MapaPrecioGalon)DgvRegistros.CurrentRow.DataBoundItem;
                var Getpre = _precioGalon.GetPrecioGolan(rwpro.Id);
                if (Getpre != null)
                {
                    var dialog =
                            MessageBox.Show("¡Esta seguro que desea eliminar el Precio de Galon!", "Eliminar Producto",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        string result = _precioGalon.Delete(Getpre);
                        if (result == "")
                        {
                            MessageBox.Show("¡Precio de Galón eliminado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDgv();
                        }
                        else
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Precio!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {
            SetUtilidad();
        }

        private void TxtCosto_TextChanged(object sender, EventArgs e)
        {
            SetUtilidad();
        }

        public void SetUtilidad()
        {
            decimal precio = decimal.TryParse(TxtPrecio.Text, out decimal p) ? p : 0.00m;
            decimal costo = decimal.TryParse(TxtCosto.Text, out decimal c) ? c : 0.00m;
  
            if (costo > precio)
                Error.SetError(TxtCosto, "¡El costo no puede ser mayor que el precio!");
            else
            {
                Error.SetError(TxtCosto, "");
                TxtUtilidad.Text = (precio - costo).ToString();
            }               

        }

        public void PreciosAyer()
        {
            TimeSpan time = new TimeSpan(0, 0, 0);
            DateTime ayer = DateTime.Now.AddDays(-1).Date + time;
            var listado = _precioGalon.GetByFecha(ayer);
            if (listado.Any())
                CheckAyer.Visible = true;
        }

        private void CbTipoCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
            CheckAyer.Checked = false;
        }
    }
}
