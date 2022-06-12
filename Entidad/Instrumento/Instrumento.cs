using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Instrumento
{
    public abstract class Instrumento
    {
        // Aquí aplico encapsulamiento
        private string? _nombre;

        public string? Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        private Accesorio? _accesorio;

        public Accesorio? accesorio
        {
            get { return _accesorio; }
            set { _accesorio = value; }
        }

        private TipoDeInstrumento? _tipoDeInstrumento;

        public TipoDeInstrumento? tipoDeInstrumento
        {
            get { return _tipoDeInstrumento; }
            set { _tipoDeInstrumento = value; }
        }


        // Aquí aplico polimorfismo de inculsión 
        public abstract string Afinar();
        public abstract string Interpretar();
    }
}
