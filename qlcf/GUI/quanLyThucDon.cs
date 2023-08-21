using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlcfBAL;

namespace qlcf
{
    public partial class quanLyThucDon : Form
    {
        public quanLyThucDon()
        {
            InitializeComponent();
        }
        thucDon xtd = new thucDon();
        string douongid;

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadThucDonData();
        }

        private void LoadThucDonData()
        {
            DataTable dt = new DataTable();
            dt = xtd.showThucDon();
            dataThucDon.DataSource = dt;
            lbTong.Text = dataThucDon.RowCount.ToString();
        }

        private void dataThucDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            douongid = dataThucDon.Rows[dong].Cells[0].Value.ToString();
            textMaDoUong.Text = dataThucDon.Rows[dong].Cells[0].Value.ToString();
            textTenDoUong.Text = dataThucDon.Rows[dong].Cells[1].Value.ToString();
            textDonGia.Text = dataThucDon.Rows[dong].Cells[2].Value.ToString();
        }

        private void themThucDon_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            string maDoUong = textMaDoUong.Text;
            string tenDoUong = textTenDoUong.Text;
            string donGia = textDonGia.Text;

            // Kiểm tra nếu các trường nhập liệu không được bỏ trống
            if (!string.IsNullOrEmpty(maDoUong) && !string.IsNullOrEmpty(tenDoUong) && !string.IsNullOrEmpty(donGia))
            {
                try
                {
                    // Thực hiện chức năng thêm dữ liệu vào cơ sở dữ liệu
                    xtd.themThucDon(maDoUong, tenDoUong, donGia);
                    MessageBox.Show("Thêm thực đơn thành công");
                    LoadThucDonData();
                }
                catch
                {
                    MessageBox.Show("Lỗi khi thêm thực đơn");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        private void suaThucDon_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            string maDoUong = textMaDoUong.Text;
            string tenDoUong = textTenDoUong.Text;
            string donGia = textDonGia.Text;

            // Kiểm tra nếu các trường nhập liệu không được bỏ trống
            if (!string.IsNullOrEmpty(maDoUong) && !string.IsNullOrEmpty(tenDoUong) && !string.IsNullOrEmpty(donGia))
            {
                try
                {
                    // Thực hiện chức năng sửa dữ liệu trong cơ sở dữ liệu
                    xtd.suaThucDon(douongid, maDoUong, tenDoUong, donGia);
                    MessageBox.Show("Sửa thực đơn thành công");
                    LoadThucDonData();
                }
                catch
                {
                    MessageBox.Show("Lỗi khi sửa thực đơn");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            textMaDoUong.ResetText();
            textTenDoUong.ResetText();
            textDonGia.ResetText();
            textMaDoUong.Focus();
        }

        private void xoaThucDon_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện chức năng xóa dữ liệu khỏi cơ sở dữ liệu
                xtd.xoaThucDon(douongid);
                MessageBox.Show("Xóa thực đơn thành công");
                LoadThucDonData();
            }
            catch
            {
                MessageBox.Show("Lỗi khi xóa thực đơn");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (this.textTimKiem.TextLength == 0)
                MessageBox.Show("Vui lòng nhập một từ khóa");
            else
            {
                DataTable dt = new DataTable();
                dt = xtd.timThucDon(this.textTimKiem.Text);
                dataThucDon.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    lbTim.Text = "Không tìm thấy kết quả!";
                }
                else
                    lbTim.ResetText();
            }
        }

        private void btnLai_Click(object sender, EventArgs e)
        {
            LoadThucDonData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
