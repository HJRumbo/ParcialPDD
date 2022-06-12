using Entidad.Instrumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Servicio
{
    public abstract class Servicio
    {
        // Aquí aplico encapsulamiento
        private string? _nombre;

        public string? Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Instrumento.Instrumento? instrumento { get; set; }

    }
}
