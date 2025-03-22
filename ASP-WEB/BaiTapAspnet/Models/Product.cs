namespace ASP_WEB.Models;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string ImageURL { get; set; }
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public string Storage { get; set; }
    public string Screen { get; set; }
    public string Camera { get; set; }
    public int Warranty { get; set; }
}