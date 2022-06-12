using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Instrumento
{
    // Aquí aplico herencia
    public class NoElectrico : TipoDeInstrumento
    {
        public NoElectrico()
        {
            NombreTipo = "No eléctrico";
        }
    }
}
