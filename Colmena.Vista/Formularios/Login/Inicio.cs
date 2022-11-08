using Colmena.Vista.Formularios.Presupuesto;
using Colmena.Vista.Formularios.Proyecto;
using Colmena.Vista.Formularios.Reunion;
using Colmena.Vista.Formularios.Seguimiento;
using Colmena.Vista.Formularios.Tipologia;
using Colmena.Vista.Vista.FormularioCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colmena.Vista.Formularios.Login
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListadoClientes frm = new frmListadoClientes();
            frm.ShowDialog();
        }

        private void btnProyecto_Click(object sender, EventArgs e)
        {
            frmProyecto frm = new frmProyecto();
            frm.ShowDialog();
        }

        private void btnCronograma_Click(object sender, EventArgs e)
        {
            frmCalendar frm = new frmCalendar();
            frm.ShowDialog();
        }

        private void btnTipologia_Click(object sender, EventArgs e)
        {
            frmTipologia frm = new frmTipologia();
            frm.ShowDialog();
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            frmPresupuesto frm = new frmPresupuesto();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSeguimiento frmSeguimiento = new frmSeguimiento();
            frmSeguimiento.ShowDialog();
        }
    }
}
