namespace DATN.Model
{
    public class Voucher
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public int PhanTramGiamGia { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
