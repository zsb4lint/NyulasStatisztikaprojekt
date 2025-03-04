﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszik_és_mezők
{
    public class Elohely: ElvagyHal
    {
        public int n, m;
        public Nyuszi[,] mat;

        public Elohely(int a, int b)
        {

            this.n = a;
            this.m = b;
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
        public void Szule(int i, int j)
        {
            UpMatrix();
            int szomszed = 0;
            if (mat[i,j].Nyuszie == false)
            {

                if (mat[i-1,j].Nyuszie == true)
                {
                    szomszed++;
                }
                if(mat[i , j-1].Nyuszie == true)
                {
                    szomszed++;
                }
                if(mat[i +1 , j].Nyuszie == true)
                {
                    szomszed++;
                }
                if(mat[i, j+1].Nyuszie == true)
                {
                    szomszed++;
                }
            }
            
            if(szomszed == 3)
            {
                mat[i, j] = new Nyuszi(i,j,true);
            }
        }

        public void Hale(int i, int j)
        {
            UpMatrix();
            int szomszed = 0;
            if(mat[i,j].Nyuszie == true)
            {

                if (mat[i - 1, j].Nyuszie == true)
                {
                    szomszed++;
                }
                if (mat[i, j - 1].Nyuszie == true)
                {
                    szomszed++;
                }
                if (mat[i + 1, j].Nyuszie == true)
                {
                    szomszed++;
                }
                if (mat[i, j + 1].Nyuszie == true)
                {
                    szomszed++;
                }

                if (szomszed > 3 ||szomszed<2)
                {
                    mat[i, j] = new Nyuszi(i, j, false);
                }
            }
        }

    }
}
