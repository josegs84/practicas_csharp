using System;
using practicas_csharp.unidad14;

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
            // UNIDAD 14
            // Declaración de métodos.
            // Ejemplo 1: Confeccionar una clase que permita ingresar valores enteros por teclado y nos muestre la tabla de multiplicar de dicho valor. Finalizar el programa al ingresar el -1.
            /*
            ud14p1 calculo = new ud14p1();
            calculo.Inicializar();
            Finalizar();
            */
            // Ejemplo 2: Confeccionar una clase que permita ingresar tres valores por teclado. Luego mostrar el mayor y el menor.
            /*
            ud14p2 numeros = new ud14p2();
            numeros.Iniciar();
            numeros.MostrarMayorYMenor();
            Finalizar();
            */
        }
    }
}
