namespace DATN.Model
{
    public class ThuongHieu
    {
        public int ID { get; set; }
        public string TenThuongHieu { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
