using Entidad.Instrumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Servicio
{
    // Aquí aplico herencia
    public class OrdenDeCompra : Servicio
    {
        public OrdenDeCompra()
        {
            Nombre = "Orden de compra";
        }
    }
}
