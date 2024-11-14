using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.NCC
{
    public class NhaCungCap
    {
        public string TenNhaCungCap { get; set; }
        public string TenSanPham { get; set; }
        public string DiaChi { get; set; }
        public string Size { get; set; }
        public int MaSanPham { get; set; } 
        public DateTime ThoiGian { get; set; }
        public int SoLuongSanPham { get; set; }
        public decimal GiaTien { get; set; }

        public NhaCungCap(string tenNhaCungCap, string tenSanPham, string diaChi, string size, int maSanPham, DateTime thoiGian, int soLuongSanPham, decimal giaTien)
        {
            TenNhaCungCap = tenNhaCungCap;
            TenSanPham = tenSanPham;
            DiaChi = diaChi;
            Size = size;
            MaSanPham = maSanPham;
            ThoiGian = thoiGian;
            SoLuongSanPham = soLuongSanPham;
            GiaTien = giaTien;
        }
        public override string ToString()
        {
            return
                $"Tên Nhà Cung Cấp: {TenNhaCungCap}\n" +
                $"Tên Sản Phẩm: {TenSanPham}\n" +
                $"Địa Chỉ: {DiaChi}\n" +
                $"Size: {Size}\n" +
                $"Mã Sản Phẩm: {MaSanPham}\n" +
                $"Số lượng Sản Phẩm: {SoLuongSanPham}\n" +
                $"Giá Tiền: {GiaTien}\n" +
                $"Thời Gian: {ThoiGian}";
        }
    }
}

