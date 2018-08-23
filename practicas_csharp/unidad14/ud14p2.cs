using System;
using System.Collections.Generic;
using System.Text;

namespace practicas_csharp.unidad14
{
    class ud14p2
    {
        private const int kNumero = 3;
        int[] numeros = new int[kNumero];
        public void Iniciar()
        {
            for(int i=0; i < kNumero; i++)
            {
                int posicion = i + 1;
                Console.WriteLine("Introduzca el número {0}:", posicion);
                Grabar(i);
            }
        }

        public void Grabar(int pos)
        {
            bool valido = false;
            do
            {
                valido = Validacion(pos);
                if (!valido)
                    Console.WriteLine("Valor introducido erróneo. Introduzca de nuevo por favor.");
            } while (!valido);
            
        }

        public bool Validacion(int pos)
        {
            return int.TryParse(Console.ReadLine(), out numeros[pos]);
        }

        public int Dato(string tipo)
        {
            int salida = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                if ((tipo == "mayor" && numeros[i] > salida) || (tipo == "menor" && numeros[i] < salida) || i == 0)
                    salida = numeros[i];
            }
            return salida;
        }

        public void MostrarMayorYMenor()
        {
            Console.WriteLine("El número mayor es {0}, el número menor es {1}.",Dato("mayor"),Dato("menor"));
        }
    }
}
