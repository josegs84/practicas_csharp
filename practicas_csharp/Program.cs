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
            Console.WriteLine("Introduce el valor del lado de un cuadrado: \n");
            int lado_cuadrado = int.Parse(Console.ReadLine());
            int perimetro = lado_cuadrado * 4;
            Console.WriteLine("El perímetro es " + perimetro + ".");
            Finalizar();
        }
    }
}
