using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszik_és_mezők
{
    public class Futtathato
    {
        public static Elohely elohely;
        static void KovLepes()
        {
            for (int i = 0; i < elohely.n-1; i++)
            {
               for (int j = 0; j < elohely.m-1; j++)
                {
                    elohely.Szule(i,j);
                    elohely.Hale(i,j);
                }
            }
        }
    }
}
