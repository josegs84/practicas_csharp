using System;
using practicas_csharp.unidad26;

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
            // UNIDAD 26 - Colaboración de clases
            // Problema 2: Plantear un programa que permita jugar a los dados. 
            // Las reglas de juego son: se tiran tres dados si los tres salen con el mismo valor mostrar un mensaje que "gano", sino "perdió".
            juego_de_dados juego = new juego_de_dados();
            juego.comenzar();
            juego.resultado();
            Finalizar();
        }
    }
}
