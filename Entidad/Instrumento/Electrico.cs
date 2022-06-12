using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Instrumento
{
    // Aquí utilizo herencia
    public class Electrico : TipoDeInstrumento
    {
        public Electrico()
        {
            NombreTipo = "Eléctrico";
        }
    }
}
