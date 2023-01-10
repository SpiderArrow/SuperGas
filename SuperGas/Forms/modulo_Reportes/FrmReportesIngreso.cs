using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models.Entradas;
using Microsoft.Reporting.WinForms;

namespace SuperGas.Forms.modulo_Reportes
{
    public partial class FrmReportesIngreso : Form
    {
        readonly HistorialEntradas _entradas = new HistorialEntradas();

        public FrmReportesIngreso()
        {
            InitializeComponent();
        }

        private void CargarInforme()
        {

            try
            {
                var entradas = _entradas.Listado();
                var rds1 = new ReportDataSource("DataSetIngresoCombustible", entradas);
                RVIngresoCombustible.LocalReport.DataSources.Clear();
                RVIngresoCombustible.LocalReport.DataSources.Add(rds1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmReportesIngreso_Load(object sender, EventArgs e)
        {
            CargarInforme();
            this.RVIngresoCombustible.RefreshReport();
        }
    }
}
