namespace DATN.Model
{
    public class SanPham
    {
        public int ID { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int ThuongHieuID { get; set; }
        public int TrangThai { get; set; }
        public virtual ThuongHieu ThuongHieu { get; set; }
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
