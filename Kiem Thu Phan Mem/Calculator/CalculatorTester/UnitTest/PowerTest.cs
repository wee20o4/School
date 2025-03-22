using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTester
{
    [TestClass]
    public class PowerTest
    {
        //Bài 2 Buổi 4
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\PowerTest.csv", "PowerTest#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestPower()
        {
            double x = double.Parse(TestContext.DataRow[0].ToString());
            int n = int.Parse(TestContext.DataRow[1].ToString());
            double expected = double.Parse(TestContext.DataRow[2].ToString());
            double actual = Math.Pow(x,n); 
            Assert.AreEqual(expected, actual);
        }

    }
}

