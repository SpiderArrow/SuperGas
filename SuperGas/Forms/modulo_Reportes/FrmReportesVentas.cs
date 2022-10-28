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
using Data.Models.Despachos;
using Microsoft.Reporting.WinForms;

namespace SuperGas.Forms.modulo_Reportes
{
    public partial class FrmReportesVentas : Form
    {
        readonly DespachosVehiculos _despachos = new DespachosVehiculos();

        public FrmReportesVentas()
        {
            InitializeComponent();
        }

        private void CargarInforme()
        {

            try
            {
                var ingresos = _despachos.ListadoIngresos();   
                var rds1 = new ReportDataSource("DataSetIngresos", ingresos);
                RVVentas.LocalReport.DataSources.Clear();
                RVVentas.LocalReport.DataSources.Add(rds1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReportesIngresos_Load(object sender, EventArgs e)
        {
            CargarInforme();
            this.RVVentas.RefreshReport();
        }
    }
}
