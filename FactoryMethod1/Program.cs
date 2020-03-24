using System;
using FactoryMethod;
using FactoryMethod1;

namespace FactoryMethod1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            BebidaEmbrigante oBebida = Creador.CreadorBebida(Creador.VINNO_TINTO);
            Console.WriteLine(oBebida.CuantoMeEmbriagaPorHora());
        }
    }
}
