using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pozo_Verde_V1.Class_Validaciones
{
    class Val_Login
    {
        /// <summary>
        /// Método que permite validar si los datos ingresados son vacios o no.
        /// </summary>
        /// <param Usuario="usser"></param>
        /// <param Contraseña="pass"></param>
        /// <returns></returns>
        public bool validacion(String usser, String pass)
        {
            if (!usser.Equals("") && !pass.Equals("") && !usser.Equals("Nombre de Usuario") && !pass.Equals("Contraseña"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
