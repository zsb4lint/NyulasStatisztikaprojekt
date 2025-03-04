using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszik_és_mezők
{
    public class Nyuszi
    {
        public int  x, y,kor;
        public bool nyusziE;
        public bool szuletikE;
        public bool meghalE;

        public Nyuszi(int x, int y, bool nyusziE, bool szuletikE = false, bool meghalE = false, int kor = 0)
        {
            this.x = x;
            this.y = y;
            this.nyusziE = nyusziE;
        }
    }
}
