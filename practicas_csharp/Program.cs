using System;
using practicas_csharp.unidad25;

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
            // UNIDAD 25 - Constructor de la clase
            // Problema 1: Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo. 
            // En el constructor cargar los atributos y luego en otro método imprimir sus datos y por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)
            /*
            ud25p1 hombre = new ud25p1("Jose", 3500);
            hombre.ImprimirDatos();
            Finalizar();
            */
            // Problema 2: Implementar la clase operaciones. Se deben cargar dos valores enteros en el constructor, calcular su suma, resta, multiplicación y división, 
            // cada una en un método, imprimir dichos resultados.
            ud25p2 calculadora = new ud25p2(5, 5);
            calculadora.Multiplicar();
            calculadora.Sumar();
            calculadora.Division();
            calculadora.Restar();
            Finalizar();
        }
    }
}
