using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDT
{
    public class Creador

    {
        //public const int LIGA = 1;
        //public const int IDV = 2;
        //public const int BAR = 3;
        //public const int EME = 4;
        public static Equipos CreadorEquipos(int tipo)
        {
            

            switch (tipo)
            {
                case 1:
                    return new Liga();
                case 2:
                    return new IndependienteValle();
                case 3:
                    return new Barcelona();
                case 4:
                    return new Emelec();
                default: return null;
            }


        }
    }
}
