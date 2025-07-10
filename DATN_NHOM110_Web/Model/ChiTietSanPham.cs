namespace DATN.Model
{
    public class ChiTietSanPham
    {
        public int ID { get; set; }
        public int SanPhamID { get; set; }
        public int ChatLieuID { get; set; }
        public int KieuDangID { get; set; }
        public int TheLoaiGiayID { get; set; }
        public int DeGiayID { get; set; }
        public int KichCoID { get; set; }
        public int MauSacID { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
        public int TrangThai { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual ChatLieu ChatLieu { get; set; }
        public virtual KieuDang KieuDang { get; set; }
        public virtual TheLoaiGiay TheLoaiGiay { get; set; }
        public virtual DeGiay DeGiay { get; set; }
        public virtual KichCo KichCo { get; set; }
        public virtual MauSac MauSac { get; set; }
    }
}
