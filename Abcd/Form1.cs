using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abcd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<HoaQua> danhSachHoaQua = new List<HoaQua>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tạo một instance của form nhập thông tin hoa quả
            FormNhapThongTinHoaQua formNhapHoaQua = new FormNhapThongTinHoaQua();

            // Mở form nhập thông tin hoa quả
            formNhapHoaQua.ShowDialog();

            // Sau khi form nhập thông tin đóng lại, kiểm tra liệu người dùng có thực hiện thêm hoa quả không
            if (formNhapHoaQua.DialogResult == DialogResult.OK)
            {
                // Lấy thông tin hoa quả từ form nhập thông tin và thêm vào danh sách
                HoaQua hoaQuaMoi = formNhapHoaQua.LayThongTinHoaQua();
                danhSachHoaQua.Add(hoaQuaMoi);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = new BindingList<HoaQua>(danhSachHoaQua);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm từ TextBox
            string keyword = txtSearch.Text.Trim();

            // Tạo một danh sách tạm thời để lưu kết quả tìm kiếm
            BindingList<HoaQua> ketQuaTimKiem = new BindingList<HoaQua>();

            // Kiểm tra xem có từ khóa tìm kiếm không
            if (!string.IsNullOrEmpty(keyword))
            {
                // Tìm kiếm và thêm vào danh sách tạm thời
                foreach (HoaQua hoaQua in danhSachHoaQua)
                {
                    if (hoaQua.Ten.ToLower().Contains(keyword.ToLower()))
                    {
                        ketQuaTimKiem.Add(hoaQua);
                    }
                }

                // Hiển thị kết quả tìm kiếm trên DataGridView
                dataGridView1.DataSource = ketQuaTimKiem;
            }
            else
            {
                // Hiển thị danh sách hoa quả ban đầu khi không có từ khóa tìm kiếm
                dataGridView1.DataSource = danhSachHoaQua;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Lấy dòng đang được chọn
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Xóa dòng đó khỏi DataGridView
                    dataGridView1.Rows.Remove(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
