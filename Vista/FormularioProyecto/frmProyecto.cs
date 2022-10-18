using Colmena.Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Colmena.Entidades.Vista.FormularioProyecto
{
	public partial class frmProyecto : Form
	{
		public frmProyecto()
		{
			InitializeComponent();
		}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            dsCRUDTableAdapters.ProyectoTableAdapter ta = new dsCRUDTableAdapters.ProyectoTableAdapter();

            Modelo.Proyecto p = new Proyecto();

            string nombre = txtCliente.Text;
            //int idCliente = (int)CboIdCliente.SelectedValue;
            //int idProyecto = p.IdProyecto;
  
            ta.InsertQuery(TxtNProyecto.Text.Trim(), TxtDescripcion.Text.Trim(), nombre, TxtTerreno.Text.Trim(), TxtSuperficie.Text.Trim(), TxtNiveles.Text.Trim(), TxtHabitaciones.Text.Trim(), TxtBaño.Text.Trim(),
                  TxtEstilo.Text.Trim(), TxtRecursos.Text.Trim());

            Refrescar();
            Limpiar();
        }

        private void Limpiar()
        {
            txtCliente.Clear();
            TxtBaño.Clear();
            TxtDescripcion.Clear();
            TxtEstilo.Clear();
            TxtHabitaciones.Clear();
            TxtNiveles.Clear();
            TxtNProyecto.Clear();
            TxtRecursos.Clear();
            TxtSuperficie.Clear();
            TxtTerreno.Clear();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                dsCRUDTableAdapters.ProyectoTableAdapter ta = new dsCRUDTableAdapters.ProyectoTableAdapter();
                ta.Remover((int)Id);
                Refrescar();
            }


        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();

        }
    
    private void Refrescar()
    {
            dsCRUDTableAdapters.ProyectoTableAdapter ta =
                     new dsCRUDTableAdapters.ProyectoTableAdapter();
            dsCRUD.ProyectoDataTable dt = ta.GetData();

            dgvProyecto.DataSource = dt;
    }
        private int? GetId()
        {
            try
            {
                return int.Parse(dgvProyecto.Rows[dgvProyecto.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                return null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)

        {
            
            int? Id = GetId();
            if (Id != null)
            {
                ModificarProyecto modificaProyecto = new ModificarProyecto(Id);
                modificaProyecto.ShowDialog();
                Refrescar();
            }
        }
        private void AgregarProyecto_load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProyecto_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'dsCRUD.Cliente1' Puede moverla o quitarla según sea necesario.
            //this.cliente1TableAdapter.Fill(this.dsCRUD.Cliente1);
 
            Refrescar();
        }

        private void dgvProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtNProyecto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}