using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models.Facturas;
using Data.Mapas.Ventas;


namespace SaleAdmin.Forms.modulo_ventas
{
    public partial class FrmVentasRealizadas : Form
    {
        readonly Factura _factura = new Factura();
        readonly DetalleFactura _detalleFactura = new DetalleFactura();
        private List<MapaFactura> listaFacturas = new List<MapaFactura>();
        private List<MapaDetalleFactura> listaDetalles = new List<MapaDetalleFactura>();

        public FrmVentasRealizadas()
        {
            InitializeComponent();
            DgvFacturas.ClearSelection();
            DgvFacturas.Update();
        }

        private void BtnIrPOS_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Ventas_Click(sender, null);
        }

        private void FrmVentasRealizadas_Load(object sender, EventArgs e)
        {
            CargarDgvFacturas();
            DgvFacturas.ClearSelection();
            DgvFacturas.Update();
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
            LbItems.Text = listaDetalles.Count().ToString();
        }

        private void BtnDocumento_Click(object sender, EventArgs e)
        {
            var row = (MapaFactura)DgvFacturas.CurrentRow.DataBoundItem;
            FrmFactura _rpfactura = new FrmFactura(row.Id);
            _rpfactura.Show();
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

        private void TxtBuscadorDetalles_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscadorDetalles.Text.ToUpper();
            if (listaDetalles.Any())
            {
                var filter = listaDetalles.Where(x => x.NombreProducto.ToUpper().Contains(txt1));
                DgvDetalles.DataSource = filter.ToList();
                DgvDetalles.ClearSelection();
            }            
        }

        private void DgvFacturas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = (MapaFactura)DgvFacturas.CurrentRow.DataBoundItem;
            LbNoFactura.Text = row.NoFactura;
            CargarDgvDetalles(row.Id);
        }
    }
}
