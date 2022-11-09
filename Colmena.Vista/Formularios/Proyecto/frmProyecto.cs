using Colmena.Negocio.LogicaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colmena.Vista.Formularios.Proyecto
{
    public partial class frmProyecto : Form
    {
        public frmProyecto()
        {
            InitializeComponent();
        }

        Entidades.Proyecto proyecto = new Entidades.Proyecto();
        ProyectoNegocio logic = new ProyectoNegocio();
        private void frmProyecto_Load(object sender, EventArgs e)
        {
            ProyectoInhabil();
            BotonesInhabilitados();
            LimpiarCampos();
            Listar();
        }

        private void Listar()
        {
            try
            {
                var lista = logic.GetAll();

                dgvProyecto.DataSource = null;
                dgvProyecto.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha ocurrido un error: {ex.Message}");
                throw;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ProyectoHabilitado();
            BotonesHabilitados();
            var id = GetById();
            id = null;
            proyecto.IdProyecto = id;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ProyectoHabilitado();
            BotonesHabilitados();
            var id = GetById();
            proyecto.IdProyecto = id;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int? Id = GetById();

                if (Id != null)
                {
                    proyecto.IdProyecto = Id;
                    logic.Delete(proyecto);
                }
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha ocurrido un error: {ex.Message}");
            }
        }
        private int? GetById()
        {
            try
            {
                return int.Parse(dgvProyecto.Rows[dgvProyecto.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha ocurrido un error: {ex.Message}");
                throw ex;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = proyecto.IdProyecto;

                if (String.IsNullOrEmpty(txtCliente.Text) || String.IsNullOrWhiteSpace(txtCliente.Text))
                {
                    MessageBox.Show($"El Campo Cliente es obligatorio");
                    lblCliente.ForeColor = Color.Red;
                }
                if (String.IsNullOrEmpty(txtDescripcion.Text) || String.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show($"El Campo Descripcion es obligatorio");
                    lblDescripcion.ForeColor = Color.Red;
                }
                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show($"El Campo Proyecto es obligatorio");
                    lblNombre.ForeColor = Color.Red;
                }
                else
                {
                    proyecto.NombreDeProyecto = txtNombre.Text;
                    proyecto.Descripcion = txtDescripcion.Text;
                    proyecto.Cliente = txtCliente.Text;
                    proyecto.Terreno = txtTerreno.Text;
                    proyecto.Superficie = txtSuperficie.Text;
                    proyecto.Niveles = txtNiveles.Text;
                    proyecto.Habitaciones = txtHabitaciones.Text;
                    proyecto.Baño = txtBaño.Text;
                    proyecto.Estilo = txtEstilo.Text;
                    proyecto.Recursos = txtRecursos.Text;

                    if (id == null)
                    {
                        logic.Insert(proyecto);
                        lblCliente.ForeColor = Color.Black;
                        lblDescripcion.ForeColor = Color.Black;
                        lblNombre.ForeColor = Color.Black;
                    }
                    else
                    {
                        proyecto.IdProyecto = id;
                        logic.Update(proyecto);
                        lblCliente.ForeColor = Color.Black;
                        lblDescripcion.ForeColor = Color.Black;
                        lblNombre.ForeColor = Color.Black;
                    }

                    LimpiarCampos();
                    Listar();
                    ProyectoInhabil();
                    BotonesInhabilitados();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha ocurrido un error: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ProyectoInhabil();
            BotonesInhabilitados();
            LimpiarCampos();
            Listar();
        }

        private void dgvProyecto_SelectionChanged(object sender, EventArgs e)
        {
            GetProyecto();
        }
        #region Metodos
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCliente.Clear();
            txtBaño.Clear();
            txtEstilo.Clear();
            txtHabitaciones.Clear();
            txtNiveles.Clear();
            txtRecursos.Clear();
            txtTerreno.Clear();
            txtSuperficie.Clear();
        }
        private void GetProyecto()
        {
            txtNombre.Text = dgvProyecto.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvProyecto.CurrentRow.Cells[2].Value.ToString();
            txtCliente.Text = dgvProyecto.CurrentRow.Cells[3].Value.ToString();
            txtTerreno.Text = dgvProyecto.CurrentRow.Cells[4].Value.ToString();
            txtSuperficie.Text = dgvProyecto.CurrentRow.Cells[5].Value.ToString();
            txtNiveles.Text = dgvProyecto.CurrentRow.Cells[6].Value.ToString();
            txtHabitaciones.Text = dgvProyecto.CurrentRow.Cells[7].Value.ToString();
            txtBaño.Text = dgvProyecto.CurrentRow.Cells[8].Value.ToString();
            txtEstilo.Text = dgvProyecto.CurrentRow.Cells[9].Value.ToString();
            txtRecursos.Text = dgvProyecto.CurrentRow.Cells[10].Value.ToString();
        }
        private void ProyectoInhabil()
        {
            txtDescripcion.Enabled = false;
            txtNombre.Enabled = false;        
            txtCliente.Enabled = false;
            txtTerreno.Enabled = false;
            txtSuperficie.Enabled = false;
            txtNiveles.Enabled = false;
            txtHabitaciones.Enabled = false;
            txtBaño.Enabled = false;
            txtEstilo.Enabled = false;
            txtRecursos.Enabled = false;

        }
        private void BotonesInhabilitados()
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            dgvProyecto.Enabled = true;
            btnCrear.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void BotonesHabilitados()
        {
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            dgvProyecto.Enabled = false;
            btnCrear.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void ProyectoHabilitado()
        {
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            txtCliente.Enabled = true;
            txtTerreno.Enabled = true;
            txtSuperficie.Enabled = true;
            txtNiveles.Enabled = true;
            txtHabitaciones.Enabled = true;
            txtBaño.Enabled = true;
            txtEstilo.Enabled = true;
            txtRecursos.Enabled = true;
        }
        #endregion Metodos        

    }
}
