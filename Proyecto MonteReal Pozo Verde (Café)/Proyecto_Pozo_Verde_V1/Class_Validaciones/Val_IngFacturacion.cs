using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Proyecto_Pozo_Verde_V1.Class_Validaciones
{
    public class LineaFactura
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal TasaImpuesto { get; set; }

        public decimal Subtotal => Cantidad * PrecioUnitario;
        public decimal Impuesto => Math.Round(Subtotal * TasaImpuesto, 2);
        public decimal Total => Subtotal + Impuesto;
    }

    public class ResumenFactura
    {
        public decimal Subtotal { get; set; }
        public decimal Descuentos { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
    }

    public class FacturacionStore
    {
        public const decimal TasaIvaPorDefecto = 0.13m;
        private readonly List<LineaFactura> _lineas = new List<LineaFactura>();

        public IReadOnlyList<LineaFactura> Lineas => _lineas.AsReadOnly();

        public bool TryAdd(string codigo, string descripcion, int cantidad, decimal precioUnitario, out string error)
        {
            error = null;
            string cod = (codigo ?? string.Empty).Trim();
            string desc = (descripcion ?? string.Empty).Trim();

            if (!new Val_IngFacturacion().validacionIng(cod, desc))
            {
                error = "Debe ingresar un código y una descripción válidos.";
                return false;
            }
            if (cantidad <= 0)
            {
                error = "La cantidad debe ser mayor que cero.";
                return false;
            }
            if (precioUnitario < 0m)
            {
                error = "El precio unitario no puede ser negativo.";
                return false;
            }

            LineaFactura existing = _lineas.FirstOrDefault(l => string.Equals(l.Codigo, cod, StringComparison.OrdinalIgnoreCase));
            if (existing != null)
            {
                existing.Cantidad += cantidad;
                existing.Descripcion = desc;
                existing.PrecioUnitario = precioUnitario;
                return true;
            }

            _lineas.Add(new LineaFactura
            {
                Codigo = cod,
                Descripcion = desc,
                Cantidad = cantidad,
                PrecioUnitario = precioUnitario,
                TasaImpuesto = TasaIvaPorDefecto
            });
            return true;
        }

        public bool TryEdit(string codigo, string nuevaDescripcion, int nuevaCantidad, decimal nuevoPrecio, out string error)
        {
            error = null;
            string cod = (codigo ?? string.Empty).Trim();
            string desc = (nuevaDescripcion ?? string.Empty).Trim();
            if (!new Val_IngFacturacion().validacionIng(cod, desc))
            {
                error = "Debe ingresar un código y una descripción válidos.";
                return false;
            }
            if (nuevaCantidad <= 0 || nuevoPrecio < 0m)
            {
                error = "Cantidad y precio deben ser válidos.";
                return false;
            }

            LineaFactura existing = _lineas.FirstOrDefault(l => string.Equals(l.Codigo, cod, StringComparison.OrdinalIgnoreCase));
            if (existing == null)
            {
                error = "No existe una línea con ese código para modificar.";
                return false;
            }

            existing.Descripcion = desc;
            existing.Cantidad = nuevaCantidad;
            existing.PrecioUnitario = nuevoPrecio;
            return true;
        }

        public bool TryDelete(string codigo)
        {
            string cod = (codigo ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(cod)) return false;
            return _lineas.RemoveAll(l => string.Equals(l.Codigo, cod, StringComparison.OrdinalIgnoreCase)) > 0;
        }

        public ResumenFactura CalcularResumen(decimal porcentajeDescuento = 0m)
        {
            if (porcentajeDescuento < 0m) porcentajeDescuento = 0m;
            if (porcentajeDescuento > 1m) porcentajeDescuento = 1m;

            decimal subtotal = _lineas.Sum(l => l.Subtotal);
            decimal descuentos = Math.Round(subtotal * porcentajeDescuento, 2);
            decimal baseImponible = Math.Max(0m, subtotal - descuentos);
            decimal impuesto = Math.Round(baseImponible * TasaIvaPorDefecto, 2);
            return new ResumenFactura
            {
                Subtotal = subtotal,
                Descuentos = descuentos,
                Impuesto = impuesto,
                Total = baseImponible + impuesto
            };
        }

        public void SaveToFile(string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            var rows = _lineas.Select(l => string.Join("	",
                l.Codigo,
                l.Descripcion,
                l.Cantidad.ToString(CultureInfo.InvariantCulture),
                l.PrecioUnitario.ToString(CultureInfo.InvariantCulture)));
            File.WriteAllLines(path, rows, Encoding.UTF8);
        }

        public void LoadFromFile(string path)
        {
            _lineas.Clear();
            if (!File.Exists(path)) return;
            foreach (string line in File.ReadAllLines(path, Encoding.UTF8))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] parts = line.Split('	');
                int cant;
                decimal precio;
                if (parts.Length >= 4 &&
                    int.TryParse(parts[2], NumberStyles.Integer, CultureInfo.InvariantCulture, out cant) &&
                    decimal.TryParse(parts[3], NumberStyles.Any, CultureInfo.InvariantCulture, out precio))
                {
                    string ignored;
                    TryAdd(parts[0], parts[1], cant, precio, out ignored);
                }
            }
        }
    }

    public class Val_IngFacturacion
    {
        public const string PlaceholderCodigo = "Código a Facturar";

        public bool validacionIng(string codInv, string descrip)
        {
            string cod = (codInv ?? string.Empty).Trim();
            string desc = (descrip ?? string.Empty).Trim();

            return !string.IsNullOrEmpty(cod)
                && !string.Equals(cod, PlaceholderCodigo, StringComparison.OrdinalIgnoreCase)
                && !string.IsNullOrEmpty(desc);
        }
    }
}
