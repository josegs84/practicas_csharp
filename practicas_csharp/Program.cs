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

            // Problema 1
            // Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro)
            /*
            Console.WriteLine("Introduce el valor del lado de un cuadrado: \n");
            int lado_cuadrado = int.Parse(Console.ReadLine());
            int perimetro = lado_cuadrado * 4;
            Console.WriteLine("El perímetro es " + perimetro + ".");
            Finalizar();
            */

            // Problema 2
            // Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.
            /*
            const int kNum = 4;
            int[] numeros = new int[kNum];
            Console.WriteLine("Introduzca 4 números:\n");
            for(int i = 0; i < numeros.Length; i++)
            {
                int id_numero = i + 1;
                Console.WriteLine("Número " + id_numero.ToString() + "\n");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La suma del primer número (" + numeros[0] + ") y el segundo número (" + numeros[1] + ") es igual a " + (numeros[0]+numeros[1]) +".\n");
            Console.WriteLine("El producto del tercer número (" + numeros[2] + ") y el cuarto número (" + numeros[3] + ") es igual a " + (numeros[2]*numeros[3]) +".\n");
            Finalizar();
            */

            // Problema 3
            // Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.
            const int kNum = 4;
            int suma = 0, i = 0;
            Console.WriteLine("Introduzca 4 números:\n");
            for (i = 0; i < kNum; i++)
            {
                int id_numero = i + 1;
                Console.WriteLine("Número " + id_numero.ToString() + "\n");
                suma += int.Parse(Console.ReadLine());
            }
            double promedio = suma / kNum;
            Console.WriteLine("La suma de todos los números es " + suma + ".\n El promedio es " + promedio + ".");
            Finalizar();
        }
    }
}
