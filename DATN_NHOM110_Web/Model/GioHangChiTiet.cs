namespace DATN.Model
{
    public class GioHangChiTiet
    {
        public int ID { get; set; }
        public int GioHangID { get; set; }
        public int ChiTietSanPhamID { get; set; }
        public int SoLuong { get; set; }
        public virtual GioHang GioHang { get; set; }
        public virtual ChiTietSanPham ChiTietSanPham { get; set; }
    }
}
