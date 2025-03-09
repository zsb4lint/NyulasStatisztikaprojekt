using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszik_és_mezők
{
    /// <summary>
    /// X: sor
    /// Y: oszlop
    /// Kor: a nyúl adott kora
    /// nyusziE: megnézi hogy nyuszi-e az adott mező
    /// szuletikE: megnézi hogy kell-e az adott mezőre szülessen nyúl
    /// meghalE: megnézi hogy az adott mezőben meghal-e a nyúl
    /// </summary>
    public class Nyuszi
    {
        public int x, y, kor;
        public bool nyusziE;
        public bool szuletikE;
        public bool meghalE;

        /// <summary>
        /// Konstruktor ami az adatokat megfelelően rendezi
        /// </summary>
        /// <param name="x">sor</param>
        /// <param name="y">oszlop</param>
        /// <param name="nyusziE">Nyúl-e az adott nyúl</param>
        /// <param name="szuletikE">Születhet-e oda nyúl</param>
        /// <param name="meghalE">Meghal-e a nyúl</param>
        /// <param name="kor">A nyúl adott kora</param>
        public Nyuszi(int x, int y, bool nyusziE, bool szuletikE = false, bool meghalE = false, int kor = 0)
        {
            this.x = x;
            this.y = y;
            this.nyusziE = nyusziE;
        }
    }
}
