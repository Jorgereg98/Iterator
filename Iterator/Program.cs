using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        public static void Main(string[] args)
        {
            ListaNumeros numeros = new ListaNumeros();
            ListaPalabras palabras = new ListaPalabras();
            Iterator iterador;

            numeros.agregar(1);
            numeros.agregar(2);
            numeros.agregar(3);
            numeros.agregar(4);

            palabras.agregar("Uno");
            palabras.agregar("Dos");
            palabras.agregar("Tres");
            palabras.agregar("Cuatro");

            iterador = numeros.iterador();
            while (iterador.tieneSiguiente())
            {
                int numero = (int)iterador.siguiente();
                Console.WriteLine(numero);
            }

            iterador = palabras.iterador();
            while (iterador.tieneSiguiente())
            {
                String numero = (String)iterador.siguiente();
                Console.WriteLine(numero);
            }

            Console.ReadLine();

        }
    }
}
