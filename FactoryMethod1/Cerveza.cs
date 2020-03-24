using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Cerveza : BebidaEmbrigante
    {
        public override int CuantoMeEmbriagaPorHora()
        {
            return 5;
        }
    }
}
