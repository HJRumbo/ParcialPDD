using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Instrumento
{
    // Aquí utilizo herencia
    public class Bajo : Instrumento
    {
        public Bajo()
        {
            Nombre = "Bajo";
        }

        #region Aquí utilizo los métodos abstractos de la clase padre (Polimorfismo)
        public override string Afinar()
        {
            return "Bajo afinado";
        }

        public override string Interpretar()
        {
            return "Bajo interpretado";
        }
        #endregion Fin de polimorfismo

    }
}
