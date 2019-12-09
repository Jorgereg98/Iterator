using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ListaNumeros
    {
        private int[] numeros;
        private int posicion;

        public ListaNumeros()
        {
            numeros = new int[10];
            posicion = 0;
        }

        public void agregar(int num) 
        {
            numeros[posicion++] = num;
        }

        public ListaNumerosIterador iterador()
        {
            return new ListaNumerosIterador(numeros);
        }
    }
}
