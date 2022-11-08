using Colmena.Negocio;
using Colmena.Negocio.LogicaEntidades.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colmena.Vista.Formularios.Seguimiento
{
    public partial class frmSeguimiento : Form
    {
        public frmSeguimiento()
        {
            InitializeComponent();
        }

        private void frmSeguimiento_Load(object sender, EventArgs e)
        {
            LoadAll();
        }



        public void LoadAll()
        {
            SeguimientoNegocio oSeguimientoNegocio = new SeguimientoNegocio();
            DataTable dt = oSeguimientoNegocio.GetAll();

            dgv.DataSource = dt;
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            cbFactibilidad.Checked = false;
            cbImplantacion.Checked = false;
            cbVistas.Checked = false;
            cbMunicipal.Checked = false;
            cbLegajo.Checked = false;
            cbComputo.Checked = false;

            if (dgv.SelectedRows != null)
            {

                lblTitulo.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                lblproject.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                lblid.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                txtComentario.Text = dgv.CurrentRow.Cells[17].Value.ToString();
                txtDescripcion.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                cbFactibilidad.Checked = dgv.CurrentRow.Cells[5].Value is true ? true : false;
                cbImplantacion.Checked = dgv.CurrentRow.Cells[7].Value is true ? true : false;
                cbVistas.Checked = dgv.CurrentRow.Cells[9].Value is true ? true : false;
                cbMunicipal.Checked = dgv.CurrentRow.Cells[11].Value is true ? true : false;
                cbLegajo.Checked = dgv.CurrentRow.Cells[13].Value is true ? true : false;
                cbComputo.Checked = dgv.CurrentRow.Cells[15].Value is true ? true : false;

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {


                SeguimientoNegocio oSeguimientoNegocio = new SeguimientoNegocio();
                if (String.IsNullOrEmpty(lblid.Text))
                {
                    Entidades.Seguimiento obe = new Entidades.Seguimiento();
                    //obe.IdSeguimiento = Convert.ToInt32(lblid.Text);
                    //obe.IdProyecto = Convert.ToInt32(lblproject.Text);
                    obe.Factibilidad = cbFactibilidad.Checked;
                    obe.Implantacion = cbImplantacion.Checked;
                    obe.Vistas = cbVistas.Checked;
                    obe.Municipal = cbMunicipal.Checked;
                    obe.Legajo = cbLegajo.Checked;
                    obe.Computo = cbComputo.Checked;
                    obe.Comentario = txtComentario.Text;
                    if (obe.Comentario == null)
                    {
                        obe.Comentario = "";
                    }

                    oSeguimientoNegocio.Insert(obe);
                    MessageBox.Show("Seguimiento realizado exitosamente");

                }
                else
                {
                    Entidades.Seguimiento obe = new Entidades.Seguimiento();
                    obe.IdSeguimiento = Convert.ToInt32(lblid.Text);
                    obe.Factibilidad = cbFactibilidad.Checked;
                    obe.Implantacion = cbImplantacion.Checked;
                    obe.Vistas = cbVistas.Checked;
                    obe.Municipal = cbMunicipal.Checked;
                    obe.Legajo = cbLegajo.Checked;
                    obe.Computo = cbComputo.Checked;
                    obe.Comentario = txtComentario.Text;
                    if (obe.Comentario == null)
                    {
                        obe.Comentario = "";
                    }

                    oSeguimientoNegocio.Update(obe);
                    MessageBox.Show("Seguimiento modificado exitosamente");
                }

                DataTable dt = oSeguimientoNegocio.GetAll();

                dgv.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
