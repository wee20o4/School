using System.ComponentModel.DataAnnotations;

namespace banhang.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
		public DateTime OrderDate { get; set; } = DateTime.Now;
		public string? Status {  get; set; }
        public decimal TotalAmount { get; set; }

        public Customer? Customer { get; set; }
		public List<Order_Details> Order_Details { get; set; } = new List<Order_Details>();

	}
}
