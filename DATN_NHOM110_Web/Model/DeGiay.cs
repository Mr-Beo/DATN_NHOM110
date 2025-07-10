namespace DATN.Model
{
    public class DeGiay
    {
        public int ID { get; set; }
        public string Ten_DeGiay { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
