using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszik_és_mezők
{
    public class Nyuszi
    {
        public int  x, y;
        public  bool nyusziE;

        public Nyuszi(int x, int y, bool nyusziE)
        {
          
            X = x;
            Y = y;
            Nyuszie= nyusziE;
        }

        public bool Nyuszie { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
