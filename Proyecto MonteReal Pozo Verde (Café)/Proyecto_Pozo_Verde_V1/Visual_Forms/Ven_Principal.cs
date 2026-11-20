using System;
using System.Linq;
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
            Ven_Facturacion existing = this.MdiChildren.OfType<Ven_Facturacion>().FirstOrDefault();
            if (existing != null && !existing.IsDisposed)
            {
                existing.BringToFront();
                existing.Focus();
                return;
            }

            Ven_Facturacion vF = new Ven_Facturacion { MdiParent = this };
            vF.Show();
        }
    }
}
