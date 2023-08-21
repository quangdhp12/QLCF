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
    public partial class ban4 : Form
    {
        public ban4()
        {
            InitializeComponent();
        }
        thucDon xb4 = new thucDon();
        string mahoadon;

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            xb4.lamMoiBan4();
            MessageBox.Show("Làm mới thành công");
            ban4_Load(sender, e);
        }

        private void ban4_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = xb4.showBan4();
            dataBan4.DataSource = dt;
            loadData4Combo(cbDoUong);
        }

        private void loadData4Combo(ComboBox cb)
        {
            cb.DataSource = xb4.showThucDon();
            cb.ValueMember = "douongid";
            cb.DisplayMember = "tendouong";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataBan4_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            mahoadon = dataBan4.Rows[dong].Cells[0].Value.ToString();
            txtMaHoaDon.Text = dataBan4.Rows[dong].Cells[0].Value.ToString();
            cbDoUong.Text = dataBan4.Rows[dong].Cells[1].Value.ToString();
            txtSoLuong.Text = dataBan4.Rows[dong].Cells[2].Value.ToString();
            txtDonGia.Text = dataBan4.Rows[dong].Cells[3].Value.ToString();
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
                xb4.themBan4(this.txtMaHoaDon.Text, cbDoUong.SelectedValue.ToString(), txtSoLuong.Text);
            MessageBox.Show("Thêm thành công");
            ban4_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.txtMaHoaDon.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một hóa đơn");
            else
                xb4.xoaBan4(mahoadon);
            MessageBox.Show("xóa bàn thành công");
            ban4_Load(sender, e);
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
                xb4.suaBan4(txtMaHoaDon.Text, cbDoUong.SelectedValue.ToString(), txtSoLuong.Text);
                MessageBox.Show("Sửa thành công");
                ban4_Load(sender, e);
            }
        }
    }
}
