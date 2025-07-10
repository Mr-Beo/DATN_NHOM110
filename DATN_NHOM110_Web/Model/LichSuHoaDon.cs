namespace DATN.Model
{
    public class LichSuHoaDon
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}
