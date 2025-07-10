namespace DATN.Model
{
    public class MauSac
    {
        public int ID { get; set; }
        public string TenMau { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
