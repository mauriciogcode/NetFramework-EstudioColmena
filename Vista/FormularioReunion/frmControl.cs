using System;
using System.Windows.Forms;

namespace Colmena.Entidades.Vista.FormularioReunion
{
    public partial class frmControl : Form
    {

        public frmControl()
        {
            InitializeComponent();
        }
        private void FormularioControl_Load(object sender, EventArgs e)
        {
            this.reunionTableAdapter.Fill(this.dsCRUD.Reunion);







        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int? Getid()
        {
            try
            {
                return int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int? Id = Getid();
            if (Id != null)
            {
                frmEvento frm = new frmEvento(Id);
                frm.ShowDialog();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int? Id = Getid();
            if (Id != null)
            {
                MessageBox.Show("Cita Borrada");
                dsCRUDTableAdapters.ReunionTableAdapter ta = new dsCRUDTableAdapters.ReunionTableAdapter();
                ta.remove((int)Id);
                this.reunionTableAdapter.Dispose();
                this.reunionTableAdapter.Fill(this.dsCRUD.Reunion);


            }
        }

    }
}
