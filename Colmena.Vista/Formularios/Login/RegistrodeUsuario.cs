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
using Colmena.Entidades;


namespace Colmena.Vista.Formularios.Login
{
    public partial class RegistrodeUsuario : Form
    {
        public RegistrodeUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LoginNegocio loginNegocio = new LoginNegocio();
            Entidades.Login login = new Entidades.Login();

            login.Usuario = txtUsuario.Text;
            login.Contraseña = txtContraseña.Text;
            login.Email = txtEmail.Text;
            login.NivelAcceso = txtPosicion.Text;
            login.Nombre = txtNombre.Text;
            login.Apellido = txtApellido.Text;

            loginNegocio.CrearUsuario(login);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
