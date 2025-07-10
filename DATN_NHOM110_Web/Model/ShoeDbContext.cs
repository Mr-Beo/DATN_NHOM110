// DbContext cấu hình đầy đủ với Fluent API
using Microsoft.EntityFrameworkCore;

namespace DATN.Model
{
    public class ShoeDbContext : DbContext
    {
        public ShoeDbContext(DbContextOptions<ShoeDbContext> options) : base(options) 
        { 

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-UKQRGABP\\SQLEXPRESS;Database=DATN_NHOM110;User Id=sa;Password=123456;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

        public DbSet<ChatLieu> ChatLieus { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<DeGiay> DeGiays { get; set; }
        public DbSet<KichCo> KichCos { get; set; }
        public DbSet<KieuDang> KieuDangs { get; set; }
        public DbSet<TheLoaiGiay> TheLoaiGiays { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<HinhThucThanhToan> HinhThucThanhToans { get; set; }
        public DbSet<LichSuHoaDon> LichSuHoaDons { get; set; }
        public DbSet<LichSuThanhToan> LichSuThanhToans { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }
    }
}
