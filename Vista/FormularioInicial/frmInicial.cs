using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstudioColmenaTrabajoPractico.Vista;




namespace EstudioColmenaTrabajoPractico.Modelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //REVISAR ESTA PARTE DEL CODIGO

             

            //MessageBox.Show("Test");
            LoadUserData();
            //Permisos
            if (Login.Posicion == Posicion.Arquitecto)
            {

                btnPresupuesto.Enabled = false;

            }

        }

        private void LoadUserData()
        {

            //REVISAR ESTA PARTE DEL CODIGO
           lblName.Text = Login.Nombre + ", " + Login.Apellido;
            lblPosition.Text = Login.Posicion;
            lblEmail.Text = Login.Email;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar la sesión?", "Cuidado",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vista.FormularioReunion.frmReuniones reu = new Vista.FormularioReunion.frmReuniones();
            reu.Show();
        }

      

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            LoadUserData();
            //Permisos
            if (Login.Posicion == Posicion.Arquitecto)
            {
                btnPresupuesto.Enabled = false;

            }
        }

        private void lblPosition_Click(object sender, EventArgs e)
        {
            LoadUserData();
            //Permisos
            if (Login.Posicion == Posicion.Arquitecto)
            {
                btnPresupuesto.Enabled = false;

            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            LoadUserData();
            //Permisos
            if (Login.Posicion == Posicion.Arquitecto)
            {
                btnPresupuesto.Enabled = false;

            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            LoadUserData();
            //Permisos
            if (Login.Posicion == Posicion.Arquitecto)
            {
                btnPresupuesto.Enabled = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();
            lOGIN.Close();
            this.Close();
           
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Vista.Formularios_cliente.frmAgregacliente agregacliente = new Vista.Formularios_cliente.frmAgregacliente();
            agregacliente.Show();
            //Vista.frmCliente frmCliente = new Vista.frmCliente();
            //frmCliente.Show();
        }

        private void btnProyecto_Click(object sender, EventArgs e)
        {
            Vista.FormularioProyecto.frmProyecto p = new Vista.FormularioProyecto.frmProyecto();
            p.Show();
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            //Vista.FormularioPrecio.frmCambiarHonorarios precio = new Vista.FormularioPrecio.frmCambiarHonorarios();
            //precio.ShowDialog();
        }

        private void btnTipologia_Click(object sender, EventArgs e)
        {
            Vista.FormularioTipologiasProyecto.frmTipologia ac = new Vista.FormularioTipologiasProyecto.frmTipologia();
            ac.ShowDialog();
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            Vista.FormularioPresupuesto.frmPresupuesto p = new Vista.FormularioPresupuesto.frmPresupuesto();
            p.ShowDialog();
        }
    }
}
