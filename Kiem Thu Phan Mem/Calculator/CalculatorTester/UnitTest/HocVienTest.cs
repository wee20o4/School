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
    public class HocVienTest
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\HocVienTest.csv", "HocVienTest#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestHocBong()
        {
            int soHocVien = int.Parse(TestContext.DataRow[0].ToString());
            string hoTen = TestContext.DataRow[1].ToString();
            string queQuan = TestContext.DataRow[2].ToString();
            double diem1 = double.Parse(TestContext.DataRow[3].ToString());
            double diem2 = double.Parse(TestContext.DataRow[4].ToString());
            double diem3 = double.Parse(TestContext.DataRow[5].ToString());
            bool expected = bool.Parse(TestContext.DataRow[6].ToString());

            HocVien hocVien = new HocVien(soHocVien, hoTen, queQuan, diem1, diem2, diem3);
            bool actual = hocVien.DuocHocBong();

            Assert.AreEqual(expected, actual, $"Sai kết quả cho học viên {hoTen}");
        }
    }
}
