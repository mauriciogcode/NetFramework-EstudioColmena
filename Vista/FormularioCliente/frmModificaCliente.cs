using EstudioColmenaTrabajoPractico.Modelo;
using System;
using System.Windows.Forms;


namespace EstudioColmenaTrabajoPractico.Vista.Formularios_cliente
{
    public partial class frmModificaCliente : Form
    {
        private int? Id;
        public frmModificaCliente(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
        }



        private void Refrescar()
        {
            dsCRUDTableAdapters.Cliente1TableAdapter ta = new dsCRUDTableAdapters.Cliente1TableAdapter();
            dsCRUD.Cliente1DataTable dt = ta.GetData();


        }


        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            dsCRUDTableAdapters.Cliente1TableAdapter ta = new dsCRUDTableAdapters.Cliente1TableAdapter();

            if (Id != null)
            {
                ta.ActualizarCliente(TxtDocumento.Text.Trim(), TxtApellido.Text.Trim(), TxtNombre.Text.Trim(), cboProvincia.Text.Trim(), cboDepartamento.Text.Trim(), cboLocalidad.Text.Trim(), TxtBarrio.Text.Trim(), TxtCalle.Text.Trim(), TxtAltura.Text.Trim(), TxtPiso.Text.Trim(), txtDepto.Text.Trim(), TxtMail.Text.Trim(), TxtOcupacion.Text.Trim(), TxtTelefono.Text.Trim(), (int)Id);
            }

            this.Close();
        }

        private void ModificaCliente_Load(object sender, EventArgs e)
        {
            ListarProvincia();

            if (Id != null)
            {
                dsCRUDTableAdapters.Cliente1TableAdapter ta = new dsCRUDTableAdapters.Cliente1TableAdapter();
                dsCRUD.Cliente1DataTable dt = ta.GetDataByIdCliente((int)Id);
                dsCRUD.Cliente1Row row = (dsCRUD.Cliente1Row)dt.Rows[0];

                TxtDocumento.Text = row.Documento;
                TxtApellido.Text = row.Apellido;
                TxtNombre.Text = row.Nombre;
                cboProvincia.Text = row.Provincia;
                cboDepartamento.Text = row.Departamento;
                cboLocalidad.Text = row.Localidad;
                TxtBarrio.Text = row.Barrio;
                TxtCalle.Text = row.Calle;
                TxtAltura.Text = row.Altura;
                TxtPiso.Text = row.Piso;
                txtDepto.Text = row.Depto;
                TxtMail.Text = row.Email;
                TxtOcupacion.Text = row.Ocupacion;
                TxtTelefono.Text = row.Telefono;
                lblId.Text = row.IdCliente.ToString();

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

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

            cboDepartamento.DataSource = new Operaciones().ObtenerDepartamento(oProvinciaSeleccionado.IdProvincia);
            cboDepartamento.ValueMember = "CodigoDepartamento";
            cboDepartamento.DisplayMember = "Nombre";

        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Departamento oDepartamentoSeleccionada = (Departamento)cboDepartamento.SelectedItem;

            cboLocalidad.DataSource = new Operaciones().ObtenerLocalidad(oDepartamentoSeleccionada.IdDepartamento);
            cboLocalidad.ValueMember = "CodigoLocalidad";
            cboLocalidad.DisplayMember = "Nombre";


        }


    }
}

