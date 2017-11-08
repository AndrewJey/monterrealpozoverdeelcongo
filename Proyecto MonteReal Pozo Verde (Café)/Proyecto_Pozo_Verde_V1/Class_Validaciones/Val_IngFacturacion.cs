using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pozo_Verde_V1.Class_Validaciones
{
    class Val_IngFacturacion
    {
        /// <summary>
        /// Método que permite validar si los datos ingresados son vacios o no.
        /// </summary>
        /// <param Código de inventario="codInv"></param>
        /// <param Descripción="descrip"></param>
        /// <returns></returns>
        public bool validacionIng(String codInv, String descrip)
        {
            if (!codInv.Equals("") && !codInv.Equals("Código a Facturar") && !descrip.Equals(""))
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
