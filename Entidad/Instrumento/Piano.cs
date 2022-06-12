using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Instrumento
{
    // Aquí aplico herencia
    public class Piano : Instrumento
    {
        public Piano()
        {
            Nombre = "Piano";
        }

        #region Aquí utilizo los métodos abstractos de la clase padre (Polimorfismo)
        public override string Afinar()
        {
            return "Piano afinado";
        }

        public override string Interpretar()
        {
            return "Piano interpretado";
        }
        #endregion Fin de polimorfismo

    }
}
