using System;
using System.Collections.Generic;
using System.Text;

namespace practicas_csharp.unidad13
{
    class ud13p1
    {
        private int edad;
        private string nombre;

        public void Inicializar()
        {
            bool repetir = true;
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("\n");
            do
            {
                Console.WriteLine("Ingrese su Edad: ");
                repetir = !int.TryParse(Console.ReadLine(), out edad);
                Console.WriteLine("\n");
            } while (repetir);
            
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: {0}",nombre);
            Console.WriteLine("Edad: {0}", edad);
            Console.WriteLine("\n");
        }

        public void MayorDeEdad()
        {
            if (edad >= 18)
                Console.WriteLine("Mayor de edad");
            else
                Console.WriteLine("No es mayor de edad");
        }
    }
}
