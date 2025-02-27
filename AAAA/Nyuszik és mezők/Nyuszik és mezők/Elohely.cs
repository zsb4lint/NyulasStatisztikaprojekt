using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszik_és_mezők
{
    internal class Elohely:  Nyuszi,ElvagyHal
    {
        public int a, b;
        public Nyuszi[,] mat;

        public Elohely(int a, int b):base (0,0,false)
        {
            this.a = a;
            this.b = b;
            mat = new Nyuszi[a+2,b+2];
        }
        
        public void UpMatrix()
        {
            for (int i = 1; i < mat.GetLength(0)-1; i++)
            {
                mat[i, 0] = mat[i, mat.GetLength(1) - 1];
                mat[i, mat.GetLength(1)] = mat[i, 1];
            }

            for (int j = 1; j < mat.GetLength(1) - 1; j++)
            {
                mat[j, 0] = mat[j, mat.GetLength(0) - 1];
                mat[j, mat.GetLength(0)] = mat[j, 1];
            }
            // Sarkok
            mat[0, 0].nyusziE = false;
            mat[0, mat.GetLength(0)].nyusziE = false;
            mat[mat.GetLength(1),0].nyusziE = false;
            mat[mat.GetLength(0), mat.GetLength(1)].nyusziE = false;
        }
        public void ElE()
        {
            UpMatrix();
            int db = 0;
            for (int i = x-1; i < x+2; i++)
            {
                for (int j = y - 1 ; j < y+2; j++)
                {
                    if (mat[i,j].nyusziE == true && i != x && j != y && (i == x || j == y))
                    {
                        db++;
                    }
                }
            }

            if((db <2 || db > 3) && nyusziE == true && (kor >1 && kor <=6))
            {
                nyusziE = false;
            }
            else
            {
                kor++;
            }

            if (db == 3 && nyusziE == false && (kor > 6))
            {
                nyusziE=true;
            }
        }

    }
}
