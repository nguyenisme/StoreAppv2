using System;
using System.Windows.Forms;

namespace StoreApp.Bill
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
            // Đảm bảo rằng sự kiện Click được đăng ký cho nút btnTaoHoaDon
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
        }


        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            int maSP, slSP, giaTien;

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
                string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(txtMaKH.Text) ||
                string.IsNullOrWhiteSpace(txtSLSP.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtGiatien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Kiểm tra định dạng số
            if (!int.TryParse(txtMaSP.Text, out maSP))
            {
                MessageBox.Show("Mã sản phẩm phải là số.");
                return;
            }
            if (!int.TryParse(txtSLSP.Text, out slSP))
            {
                MessageBox.Show("Số lượng sản phẩm phải là số.");
                return;
            }
            if (!int.TryParse(txtGiatien.Text, out giaTien))
            {
                MessageBox.Show("Giá tiền phải là số.");
                return;
            }

            // Lấy thông tin từ các TextBox 
            string tenSP = txtTenSP.Text;
            string maKH = txtMaKH.Text;
            string diaChi = txtDiaChi.Text;
            string tennhanvien = txtTenNhanVien.Text;
            string tenkhachhang = txtTenKhachKhang.Text;
            string sodienthoai = txtSoDienThoai.Text;

            DateTime thoigian = DateTime.Now;

            // Tạo đối tượng Hóa Đơn
            HoaDon hoaDon = new HoaDon(maSP, tenSP, maKH, slSP, diaChi, thoigian, giaTien, tennhanvien, tenkhachhang, sodienthoai);

            // Hiển thị thông tin hóa đơn
            lblResult.Text = "Thông tin hóa đơn:\n" + hoaDon.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
