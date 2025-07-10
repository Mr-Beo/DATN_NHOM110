namespace DATN.Model
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int TaiKhoanID { get; set; }
        public int KhachHangID { get; set; }
        public int HinhThucThanhToanID { get; set; }
        public int? VoucherID { get; set; }
        public DateTime NgayTao { get; set; }
        public int TrangThai { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual HinhThucThanhToan HinhThucThanhToan { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual ICollection<LichSuHoaDon> LichSuHoaDons { get; set; }
        public virtual ICollection<LichSuThanhToan> LichSuThanhToans { get; set; }
    }
}
