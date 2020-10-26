using MaximumNumberGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(8,2,3)]
        [DataRow(3,4,8)]
        [DataRow(7,8,6)]
        public void TestMethod1(int a, int b , int c)
        {
            int actualMax;
            int expectedMax = 8;

            actualMax = FindMaximum.FindMaximumInt(a, b, c);

            Assert.AreEqual(actualMax,expectedMax);
        }
    }
}
