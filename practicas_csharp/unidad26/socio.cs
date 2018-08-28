using System;
using System.Collections.Generic;
using System.Text;

namespace practicas_csharp.unidad26
{
    class socio
    {
        private string nombre;
        private int antiguedad;

        public socio()
        {
            bool correcto;
            nombre = preguntar("Introduzca nombre");
            do
            {
                correcto = int.TryParse(preguntar("Introduzca la antiguedad"), out antiguedad);
            } while (!correcto);
            Console.WriteLine("El socio {0} lleva {1} años en el club",nombre,antiguedad);
        }

        public string preguntar(string dato)
        {
            string salida;
            Console.WriteLine(dato);
            salida = Console.ReadLine();
            return salida;
        }

        public string dame_nombre()
        {
            return nombre;
        }

        public int dame_antiguedad()
        {
            return antiguedad;
        }
    }
}
