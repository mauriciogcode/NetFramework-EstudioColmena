using System;
using System.Windows.Forms;
using EstudioColmenaTrabajoPractico.Vista.Formularios_cliente;
using EstudioColmenaTrabajoPractico.Modelo;
using EstudioColmenaTrabajoPractico.Controlador;


namespace EstudioColmenaTrabajoPractico.Vista.Formularios_cliente
{
    public partial class frmAgregacliente : Form
    {
        public frmAgregacliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) //boton de agregar
        {
            dsCRUDTableAdapters.Cliente1TableAdapter ta = new dsCRUDTableAdapters.Cliente1TableAdapter();

            ta.CrearCliente(TxtDocumento.Text.Trim(), TxtApellido.Text.Trim(), TxtNombre.Text.Trim(), cboProvincia.Text.Trim(),cboDepartamento.Text.Trim(), cboLocalidad.Text.Trim(), TxtBarrio.Text.Trim(),TxtCalle.Text.Trim(), TxtAltura.Text.Trim(), TxtPiso.Text.Trim(), txtDepto.Text.Trim(), TxtMail.Text.Trim(), TxtOcupacion.Text.Trim(),TxtTelefono.Text.Trim());

            Refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cancelar
            this.Close();
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            dsCRUDTableAdapters.Cliente1TableAdapter ta = new dsCRUDTableAdapters.Cliente1TableAdapter();
            dsCRUD.Cliente1DataTable dt = ta.GetData();

            DgvClientes.DataSource = dt;
        }
        private int? GetId()
        {
            try
            {
                return int.Parse(DgvClientes.Rows[DgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
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
                frmModificaCliente modificaCliente = new frmModificaCliente(Id);
                modificaCliente.ShowDialog();
                Refrescar();
            }            
        }

        private void Agregacliente_Load(object sender, EventArgs e)
        {
            Refrescar();
            ListarProvincia();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                dsCRUDTableAdapters.Cliente1TableAdapter ta = new dsCRUDTableAdapters.Cliente1TableAdapter();
                ta.DeleteQuery((int)Id);
                Refrescar();
            }
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ListarProvincia();

        }

        private void ListarProvincia()
        {
            cboProvincia.DataSource = new Operaciones().ObtenerProvincia();
            cboProvincia.ValueMember = "CodigoProvincia";
            cboProvincia.DisplayMember = "Nombre";

        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Provincia oProvinciaSeleccionado = (Provincia)cboProvincia.SelectedItem;

            cboDepartamento.DataSource = new Operaciones().ObtenerDepartamento(oProvinciaSeleccionado.CodigoProvincia);
            cboDepartamento.ValueMember = "CodigoDepartamento";
            cboDepartamento.DisplayMember = "Nombre";

        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
           Departamento oDepartamentoSeleccionada = (Departamento)cboDepartamento.SelectedItem;

            cboLocalidad.DataSource = new Operaciones().ObtenerLocalidad(oDepartamentoSeleccionada.CodigoDepartamento);
            cboLocalidad.ValueMember = "CodigoLocalidad";
            cboLocalidad.DisplayMember = "Nombre";


        }


    }



}
