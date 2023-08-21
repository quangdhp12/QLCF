using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlcfBUS;
namespace qlcf.danhSachBan
{
    public partial class ban6 : Form
    {
        public ban6()
        {
            InitializeComponent();
        }

        thucDon xb6 = new thucDon();
        string mahoadon;
        private void ban6_Load(object sender, EventArgs e)
        {
            loadData4Combo(cbDoUong);
            DataTable dt = new DataTable();
            dt = xb6.showBan6();
            dataBan6.DataSource = dt;
        }

        private void loadData4Combo(ComboBox cb)
        {
            cb.DataSource = xb6.showThucDon();
            cb.ValueMember = "douongid";
            cb.DisplayMember = "tendouong";
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            xb6.lamMoiBan6();
            MessageBox.Show("Làm mới thành công");
            ban6_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataBan6_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            mahoadon = dataBan6.Rows[dong].Cells[0].Value.ToString();
            txtMaHoaDon.Text = dataBan6.Rows[dong].Cells[0].Value.ToString();
            cbDoUong.Text = dataBan6.Rows[dong].Cells[1].Value.ToString();
            txtSoLuong.Text = dataBan6.Rows[dong].Cells[2].Value.ToString();
            txtDonGia.Text = dataBan6.Rows[dong].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(txtDonGia.Text);
            b = Convert.ToInt32(txtSoLuong.Text);
            txtTinhTien.Text = (a * b).ToString() + " VNĐ";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txtMaHoaDon.TextLength == 0)
                MessageBox.Show("Mã bàn không được bỏ trống");
            else
              if (this.txtMaHoaDon.TextLength > 10)
                MessageBox.Show("Mã ban không được vượt quá 10 ký tự");
            else
                xb6.themBan6(this.txtMaHoaDon.Text, cbDoUong.SelectedValue.ToString(), txtSoLuong.Text);
            MessageBox.Show("Thêm thành công");
            ban6_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.txtMaHoaDon.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một hóa đơn");
            else
                xb6.xoaBan6(mahoadon);
            MessageBox.Show("xóa bàn thành công");
            ban6_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txtMaHoaDon.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một hóa đơn");
            else
            if (this.txtMaHoaDon.TextLength > 10)
                MessageBox.Show("Mã bàn không được vượt quá 10 ký tự");
            else
               if (txtMaHoaDon.Text != mahoadon)
                MessageBox.Show("Mã hóa đơn không được thay đổi");

            else
            {
                xb6.suaBan6(txtMaHoaDon.Text, cbDoUong.SelectedValue.ToString(), txtSoLuong.Text);
                MessageBox.Show("Sửa thành công");
                ban6_Load(sender, e);
            }
        }
    }
}
