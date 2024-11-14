using System;

namespace StoreApp.Bill
{
    public class HoaDon
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaKH { get; set; }
        public int SLSP { get; set; }
        public string DiaChi { get; set; }
        public DateTime Thoigian { get; set; }
        public int Giatien { get; set; }
        public string TenNhanVien { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }

        public HoaDon(int maSP, string tenSP, string maKH, int slSP, string diaChi, DateTime thoigian, int giatien, string tennhanvien, string tenkhachhang, string sodienthoai)
        {
            MaSP = maSP;
            TenSP = tenSP;
            MaKH = maKH;
            SLSP = slSP;
            DiaChi = diaChi;
            Thoigian = thoigian;
            Giatien = giatien;
            TenNhanVien = tennhanvien;
            TenKhachHang = tenkhachhang;
            SoDienThoai = sodienthoai;
        }

        public int TongTien => SLSP * Giatien;

        public override string ToString()
        {
            return
                $"Mã KH: {MaKH}\n" +
                $"Tên Khách Hàng: {TenKhachHang}\n" +
                $"Số Điện Thoại: {SoDienThoai}\n" +
                $"Mã SP: {MaSP}\n" +
                $"Tên SP: {TenSP}\n" +
                $"Số lượng SP: {SLSP}\n" +
                $"Địa chỉ: {DiaChi}\n" +
                $"Giá tiền: {Giatien}\n" +
                $"Tổng tiền: {TongTien}\n" +
                $"Tên Nhân Viên: {TenNhanVien}\n" +
                $"Thời gian: {Thoigian}";
        }
    }
}
