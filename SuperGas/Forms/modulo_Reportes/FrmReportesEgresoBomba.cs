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
using Microsoft.Reporting.WinForms;

namespace SuperGas.Forms.modulo_Reportes
{
    public partial class FrmReportesEgresoVehiculo : Form
    {
        readonly DespachosBombas despachosBombas = new DespachosBombas();

        public FrmReportesEgresoVehiculo()
        {
            InitializeComponent();
        }

        private void CargarInforme()
        {

            try
            {
                var egresos = despachosBombas.Listado();
                var rds1 = new ReportDataSource("DataSetEgresosBombas", egresos);
                RVEgresoBomba.LocalReport.DataSources.Clear();
                RVEgresoBomba.LocalReport.DataSources.Add(rds1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmReportesEgresoVehiculo_Load(object sender, EventArgs e)
        {
            CargarInforme();
            this.RVEgresoBomba.RefreshReport();
        }
    }
}
