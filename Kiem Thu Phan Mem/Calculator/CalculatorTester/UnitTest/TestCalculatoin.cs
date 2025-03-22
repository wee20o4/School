using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator; 

namespace CalculatorTester
{
    [TestClass]
    public class TestCalculatoin
    {
        [TestMethod]
        public void TestCong()
        {
            var calc = new Calculation(5, 3);
            Assert.AreEqual(8, calc.Execute("+"));
        }

        [TestMethod]
        public void TestTru()
        {
            var calc = new Calculation(5, 3);
            Assert.AreEqual(2, calc.Execute("-"));
        }

        [TestMethod]
        public void TestNhan()
        {
            var calc = new Calculation(5, 3);
            Assert.AreEqual(15, calc.Execute("*"));
        }

        [TestMethod]
        public void TestChia()
        {
            var calc = new Calculation(6, 3);
            Assert.AreEqual(2, calc.Execute("/"));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestChiaVoi0()
        {
            var calc = new Calculation(5, 0);
            calc.Execute("/");
        }

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        
        [TestMethod]
        public void TestWithDataSource()    
        {

            int a = int.Parse(TestContext.DataRow[0].ToString()); 
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString()); 


            Calculation calc = new Calculation(a, b);
            int actual = calc.Execute("+");


            Assert.AreEqual(expected, actual);
        }
        //Bài 1 Buổi 4
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "Data\\TestCong_DataSource.csv", "TestCong_DataSource#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestCong_DataTest()
        {
            int c = int.Parse(TestContext.DataRow[0].ToString());
            int d = int.Parse(TestContext.DataRow[1].ToString());
            string operation = TestContext.DataRow["operation"].ToString().Trim('\'');
            int expected = int.Parse(TestContext.DataRow["expected"].ToString());

            Calculation calc = new Calculation(c, d);
            int actual = calc.Execute(operation);
            Assert.AreEqual(expected, actual);
        }


    }
}