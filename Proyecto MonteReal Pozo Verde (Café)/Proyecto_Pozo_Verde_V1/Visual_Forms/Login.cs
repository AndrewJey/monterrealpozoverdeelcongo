using Proyecto_Pozo_Verde_V1.Class_Validaciones;
using Proyecto_Pozo_Verde_V1.Visual_Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Pozo_Verde_V1
{
    public partial class Login : Form
    {
        private readonly Val_Login valLogin = new Val_Login();

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valLogin.validacion(txtUsuario.Text, txtPass.Text))
            {
                Ven_Principal vP = new Ven_Principal();
                vP.FormClosed += (s, args) =>
                {
                    if (!this.IsDisposed)
                    {
                        this.Close();
                    }
                };
                vP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos, por favor verifique los datos.",
                    "Inicio de sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(Val_Login.PlaceholderUsuario))
            {
                txtUsuario.ForeColor = Color.Black;
                txtUsuario.Text = string.Empty;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.ForeColor = Color.Gray;
                txtUsuario.Text = Val_Login.PlaceholderUsuario;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(Val_Login.PlaceholderPass))
            {
                txtPass.ForeColor = Color.Black;
                txtPass.Text = string.Empty;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.Gray;
                txtPass.Text = Val_Login.PlaceholderPass;
            }
        }
    }
}
