using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WindowsFormsAppPTB1;

namespace UnitTestProjectPTB1
{
    [TestClass]
    public class UnitTestPTB1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestGiaiPTB1()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string expectedResult = TestContext.DataRow[2].ToString().Trim('"');
            Form1 form = new Form1();
            string result = form.GiaiPTB1(a, b);
            Assert.AreEqual(expectedResult, result);
        }
    }
}