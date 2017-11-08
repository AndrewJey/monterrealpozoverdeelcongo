using Proyecto_Pozo_Verde_V1.Class_Validaciones;
using Proyecto_Pozo_Verde_V1.Visual_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pozo_Verde_V1
{
    public partial class Login : Form
    {
        private Val_Login valLogin = new Val_Login();
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valLogin.validacion(txtUsuario.Text, txtPass.Text))
            {
                Ven_Principal vP = new Ven_Principal();
                vP.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Usuario o Contraseña incorrectos, favor verifique los datos.");
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Nombre de Usuario")) {
                txtUsuario.ForeColor = Color.Black;
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                txtUsuario.ForeColor = Color.Gray;
                txtUsuario.Text = "Nombre de Usuario";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals("Contraseña"))
            {
                txtPass.ForeColor = Color.Black;
                txtPass.Text = "";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(""))
            {
                txtPass.ForeColor = Color.Gray;
                txtPass.Text = "Contraseña";
            }
        }
    }
}
