using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace banhang.Models
{
    public class Order_Details
    {
        [Key]
        public int ODId { get; set; }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        [NotMapped]
        public decimal TotalPrice => Quantity * UnitPrice;

        // Thiết lập quan hệ với Order và Product
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
