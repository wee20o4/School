using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class HoSoUngVien
{
    [Key]
    public int MaHoSo { get; set; }

    [ForeignKey("NguoiDung")]
    public int MaNguoiDung { get; set; }
    public NguoiDung NguoiDung { get; set; }

    public string KinhNghiem { get; set; }
    public string BangCap { get; set; }
    public string KyNang { get; set; }

    [ForeignKey("BangLuong")]
    public int MaLuong { get; set; }
    public BangLuong BangLuong { get; set; }
}
