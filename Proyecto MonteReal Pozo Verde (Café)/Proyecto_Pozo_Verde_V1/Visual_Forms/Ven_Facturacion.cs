using Proyecto_Pozo_Verde_V1.Class_Validaciones;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Proyecto_Pozo_Verde_V1.Visual_Forms
{
    public partial class Ven_Facturacion : Form
    {
        private readonly FacturacionStore _store = new FacturacionStore();
        private const decimal PrecioBasePorDefecto = 2500m;

        public Ven_Facturacion()
        {
            InitializeComponent();
            ActualizarTotalesUI();
        }

        public FacturacionStore Store => _store;

        private void RefreshGrid()
        {
            dgvProdFact.Rows.Clear();
            foreach (LineaFactura linea in _store.Lineas)
            {
                dgvProdFact.Rows.Add(
                    linea.Codigo,
                    linea.Descripcion,
                    linea.Cantidad,
                    linea.PrecioUnitario.ToString("N2", CultureInfo.CurrentCulture),
                    linea.Impuesto.ToString("N2", CultureInfo.CurrentCulture),
                    linea.Total.ToString("N2", CultureInfo.CurrentCulture));
            }
            ActualizarTotalesUI();
        }

        private void ActualizarTotalesUI()
        {
            ResumenFactura resumen = _store.CalcularResumen(0m);
            txtSubTotal.Text = resumen.Subtotal.ToString("N2", CultureInfo.CurrentCulture);
            txtDescuentos.Text = resumen.Descuentos.ToString("N2", CultureInfo.CurrentCulture);
            txtIV.Text = resumen.Impuesto.ToString("N2", CultureInfo.CurrentCulture);
            txtTotal.Text = resumen.Total.ToString("N2", CultureInfo.CurrentCulture);
        }

        private void txtCodInv_Enter(object sender, EventArgs e)
        {
            if (txtCodInv.Text.Equals(Val_IngFacturacion.PlaceholderCodigo))
            {
                txtCodInv.ForeColor = Color.Black;
                txtCodInv.Text = string.Empty;
            }
        }

        private void txtCodInv_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodInv.Text))
            {
                txtCodInv.ForeColor = Color.Gray;
                txtCodInv.Text = Val_IngFacturacion.PlaceholderCodigo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string error;
            if (_store.TryAdd(txtCodInv.Text, cbDescripcion.Text, 1, PrecioBasePorDefecto, out error))
            {
                RefreshGrid();
                MessageBox.Show("Datos ingresados con éxito.", "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error ?? "Error de ingreso de datos. Por favor verifique los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string error;
            if (_store.TryEdit(txtCodInv.Text, cbDescripcion.Text, 1, PrecioBasePorDefecto, out error))
            {
                RefreshGrid();
                MessageBox.Show("Datos modificados con éxito.", "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error ?? "Error al modificar los datos. Verifique el código y la descripción.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (_store.TryDelete(txtCodInv.Text))
            {
                RefreshGrid();
                MessageBox.Show("Datos eliminados con éxito.", "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró el código especificado para eliminar.", "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
