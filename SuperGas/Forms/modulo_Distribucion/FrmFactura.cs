using System;
using Data.Models.Facturas;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models.Usuarios;
using Microsoft.Reporting.WinForms;
using SuperGas.Reports.helpers;

namespace SuperGas.Forms.modulo_Distribucion
{
    public partial class FrmFactura : Form
    {
        readonly long IdFactura;
        readonly User _usuario = new User();
        readonly Factura _factura = new Factura();
        readonly DetalleFactura _detalleFactura = new DetalleFactura();
        
        public FrmFactura(long idFact)
        {
            IdFactura = idFact;
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CargarInforme() {

            try
            {
                var Factura = _factura.GetFactura(IdFactura);
                var usuario = _usuario.GetUser(Factura.UserId);
                var DetallesFactura = _detalleFactura.ListadoMapaDetalleFactura(IdFactura);
                string totalletra = Conversores.NumeroALetras(Factura.TotalFactura);

                //para llenar el datasource con filas vacias y poder visualizar la factura 
                //en todo el largo de la pagina tamaño carta
                int limite = 32 - DetallesFactura.Count();
                for (int i = 0; i < limite; i++)
                    DetallesFactura.Add(new Data.Mapas.Facturas.MapaDetalleFactura());

                var rds1 = new ReportDataSource("DataSetDetalleFactura", DetallesFactura);
                ReportParameterCollection reportParameters = new ReportParameterCollection
                {
                    new ReportParameter("Serie", Factura.Serie ),
                    new ReportParameter("NumeroID", Factura.Id.ToString()),
                    new ReportParameter("NoFactura", Factura.NoFactura ),
                    new ReportParameter("FechaVenta",Factura.FechaVenta.ToString()),
                    new ReportParameter("Cliente", Factura.Nombre),
                    new ReportParameter("Direccion", Factura.Direccion),
                    new ReportParameter("NIT",Factura.NIT),
                    new ReportParameter("Vendedor",usuario.Name),
                    new ReportParameter("Correo",usuario.Email),                    
                    //new ReportParameter("Vendedor","JOL"),
                    //new ReportParameter("Correo","JOL"),
                    new ReportParameter("TotalLetras", totalletra),
                };

                RVFactura.LocalReport.SetParameters(reportParameters);
                RVFactura.LocalReport.DataSources.Clear();
                RVFactura.LocalReport.DataSources.Add(rds1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            CargarInforme();
            this.RVFactura.RefreshReport();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
