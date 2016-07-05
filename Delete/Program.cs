using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_BitMath;
namespace Delete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BitHelper.PasteNumInNum(-20,-20,0,10));
            Console.WriteLine(BitHelper.PasteNumInNum(-100,1,30,31));
            Console.ReadKey();
        }
    }
}
