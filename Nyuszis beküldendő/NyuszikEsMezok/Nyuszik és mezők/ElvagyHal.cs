using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszik_és_mezők
{
    public interface IElvagyHal
    {
        /// <summary>
        /// Megadja hogy az adott indexű nyúl szül-e a következő generációban
        /// </summary>
        /// <param name="i">sor</param>
        /// <param name="j">oszlop</param>
        void SzuletikE(Elohely elohely);

        /// <summary>
        /// Megadja hogy az adott indexű nyúl meghal-e a következő generációban
        /// </summary>
        /// <param name="i">sor</param>
        /// <param name="j">oszlop</param>
        void MeghalE(Elohely elohely); //Fish?
    }
}
