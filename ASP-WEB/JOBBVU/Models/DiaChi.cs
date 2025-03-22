using System.ComponentModel.DataAnnotations;

public class DiaChi
{
    [Key]
    public int MaDiaChi { get; set; }

    public string TinhThanh { get; set; }
    public string QuanHuyen { get; set; }
    public string PhuongXa { get; set; }
    public string ChiTiet { get; set; }
}
