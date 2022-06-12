using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Instrumento
{
    public class Guitarra : Instrumento
    {
        public Guitarra()
        {
            Nombre = "Guitarra";
        }

        #region Aquí utilizo los métodos abstractos de la clase padre (Polimorfismo)
        public override string Afinar()
        {
            return "Guitarra afinado";
        }

        public override string Interpretar()
        {
            return "Guitarra interpretado";
        }
        #endregion Fin de polimorfismo
    }
}
