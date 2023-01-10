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
    
    public partial class FrmReportesEgreso : Form
    {
        readonly DespachosVehiculos despachosVehiculos = new DespachosVehiculos();
        public FrmReportesEgreso()
        {
            InitializeComponent();
        }
        private void CargarInforme()
        {

            try
            {
                var egresos = despachosVehiculos.Listado();
                var rds1 = new ReportDataSource("DataSetEgresosVehiculo", egresos);
                RVEgresoVehiculo.LocalReport.DataSources.Clear();
                RVEgresoVehiculo.LocalReport.DataSources.Add(rds1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmReportesEgreso_Load(object sender, EventArgs e)
        {
            CargarInforme();
            this.RVEgresoVehiculo.RefreshReport();
        }
    }
}
