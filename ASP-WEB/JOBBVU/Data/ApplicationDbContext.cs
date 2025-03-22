using JOBBVU.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JOBBVU.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>  // 🔹 Kế thừa IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<CongViec> CongViecs { get; set; }
        public DbSet<TuyenDung> TuyenDungs { get; set; }
        public DbSet<CongTy> CongTys { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<HoSoUngVien> HoSoUngViens { get; set; }
        public DbSet<DiaChi> DiaChis { get; set; }
        public DbSet<LienHe> LienHes { get; set; }
        public DbSet<BangLuong> BangLuongs { get; set; }
        public DbSet<User> Users { get; set; } // Thêm bảng Users

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);  // 🔹 Đặt base.OnModelCreating trước khi tùy chỉnh

            modelBuilder.Entity<BangLuong>()
                .Property(b => b.LuongToiDa)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<BangLuong>()
                .Property(b => b.LuongToiThieu)
                .HasColumnType("decimal(18,2)");
        }
    }
}
