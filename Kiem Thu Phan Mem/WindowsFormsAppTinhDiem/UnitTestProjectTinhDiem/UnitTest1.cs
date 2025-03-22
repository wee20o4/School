using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsAppTinhDiem;

namespace UnitTestProjectTinhDiem
{
    [TestClass]
    public class UnitTestTinhDiem
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestTinhDiem()
        {
            double a = double.Parse(TestContext.DataRow[0].ToString());
            double b = double.Parse(TestContext.DataRow[1].ToString());
            double c = double.Parse(TestContext.DataRow[2].ToString());
            int renLuyen = int.Parse(TestContext.DataRow[3].ToString());
            bool expectedResult = bool.Parse(TestContext.DataRow[4].ToString());
            Form1 form = new Form1();
            bool result = form.TinhDiem(a, b, c, renLuyen);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
