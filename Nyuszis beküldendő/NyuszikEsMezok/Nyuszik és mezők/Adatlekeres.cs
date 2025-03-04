using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nyuszik_és_mezők
{
    public class Adatlekeres
    {
        public static Elohely General(int n, int m, int chance)
        {
            Random r = new Random();
            int szam = 0;
            Elohely elohely = new Elohely(n, m);

            for (int i = 0; i < elohely.mat.GetLength(0) ; i++)
            {
                for (int j = 0; j < elohely.mat.GetLength(1); j++)
                {
                    szam = r.Next(1,101);
                    if (szam <= chance)
                    {
                        elohely.mat[i, j] = new Nyuszi(i, j, true);
                    }
                    else
                    {
                        elohely.mat[i, j] = new Nyuszi(i, j, false);
                    }
                }
            }
            return elohely;
        }
        static Elohely Fajlbe(string path)
        {
            int[] nm = SorOszlopSzamol(path);
            int n = nm[0];
            int m = nm[1];

            Elohely elohely = new Elohely(n,m);
            StreamReader f = new StreamReader(path);
            for (int i = 0; i < elohely.mat.GetLength(0)-1; i++)
            {
                string[] sv = f.ReadLine().Split();
                for (int j = 0; j < elohely.mat.GetLength(1)-1; j++)
                {
                    elohely.mat[i, j].x = i+1;
                    elohely.mat[i, j].y = j+1;
                    elohely.mat[i, j].nyusziE = Convert.ToBoolean(sv[j]);
                }
            }
            f.Close();
            return elohely;
        }
        static int[] SorOszlopSzamol(string path)
        {
            int[] nm = new int[2];
            int n = 0;
            int m = 0;
            StreamReader f = new StreamReader(path);
            while (!f.EndOfStream)
            {
                m = f.ReadLine().Split().Length;
                n++;
            }
            nm[0] = n;
            nm[1] = m;
            f.Close();
            return nm;
        }
    }
}
