using System;
using System.Collections.Generic;
using System.Text;

namespace practicas_csharp.unidad14
{
    class ud14p1
    {
        private int valor;

        public void Inicializar()
        {
            bool correcto = false;
            do
            {
                Console.WriteLine("Introduzca un número: ");
                correcto = int.TryParse(Console.ReadLine(), out valor);

                if (correcto && valor > 0)
                    Calcular(valor);
                else
                    correcto = false;

            } while (correcto);
        }

        public void Calcular(int dato)
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", dato, i, dato * i);
            }
        }
    }
}
