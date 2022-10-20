using Colmena.Entidades;
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

namespace Colmena.Vista.Vista.FormularioCliente
{
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
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
    }
}
