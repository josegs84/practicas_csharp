using System;

namespace practicas_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Finalizar() // Función que finaliza el programa. Se usa siempre al final y establece el mensaje de aviso.
            {
                Console.WriteLine("\nPulsa cualquier tecla para finalizar");
                Console.ReadKey();
            }

            // Sacado de https://www.tutorialesprogramacionya.com/csharpya/

            // UNIDAD 6
            // Problema 1: 
            // Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia, en caso contrario informar el producto y la división del primero respecto al segundo.
            /*            
            const int kNum = 2;
            int accion1, accion2;
            int[] numeros = new int[kNum];
            for (int i = 0; i < kNum; i++)
            {
                int posicion_actual = i + 1;
                Console.WriteLine("\nIntroduce el número "+ posicion_actual + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            if (numeros[0] > numeros[1])
            {
                accion1 = numeros[0] + numeros[1];
                accion2 = numeros[0] - numeros[1];
            } else
            {
                accion1 = numeros[0] * numeros[1];
                accion2 = numeros[0] / numeros[1]; // Quiza debiera ser el mayor dividido entre el menor, pero como pone el primero...
            }
            Console.WriteLine("\nEfecto 1: " + accion1 + " -- Efecto 2: " + accion2 + ".");
            Finalizar();
            */
            // Problema 2:
            //  Se ingresan tres notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado". 
            /*
            const int kNotas = 3;
            int[] notas = new int[kNotas];
            int suma = 0;
            for(int i = 0; i < kNotas; i++)
            {
                int numero = i + 1;
                Console.WriteLine("\nIntroduce la nota "+numero+".");
                notas[i] = int.Parse(Console.ReadLine());
                suma += notas[i];
            }
            string promocion = (suma / kNotas) >= 7 ? "promocionado" : "no promocionado";
            Console.WriteLine("\nLas notas del alumno son " + notas[0] + ", " + notas[1] + " y "+notas[2]+".");
            Console.WriteLine("Alumno " + promocion + ".");
            Finalizar();
            */
            // Problema 3:
            // Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el número tiene uno o dos dígitos.
            // (Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)
            bool correcto = false;
            int numero, numero_de_digitos;
            while (!correcto)
            {
                Console.WriteLine("Introduzca un número positivo de uno o dos dígitos (del 0 al 99): \n");
                correcto = int.TryParse(Console.ReadLine(), out numero);
                numero_de_digitos = (numero.ToString()).Length;
                if (correcto && numero_de_digitos <= 2)
                {
                    Console.WriteLine("El número " + numero + " tiene " + numero_de_digitos + " dígitos.");
                } else
                {
                    correcto = false;
                    Console.WriteLine("Número no válido");
                }
            }
            Finalizar();
        }
    }
}
