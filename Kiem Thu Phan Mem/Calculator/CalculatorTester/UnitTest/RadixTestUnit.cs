using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace RadixTester
{
    [TestClass]
    public class RadixTestUnit
    {
        //Bài 4 buổi 4
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\RadixTest.csv", "RadixTest#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestRadixConversion()
        {
            int number = int.Parse(TestContext.DataRow[0].ToString());
            int radix = int.Parse(TestContext.DataRow[1].ToString());
            string expected = TestContext.DataRow[2].ToString();

            Radix radixConverter = new Radix(number);
            string result = radixConverter.ConvertDecimalToAnother(radix);

            Assert.AreEqual(expected, result, "The result of the radix conversion is incorrect.");
        }
    }
}