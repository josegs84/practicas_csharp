using System;
using System.Collections.Generic;
using System.Text;

namespace practicas_csharp.unidad25
{
    class ud25p2
    {
        private int valor1, valor2;

        public ud25p2(int anadir_valor1, int anadir_valor2)
        {
            valor1 = anadir_valor1;
            valor2 = anadir_valor2;
        }

        public void Sumar()
        {
            double dato = valor1 + valor2;
            string accion = "sumar";
            Imprimir(dato, accion);
        }
        public void Restar()
        {
            double dato = valor1 - valor2;
            string accion = "restar";
            Imprimir(dato, accion);
        }
        public void Multiplicar()
        {
            double dato = valor1 * valor2;
            string accion = "multiplicar";
            Imprimir(dato, accion);
        }
        public void Division()
        {
            double dato = valor1 / valor2;
            string accion = "dividir";
            Imprimir(dato, accion);
        }

        private void Imprimir(double dato, string accion)
        {
            Console.WriteLine("El resultado de {0} {1} y {2} es {3}.", accion, valor1, valor2, dato);
        }
    }
}
