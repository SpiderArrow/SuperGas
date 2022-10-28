using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SuperGas.Forms.modulo_Usuarios;
using Data.Models.Usuarios;
using SuperGas.Globals;
using Data.Mapas.Usuarios;
using Data.Models.Limpieza;
using SuperGas.Forms.modulo_Limpieza;
using SuperGas.Forms.modulo_Gasolineras;
using SuperGas.Forms.modulo_Empleado;
using SuperGas.Forms.modulo_Vehiculos;
using Data.Models.Gasolineras;
using SuperGas.Forms.modulo_Bombas;
using SuperGas.Forms.modulo_Pistas;
using SuperGas.Forms.modulo_Distribucion;
using SuperGas.Forms.modulo_Cisternas;
using SuperGas.Forms.modulo_Entradas;

namespace SuperGas.Forms
{
    public partial class FormBase : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public FormBase()
        {
            InitializeComponent();
        }


        public FormBase(User usuario)
        {
            UserLogIn.User = usuario;
            InitializeComponent();
        }

        

        private void FormBase_Load(object sender, EventArgs e)
        {
            Inicio_Click(null, e);
        }

        private void AbrirFormHijo(object FormHijo)
        {
            try
            {
                if (this.PnlContenedor.Controls.Count > 0)
                    this.PnlContenedor.Controls.RemoveAt(0);

                Form frm = FormHijo as Form;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.PnlContenedor.Controls.Add(frm);
                this.PnlContenedor.Tag = frm;
                frm.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show("¡Ha ocurrido un error interno! \n Intente iniciar sesion nuevamente.\n"+e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;            
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }        

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmUsuarios());
        }

        public void Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Inicio());
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = !SubMenuReportes.Visible;
        }

        private void BtnRVentas_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
        }

        private void BtnRCompras_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
        }

        private void BtnRClientes_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
        }

        private void Limpieza_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmLimpieza());
        }

        private void Distribucion_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmDistribucion());
        }

        public void GestionLimpieza(HistorialLimpieza Limpieza)
        {
            AbrirFormHijo(new FrmGestionLimpieza(Limpieza));
        }

        public void GestionDistribucion()
        {
            AbrirFormHijo(new FrmGestionDistribucion());
        }

        public void Gasolineras()
        {
            AbrirFormHijo(new FrmGasolineras());
        }


        public void Empleados()
        {
            AbrirFormHijo(new FrmEmpleados());
        }

        public void Vehiculos()
        {
            AbrirFormHijo(new FrmCamiones());
        }

        public void Bomba()
        {
            AbrirFormHijo(new FrmBombas());
        }

        public void Pistas()
        {
            AbrirFormHijo(new FrmPistas());
        }

        public void Cisternas()
        {
            AbrirFormHijo(new FrmCisternas());
        }

        public void MLimpieza()
        {
            AbrirFormHijo(new FrmLimpieza());
        }

        public void MDistribucion()
        {
            AbrirFormHijo(new FrmDistribucion());
        }

        public void PrecioGalon()
        {
            AbrirFormHijo(new IngresoPrecioGalon());
        }

        private void Entradas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmEntradas());
        }
    }
}
