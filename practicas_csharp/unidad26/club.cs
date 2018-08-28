using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace practicas_csharp.unidad26
{
    class club
    {
        private int numero_alto;
        private string socio_mas_antiguo;
        private ArrayList socios = new ArrayList();

        public club(int cantidad)
        {


            for (int i = 0; i < cantidad; i++)
            {
                socios.Add(new socio());
            }
        }

        public void dime_socios()
        {
            numero_alto = 0;
            socio_mas_antiguo = "";

            foreach (socio dato in socios)
            {
                string nombre_este = dato.dame_nombre();
                int numero_este = dato.dame_antiguedad();

                Console.WriteLine("Socio: {0} - Antigüedad: {1}", nombre_este, numero_este);

                establece_socio_mas_antiguo(numero_este, nombre_este);

            }

            dime_socio_mas_antiguo();
        }

        public void establece_socio_mas_antiguo(int numero_este, string nombre_nuevo)
        {
            if (numero_este > numero_alto)
            {
                socio_mas_antiguo = nombre_nuevo;
                numero_alto = numero_este;
            }
        }

        public void dime_socio_mas_antiguo()
        {
            Console.WriteLine("El socio {0} es el socio mas antiguo", socio_mas_antiguo);
        }
    }
}
