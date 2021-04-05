using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Salario_Empleados
{
    public partial class Inicio_de_Sesion : Form
    {
        public Inicio_de_Sesion()
        {
            InitializeComponent();

        }
        String UsuarioAdministrador = "empleado";
        string ContraseñaAdministrador = "AUTONORTE";
        //Para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //TODO Funciones del mismo programa
        void actuar()
        {
            bool usuario, contraseña;
            if (txtUsuario.Text.ToLower() != UsuarioAdministrador)
            {
                pnstadoUsuario.BackColor = Color.Crimson;
                usuario = false;
            }
            else
            {
                pnstadoUsuario.BackColor = Color.LawnGreen;
                usuario = true;
            }
            if (txtContraseña.Text != ContraseñaAdministrador)
            {
                pnstadoContraseña.BackColor = Color.Crimson;
                contraseña = false;
            }
            else
            {
                pnstadoContraseña.BackColor = Color.LawnGreen;
                contraseña = true;
            }
            if (usuario == true && contraseña == true)
            {
                Visible = false;
                Form ventanaPrincipal = new General();
                ventanaPrincipal.Show();
            }
            else
            {
                msnError.Visible = true;
                msnError.Text = "Usuario o contraseña incorrecta";
            }

        }

        private void Inicio_de_Sesion_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "Nombre de usuario";
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtContraseña.Text = "Contraseña";
            txtContraseña.ForeColor = Color.Gray;
            txtContraseña.BorderStyle = BorderStyle.None;
            pncontenedor.Select();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.White;
            pnUsuario.BackColor = Color.White;
            pnUsuario.BorderStyle = BorderStyle.None;
            if (txtUsuario.Text == "")
                txtUsuario.Text = "Nombre de usuario";
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {

            txtUsuario.BackColor = Color.WhiteSmoke;
            pnUsuario.BackColor = Color.WhiteSmoke;
            pnUsuario.BorderStyle = BorderStyle.FixedSingle;
            if (txtUsuario.Text == "Nombre de usuario" || txtUsuario.Text == "")
            {
                txtUsuario.Text = "";
            }

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {


            txtContraseña.BackColor = Color.White;
            pnContraseña.BackColor = Color.White;
            pnContraseña.BorderStyle = BorderStyle.None;
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.PasswordChar = '\0';
            }

        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            txtContraseña.BackColor = Color.WhiteSmoke;
            pnContraseña.BackColor = Color.WhiteSmoke;
            pnContraseña.BorderStyle = BorderStyle.FixedSingle;
            if (txtContraseña.Text == "Contraseña" || txtContraseña.Text == "")
            {
                txtContraseña.Text = "";
                txtContraseña.PasswordChar = '*';
            }
            //if(txtContraseña.Text != "Contraseña")
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            actuar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) actuar();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) actuar();
        }

        private void pncontenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void paneltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pncontenedor_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Inicio_de_Sesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
