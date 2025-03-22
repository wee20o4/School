using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class HocVien
    {
        public int SoHocVien { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public double DiemMon1 { get; set; }
        public double DiemMon2 { get; set; }
        public double DiemMon3 { get; set; }

        public HocVien(int soHocVien, string hoTen, string queQuan, double diem1, double diem2, double diem3)
        {
            SoHocVien = soHocVien;
            HoTen = hoTen;
            QueQuan = queQuan;
            DiemMon1 = diem1;
            DiemMon2 = diem2;
            DiemMon3 = diem3;
        }

        public bool DuocHocBong()
        {
            double diemTrungBinh = (DiemMon1 + DiemMon2 + DiemMon3) / 3;
            return diemTrungBinh >= 8.0 && DiemMon1 >= 5 && DiemMon2 >= 5 && DiemMon3 >= 5;
        }
    }

    public class TrungTamGiaSu
    {
        public List<HocVien> DanhSachHocVien { get; set; } = new List<HocVien>();

        public void ThemHocVien(HocVien hocVien)
        {
            DanhSachHocVien.Add(hocVien);
        }

        public List<HocVien> DanhSachHocBong()
        {
            return DanhSachHocVien.Where(hv => hv.DuocHocBong()).ToList();
        }
    }
}
