using StoreApp.Bill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp.NCC
{
    public partial class NhaCungCapForm : Form
    {
        public NhaCungCapForm()
        {
            InitializeComponent();
            btnXuat.Click += btnXuat_Click;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            int MaSanPham, SoLuongSanPham, GiaTien;

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(txtTenNhaCungCap.Text) ||
                string.IsNullOrWhiteSpace(txtTenSanPham.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSize.Text) ||
                //string.IsNullOrWhiteSpace(txtMaSanPham.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuongSanPham.Text) ||
                string.IsNullOrWhiteSpace(txtGiaTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            if (!int.TryParse(txtMaSanPham.Text, out MaSanPham))
            {
                MessageBox.Show("Mã sản phẩm phải là số.");
                return;
            }
            if (!int.TryParse(txtSoLuongSanPham.Text, out SoLuongSanPham))
            {
                MessageBox.Show("Số lượng sản phẩm phải là số.");
                return;
            }
            if (!int.TryParse(txtGiaTien.Text, out GiaTien))
            {
                MessageBox.Show("Giá Tiền phải là số.");
                return;
            }
            string TenNhaCungCap = txtTenNhaCungCap.Text;
            string TenSanPham = txtTenSanPham.Text;
            string DiaChi = txtDiaChi.Text;
            string Size = txtSize.Text;
            //string MaSanPham = txtMaSanPham.Text;
            //string SoLuongSanPham = txtSoLuongSanPham.Text;
            //string GiaTien = txtGiaTien.Text;
            DateTime thoigian = DateTime.Now;

            NhaCungCap nhacungcap = new NhaCungCap(TenNhaCungCap, TenSanPham, DiaChi, Size, MaSanPham, thoigian, SoLuongSanPham, GiaTien);

            inthongtinhnhacungcap.Text = "Thông tin nhà cung cấp:\n" + nhacungcap.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
