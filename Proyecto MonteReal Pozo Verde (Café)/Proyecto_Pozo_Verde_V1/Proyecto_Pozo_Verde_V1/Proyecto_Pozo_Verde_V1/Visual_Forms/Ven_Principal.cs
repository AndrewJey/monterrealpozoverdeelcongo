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
    public partial class Ven_Principal : Form
    {
        public Ven_Principal()
        {
            InitializeComponent();
        }

        private void facturaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ven_Facturacion vF = new Ven_Facturacion();
            vF.MdiParent = this;
            vF.Show();
        }
    }
}
