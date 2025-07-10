namespace DATN.Model
{
    public class HinhThucThanhToan
    {
        public int ID { get; set; }
        public string TenHinhThuc { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
