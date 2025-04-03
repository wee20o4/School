using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTester
{
    //Bài 5 buổi 4
    [TestClass]
    public class HinhChuNhatTestUnit
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\HinhChuNhatTest.csv", "HinhChuNhatTest#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestTinhDienTich()
        {
            double diemTraiX = double.Parse(TestContext.DataRow[0].ToString());
            double diemTraiY = double.Parse(TestContext.DataRow[1].ToString());
            double diemPhaiX = double.Parse(TestContext.DataRow[2].ToString());
            double diemPhaiY = double.Parse(TestContext.DataRow[3].ToString());
            double expectedArea = double.Parse(TestContext.DataRow[4].ToString());

            Diem diemTrai = new Diem(diemTraiX, diemTraiY);
            Diem diemPhai = new Diem(diemPhaiX, diemPhaiY);
            HinhChuNhat rectangle = new HinhChuNhat(diemTrai, diemPhai);

            double actualArea = rectangle.TinhDienTich();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @".\Data\KiemTraGiaoHauTest.csv", "KiemTraGiaoHauTest#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestKiemTraGiaoNhau()
        {
            double diemTraiX1 = double.Parse(TestContext.DataRow[0].ToString());
            double diemTraiY1 = double.Parse(TestContext.DataRow[1].ToString());
            double diemPhaiX1 = double.Parse(TestContext.DataRow[2].ToString());
            double diemPhaiY1 = double.Parse(TestContext.DataRow[3].ToString());

            double diemTraiX2 = double.Parse(TestContext.DataRow[4].ToString());
            double diemTraiY2 = double.Parse(TestContext.DataRow[5].ToString());
            double diemPhaiX2 = double.Parse(TestContext.DataRow[6].ToString());
            double diemPhaiY2 = double.Parse(TestContext.DataRow[7].ToString());

            bool expectedIntersection = bool.Parse(TestContext.DataRow[8].ToString());

            Diem diemTrai1 = new Diem(diemTraiX1, diemTraiY1);
            Diem diemPhai1 = new Diem(diemPhaiX1, diemPhaiY1);
            HinhChuNhat rectangle1 = new HinhChuNhat(diemTrai1, diemPhai1);

            Diem diemTrai2 = new Diem(diemTraiX2, diemTraiY2);
            Diem diemPhai2 = new Diem(diemPhaiX2, diemPhaiY2);
            HinhChuNhat rectangle2 = new HinhChuNhat(diemTrai2, diemPhai2);

            bool actualIntersection = rectangle1.KiemTraGiaoHau(rectangle2);

            Assert.AreEqual(expectedIntersection, actualIntersection, "Intersection check is incorrect");
        }
    }
}
