using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Instrumento
{
    public class TipoDeInstrumento
    {
        // Aquí aplico encapsulamiento
        private string? _nombreTipo;

        public string? NombreTipo
        {
            get { return _nombreTipo; }
            set { _nombreTipo = value; }
        }

    }
}
