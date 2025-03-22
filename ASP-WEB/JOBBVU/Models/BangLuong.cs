using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class BangLuong
{
    public int Id { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal LuongToiDa { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal LuongToiThieu { get; set; }
}

