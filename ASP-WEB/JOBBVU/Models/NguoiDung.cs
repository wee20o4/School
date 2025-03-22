using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
public class NguoiDung
    {
        [Key]
        public int MaNguoiDung { get; set; }

        [Required, StringLength(255)]
        public string? HoTen { get; set; }

        public string? GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string? LoaiNguoiDung { get; set; }

        [ForeignKey("LienHe")]
        public int MaLienHe { get; set; }
        public LienHe LienHe { get; set; }
    }

