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
using Data.Mapas._helpers;
using Data.Models.Direcciones;
using Data.Models.Gasolineras;

namespace SuperGas.Forms.modulo_Gasolineras
{
    public partial class FrmConfiguracion : Form
    {
        readonly Departamentos _departamentos = new Departamentos();
        readonly Municipios _municipios = new Municipios();
        readonly Zonas _zonas = new Zonas();
        readonly Empresas _empresas = new Empresas();
        public bool CargaAutomatica = false;      
        public MapaEntity _modelo = null;
        public FrmGasolineras _frmgasolinera = null;
        public bool Nuevo = true;
        public int Opc =0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmConfiguracion(FrmGasolineras frmgasolinera)
        {
            InitializeComponent();
            _frmgasolinera = frmgasolinera;
           
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            CargarComboConfiguracion();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (_frmgasolinera != null)
            {
                _frmgasolinera.CargarDepartamentos();
                _frmgasolinera.CargarEmpresas();
            }
            Close();
        }

        private void CbConfiguracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Configuracion)CbConfiguracion.ComboBox.SelectedItem;
            Opc = item.Id;
            if (CargaAutomatica)
                CargarDatos(Opc);
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            CargarDatos(Opc);
            CargaAutomatica = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtDescripcion.Text = _modelo != null ? _modelo.Descripcion : "";
            if (CbPadre.Items.Count > 0)
                CbPadre.SelectedValue = _modelo != null ? _modelo.PadreId : 1;
            Nuevo = false;
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            var dialog =
                            MessageBox.Show("¡Esta seguro que desea desactivar el elemento seleccionado!", "Desactivación",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                TxtDescripcion.Text = _modelo.Descripcion;
                CbPadre.SelectedValue = _modelo.PadreId;
                _modelo.Estado = "Inactivo";
                string result = ActualizarEntity();
                if (result == "")
                    MessageBox.Show("¡Elemento desactivado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CargarDatos(Opc);
                LimpiarDatos();
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            TxtDescripcion.Text = _modelo.Descripcion;
            CbPadre.SelectedValue = _modelo.PadreId;
            _modelo.Estado = "Activo";
            string result = ActualizarEntity();
            if (result == "")
                MessageBox.Show("¡Elemento Activado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            CargarDatos(Opc);
            LimpiarDatos();
        }

        private void DgvModels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _modelo = (MapaEntity)DgvModels.CurrentRow.DataBoundItem;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtDescripcion.Text.Length > 0)
            {
                _modelo = Nuevo ? null : _modelo;
                string result = _modelo == null ? GuardarEntity() : ActualizarEntity();
                if (result == "")
                    MessageBox.Show("¡Cambios guardados exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(result, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarDatos(Opc);
                LimpiarDatos();
            }
            else
            {
                MessageBox.Show("El campo descripción esta vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtDescripcion.Text = "";
            _modelo = null;
            if (CbPadre.Items.Count > 0)
                CbPadre.SelectedValue = 1;
        }

        public void CargarComboConfiguracion()
        {
            List<Configuracion> lista = new List<Configuracion>
            {
                new Configuracion() { Id = 0, Descripcion = "Seleccione una opción" },
                new Configuracion() { Id = 1, Descripcion = "Departamentos" },
                new Configuracion() { Id = 2, Descripcion = "Municipios" },
                new Configuracion() { Id = 3, Descripcion = "Zonas" },
                new Configuracion() { Id = 4, Descripcion = "Empresas" }
            };

            CbConfiguracion.ComboBox.DataSource = lista;
            CbConfiguracion.ComboBox.DisplayMember = "Descripcion";
            CbConfiguracion.ComboBox.ValueMember = "Id";
            CbConfiguracion.ComboBox.SelectedItem = 1;
            CbConfiguracion.ComboBox.Invalidate();
        }

        public void CargarDatos(int opcion) {
            switch (opcion)
            {
                case 1:
                    CargarDgv(_departamentos.Listado(null), "Departamentos", false, "");
                    MostrarComboPadre(false);
                    break;
                case 2:
                    CargarDgv(_municipios.Listado(null), "Municipios", true, "Departamento");
                    CargarComboPadre(_departamentos.Listado(null), "Departamento");
                    MostrarComboPadre(true);
                    break;
                case 3:
                    CargarDgv(_zonas.Listado(null), "Zonas", true, "Zonas");
                    CargarComboPadre(_municipios.Listado(null), "Municipios");
                    MostrarComboPadre(true);
                    break;
                case 4:
                    CargarDgv(_empresas.Listado(null), "Empresa", false, "");
                    MostrarComboPadre(false);
                    break;
                default:
                    MessageBox.Show("¡Debe Seleccionar una de las opciones!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        public void CargarDgv(object source, string label, bool visible, string header)
        {
            try
            {
                DgvModels.DataSource = source;
                DgvModels.Columns[1].Visible = false;
                DgvModels.Columns[2].Visible = visible;
                DgvModels.Columns[2].HeaderText = header;
                LbEntity.Visible = true;
                LbEntity.Text = label;

                if (DgvModels.Rows.Count > 0)
                {
                    BtnEditar.Enabled = true;
                    BtnDesactivar.Enabled = true;
                    BtnActivar.Enabled = true;
                }
                else
                {
                    BtnEditar.Enabled = false;
                    BtnDesactivar.Enabled = false;
                    BtnActivar.Enabled = false;
                }
            } catch (Exception ex){
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public void CargarComboPadre(object source, string padre)
        {
            LbPadre.Text = padre;   
            CbPadre.DataSource = source;
            CbPadre.DisplayMember = "Descripcion";
            CbPadre.ValueMember = "Id";
            CbPadre.SelectedItem = 1;
            CbPadre.Invalidate();            
        }

        public string GuardarEntity() {
            switch (Opc)
            {
                case 1:
                    return _departamentos.Insert(new Departamentos()
                    {
                        Descripcion = TxtDescripcion.Text,
                        IsActive = true
                    }); 
                case 2:
                    var dept = (MapaEntity)CbPadre.SelectedItem;
                    if (dept != null)
                    {
                        return _municipios.Insert(new Municipios()
                        {
                            DepartamentoId = dept.Id,
                            Descripcion = TxtDescripcion.Text,
                            IsActive = true
                        });
                    }
                    else
                    {
                        return "No se puede guardar por que no hay Departamentos.";
                    }
                case 3:
                    var mpio = (MapaEntity)CbPadre.SelectedItem;
                    if (mpio != null)
                    {
                        return _zonas.Insert(new Zonas()
                        {
                            MunicipioId = mpio.Id,
                            Descripcion = TxtDescripcion.Text,
                            IsActive = true
                        });
                    }
                    else
                    {
                        return "No se puede guardar por que no hay Municipios.";
                    }
                case 4:
                    return _empresas.Insert(new Empresas()
                    {
                        Descripcion = TxtDescripcion.Text,
                        IsActive = true
                    });
                default:
                    return "";
            }
        }

        public string ActualizarEntity()
        {
            //esto para que luego de que realice la actualizacion
            //vuelva a estado true para poder agregar uno nuevo
            //sirve como bandera para insertar/actualizar
            Nuevo = true;
            switch (Opc)
            {
                case 1:
                    return _departamentos.Update(new Departamentos()
                    {
                        Id = _modelo.Id,
                        Descripcion = TxtDescripcion.Text,
                        IsActive = _modelo.Estado == "Activo"
                    });
                case 2:
                    var depto = (MapaEntity)CbPadre.SelectedItem;
                    if (depto != null)
                    {
                        return _municipios.Update(new Municipios()
                        {
                            Id = _modelo.Id,
                            DepartamentoId = depto.Id,
                            Descripcion = TxtDescripcion.Text,
                            IsActive = _modelo.Estado == "Activo"
                        });
                    }
                    else
                    {
                        return "No se puede guardar por que no hay Departamentos.";
                    }                   
                case 3:
                    var mpio = (MapaEntity)CbPadre.SelectedItem;
                    if (mpio != null)
                    {
                        return _zonas.Update(new Zonas()
                        {
                            Id = _modelo.Id,
                            MunicipioId = mpio.Id,
                            Descripcion = TxtDescripcion.Text,
                            IsActive = _modelo.Estado == "Activo"
                        });
                    }
                    else
                    {
                        return "No se puede guardar por que no hay Departamentos.";
                    }
                case 4:
                    return _empresas.Update(new Empresas()
                    {
                        Id = _modelo.Id,
                        Descripcion = TxtDescripcion.Text,
                        IsActive = _modelo.Estado == "Activo"
                    });                
                default:
                    return "";
            }
        }

        public void LimpiarDatos() {
            TxtDescripcion.Text = "";
        }

        public void MostrarComboPadre(bool mostrar)
        {
            LbPadre.Visible = mostrar;
            CbPadre.Visible = mostrar;
        }

        
    }
}
