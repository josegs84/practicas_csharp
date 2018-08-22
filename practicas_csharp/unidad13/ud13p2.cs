using System;
using System.Collections.Generic;
using System.Text;

namespace practicas_csharp.unidad13
{
    class ud13p2
    {
        private const int kLados = 3;
        private int[] lado = new int[kLados];

        public void Iniciar()
        {
            for(int i = 0; i < kLados; i++)
            {
                int posicion = i + 1;
                bool correcto = true;
                do
                {
                    Console.WriteLine("Introduzca el lado {0}: ", posicion);
                    correcto = int.TryParse(Console.ReadLine(), out lado[i]);
                } while (!correcto);
            }
        }

        public void LadoMayor()
        {
            int ladomayor = lado[0] > lado[1] ? (lado[0] > lado[2] ? lado[0] : lado[2]) : (lado[1] > lado[2] ? lado[1] : lado[2]);
            Console.WriteLine("El lado mayor es {0}", ladomayor);
        }

        public void EsEquilatero()
        {
            string afirmacion = lado[0] == lado[1] || lado[0] == lado[2] || lado[1] == lado[2] ? "es" : "no es";
            Console.WriteLine("El triángulo {0} isosceles", afirmacion);
        }
    }
}
