using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Instrumento
{
    public class FabricaInstrumento
    {
        public Instrumento ObtenerAleatorio()
        {
            Random rInstrumento = new Random();
            Random rTipo = new Random();

            int numeroInstrumento = rInstrumento.Next(1, 4);
            int numeroTipo = rTipo.Next(1, 3);

            var objeto = ObtenerInstrumento(numeroInstrumento, numeroTipo);

            return objeto;

        }

        #region Aquí utilizo polimorfismo paramétrico
        public Instrumento ObtenerInstrumento(int numeroInstrumento, int numeroTipo)
        {
            var objeto = InstanciarObjeto(numeroInstrumento);
            objeto.tipoDeInstrumento = ObtenerTipo(numeroTipo);

            return objeto;
        }
        public Instrumento ObtenerInstrumento(int numeroInstrumento, int numeroTipo, string nombreAccesorio)
        {
            var objeto = InstanciarObjeto(numeroInstrumento);
            objeto.accesorio = Accesorio.AñadirAccesorio(nombreAccesorio);
            objeto.tipoDeInstrumento = ObtenerTipo(numeroTipo);

            return objeto;
        }
        #endregion Fin del polimorfismo paramétrico

        private Instrumento InstanciarObjeto(int numeroInstrumento)
        {
            if (numeroInstrumento == 1)
            {
                return new Guitarra();
            }
            else if (numeroInstrumento == 2)
            {
                return new Bajo();
            }
            else
            {
                return new Piano();
            }
        }

        public TipoDeInstrumento ObtenerTipo(int numeroTipo)
        {
            if (numeroTipo == 1)
            {
                return new Electrico();
            }
            else 
            {
                return new NoElectrico();
            }
        }

    }
}
