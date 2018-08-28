using System;
using System.Collections.Generic;
using System.Text;

namespace practicas_csharp.unidad26
{
    class dados
    {
        private int numero;
        private static Random aleatorio;

        public dados()
        {
            aleatorio = new Random();
        }
        public void tirar()
        {
            numero = aleatorio.Next(1, 7);
        }

        public void imprimir()
        {
            Console.WriteLine("El valor del dado es {0}", numero);
        }

        public int valor()
        {
            return numero;
        }
    }
}
