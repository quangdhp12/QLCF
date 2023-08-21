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

namespace qlcf
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void mQuanLyThucDon_Click(object sender, EventArgs e)
        {
            quanLyThucDon td = new quanLyThucDon();
            td.Show();
        }

        private void mQuanLyBan_Click(object sender, EventArgs e)
        {
            quanLyBan ba = new quanLyBan();
            ba.Show();
        }

        private void mThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main_Load(sender, e);
        }
        thucDon xhd = new thucDon();
        private void main_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = xhd.showHoaDon();
            dataHoaDon.DataSource = dt;
            lbTong.Text = dataHoaDon.RowCount.ToString();
        }

     

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (this.txtTimKiem.TextLength == 0)
                MessageBox.Show("Vui lòng chọn nhập một từ khóa");
            else
            {
                DataTable dt = new DataTable();
                dt = xhd.timHoaDon(this.txtTimKiem.Text);
                dataHoaDon.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    lbTimKiem.Text = "Không tìm thấy kết quả!";
                    lbTimKiem.ForeColor = Color.Red;
                }
                else
                    lbTimKiem.ResetText();
            }

        }
    }
}
