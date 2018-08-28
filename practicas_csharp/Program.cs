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
            /*
            juego_de_dados juego = new juego_de_dados();
            juego.comenzar();
            juego.resultado();
            Finalizar();
            */
            // Ejercicio propuesto: Plantear una clase Club y otra clase Socio.
            // La clase Socio debe tener los siguientes atributos privados: nombre y la antigüedad en el club(en años).
            // En el constructor pedir la carga del nombre y su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase Socio.
            // Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.
            /*
            const int kSocios = 3;
            club megatrix = new club(kSocios);
            megatrix.dime_socios();
            Finalizar();
            */
        }
    }
}
