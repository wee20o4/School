using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CongViec
{
    [Key]
    public int MaCV { get; set; }

    [Required, StringLength(255)]
    public string TieuDe { get; set; }

    [Required]
    public string MoTa { get; set; }

    public string YeuCau { get; set; }

    [ForeignKey("BangLuong")]
    public int MaLuong { get; set; }
    public BangLuong BangLuong { get; set; }

    [ForeignKey("DiaChi")]
    public int MaDiaChi { get; set; }
    public DiaChi DiaChi { get; set; }

    [ForeignKey("TuyenDung")]
    public int MaNTD { get; set; }
    public TuyenDung TuyenDung { get; set; }

    public DateTime NgayDang { get; set; }
    public DateTime HanNop { get; set; }

    public string TrangThai { get; set; }
}

