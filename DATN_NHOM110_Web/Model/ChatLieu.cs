namespace DATN.Model
{
    public class ChatLieu
    {
        public int ID { get; set; }
        public string TenChatLieu { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
