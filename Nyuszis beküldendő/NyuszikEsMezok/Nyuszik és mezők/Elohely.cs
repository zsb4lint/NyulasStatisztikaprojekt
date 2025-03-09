using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszik_és_mezők
{
    public class Elohely : IElvagyHal
    {
        /// <summary>
        /// N: sor, M: oszlop, mat: Mátrix, ami nyuszi objektummal van feltöltve
        /// </summary>
        public int n, m;
        public Nyuszi[,] mat;

        /// <summary>
        /// Konstruktor ami belehelyezi a mátrixba a nyuszikat
        /// </summary>
        /// <param name="a">sor</param>
        /// <param name="b">oszlop</param>
        public Elohely(int a, int b)
        {
            this.n = a;
            this.m = b;
            mat = new Nyuszi[a + 2, b + 2];
        }
        /// <summary>
        /// Megnézi hogy van-e elég szomszéd egy halálhoz 
        /// </summary>
        public void MeghalE(Elohely elohely)
        {
            int szomszed = 0;
            for (int i = 1; i < elohely.mat.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < elohely.mat.GetLength(1) - 1; j++)
                {
                    szomszed = 0;
                    if (elohely.mat[i, j].nyusziE == true)
                    {
                        if (elohely.mat[i + 1, j].nyusziE == true)
                        {
                            szomszed++;
                        }
                        if (elohely.mat[i - 1, j].nyusziE == true)
                        {
                            szomszed++;
                        }
                        if (elohely.mat[i, j + 1].nyusziE == true)
                        {
                            szomszed++;
                        }
                        if (elohely.mat[i, j - 1].nyusziE == true)
                        {
                            szomszed++;
                        }
                        if (szomszed > 3 || szomszed <= 2)
                        {
                            elohely.mat[i, j].meghalE = true;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Megnézi hogy van-e elég szomszéd egy új születéshez
        /// </summary>
        public void SzuletikE(Elohely elohely)
        {
            int szomszed = 0;
            for (int i = 1; i < elohely.mat.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < elohely.mat.GetLength(1) - 1; j++)
                {
                    szomszed = 0;
                    if (elohely.mat[i, j].nyusziE == false)
                    {
                        if (elohely.mat[i + 1, j].nyusziE == true)
                        {
                            szomszed++;
                        }
                        if (elohely.mat[i - 1, j].nyusziE == true)
                        {
                            szomszed++;
                        }
                        if (elohely.mat[i, j + 1].nyusziE == true)
                        {
                            szomszed++;
                        }
                        if (elohely.mat[i, j - 1].nyusziE == true)
                        {
                            szomszed++;
                        }
                        if (szomszed == 3)
                        {
                            elohely.mat[i, j].szuletikE = true;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Megnézi a széleken lévő nyulak szomszédjait, a másik oldalt is bele értve
        /// </summary>
        public static void UpdateEloh(Elohely elohely)
        {
            for (int i = 0; i < elohely.mat.GetLength(0); i++)
            {
                elohely.mat[i, 0] = elohely.mat[i, elohely.mat.GetLength(1) - 2];
                elohely.mat[i, elohely.mat.GetLength(1) - 1] = elohely.mat[i, 1];
            }
            for (int i = 0; i < elohely.mat.GetLength(1); i++)
            {
                elohely.mat[0, i] = elohely.mat[elohely.mat.GetLength(0) - 2, i];
                elohely.mat[elohely.mat.GetLength(0) - 1, i] = elohely.mat[1, i];
            }
        }
        /*
        public void UpMatrix()
        {
            for (int i = 1; i < mat.GetLength(0) - 1; i++)
            {
                mat[i, 0] = mat[i, mat.GetLength(1) - 1];
                mat[i, mat.GetLength(1)] = mat[i, 1];
            }

            for (int j = 1; j < mat.GetLength(1) - 1; j++)
            {
                mat[0, j] = mat[mat.GetLength(0) - 1, j];
                mat[mat.GetLength(0), j] = mat[1, j];
            }
            // Sarkok
            mat[0, 0] = new Nyuszi(0, 0, false);
            mat[0, mat.GetLength(0)] = new Nyuszi(0, 0, false);
            mat[mat.GetLength(1), 0] = new Nyuszi(0, 0, false);
            mat[mat.GetLength(0), mat.GetLength(1)] = new Nyuszi(0, 0, false);
        }
        public void Szule(int i, int j)
        {
            UpMatrix();
            int szomszed = 0;
            if (mat[i, j].nyusziE == false)
            {

                if (mat[i - 1, j].nyusziE == true)
                {
                    szomszed++;
                }
                if (mat[i, j - 1].nyusziE == true)
                {
                    szomszed++;
                }
                if (mat[i + 1, j].nyusziE == true)
                {
                    szomszed++;
                }
                if (mat[i, j + 1].nyusziE == true)
                {
                    szomszed++;
                }
            }

            if (szomszed == 3)
            {
                mat[i, j].szuletikE = true;
            }
        }
        public void Hale(int i, int j)
        {
            UpMatrix();
            int szomszed = 0;
            if (mat[i, j].nyusziE == true)
            {

                if (mat[i - 1, j].nyusziE == true)
                {
                    szomszed++;
                }
                if (mat[i, j - 1].nyusziE == true)
                {
                    szomszed++;
                }
                if (mat[i + 1, j].nyusziE == true)
                {
                    szomszed++;
                }
                if (mat[i, j + 1].nyusziE == true)
                {
                    szomszed++;
                }

                if (szomszed > 3 || szomszed < 2)
                {
                    mat[i, j].meghalE = true;
                }
            }
        }
        */
    }
}
