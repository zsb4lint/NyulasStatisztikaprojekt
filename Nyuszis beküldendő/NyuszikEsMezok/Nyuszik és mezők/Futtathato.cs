using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszik_és_mezők
{
    public class Futtathato
    {
        /// <summary>
        /// A születés, halás alapján rakja, vagy nem rakja bele a nyulakat a mátrixba, valamint növeli a kort ha megfelelnek a feltételek
        /// </summary>
        /// <param name="sor">bekért sor</param>
        /// <param name="oszlop">bekért oszlop</param>
        /// <returns></returns>
        public static void UpdateSzulHal(Elohely elohely)
        {
            for (int i = 1; i < elohely.mat.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < elohely.mat.GetLength(1) - 1; j++)
                {
                    if (elohely.mat[i, j].szuletikE == true)
                    {
                        elohely.mat[i, j] = new Nyuszi(i, j, true);
                    }
                    if (elohely.mat[i, j].meghalE == true)
                    {
                        elohely.mat[i, j] = new Nyuszi(i, j, false);
                    }
                }
            }
        }

        /*
        static public Elohely KovLepes(int sor, int oszlop, Elohely elohely)
        {
            for (int i = 1; i < elohely.mat.GetLength(0)-1; i++)
            {
                for (int j = 1; j < elohely.mat.GetLength(1)-1; j++)
                {
                    elohely.Szule(i, j);
                    elohely.Hale(i, j);
                }
            }
            return elohely;
        }
        */

        /*
        static public Elohely Update(int sor, int oszlop, Elohely elohely)
        {
            for (int i = 0; i < elohely.n - 2; i++)
            {
                for (int j = 0; j < elohely.m - 2; j++)
                {
                    if (elohely.mat[i + 1, j + 1].szuletikE == true)
                    {
                        elohely.mat[i + 1, j + 1] = new Nyuszi(i + 1, j + 1, true);
                    }
                    if (elohely.mat[i + 1, j + 1].meghalE == true)
                    {
                        elohely.mat[i + 1, j + 1] = new Nyuszi(i + 1, j + 1, false);
                    }
                    else if (elohely.mat[i + 1, j + 1].meghalE == false && elohely.mat[i + 1, j + 1].nyusziE == true)
                    {
                        elohely.mat[i + 1, j + 1].kor++;
                    }
                }
            }
            return elohely;
        }
        */
    }
}
