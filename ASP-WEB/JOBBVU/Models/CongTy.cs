using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

public class CongTy
{
    [Key]
    public int MaCT { get; set; }

    [Required, StringLength(255)]
    public string TenCTY { get; set; }

    [ForeignKey("LienHe")]
    public int MaLienHe { get; set; }
    public LienHe LienHe { get; set; }

    [ForeignKey("DiaChi")]
    public int MaDiaChi { get; set; }
    public DiaChi DiaChi { get; set; }

    public string LoaiHinh { get; set; }
    public string Website { get; set; }
    public DateTime NgayThanhLap { get; set; }
}
