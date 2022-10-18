using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Colmena.Entidades.Vista.FormularioTipologiasProyecto;

namespace Colmena.Entidades.Vista.FormularioTipologiasProyecto
{
    public partial class frmTipologia : Form
    {
        public frmTipologia()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dsCRUDTableAdapters.TipologiaTableAdapter ta =
                new dsCRUDTableAdapters.TipologiaTableAdapter();

            ta.InsertQuery(txtTipo.Text.Trim(), txtCaracteristicas.Text.Trim());

            Limpiar();
            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                Vista.FormularioTipologiasProyecto.frmModificarTipo modificar =
               new frmModificarTipo(Id);
                modificar.ShowDialog();
                Refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                dsCRUDTableAdapters.TipologiaTableAdapter ta = new dsCRUDTableAdapters.TipologiaTableAdapter();
                ta.DeleteQuery((int)Id);
                Refrescar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refrescar()
        {
            dsCRUDTableAdapters.TipologiaTableAdapter ta =
                new dsCRUDTableAdapters.TipologiaTableAdapter();

            dsCRUD.TipologiaDataTable dt = ta.GetData();

            dataGridView1.DataSource = dt;
        }

        private void frmTipologia_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                return null;
            }
        }
        private void Limpiar()
        {
            txtTipo.Clear();
            txtCaracteristicas.Clear();
        }
    }
}
