using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Creador

    {
        public const int VINNO_TINTO = 1;
        public const int CERVEZA = 2;

        public static BebidaEmbrigante CreadorBebida(int Tipo)
        {
            switch (Tipo)
            {
                case VINNO_TINTO:
                    return new VinoTinto();
                case CERVEZA:
                    return new Cerveza();
                default: return null;

            }
        }
    }
}
