using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace banhang.Models
{
    public class PurchaseOrder
    {
        [Key]
        public int PurchaseOrderId { get; set; }

        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier? Supplier { get; set; }

        public DateTime PurchaseOrderDate { get; set; } = DateTime.Now;

        [Required]
        public bool Status { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn ít nhất một sản phẩm.")]
        public string ProductIds { get; set; }

        [Required(ErrorMessage = "Số lượng sản phẩm không hợp lệ.")]
        public string Quantities { get; set; }

        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } = new List<PurchaseOrderDetail>();

    }
}
