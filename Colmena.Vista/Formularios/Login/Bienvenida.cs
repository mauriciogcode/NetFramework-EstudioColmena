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
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            Entidades.Login login = new Entidades.Login();

            lblNombre.Text = login.Nombre;
            lblPosicion.Text = login.NivelAcceso;

            //lblPosicion.Text = Login.NivelAcceso;
            //lblNombre.Text = Login.Nombre + ", " + Login.Apellido;
        }
    }


}
