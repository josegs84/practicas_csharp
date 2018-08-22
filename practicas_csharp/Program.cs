using System;
using practicas_csharp.unidad13;

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
            // UNIDAD 13
            // Declaración de una clase y definición de objetos.
            // Problema 1
            // Confeccionar una clase que permita carga el nombre y la edad de una persona. Mostrar los datos cargados. Imprimir un mensaje si es mayor de edad (edad>=18)
            /*
            ud13p1 persona = new ud13p1();
            persona.Inicializar();
            persona.Imprimir();
            persona.MayorDeEdad();
            Finalizar();
            */
            // Problema 2
            // Desarrollar un programa que cargue los lados de un triángulo e implemente los siguientes métodos: 
            // inicializar los atributos, imprimir el valor del lado mayor y otro método que muestre si es equilátero o no.

        }
    }
}
