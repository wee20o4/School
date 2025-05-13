namespace banhang.Models.ViewModel
{
    public class OrderViewModel
    {
        public int CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderNote { get; set; }
        public List<OrderDetailViewModel> OrderDetails { get; set; }
    }

    public class OrderDetailViewModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
