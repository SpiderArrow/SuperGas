using Data.Mapas.Facturas;
using Data.Models.Facturas;
using SuperGas.Forms.modulo_Distribucion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Mapas.Entradas;
using Data.Models.Vehiculos;
using Data.Models.Entradas;
using Data.Models.Gasolineras;
using Data.Mapas.Gasolineras;

namespace SuperGas.Forms.modulo_Entradas
{
    public partial class FrmEntradas : Form
    {
        readonly Factura _factura = new Factura();
        readonly DetalleFactura _detalleFactura = new DetalleFactura();
        private List<MapaFactura> listaFacturas = new List<MapaFactura>();
        private List<MapaDetalleFactura> listaDetalles = new List<MapaDetalleFactura>();

        readonly DateTime Hoy = new DateTime();
        readonly HistorialEntradas _historialEntradas = new HistorialEntradas();
        readonly TipoCombustible _tipoCombustible = new TipoCombustible();
        readonly Bombas _bombas = new Bombas();
        public List<MapaEntradas> listado = new List<MapaEntradas>();

        public FrmEntradas()
        {
            InitializeComponent();
            CargarTipoCombustible();
            CargarBombas();
            TimeSpan time = new TimeSpan(0, 0, 0);
            Hoy = DateTime.Now.Date + time;
            DtpFecha.Value = Hoy;
        }

        public void CargarDgvFacturas()
        {
            listaFacturas = _factura.Listado();
            BindingSource recurso = new BindingSource
            {
                DataSource = listaFacturas
            };
            DgvFacturas.DataSource = typeof(List<>);
            DgvFacturas.DataSource = recurso;
            DgvFacturas.ClearSelection();
            DgvFacturas.Update();
        }

        public void CargarDgvDetalles(long idFactura)
        {
            listaDetalles = _detalleFactura.ListadoMapaDetalleFactura(idFactura);
            BindingSource recurso = new BindingSource
            {
                DataSource = listaDetalles
            };
            DgvDetalles.DataSource = typeof(List<>);
            DgvDetalles.DataSource = recurso;
            DgvDetalles.ClearSelection();
            DgvFacturas.Update();

            if (listaDetalles.Any())
            {
                DgvDetalles.Columns[1].Visible = false;
                DgvDetalles.Columns[2].Visible = false;
            
            }
        }

        private void BtnDocumento_Click(object sender, EventArgs e)
        {
            var row = (MapaFactura)DgvFacturas.CurrentRow.DataBoundItem;
            FrmFactura _rpfactura = new FrmFactura(row.Id);
            _rpfactura.Show();
        }

        private void FrmEntradas_Load(object sender, EventArgs e)
        {
            CargarDgvFacturas();
            DgvFacturas.ClearSelection();
            DgvFacturas.Update();
        }

        private void DgvFacturas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = (MapaFactura)DgvFacturas.CurrentRow.DataBoundItem;
            LbNoFactura.Text = row.NoFactura;
            CargarDgvDetalles(row.Id);
        }

        private void TxtBuscadorFact_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscadorFact.Text.ToUpper();
            if (listaFacturas.Any())
            {
                var filter = listaFacturas.Where(x => x.Nombre.ToUpper().Contains(txt1) ||
                                                      x.Direccion.ToUpper().Contains(txt1) ||
                                                      x.NIT.Contains(txt1) ||
                                                      x.NoFactura.Contains(txt1));
                DgvFacturas.DataSource = filter.ToList();
                DgvFacturas.ClearSelection();
            }
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text.ToUpper();
            var filter = listado.Where(x => x.TipoCombustible.ToUpper().Contains(txt1) ||
                                            x.Bomba.ToUpper().Contains(txt1));
            DgvRegistros.DataSource = filter.ToList();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = ValidarCampos();
                if (mensaje.Length == 0)
                {
                    ActivarCampos(false);
                    var entrada = new HistorialEntradas
                    {
                        BombaId = Convert.ToInt32(CbBombas.SelectedValue),
                        TipoCombustibleId = Convert.ToInt32(CbTipoCombustible.SelectedValue),
                        FechaEntrada = Hoy,
                        GalonesDisponiblesBomba = Convert.ToDecimal(TxtGalDisp.Text),
                        GalonesEntrada = Convert.ToDecimal(TxtGalEntrada.Text),
                    };

                    string result = _historialEntradas.Insert(entrada);
                    if (result == "")
                    {
                        var bomba = _bombas.GetBomba(entrada.BombaId);
                        bomba.GalonesActuales += entrada.GalonesEntrada;

                        result = _bombas.Update(bomba);

                        if (result == "")
                        {
                            MessageBox.Show("¡Cambios guardados exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            ResetCombo();
                            CargarDgv();
                        }
                        else
                            MessageBox.Show(result, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        
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
            catch
            {
                MessageBox.Show("Error interno, revise los datos ingresados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
            CbBombas.Invalidate();
        }

        public void LimpiarCampos()
        {
            TxtGalDisp.Text = "";
            TxtGalEntrada.Text = "";
        }

        public void ResetCombo()
        {
            if (CbTipoCombustible.Items.Count > 0)
                CbTipoCombustible.SelectedIndex = 0;
            CbTipoCombustible.Invalidate();

            if (CbBombas.Items.Count > 0)
                CbBombas.SelectedIndex = 0;
             CbBombas.Invalidate();
        }

        public void ActivarCampos(bool activar)
        {
            TxtGalDisp.Enabled = activar;
            TxtGalEntrada.Enabled = activar;
            CbTipoCombustible.Enabled = activar;
            CbBombas.Enabled = activar;
            BtnGuardar.Enabled = activar;
        }

        public void CargarDgv()
        {
            listado = _historialEntradas.Listado();
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
                DgvRegistros.Columns[3].Visible = false;
            }
        }

        public string ValidarCampos()
        {
            decimal entrada = decimal.TryParse(TxtGalEntrada.Text, out decimal p) ? p : 0.00m;
            decimal disponibles = decimal.TryParse(TxtGalDisp.Text, out decimal d) ? d : 0.00m;

            if (CbBombas.SelectedValue == null)
                return "Debe seleccinar una Bomba de despacho";
            else if (CbTipoCombustible.SelectedValue == null)
                return "Debe seleccionar un tipo de Combustible";
            else if (entrada == 0.00m)
                return "Galones de Entrada debe ser mayor a cero";
            else if (entrada > disponibles)
                return "Los Galones de Entrada exceden a los disponibles en la bomba";
            else
                return "";
        }

        private void CbTipoCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarBombas();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar una Entrada para eliminar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rwpro = (MapaEntradas)DgvRegistros.CurrentRow.DataBoundItem;
                var Gete = _historialEntradas.GetEntrada(rwpro.Id);
                if (Gete != null)
                {
                    var dialog =
                            MessageBox.Show("¡Esta seguro que desea eliminar la Entrada!", "Eliminar Entrada",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        string result = _historialEntradas.Delete(Gete);
                        if (result == "")
                        {
                            var bomba = _bombas.GetBomba(Gete.BombaId);
                            bomba.GalonesActuales -= Gete.GalonesEntrada;

                            result = _bombas.Update(bomba);

                            if (result == "")
                            {
                                MessageBox.Show("¡Entrada Eliminada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarDgv();
                            }
                            else
                                MessageBox.Show(result, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos de la Entrada!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CbBombas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bomba = CbBombas.SelectedItem;
            if (bomba != null)
            {
                var b = (MapaSimple)bomba;

                TxtGalDisp.Text = decimal.Round(b.GalonesActuales, 2) + "";
                TxtGalDisp.ReadOnly = true;
            }
        }
    }
}
