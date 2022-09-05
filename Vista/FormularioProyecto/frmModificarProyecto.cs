using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EstudioColmenaTrabajoPractico.Vista.FormularioProyecto
{
    public partial class ModificarProyecto : Form

    {
        private int? Id;
        public ModificarProyecto(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;

        }

        private void Refrescar()
        {
            dsCRUDTableAdapters.ProyectoTableAdapter ta = new dsCRUDTableAdapters.ProyectoTableAdapter();
            dsCRUD.ProyectoDataTable dt = ta.GetData();

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dsCRUDTableAdapters.ProyectoTableAdapter ta = new dsCRUDTableAdapters.ProyectoTableAdapter();

            if (Id != null)
            {

                string nombre = txtCliente.Text;

                ta.UpdateQuery(TxtNProyecto.Text.Trim(), TxtDescripcion.Text.Trim(), nombre, TxtTerreno.Text.Trim(),
                    TxtSuperficie.Text.Trim(), TxtNiveles.Text.Trim(), TxtHabitaciones.Text.Trim(), TxtBaño.Text.Trim(),
                  TxtEstilo.Text.Trim(), TxtRecursos.Text.Trim(), (int)Id);

                Refrescar();
            }
            this.Close();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void TxtClientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificarProyecto_Load(object sender, EventArgs e)
        {
            //if (Id != null)
            //{
            //    //dsCRUDTableAdapters.ProyectoTableAdapter ta = new dsCRUDTableAdapters.ProyectoTableAdapter();
            //    //dsCRUD.ProyectoDataTable dt = ta.GetDataById((int)Id);
            //    //dsCRUD.ProyectoRow row = (dsCRUD.ProyectoRow)dt.Rows[0];

            //    dsCRUDTableAdapters.ProyectoTableAdapter ta =
            //        new dsCRUDTableAdapters.ProyectoTableAdapter();
            //    dsCRUD.ProyectoDataTable dt = ta.GetDataById((int)Id);
            //    dsCRUD.ProyectoRow row = (dsCRUD.ProyectoRow)dt.Rows[0];

            //    TxtNProyecto.Text = row.Nombre;
            //    TxtDescripcion.Text = row.Descripcion;
            //    txtCliente.Text = row.Cliente;
            //    TxtTerreno.Text = row.Terreno;
            //    TxtSuperficie.Text = row.Superficie;
            //    TxtNiveles.Text = row.Niveles;
            //    TxtHabitaciones.Text = row.Habitaciones;
            //    TxtBaño.Text = row.Baño;
            //    TxtEstilo.Text = row.Estilo;
            //    TxtRecursos.Text = row.Recursos;
            //}
        }
    }
}
