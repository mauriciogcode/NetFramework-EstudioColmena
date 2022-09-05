using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstudioColmenaTrabajoPractico.Controlador;

namespace TrabajoIntegradorS.Vista
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var user = new ModelodeUsuario();
            var result = user.RecuperarContraseña(txtSolicitudUsuario.Text);
            lblResultado.Text = result;
        }
    }
}
