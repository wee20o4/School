namespace banhang.Models.ViewModel
{
    public class ReturnOrderViewModel
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public List<ReturnOrderItemViewModel> Products { get; set; }
    }
}
