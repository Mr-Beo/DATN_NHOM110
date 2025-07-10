namespace DATN.Model
{
    public class HoaDonChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int ChiTietSanPhamID { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual ChiTietSanPham ChiTietSanPham { get; set; }
    }
}
