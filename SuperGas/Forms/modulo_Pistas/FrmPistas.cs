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
using Data.Mapas.Gasolineras;

namespace SuperGas.Forms.modulo_Pistas

{
    public partial class FrmPistas : Form
    {
        private Pistas PistasUpd = null;
        readonly Pistas _Pistas = new Pistas();
        readonly Gasolinera _gasolineras = new Gasolinera();
        public List<MapaPista> listado = new List<MapaPista>();

        public FrmPistas()
        {
            InitializeComponent();
            CargarGasolineras();
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text.ToUpper();
            var filter = listado.Where(x => x.Descripcion.ToUpper().Contains(txt1));
            DgvRegistros.DataSource = filter.ToList();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un Pistas para editar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rw = (MapaPista)DgvRegistros.CurrentRow.DataBoundItem;
                PistasUpd = _Pistas.GetPista(rw.Id);
                if (PistasUpd != null)
                {
                    CbGasolinera.SelectedValue = rw.GasolineraId;

                    TxtDescripcion.Text = PistasUpd.Descripcion;
                    TxtObservaciones.Text = PistasUpd.Observaciones;        

                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Pistas!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un Pistas para eliminar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rwpro = (MapaPista)DgvRegistros.CurrentRow.DataBoundItem;
                var Getveh = _Pistas.GetPista(rwpro.Id);
                if (Getveh != null)
                {
                    var dialog =
                            MessageBox.Show("¡Esta seguro que desea eliminar la Pista!", "Eliminar Producto",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        Getveh.IsActive = false;
                        string result = _Pistas.Update(Getveh);
                        if (result == "")
                        {
                            MessageBox.Show("¡Pista eliminado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDgv();
                        }
                        else
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos de la Pista!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = ValidarCampos();
                if (mensaje == "")
                {
                    string resultado;
                    ActivarCampos(false);
                    if (PistasUpd == null)
                        resultado = _Pistas.Insert(GetModel(0));
                    else
                        resultado = _Pistas.Update(GetModel(PistasUpd.Id));

                    if (resultado == "")
                    {
                        MessageBox.Show("¡Cambios Guardados Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDgv();
                        LimpiarCampos();
                        ActivarCampos(true);
                        PistasUpd = null;
                    }
                    else
                    {
                        ActivarCampos(true);
                        MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ActivarCampos(true);
                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ActivarCampos(true);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            PistasUpd = null;
        }

        public void CargarDgv()
        {
            listado = _Pistas.Listado();
            BindingSource recurso = new BindingSource
            {
                DataSource = listado
            };
            DgvRegistros.DataSource = typeof(List<>);
            DgvRegistros.DataSource = recurso;

            if (listado.Any())
            {
                DgvRegistros.Columns[1].Visible = false;
            }
        }

        public void CargarGasolineras()
        {
            var listado = _gasolineras.ListadoGasolineras();
            CbGasolinera.DataSource = listado;
            CbGasolinera.DisplayMember = "Descripcion";
            CbGasolinera.ValueMember = "Id";
            if (listado.Any())
                CbGasolinera.SelectedIndex = 0;
            CbGasolinera.Invalidate();
        }



        public void ActivarCampos(bool activar)
        {
            CbGasolinera.Enabled = activar;
            TxtDescripcion.Enabled = activar;
            TxtObservaciones.Enabled = activar;
            BtnGuardar.Enabled = activar;
            BtnCancelar.Enabled = activar;
        }

        public void LimpiarCampos()
        {
            TxtDescripcion.Text = "";
            TxtObservaciones.Text = "";
        }

        private string ValidarCampos()
        {
            if (CbGasolinera.SelectedItem == null)
                return "Debe seleccinar un Tipo de Combustible";
            else if (TxtDescripcion.Text.Length == 0)
                return "Debe ingresar una descripcion";
            else
                return "";
        }

        private Pistas GetModel(int id)
        {
            return new Pistas()
            {
                Id = id,
                GasolineraId = Convert.ToInt32(CbGasolinera.SelectedValue),
                Descripcion = TxtDescripcion.Text,
                Observaciones = TxtObservaciones.Text,
                IsActive = true
            };
        }

        private void BtnAddGasolinera_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.Gasolineras();
        }
    }
}
