namespace DATN.Model
{
    public class LichSuThanhToan
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public decimal SoTien { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}
