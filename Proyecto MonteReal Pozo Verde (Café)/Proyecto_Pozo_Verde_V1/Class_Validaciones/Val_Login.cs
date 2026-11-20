using System;

namespace Proyecto_Pozo_Verde_V1.Class_Validaciones
{
    public class Val_Login
    {
        public const string PlaceholderUsuario = "Nombre de Usuario";
        public const string PlaceholderPass = "Contraseña";

        public bool validacion(string usser, string pass)
        {
            string u = (usser ?? string.Empty).Trim();
            string p = (pass ?? string.Empty).Trim();

            return !string.IsNullOrEmpty(u)
                && !string.IsNullOrEmpty(p)
                && !string.Equals(u, PlaceholderUsuario, StringComparison.OrdinalIgnoreCase)
                && !string.Equals(p, PlaceholderPass, StringComparison.OrdinalIgnoreCase);
        }
    }
}
