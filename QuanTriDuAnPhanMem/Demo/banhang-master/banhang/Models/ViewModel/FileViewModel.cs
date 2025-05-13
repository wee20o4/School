namespace banhang.Models.ViewModel
{
    public class FileViewModel
    {
        public string FileName { get; set; }
        public string LastModified { get; set; }  // Chuỗi hiển thị
        public DateTime LastModifiedDate { get; set; }  // Dùng để lọc ngày
    }

}
