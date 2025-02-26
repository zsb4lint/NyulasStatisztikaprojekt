using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2025_02_21
{
    internal class nyulak
    {
        public int x, y, eletkor;

        public nyulak(int x, int y, int eletkor)
        {
            this.x = x;
            this.y = y;
            this.eletkor = eletkor;
        }
        public void FajlBeolvasas(string path)
        {
            StreamReader f = new StreamReader(path);
            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(' ');
                nyulak sv = new nyulak(Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), Convert.ToInt32(st[2]));
            }
            f.Close();
        }
    }
}
