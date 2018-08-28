using System;
using System.Collections.Generic;
using System.Text;

namespace practicas_csharp.unidad26
{
    class juego_de_dados
    {
        private int numero, cant_tiradas;
        private string texto;
        private bool seguir;
        
        public juego_de_dados()
        {
            cant_tiradas = 0;
            numero = 0;
            seguir = true;
        }

        public void comenzar()
        {
            do
            {
                dados dado = new dados();
                dado.tirar();
                if (cant_tiradas == 0)
                    numero = dado.valor();
                else
                    seguir = numero == dado.valor();
                cant_tiradas++;
            } while (seguir && cant_tiradas < 3);
        }

        public void resultado()
        {
            texto = seguir ? "Bien!" : "Fallo!";
            Console.WriteLine("{0} has tirado el dado {1} veces!", texto, cant_tiradas);
        }
    }
}
