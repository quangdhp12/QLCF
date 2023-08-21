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
    public partial class ban1 : Form
    {
        public ban1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xb1.lamMoiBan1();
            MessageBox.Show("Làm mới thành công");
            ban1_Load(sender, e);
        }
        thucDon xb1 = new thucDon();
        string mahoadon;
        private void ban1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = xb1.showBan1();
            dataBan1.DataSource = dt;
            loadData4Combo(cbDoUong);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataBan1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            mahoadon = dataBan1.Rows[dong].Cells[0].Value.ToString();
            txtMaHoaDon.Text = dataBan1.Rows[dong].Cells[0].Value.ToString();
            cbDoUong.Text = dataBan1.Rows[dong].Cells[1].Value.ToString();
            txtSoLuong.Text = dataBan1.Rows[dong].Cells[2].Value.ToString();
            txtDonGia.Text = dataBan1.Rows[dong].Cells[3].Value.ToString();
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
                    xb1.themBan1(this.txtMaHoaDon.Text, cbDoUong.SelectedValue.ToString(), txtSoLuong.Text);
                    MessageBox.Show("Thêm thành công");
                    ban1_Load(sender, e);
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.txtMaHoaDon.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một hóa đơn");
            else
                xb1.xoaBan1(mahoadon);
            MessageBox.Show("xóa bàn thành công");
            ban1_Load(sender, e);
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
                xb1.suaBan1(txtMaHoaDon.Text, cbDoUong.SelectedValue.ToString(), txtSoLuong.Text);
                MessageBox.Show("Sửa thành công");
                ban1_Load(sender, e);
            }
        }
        private void loadData4Combo(ComboBox cb)
        {
            cb.DataSource = xb1.showThucDon();
            cb.ValueMember = "douongid";
            cb.DisplayMember = "tendouong";
        }
    }
}
