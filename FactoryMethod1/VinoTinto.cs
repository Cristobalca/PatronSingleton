﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class VinoTinto : BebidaEmbrigante
    {
        public override int CuantoMeEmbriagaPorHora()
        {
            return 20;
        }
    }
}
