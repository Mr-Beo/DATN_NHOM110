namespace DATN.Model
{
    public class TheLoaiGiay
    {
        public int ID { get; set; }
        public string TenTheLoai { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
