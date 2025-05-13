using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace banhang.Models
{
    public class ReturnOrderDetail
    {
        [Key]
        public int Id { get; set; } // Mã chi tiết trả hàng

        [ForeignKey("ReturnOrder")]
        public int ReturnOrderId { get; set; } // Mã trả hàng
        public virtual ReturnOrder ReturnOrder { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; } // Mã sản phẩm bị trả
        public virtual Product Product { get; set; }

        public int Quantity { get; set; } // Số lượng trả lại
        public decimal RefundAmount { get; set; } // Số tiền hoàn lại cho sản phẩm này
    }
}
