using System;

namespace Calculator
{
    public class Diem
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Diem(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public class HinhChuNhat
    {
        public Diem DiemTrai { get; set; }
        public Diem DiemPhai { get; set; }

        public HinhChuNhat(Diem diemTrai, Diem diemPhai)
        {
            DiemTrai = diemTrai;
            DiemPhai = diemPhai;
        }

        public double TinhDienTich()
        {
            double width = Math.Abs(DiemPhai.X - DiemTrai.X);
            double height = Math.Abs(DiemPhai.Y - DiemTrai.Y);
            return width * height;
        }

        public bool KiemTraGiaoHau(HinhChuNhat other)
        {
            bool xOverlap = (DiemTrai.X <= other.DiemPhai.X && DiemTrai.X >= other.DiemTrai.X) ||
                           (DiemTrai.X >= other.DiemPhai.X && DiemTrai.X <= other.DiemTrai.X) ||
                           (other.DiemTrai.X <= DiemPhai.X && other.DiemTrai.X >= DiemTrai.X) ||
                           (other.DiemTrai.X >= DiemPhai.X && other.DiemTrai.X <= DiemTrai.X);

            bool yOverlap = (DiemTrai.Y <= other.DiemPhai.Y && DiemTrai.Y >= other.DiemTrai.Y) ||
                           (DiemTrai.Y >= other.DiemPhai.Y && DiemTrai.Y <= other.DiemTrai.Y) ||
                           (other.DiemTrai.Y <= DiemPhai.Y && other.DiemTrai.Y >= DiemTrai.Y) ||
                           (other.DiemTrai.Y >= DiemPhai.Y && other.DiemTrai.Y <= DiemTrai.Y);

            return xOverlap && yOverlap;
        }
    }
}