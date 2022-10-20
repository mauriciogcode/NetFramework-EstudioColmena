using Colmena.Entidades;
using Colmena.Negocio.LogicaEntidades;
using Colmena.Vista.Formularios.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colmena.Vista.Vista.FormularioCliente
{
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        ClienteNegocio logic = new ClienteNegocio();
        Cliente cliente = new Cliente();

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                var lista = logic.GetAll();

                DgvClientes.DataSource = null;
                DgvClientes.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha ocurrido un error: {ex.Message}");
                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Nombre = TxtNombre.Text;
                cliente.Apellido = TxtApellido.Text;
                cliente.Documento = TxtDocumento.Text;
                cliente.Calle = TxtCalle.Text;
                cliente.Altura = TxtAltura.Text;
                cliente.Piso = TxtPiso.Text;
                cliente.Barrio = TxtBarrio.Text;
                cliente.Depto = txtDepto.Text;
                cliente.Email = TxtMail.Text;
                cliente.Ocupacion = TxtOcupacion.Text;
                cliente.Telefono = TxtTelefono.Text;

                logic.Insert(cliente);
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha ocurrido un error: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int? Id = GetById();

                if (Id != null)
                {
                    cliente.Documento = Id.ToString();
                    logic.Delete(cliente);
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
                return int.Parse(DgvClientes.Rows[DgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha ocurrido un error: {ex.Message}");
                throw ex;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarCliente frm = new frmModificarCliente();
            frm.ShowDialog();            
        }
    }
}
