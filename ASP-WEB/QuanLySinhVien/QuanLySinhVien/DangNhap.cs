using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class DangNhap
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string Quyen { get; set; }

        public DangNhap() { }


        public DangNhap( string tenDangNhap,  string matKhau, string hoTen, string quyen)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;  
            HoTen = hoTen;
            Quyen = quyen;
        }
    }
}
