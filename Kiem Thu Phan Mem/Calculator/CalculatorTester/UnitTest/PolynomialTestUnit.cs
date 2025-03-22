using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace CalculatorTester
{
    //Bài 3 Buổi 4
    [TestClass]
    public class PolynomialTestUnit
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\PolynomialTest.csv", "PolynomialTest#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestPolynomial()
        {
            int degree = int.Parse(TestContext.DataRow[0].ToString());
            string coefficientsStr =TestContext.DataRow[1].ToString();
            double x = double.Parse(TestContext.DataRow[2].ToString());
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            List<int> coefficients = new List<int>();
            string[] coeffArray = coefficientsStr.Split(',');
            foreach (string coeff in coeffArray)
            {
                coefficients.Add(Convert.ToInt32(coeff));
            }
            Polynomial polynomial = new Polynomial(degree, coefficients);
            int result = polynomial.Cal(x);

            Assert.AreEqual(expected, result, "The result of the polynomial calculation is incorrect.");
        }
    }
}