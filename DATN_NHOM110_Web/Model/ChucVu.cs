namespace DATN.Model
{
    public class ChucVu
    {
        public int ID { get; set; }
        public string TenChucVu { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
