using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlcfDAL;

namespace qlcf
{
    public partial class qlNhanVien : Form
    {
        private data dataHelper;

        public qlNhanVien()
        {
            InitializeComponent();
            dataHelper = new data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenNhanVien = tbhovaten.Text;
            string diaChi = tbdiachi.Text;
            string soDienThoai = tbsodienthoai.Text;
            int ngayCong = Convert.ToInt32(tbngaycong.Text);
            double heSoLuong = Convert.ToDouble(tbhesoluong.Text);
            double tienLuong = ngayCong * heSoLuong;

            if (!string.IsNullOrEmpty(tenNhanVien) && !string.IsNullOrEmpty(diaChi) && !string.IsNullOrEmpty(soDienThoai))
            {
                try
                {
                    string sql = $"INSERT INTO NhanVien (TenNhanVien, DiaChi, SoDienThoai, NgayCong, HeSoLuong, TienLuong) " +
                                 $"VALUES ('{tenNhanVien}', '{diaChi}', '{soDienThoai}', {ngayCong}, {heSoLuong}, {tienLuong})";
                    dataHelper.excuteNonQuery(sql);
                    MessageBox.Show("Thêm nhân viên thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lưu ý: Để sửa thông tin nhân viên, bạn cần có thông tin xác định về nhân viên cần sửa (ví dụ: ID của nhân viên).
            // Trong ví dụ này, chúng ta sẽ sử dụng ID của nhân viên được chọn từ danh sách (sau khi tạo danh sách).

            int nhanVienID = 1; // Thay thế bằng ID của nhân viên cần sửa
            string tenNhanVien = tbhovaten.Text;
            string diaChi = tbdiachi.Text;
            string soDienThoai = tbsodienthoai.Text;
            int ngayCong = Convert.ToInt32(tbngaycong.Text);
            double heSoLuong = Convert.ToDouble(tbhesoluong.Text);
            double tienLuong = ngayCong * heSoLuong;

            if (!string.IsNullOrEmpty(tenNhanVien) && !string.IsNullOrEmpty(diaChi) && !string.IsNullOrEmpty(soDienThoai))
            {
                try
                {
                    string sql = $"UPDATE NhanVien SET TenNhanVien = '{tenNhanVien}', DiaChi = '{diaChi}', SoDienThoai = '{soDienThoai}', " +
                                 $"NgayCong = {ngayCong}, HeSoLuong = {heSoLuong}, TienLuong = {tienLuong} WHERE NhanVienID = {nhanVienID}";
                    dataHelper.excuteNonQuery(sql);
                    MessageBox.Show("Sửa nhân viên thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa nhân viên: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lưu ý: Để xóa nhân viên, bạn cần có thông tin xác định về nhân viên cần xóa (ví dụ: ID của nhân viên).
            // Trong ví dụ này, chúng ta sẽ sử dụng ID của nhân viên được chọn từ danh sách (sau khi tạo danh sách).

            int nhanVienID = 1; // Thay thế bằng ID của nhân viên cần xóa

            try
            {
                string sql = $"DELETE FROM NhanVien WHERE NhanVienID = {nhanVienID}";
                dataHelper.excuteNonQuery(sql);
                MessageBox.Show("Xóa nhân viên thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
