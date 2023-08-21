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
    public partial class ban2 : Form
    {
        public ban2()
        {
            InitializeComponent();
        }
        thucDon xb2 = new thucDon();
        string mahoadon;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(txtDonGia.Text);
            b = Convert.ToInt32(txtSoLuong.Text);
            txtTinhTien.Text = (a * b).ToString() + " VND";
        }

        private void ban2_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = xb2.showBan2();
            dataBan2.DataSource = dt;
            loadData4Combo2(cbDoUong);
        }

        private void dataBan2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            mahoadon = dataBan2.Rows[dong].Cells[0].Value.ToString();
            txtMaHoaDon.Text = dataBan2.Rows[dong].Cells[0].Value.ToString();
            cbDoUong.Text = dataBan2.Rows[dong].Cells[1].Value.ToString();
            txtSoLuong.Text = dataBan2.Rows[dong].Cells[2].Value.ToString();
            txtDonGia.Text = dataBan2.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txtMaHoaDon.TextLength == 0)
                MessageBox.Show("Mã bàn không được bỏ trống");
            else
               if (this.txtMaHoaDon.TextLength > 10)
                MessageBox.Show("Mã ban không được vượt quá 10 ký tự");
            else
                xb2.themBan2(this.txtMaHoaDon.Text, cbDoUong.SelectedValue.ToString() , txtSoLuong.Text);
            MessageBox.Show("Thêm thành công");
            ban2_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.txtMaHoaDon.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một hóa đơn");
            else
                xb2.xoaBan2(mahoadon);
            MessageBox.Show("xóa bàn thành công");
            ban2_Load(sender, e);
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
                xb2.suaBan2(txtMaHoaDon.Text, cbDoUong.SelectedValue.ToString(), txtSoLuong.Text);
                MessageBox.Show("Sửa thành công");
                ban2_Load(sender, e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            xb2.lamMoiBan2();
            MessageBox.Show("Làm mới thành công");
            ban2_Load(sender, e);
        }
        private void loadData4Combo2 (ComboBox cb2)
        {
            cb2.DataSource = xb2.showThucDon();
            cb2.ValueMember = "douongid";
            cb2.DisplayMember = "tendouong";
        }
        
    }
}
