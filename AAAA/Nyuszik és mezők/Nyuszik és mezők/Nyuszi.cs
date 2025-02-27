using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszik_és_mezők
{
    internal class Nyuszi
    {
        public int kor, x, y;
        public bool nyusziE;

        public Nyuszi(int x, int y, bool nyusziE)
        {
            kor = 0;   
            this.x = x;
            this.y = y;
            this.nyusziE = nyusziE;
        }

        
    }
}
