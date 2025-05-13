namespace banhang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ReturnOrder
    {
        [Key]
        public int ReturnOrderId { get; set; } // Mã trả hàng

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public DateTime ReturnDate { get; set; } = DateTime.Now;
        public decimal TotalRefund { get; set; }
        public string? Reason { get; set; }
        public int Status { get; set; }

        public virtual ICollection<ReturnOrderDetail> ReturnOrderDetails { get; set; }

        [NotMapped]
        public string CustomerName => Customer != null ? Customer.CustomerName : "Khách lẻ"; // Tránh lỗi null
    }
}
