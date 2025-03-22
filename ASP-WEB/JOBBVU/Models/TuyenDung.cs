using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TuyenDung
{
    [Key]
    public int MaNTD { get; set; }

    [Required, StringLength(255)]
    public string HoTen { get; set; }

    [ForeignKey("LienHe")]
    public int MaLienHe { get; set; }
    public LienHe LienHe { get; set; }

    [ForeignKey("CongTy")]
    public int MaCongTy { get; set; }
    public CongTy CongTy { get; set; }

    public string TrangThaiNTD { get; set; }
}
