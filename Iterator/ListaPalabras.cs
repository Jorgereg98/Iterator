using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ListaPalabras
    {
        private String pal1;
        private String pal2;
        private String pal3;

        private int posicion;

        public ListaPalabras()
        {
            posicion = 0;
        }

        public void agregar(String palabra)
        {
            switch (posicion)
            {
                case 0:
                    pal1 = palabra;
                    break;
                case 1:
                    pal2 = palabra;
                    break;
                case 2:
                    pal3 = palabra;
                    break;
            }
            posicion++;
        }

        public ListaPalabrasIterador iterador()
        {
            return new ListaPalabrasIterador(pal1, pal2, pal3);
        }
    }
}
