using System;
using NUnit.Framework;
using Task3_BitMath;

namespace Task3_BitMathNTest
{
    [TestFixture]
    public class BitHelperNTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCase(10, 20, 6, 4)]
        [TestCase(10, 20, 31, 37)]
        [TestCase(10, 20, 6, 37)]
        [TestCase(10, 20, -6, 4)]
        [TestCase(10, 20, 6, -4)]
        public void PasteNumInNum_ArgumentOutOfRangeEx(int a,int b,int i, int j)
        {
            BitHelper.PasteNumInNum(a, b, i, j);
        }

        [Test]
        [TestCase(9,6,1,2,13)]
        [TestCase(15,0,1,2,9)]
        [TestCase(Int32.MaxValue,Int32.MinValue,1,30,1)]
        [TestCase(Int32.MinValue, Int32.MaxValue,0,1,Int32.MinValue+3)]
        [TestCase(0,9,0,20,9)]
        public void PasteNumInNum_Number_Number_PosI_PosJ(int a, int b, int i, int j, int res)
        {
            Assert.AreEqual(BitHelper.PasteNumInNum(a, b, i, j), res);
        }


    }
}