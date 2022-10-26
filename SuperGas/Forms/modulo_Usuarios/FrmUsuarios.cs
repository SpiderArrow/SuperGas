using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models.Usuarios;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Data.Mapas.Usuarios;
using Data.Security;
using Data.Models;
using Microsoft.Owin.Security.DataProtection;
using Microsoft.AspNet.Identity.Owin;

namespace SuperGas.Forms.modulo_Usuarios
{
    public partial class FrmUsuarios : Form
    {

        readonly User Users = new User();
        readonly ModelState mState = new ModelState();
        public List<MapaUsuarios> listado = new List<MapaUsuarios>();
        private User usrUpd = null;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarDgv();
            CbPrivilegios.SelectedText = "Administrador";
        }

        public void CargarDgv() {
            listado = Users.Listado();
            BindingSource recurso = new BindingSource
            {
                DataSource = listado
            };
            DgvUsuarios.DataSource = typeof(List<>);
            DgvUsuarios.DataSource = recurso;
        }

        private IdentityResult CrearUsuario(string name, string username, string password, string privilegios)
        {
            var usermanagerr = new UserManager<User>(new UserStore<User>(new ModelContext()));
            var user = new User()
            {
                UserName = username,
                Name = name,
                Privilegios = privilegios,
                Email = username
            };
            return usermanagerr.Create(user, password);
        }

        private void ActualizarUsuario(string userId, MapaUserModel user)
        {

            var provider = new DpapiDataProtectionProvider("SampleAppName");
            var usermanagerr = new UserManager<User>(new UserStore<User>(new ModelContext()))
            {
                UserTokenProvider = new DataProtectorTokenProvider<User>(provider.Create("SampleTokenName"))
            };
            var token = usermanagerr.GeneratePasswordResetToken(userId);
            usermanagerr.ResetPassword(userId, token, user.Password);
            var Getusr = Users.GetUser(userId);
            Getusr.Name = user.Name;
            Getusr.Email = user.Email;
            Getusr.UserName = user.Email;
            Getusr.Privilegios = user.Privilegios;
            Users.Update(Getusr);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ActivarCampos(false);

            var usuario = new MapaUserModel()
            {
                Email = TxtCorreo.Text,
                Name = TxtNombre.Text,
                Password = TxtPass.Text,
                ConfirmPassword = TxtPass2.Text,
                Privilegios = CbPrivilegios.Text,
            };

            if (mState.IsValid(usuario))
            {
                try
                {
                    if (usrUpd != null)
                        ActualizarUsuario(usrUpd.Id, usuario);
                    else
                        CrearUsuario(usuario.Name, usuario.Email, usuario.Password, usuario.Privilegios);

                    MessageBox.Show("¡Cambios Guardados Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PnlFormulario.Visible = false;
                    LimpiarCampos();
                    CargarDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                ActivarCampos(true);
                string Mensaje = "";
                foreach (var error in mState.ErrorMessages) 
                    Mensaje += "\n" + error;
                Mensaje = Mensaje.Length > 0 ? Mensaje : "¡Hay campos obligatorios sin llenar!";
                MessageBox.Show(Mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            PnlFormulario.Visible = true;
            ActivarCampos(true);
        }

        public void ActivarCampos(bool activar) {
            TxtCorreo.Enabled = activar;
            TxtNombre.Enabled = activar;
            CbPrivilegios.Enabled = activar;
            TxtPass.Enabled = activar;
            TxtPass2.Enabled = activar;
            BtnGuardar.Enabled = activar;
            BtnCancelar.Enabled = activar;
        }

        public void LimpiarCampos() {
            TxtCorreo.Text = "";
            TxtNombre.Text = "";
            CbPrivilegios.Text = "";
            TxtPass.Text = "";
            TxtPass2.Text = "";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("¡Debe seleccionar un usuario para editar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var user = (MapaUsuarios)DgvUsuarios.CurrentRow.DataBoundItem;
                var Getuser = Users.GetUser(user.Id);
                if (Getuser != null)
                {
                    PnlFormulario.Visible = true;
                    ActivarCampos(true);

                    usrUpd = Getuser;
                    TxtNombre.Text = Getuser.Name;
                    TxtCorreo.Text = Getuser.UserName;
                    CbPrivilegios.Text = Getuser.Privilegios;
                }
                else
                {
                    MessageBox.Show("¡No se pudo obtener los datos del usuario!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("¡Debe seleccionar un usuario para desactivar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var user = (MapaUsuarios)DgvUsuarios.CurrentRow.DataBoundItem;
                var Getuser = Users.GetUser(user.Id);
                if (Getuser != null)
                {
                    var dialog =
                            MessageBox.Show("¡Esta seguro que desea desactivar al usuario!", "Eliminar Usuario", 
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        Getuser.IsDeleted = true;
                        string result = Users.Update(Getuser);
                        if ( result == "")
                        {
                            MessageBox.Show("¡Usuario desactivado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDgv();
                        }
                        else
                        {
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                        
                    }
                }
                else
                {
                    MessageBox.Show("¡No se pudo obtener los datos del usuario!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text;
            string txt2 = TxtBuscador.Text.ToUpper();
            var filter = listado.Where(x => x.UserName.Contains(txt1) || x.UserName.Contains(txt2) ||
                                            x.NombreCompleto.Contains(txt1) || x.NombreCompleto.Contains(txt2));
            DgvUsuarios.DataSource = filter.ToList();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ActivarCampos(true);
            PnlFormulario.Visible = false;
        }
    }
}
