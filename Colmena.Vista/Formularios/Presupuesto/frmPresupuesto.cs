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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Colmena.Vista.Formularios.Presupuesto
{
    public partial class frmPresupuesto : Form
    {
        public frmPresupuesto()
        {
            InitializeComponent();
        }
        Entidades.Presupuesto presupuesto = new Entidades.Presupuesto();
        PresupuestoNegocio logic = new PresupuestoNegocio();
        private void btnCrearPresupuesto_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPrecioTipologia.Text) || String.IsNullOrEmpty(txtPrecioTipologia.Text))
            {
                MessageBox.Show($"El precio del Tipo de proyecto es obligatorio. Por favor completar.");

            }
            if (String.IsNullOrWhiteSpace(txtCantidadReuniones.Text) || String.IsNullOrEmpty(txtCantidadReuniones.Text))
            {
                MessageBox.Show($"La cantidad de reuniones es obligatorio. Por favor completar.");
            }
            else
            {
                CrearPresupuesto();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPresupuesto_Load(object sender, EventArgs e)
        {
            ListarCliente();
            ListarProyecto();
            Deshabilitar();

        }

        private void ListarCliente()
        {
            var lista = logic.GetCliente();

            dgvCliente.DataSource = null;
            dgvCliente.DataSource = lista;
        }
        private void ListarProyecto()
        {
            var lista = logic.GetProyecto();

            dgvProyecto.DataSource = null;
            dgvProyecto.DataSource = lista;
        }

        private void GetClientes()
        {
            txtCliente.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            TxtDocumento.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            TxtCalle.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            TxtMail.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
        }
        private void GetProyecto()
        {
            txtProyecto.Text = dgvProyecto.CurrentRow.Cells[0].Value.ToString();
            txtTipo.Text = dgvProyecto.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvProyecto.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            GetClientes();
        }

        private void dgvProyecto_SelectionChanged(object sender, EventArgs e)
        {
            GetProyecto();
        }

        private void Deshabilitar()
        {
            txtProyecto.Enabled = false;
            txtTipo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtCliente.Enabled = false;
            TxtDocumento.Enabled = false;
            TxtCalle.Enabled = false;
            TxtMail.Enabled = false;
        }

        private void CrearPresupuesto()
        {
            string fechaActual = DateTime.Now.ToString("dd/MM/yy");
            int total = 0;
            int cantReuniones = int.Parse(txtCantidadReuniones.Text);
            int precioTipologia = int.Parse(txtPrecioTipologia.Text);
            int totalTipologia = 0;
            int precioReunion = int.Parse(txtPrecioReunion.Text);
            int totalReuniones = 0;
            int numLista = 1;


            precioReunion = int.Parse(txtPrecioReunion.Text);

            totalTipologia = precioTipologia;
            totalReuniones = cantReuniones * precioReunion;
            total = totalReuniones + totalTipologia;
            try
            {
                presupuesto.TotalNeto = total;
                presupuesto.FechaDeCreacion = DateTime.Now;
                logic.Insert(presupuesto);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha pasado un error {ex}");
            }

            int idPresupuesto = presupuesto.IdPresupuesto;


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}{1}.pdf", fechaActual, "PresupuestoColmena");
            string PaginaHTML_Texto = Properties.Resources.presupuestoModificado.ToString();

            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", fechaActual.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txtCliente.Text.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOMICILIO", TxtCalle.Text.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TELEFONO", TxtDocumento.Text.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MAIL", TxtMail.Text.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@ID_PRESUPUESTO", idPresupuesto.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NUMERO_LISTA", numLista.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TIPOLOGIA", txtTipo.Text.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PRECIOT", precioTipologia.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL_TIPOLOGIA", totalTipologia.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PRECIOR", precioReunion.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL_REUNIONES", totalReuniones.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CANTIDAD_REUNIONES", cantReuniones.ToString());

            string filas = string.Empty;

            try
            {
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        //Creamos un nuevo documento y lo definimos como PDF
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        //Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.fondoPresupuesto, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(1500, 1340);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        img.SetAbsolutePosition(500, 100);
                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top);
                        pdfDoc.Add(img);


                        //pdfDoc.Add(new Phrase("Hola Mundo"));
                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups! Ha pasado un error {ex}");
            }
        }

    }
}

