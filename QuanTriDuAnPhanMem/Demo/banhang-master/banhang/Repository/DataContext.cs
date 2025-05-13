using banhang.Models;
using banhang.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Collections.Generic;

namespace banhang.Repository
{
    public class DataContext: IdentityDbContext<AppUserModel>
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        { 
            
        }
        public async Task<string> GenerateProductCode()
        {
            int? lastId = await this.Products.MaxAsync(p => (int?)p.ProductId);
            int newId = (lastId ?? 1000) + 1; // Bắt đầu từ 1001 nếu không có sản phẩm nào
            return $"SP{newId}";
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseOrderDetail>()
               .HasOne(pod => pod.Supplier)
               .WithMany(s => s.PurchaseOrderDetails)
               .HasForeignKey(pod => pod.SupplierId)
               .OnDelete(DeleteBehavior.NoAction); // 🔥 Ngăn chặn xóa theo cascade

            modelBuilder.Entity<PurchaseOrder>()
                .HasMany(po => po.PurchaseOrderDetails)
                .WithOne(pod => pod.PurchaseOrder)
                .HasForeignKey(pod => pod.PurchaseOrderId);

            modelBuilder.Entity<Order>()
               .HasMany(o => o.Order_Details)
               .WithOne(od => od.Order)
               .HasForeignKey(od => od.OrderId)
               .OnDelete(DeleteBehavior.Cascade); // Xóa đơn hàng sẽ xóa chi tiết

            modelBuilder.Entity<Order_Details>()
                .HasOne(od => od.Product)
                .WithMany()
                .HasForeignKey(od => od.ProductId);

            modelBuilder.Entity<Order_Details>()
                .HasKey(od => od.ODId);

            var hasher = new PasswordHasher<AppUserModel>();

            modelBuilder.Entity<AppUserModel>().HasData(new AppUserModel
            {
                Id = "11111111-1111-1111-1111-111111111111",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                PasswordHash = hasher.HashPassword(null, "123"),
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                Occupation = "Administrator",
                FullName = "Administrator",
                Province = "Hồ Chí Minh",
                District = "Quận 1",  // Cần có giá trị hợp lệ
                Ward = "Phường Bến Nghé",
                Gender = "Nam",
                ProfileImage = "uploads/default.png"
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product>Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Details> OrderDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set;}
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ReturnOrder> ReturnOrders { get; set; }
        public DbSet<ReturnOrderDetail> ReturnOrderDetails { get; set; }
    }
}
