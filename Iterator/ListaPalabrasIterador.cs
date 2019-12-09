using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ListaPalabrasIterador : Iterator
    {
        private String pal1;
        private String pal2;
        private String pal3;

        private int posicion;

        public ListaPalabrasIterador(String pal1, String pal2, String pal3)
        {
            this.pal1 = pal1;
            this.pal2 = pal2;
            this.pal3 = pal3;
            this.posicion = 0;
        }

        public object siguiente()
        {
            switch (posicion++)
            {
                case 0:
                    return pal1;
                case 1:
                    return pal2;
                case 2:
                    return pal3;
            }
            return null;
        }

        public bool tieneSiguiente()
        {
            if(posicion < 3)
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
