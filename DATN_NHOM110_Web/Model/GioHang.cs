namespace DATN.Model
{
    public class GioHang
    {
        public int ID { get; set; }
        public int TaiKhoanID { get; set; }
        public DateTime NgayTao { get; set; }
        public int TrangThai { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }
    }
}

