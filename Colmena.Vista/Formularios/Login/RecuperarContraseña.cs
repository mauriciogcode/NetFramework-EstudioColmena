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

namespace Colmena.Vista.Formularios.Login
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Login login = new Entidades.Login();
            if (String.IsNullOrEmpty(textUsuarioReq.Text)|| String.IsNullOrWhiteSpace(textUsuarioReq.Text)) 
            {
                MessageBox.Show("El usuario es un campo Obligatorio");
               label1.ForeColor = Color.Red;
            }
            else
            {
                login.Usuario = textUsuarioReq.Text;
                label1.ForeColor = Color.Black;
            }
            
            var user = new LoginNegocio();
            var result = user.RecuperarContraseña(login);
            lblResultado.Text = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
