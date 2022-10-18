using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colmena.Entidades.Vista.FormularioTipologiasProyecto
{
    public partial class frmModificarTipo : Form
    {
        private int? Id;
        public frmModificarTipo(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dsCRUDTableAdapters.TipologiaTableAdapter ta = new dsCRUDTableAdapters.TipologiaTableAdapter();

            if (Id != null)
            {
                ta.ModificarTipologia(txtTipo.Text.Trim(), txtCaracteristicas.Text.Trim(), (int)Id);
            }

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ModificarTipo_Load(object sender, EventArgs e)
        {
             if (Id != null)
            {
                dsCRUDTableAdapters.TipologiaTableAdapter ta = new dsCRUDTableAdapters.TipologiaTableAdapter();
                dsCRUD.TipologiaDataTable dt = ta.GetDataById((int)Id);
                dsCRUD.TipologiaRow row = (dsCRUD.TipologiaRow)dt.Rows[0];

                txtTipo.Text = row.Tipo;
                txtCaracteristicas.Text = row.Caracteristicas;
              
            }
        }
    }
}
