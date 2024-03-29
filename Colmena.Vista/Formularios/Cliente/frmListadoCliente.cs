﻿using Colmena.Entidades;
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
            ClienteInhabil();
            BotonesInhabilitados();
            LimpiarCampos();
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
                var id = cliente.IdCliente;

                if (String.IsNullOrEmpty(TxtDocumento.Text) || String.IsNullOrWhiteSpace(TxtDocumento.Text))
                {
                    MessageBox.Show($"El Campo Documento es obligatorio");
                    lblDocumento.ForeColor = Color.Red;
                }
                else
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

                    if (id == null)
                    {
                        logic.Insert(cliente);
                        lblDocumento.ForeColor = Color.Black;
                    }
                    else
                    {
                        cliente.IdCliente = id;
                        logic.Update(cliente);
                        lblDocumento.ForeColor = Color.Black;
                    }

                    LimpiarCampos();
                    Listar();
                    ClienteInhabil();
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
                string Id = GetByDocumento();

                if (Id != null)
                {
                    cliente.Documento = Id;
                    logic.Delete(cliente);
                }
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha ocurrido un error: {ex.Message}");
            }
        }

        private string GetByDocumento()
        {
            try
            {
                return DgvClientes.Rows[DgvClientes.CurrentRow.Index].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha ocurrido un error: {ex.Message}");
                throw ex;
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
            ClienteHabilitado();
            BotonesHabilitados();
            var id = GetById();
            cliente.IdCliente = id;
        }

        private void DgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            GetClientes();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ClienteHabilitado();
            BotonesHabilitados();
            var id = GetById();
            id = null;
            cliente.IdCliente = id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClienteInhabil();
            BotonesInhabilitados();
            LimpiarCampos();
            Listar();
        }

        #region Metodos
        private void LimpiarCampos()
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDocumento.Clear();
            TxtCalle.Clear();
            TxtAltura.Clear();
            TxtPiso.Clear();
            TxtBarrio.Clear();
            txtDepto.Clear();
            TxtMail.Clear();
            TxtOcupacion.Clear();
            TxtTelefono.Clear();
        }
        private void GetClientes()
        {
            TxtDocumento.Text = DgvClientes.CurrentRow.Cells[1].Value.ToString();
            TxtNombre.Text = DgvClientes.CurrentRow.Cells[2].Value.ToString();
            TxtBarrio.Text = DgvClientes.CurrentRow.Cells[3].Value.ToString();
            TxtCalle.Text = DgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtDepto.Text = DgvClientes.CurrentRow.Cells[5].Value.ToString();
            TxtMail.Text = DgvClientes.CurrentRow.Cells[6].Value.ToString();
            TxtOcupacion.Text = DgvClientes.CurrentRow.Cells[7].Value.ToString();
            TxtTelefono.Text = DgvClientes.CurrentRow.Cells[8].Value.ToString();
        }
        private void ClienteInhabil()
        {
            TxtNombre.Enabled = false;
            TxtApellido.Enabled = false;
            TxtDocumento.Enabled = false;
            TxtCalle.Enabled = false;
            TxtAltura.Enabled = false;
            TxtPiso.Enabled = false;
            TxtBarrio.Enabled = false;
            txtDepto.Enabled = false;
            TxtMail.Enabled = false;
            TxtOcupacion.Enabled = false;
            TxtTelefono.Enabled = false;
        }
        private void BotonesInhabilitados()
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            DgvClientes.Enabled = true;
            btnCrear.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void BotonesHabilitados()
        {
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            DgvClientes.Enabled = false;
            btnCrear.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void ClienteHabilitado()
        {
            TxtNombre.Enabled = true;
            TxtApellido.Enabled = true;
            TxtDocumento.Enabled = true;
            TxtCalle.Enabled = true;
            TxtAltura.Enabled = true;
            TxtPiso.Enabled = true;
            TxtBarrio.Enabled = true;
            txtDepto.Enabled = true;
            TxtMail.Enabled = true;
            TxtOcupacion.Enabled = true;
            TxtTelefono.Enabled = true;
        }
        #endregion Metodos
    }
}
