using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models.Limpieza;
using Data.Mapas.Limpieza;

namespace SuperGas.Forms.modulo_Limpieza
{
    public partial class FrmLimpieza : Form
    {
        private HistorialLimpieza LimpiezaUpd = null;
        readonly HistorialLimpieza _historialLimpieza = new HistorialLimpieza();
        public List<MapaLimpieza> listado = new List<MapaLimpieza>();

        public FrmLimpieza()
        {
            InitializeComponent();
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            string txt1 = TxtBuscador.Text.ToUpper();
            var filter = listado.Where(x => x.Gasolinera.ToUpper().Contains(txt1) ||
                                            x.Encargado.Contains(txt1) ||
                                            x.Bomba.Contains(txt1) ||
                                            x.Pista.Contains(txt1) ||
                                            x.Camion.ToUpper().Contains(txt1));
            DgvRegistros.DataSource = filter.ToList();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.GestionLimpieza(new HistorialLimpieza());
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un Gasolinera para editar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rw = (MapaLimpieza)DgvRegistros.CurrentRow.DataBoundItem;
                LimpiezaUpd = _historialLimpieza.GetLimpieza(rw.Id);
                if (LimpiezaUpd != null)
                {
                    FormBase parent = this.ParentForm as FormBase;
                    parent.GestionLimpieza(LimpiezaUpd);
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos de la Limpieza!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvRegistros.CurrentRow == null)
                MessageBox.Show("¡Debe seleccionar un Gasolinera para eliminar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var rwpro = (MapaLimpieza)DgvRegistros.CurrentRow.DataBoundItem;
                var Getlimp = _historialLimpieza.GetLimpieza(rwpro.Id);
                if (Getlimp != null)
                {
                    var dialog =
                            MessageBox.Show("¡Esta seguro que desea eliminar la Limpieza!", "Eliminar Producto",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        Getlimp.IsActive = false;
                        string result = _historialLimpieza.Update(Getlimp);
                        if (result == "")
                        {
                            MessageBox.Show("¡Gasolinera eliminado con éxito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDgv();
                        }
                        else
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("¡No se pudo obtener los datos del Gasolinera!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmConfiguracion"] == null)
            {
                FrmConfiguracion config = new FrmConfiguracion();
                config.Show();
            }
            else
                Application.OpenForms["FrmConfiguracion"].Activate();
        }
      

        public void CargarDgv()
        {
            listado = _historialLimpieza.Listado();
            BindingSource recurso = new BindingSource
            {
                DataSource = listado
            };
            DgvRegistros.DataSource = typeof(List<>);
            DgvRegistros.DataSource = recurso;

            if (listado.Any())
            {
                DgvRegistros.Columns[1].Visible = false;
                DgvRegistros.Columns[2].Visible = false;
                DgvRegistros.Columns[3].Visible = false;
                DgvRegistros.Columns[4].Visible = false;
                DgvRegistros.Columns[5].Visible = false;
                DgvRegistros.Columns[6].Visible = false;

                DgvRegistros.Columns[8].Visible = false;
                DgvRegistros.Columns[9].Visible = false;
                DgvRegistros.Columns[10].Visible = false;
                DgvRegistros.Columns[11].Visible = false;


                DgvRegistros.Columns[14].HeaderText = "Hora Inicio";
                DgvRegistros.Columns[15].HeaderText = "Hora Final";
                DgvRegistros.Columns[16].HeaderText = "Fecha de Limpieza";
                DgvRegistros.Columns[17].HeaderText = "Próxima Limpieza";

            }
        }
    }
}
