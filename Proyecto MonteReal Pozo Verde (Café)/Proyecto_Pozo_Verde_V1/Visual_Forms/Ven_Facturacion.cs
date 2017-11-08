using Proyecto_Pozo_Verde_V1.Class_Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pozo_Verde_V1.Visual_Forms
{
    public partial class Ven_Facturacion : Form
    {
        Val_IngFacturacion vIngFact = new Val_IngFacturacion();
        public Ven_Facturacion()
        {
            InitializeComponent();
        }

        private void txtCodInv_Enter(object sender, EventArgs e)
        {
            if (txtCodInv.Text.Equals("Código a Facturar"))
            {
                txtCodInv.ForeColor = Color.Black;
                txtCodInv.Text = "";
            }
        }

        private void txtCodInv_Leave(object sender, EventArgs e)
        {
            if (txtCodInv.Text.Equals(""))
            {
                txtCodInv.ForeColor = Color.Gray;
                txtCodInv.Text = "Código a Facturar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (vIngFact.validacionIng(txtCodInv.Text, cbDescripcion.Text))
            {
                MessageBox.Show("Datos ingresador con exito.");
            }
            else {
                MessageBox.Show("Error de ingreso de datos, Favor verfique los datos que se están ingresando son correctos.");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (vIngFact.validacionIng(txtCodInv.Text, cbDescripcion.Text))
            {
                MessageBox.Show("Datos modificados con exito.");
            }
            else
            {
                MessageBox.Show("Error de modificar de datos, Favor verfique los datos que se está modificando sean correctos.");
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (vIngFact.validacionIng(txtCodInv.Text, cbDescripcion.Text))
            {
                MessageBox.Show("Datos eliminados con exito.");
            }
            else
            {
                MessageBox.Show("Error de eliminación de datos.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lb_Ident.Text = "Cédula:";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lb_Ident.Text = "Razón Social:";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lb_Ident.Text = "Pasaporte:";
        }
    }
}
