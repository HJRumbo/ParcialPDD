using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Instrumento
{
    public class Accesorio
    {
        // Aquí utilizo encapsulamiento
        private static Accesorio? objeto = null;

        private string? _nombre;

        public string? Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private Accesorio() { }

        private static Accesorio ObtenerInstancia(string nombre)
        {
            if (objeto == null)
            {
                objeto = new Accesorio();
                objeto.Nombre = nombre;
            }

            return objeto!;
        }

        public static Accesorio AñadirAccesorio(string nombre)
        {
            return ObtenerInstancia(nombre);
        }
    }
}
