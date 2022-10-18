using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Colmena.Entidades.Vista.FormularioPresupuesto;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;


namespace Colmena.Entidades.Vista.FormularioPresupuesto
{
    public partial class frmPresupuesto : Form
    {
        public frmPresupuesto()
        {
            InitializeComponent();
        }

        private void Presupuesto_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dsCRUD1.Tipologia' table. You can move, or remove it, as needed.
            this.tipologiaTableAdapter.Fill(this.dsCRUD1.Tipologia);
            //// TODO: This line of code loads data into the 'dsCRUD1.Proyecto' table. You can move, or remove it, as needed.
            this.proyectoTableAdapter.Fill(this.dsCRUD1.Proyecto);
            //// TODO: This line of code loads data into the 'dsCRUD.Cliente1' table. You can move, or remove it, as needed.
            this.cliente1TableAdapter.Fill(this.dsCRUD.Cliente1);
            //// TODO: This line of code loads data into the 'dsCRUD.Presupuesto' table. You can move, or remove it, as needed.
            //this.presupuestoTableAdapter.Fill(this.dsCRUD.Presupuesto);


            Refrescar();
        }
        private void Refrescar()
        {
            dsCRUDTableAdapters.Presupuesto2TableAdapter ta = new dsCRUDTableAdapters.Presupuesto2TableAdapter();
            dsCRUD.Presupuesto2DataTable dt = ta.GetData();

            //dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void button3_Click(object sender, EventArgs e) //boton agregar
        //{
        //    dsCRUDTableAdapters.Presupuesto2TableAdapter ta = new dsCRUDTableAdapters.Presupuesto2TableAdapter();

        //    Modelo.Presupuesto2 p = new Modelo.Presupuesto2();

        //    int cantidad = p.Cantidad;
        //    int precio = p.Precio;


        //    cantidad = int.Parse(txtCantidadConsulta.Text);
        //    precio = int.Parse(txtPrecioConsulta.Text);

        //    int costoTotal = 0;
        //    costoTotal = cantidad * precio;
        //    //costoTotal = decimal.Parse(txtPrecioConsulta.Text) * int.Parse(txtCantidadConsulta.Text);

        //    //ta.InsertQuery(cboCliente.SelectedValue.ToString(), cboProyecto.SelectedValue.ToString(),
        //    //    cboTipologia.SelectedValue.ToString(), precio, cantidad, costoTotal);

        //    ta.InsertQuery(cboCliente.SelectedValue.ToString(), cboProyecto.SelectedValue.ToString(),
        //        cboTipologia.SelectedValue.ToString(), precio, cantidad, costoTotal);
        //    Refrescar();
        //    Limpiar();
        //}

       private void Limpiar()
        {
            cboCliente.SelectedIndex = 0;
            cboProyecto.SelectedIndex = 0;
            cboTipologia.SelectedIndex = 0;
            txtCantidadConsulta.Clear();
            txtPrecioConsulta.Clear();
        }

        private void button1_Click(object sender, EventArgs e) //boton generar
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto =Properties.Resources.Plantilla.ToString();
            ;
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
           

            string filas = string.Empty;
         
           


            Modelo.Presupuesto2 p = new Modelo.Presupuesto2();
            int cantidad = p.Cantidad;
            int precio = p.Precio;


            cantidad = int.Parse(txtCantidadConsulta.Text);
            precio = int.Parse(txtPrecioConsulta.Text);

            int costoTotal = 0;
            costoTotal = cantidad * precio;

          
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Cliente", cboCliente.SelectedValue.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PROYECTO", cboProyecto.SelectedValue.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Cant", cantidad.ToString() );
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Tipologia", cboTipologia.SelectedValue.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Precio", precio.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", costoTotal.ToString());
            


            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    filas += "<tr>";
            //    filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
            //    filas += "<td>" + row.Cells["Tipologia"].Value.ToString() + "</td>";
            //    filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
            //    filas += "<td>" + row.Cells["Total"].Value.ToString() + "</td>";
            //    filas += "</tr>";
            //    total += decimal.Parse(row.Cells["Total"].Value.ToString());
            //}
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());



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
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.estudiocolmena, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(120, 400);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 30);
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
        
    }
    }

