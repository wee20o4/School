using System.ComponentModel.DataAnnotations;

public class LienHe
{
    [Key]
    public int MaLienHe { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    [Phone]
    public string PhoneNumber { get; set; }
}
