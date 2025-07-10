namespace DATN.Model
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string TenKhachHang { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MatKhau { get; set; } 
        public string Email { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
