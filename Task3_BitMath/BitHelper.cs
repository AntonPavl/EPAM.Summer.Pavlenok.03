using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_BitMath
{
    public class BitHelper
    {
        /// <summary>
        /// Inserts bits from first number to seCond from posi to posj
        /// </summary>
        /// <param name="a">Main number</param>
        /// <param name="b">Inserted number</param>
        /// <param name="posi"></param>
        /// <param name="posj"></param>
        /// <returns></returns>
        public static int PasteNumInNum(int a, int b, int posi, int posj)
        {
            if (posi >= posj) throw new ArgumentOutOfRangeException();
            if (posi > 30 || posj > 31) throw new ArgumentOutOfRangeException();
            if (posi < 0 || posj < 0) throw new ArgumentOutOfRangeException();
            int[] result = new int[1];

            result[0] = a;
            BitArray a_ByteArr = new BitArray(result);
            result[0] = b;
            BitArray b_ByteArr = new BitArray(result);
            int index = 0;
            while(posi <= posj)
            {
                a_ByteArr[posi] = b_ByteArr[index];
                posi++;
                index++;
            }

            a_ByteArr.CopyTo(result, 0);

            return result[0];
        }
    }
}
