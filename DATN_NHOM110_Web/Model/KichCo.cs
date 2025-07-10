namespace DATN.Model
{
    public class KichCo
    {
        public int ID { get; set; }
        public string Ten_KichCo { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
