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

namespace Colmena.Vista.Formularios.Tipologia
{
    public partial class frmTipologia : Form
    {
        public frmTipologia()
        {
            InitializeComponent();
        }

        TipologiaNegocio logic = new TipologiaNegocio();
        Entidades.Tipologia tipologia = new Entidades.Tipologia();
        private void frmTipologia_Load(object sender, EventArgs e)
        {
            TipoInhabil();
            BotonesInhabilitados();
            LimpiarCampos();
            Listar();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = tipologia.IdTipologia;

                if (String.IsNullOrEmpty(txtTipo.Text) || String.IsNullOrWhiteSpace(txtTipo.Text))
                {
                    MessageBox.Show($"El Campo Tipo es obligatorio");
                    lblTipo.ForeColor = Color.Red;
                }
                if (String.IsNullOrEmpty(txtDescripcion.Text) || String.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show($"El Campo Descripcion es obligatorio");
                    lblDescripcion.ForeColor = Color.Red;
                }
                else
                {
                    tipologia.Tipo = txtTipo.Text;
                    tipologia.Caracteristicas = txtDescripcion.Text;

                    if (id == null)
                    {
                        logic.Insert(tipologia);
                        lblTipo.ForeColor = Color.Black;
                        lblDescripcion.ForeColor = Color.Black;
                    }
                    else
                    {
                       tipologia.IdTipologia = id;
                        logic.Update(tipologia);
                        lblTipo.ForeColor = Color.Black;
                        lblDescripcion.ForeColor = Color.Black;
                    }

                    LimpiarCampos();
                    Listar();
                    TipoInhabil();
                    BotonesInhabilitados();
                }

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
                    tipologia.IdTipologia = Id;
                    logic.Delete(tipologia);
                }
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha ocurrido un error: {ex.Message}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TipoHabilitado();
            BotonesHabilitados();
            var id = GetById();
            tipologia.IdTipologia = id;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            TipoHabilitado();
            BotonesHabilitados();
            var id = GetById();
            id = null;
            tipologia.IdTipologia = id;
        }

        private int? GetById()
        {
            try
            {
                return int.Parse(dgvTipologia.Rows[dgvTipologia.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha ocurrido un error: {ex.Message}");
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TipoInhabil();
            BotonesInhabilitados();
            LimpiarCampos();
            Listar();
        }

        private void Listar()
        {
            try
            {
                var lista = logic.GetAll();

                dgvTipologia.DataSource = null;
                dgvTipologia.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha ocurrido un error: {ex.Message}");
                throw;
            }
        }
        private void dgvTipologia_SelectionChanged(object sender, EventArgs e)
        {
            GetTipos();
        }

        #region Metodos
        private void LimpiarCampos()
        {
            txtTipo.Clear();
            txtDescripcion.Clear();
        }
        private void GetTipos()
        {
            txtTipo.Text = dgvTipologia.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvTipologia.CurrentRow.Cells[2].Value.ToString();
        }
        private void TipoInhabil()
        {
            txtDescripcion.Enabled = false;
            txtTipo.Enabled = false;

        }
        private void BotonesInhabilitados()
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            dgvTipologia.Enabled = true;
            btnCrear.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void BotonesHabilitados()
        {
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            dgvTipologia.Enabled = false;
            btnCrear.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void TipoHabilitado()
        {
            txtTipo.Enabled = true;
            txtDescripcion.Enabled = true;
        }
        #endregion Metodos        

    }
}
