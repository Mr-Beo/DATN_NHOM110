namespace DATN.Model
{
    public class KieuDang
    {
        public int ID { get; set; }
        public string Ten_KieuDang { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
