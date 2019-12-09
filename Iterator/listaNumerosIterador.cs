using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ListaNumerosIterador : Iterator
    {
        private int[] numeros;
        private int posicion;

        public ListaNumerosIterador(int[] num)
        {
            this.numeros = num;
            this.posicion = 0;
        }

        public Object siguiente()
        {
            return numeros[posicion++];
        }

        public bool tieneSiguiente()
        {
            if(posicion < numeros.Length && numeros[posicion] != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
