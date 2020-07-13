using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLibrary;

namespace CalcLibrary.Test
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestRadQ()
        {
            double num = 4;
            double resp = Calc.RadQ(num);
            double asp = 2;
            Assert.AreEqual(asp, resp);
        }

        [DataTestMethod]
        [DataRow(4, 2)]
        [DataRow(-1, double.NaN)]
        public void DataTestRadQ(double num, double asp)
        {
            double resp = Calc.RadQ(num);
            Assert.AreEqual(asp, resp);
        }
    }
}
