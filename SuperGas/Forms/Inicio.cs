using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models.Gasolineras;
using SuperGas.Globals;

namespace SuperGas.Forms
{
    public partial class Inicio : Form
    {
        readonly DateTime Hoy = new DateTime();
        readonly PrecioGalon _precioGalon = new PrecioGalon();

        public Inicio()
        {
            InitializeComponent();

            TimeSpan time = new TimeSpan(0, 0, 0);
            Hoy = DateTime.Now.Date + time;
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Empleados();
        }

        private void BtnCamiones_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Vehiculos();
        }

        private void BtnGasolineras_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Gasolineras();
        }

        private void BtnBombas_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Bomba();
        }

        private void BtnPistas_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Pistas();
        }

        private void BtnCisternas_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Cisternas();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            var Name = UserLogIn.User.Name;
            BtnBienvenido.Text = "¡Bienvenido " + Name + "!";
            IngresoPrecioGalon();
        }

        public void IngresoPrecioGalon() {

            var listado = _precioGalon.GetByFecha(Hoy);
            if (!listado.Any())
            {
                var dialog =
                            MessageBox.Show("¡NO se ha ingresado precio de Galón del dia!, ¿Desea ingresarlo?", "ingreso Precio Galón",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    FormBase parent = this.ParentForm as FormBase;
                    parent.PrecioGalon();
                }
            }
        }

        private void BtnGalones_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.PrecioGalon();
        }

        private void BtnBienvenido_Click(object sender, EventArgs e)
        {
            var Name = UserLogIn.User.Name;
            MessageBox.Show("¡Que tengas un excelente día "+Name+"!", "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
