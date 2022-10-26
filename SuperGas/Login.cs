using Data.Mapas.Usuarios;
using Data.Models;
using Data.Models.Usuarios;
using Data.Security;
using SuperGas.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Runtime.InteropServices;

namespace SuperGas
{
    public partial class Login : Form
    {
        public ModelState mState = new ModelState();
        private User User = new User();

        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //if (Properties.Settings.Default.UserName != null)
            //{
            //    TxtUserName.Text = Properties.Settings.Default.UserName;
            //    ChkRecordar.Checked = true;
            //}
        }

        private void IniciarSesion() {   
            try
            {
                ActivarCampos(false);
                var usuario = new MapaUserLogin()
                {
                    Email = TxtUserName.Text.Replace(" ", string.Empty),
                    Password = TxtPassword.Text.Replace(" ", string.Empty)
                };
                GuardarUsuario();

                if (!mState.IsValid(usuario)) {
                    ActivarCampos(true);
                    MessageBox.Show("¡Revise que los datos sean correctos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (SignInStatus(usuario.Email, usuario.Password)) {
                    if (User.Privilegios == "Administrador"){
                        FormBase SuperGas = new FormBase(User);
                        SuperGas.Show();
                        this.Hide();
                    }
                    else {
                        ActivarCampos(true);
                        MessageBox.Show("¡Login Incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    ActivarCampos(true);
                    MessageBox.Show("¡Login Incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch {
                ActivarCampos(true);
                MessageBox.Show("¡Ha ocurrido un error interno!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarUsuario()
        {
            //if (ChkRecordar.Checked)
            //{
            //    Properties.Settings.Default.UserName = TxtUserName.Text;
            //    Properties.Settings.Default.Save();
            //}
        }

        public bool SignInStatus(string username, string password)
        {
            var usermanagerr = new UserManager<User>(new UserStore<User>(new ModelContext()));
            User = usermanagerr.Find(username, password);
            return User != null;
           
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnEntrar;
        }

        private void ActivarCampos(bool activar) {
            TxtPassword.Enabled = activar;
            TxtUserName.Enabled = activar;
            BtnEntrar.Enabled = activar;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
