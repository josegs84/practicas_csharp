using System;
using System.Collections.Generic;
using System.Text;

namespace practicas_csharp.unidad25
{
    class ud25p1
    {
        // Problema 1: Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo. 
        // En el constructor cargar los atributos y luego en otro método imprimir sus datos y por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)
        private string nombre;
        private int sueldo;
        private bool impuestos;

        public ud25p1(string valNombre, int valSueldo)
        {
            nombre = valNombre;
            sueldo = valSueldo;
            impuestos = DebePagarImpuestos(sueldo);
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("Nombre: {0} - Sueldo: {1} - Impuestos: {2}", nombre, sueldo, impuestos ? "Si" : "No");
        }

        public bool DebePagarImpuestos(int sueldo)
        {
            return sueldo > 3000;
        }

    }
}
