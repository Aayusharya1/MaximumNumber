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
        [TestMethod]
        [DataRow("Corona", "Covid", "SarsCov2")]
        [DataRow("SarsCov2", "Covid", "Corona")]
        [DataRow("Covid", "SarsCov2", "Corona")]
        public void MaxStringMethod_ShouldReturnMaxString(string s1, string s2, string s3)
        {
            //arrange
            string expectedMax = "SarsCov2";
            string actualMax;
            //act
            actualMax = FindMaximum.MaximumStringNumber(s1, s2, s3);
            //Assert
            Assert.AreEqual(expectedMax, actualMax);
        }

        [TestMethod]
        [DataRow("Corona", "Covid", "SarsCov2")]
        [DataRow("SarsCov2", "Covid", "Corona")]
        [DataRow("Covid", "SarsCov2", "Corona")]
        [DataRow("SarsCov2", "Corona", "Covid", "pandemic", "lockdown")]
        [DataRow("Covid", "SarsCov2", "Corona", "pandemic")]
        public void MaxStringMethod_ShouldReturnMaxString(params string[] values)
        {
            //arrange
            GenericMaximum<string> compareString = new GenericMaximum<string>(values);
            string expectedMax = "SarsCov2";

            //act
            string actualMax = compareString.MaxValue(values);

            //Assert
            Assert.AreEqual(expectedMax, actualMax);
        }

    }
}
