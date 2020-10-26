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
        [TestMethod]
        [DataRow(8.5f, 3.2f, 1.7f)]
        [DataRow(3.2f, 8.5f, 1.7f)]
        [DataRow(3.2f, 1.7f, 8.5f)]
        public void MaxFloatMethod_ShouldReturnMaxFloat(float n1, float n2, float n3)
        {
            //arrange
            float expectedMax = 8.5f;
            float actualMax;
            //act
            actualMax = FindMaximum.FindMaximumFloat(n1, n2, n3);
            //Assert
            Assert.AreEqual(expectedMax, actualMax);
        }

    }
}
