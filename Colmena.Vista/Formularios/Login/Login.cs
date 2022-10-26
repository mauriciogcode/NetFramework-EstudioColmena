using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//FUNCIONALIDAD PARA PODER ARRASTRAR EL FORMULARIO 
using System.Runtime.InteropServices;
using Colmena.Negocio.LogicaEntidades;

namespace Colmena.Vista.Formularios.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Entidades.Login user = new Entidades.Login();
        LoginNegocio loginNegocio = new LoginNegocio();


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black;
            }

        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {

            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {

            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;
            }

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;

        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblError.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var RecuperarContraseña = new RecuperarContraseña();
            RecuperarContraseña.ShowDialog();


        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrarUusario = new RegistrodeUsuario();
            registrarUusario.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                {
                    txtContraseña.UseSystemPasswordChar = false;
                }
                else
                {
                    txtContraseña.UseSystemPasswordChar = true;
                }
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text != "USUARIO" && txtUsuario.TextLength > 2)
                {
                    if (txtContraseña.Text != "CONTRASEÑA")
                    {
                        user.Usuario = txtUsuario.Text;
                        user.Contraseña = txtContraseña.Text;


                        var validLogin = loginNegocio.LoginDeUsuario(user);
                        if (validLogin == true)
                        {
                            this.Hide();
                            //Bienvenida welcome = new Bienvenida();
                            //welcome.ShowDialog();
                            Inicio mainMenu = new Inicio();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                        }
                        else
                        {
                            msgError("Usuario y Contraseña incorrecta. Por favor intente de nuevo");
                            txtContraseña.Text = "CONTRASEÑA";
                            txtContraseña.Focus();

                        }
                    }

                    else msgError("Por favor ingresar Contraseña");
                }
                else msgError("Por favor ingresar Usuario");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error: {ex}");
                
            }
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrarUusario = new RegistrodeUsuario();
            registrarUusario.ShowDialog();
        }

        private void linkpass_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var RecuperarContraseña = new RecuperarContraseña();
            RecuperarContraseña.ShowDialog();
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                {
                    txtContraseña.UseSystemPasswordChar = false;
                }
                else
                {
                    txtContraseña.UseSystemPasswordChar = true;
                }
            }
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void btnminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
