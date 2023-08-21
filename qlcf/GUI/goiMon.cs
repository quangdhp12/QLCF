using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlcf
{
    public partial class goiMon : Form
    {
        public goiMon()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnBan1.Enabled = true;
                checkBox1.ForeColor = Color.Red;
                checkBox1.Text = "Đang sử dụng";
            }
            else
            {
                btnBan1.Enabled = false;
                checkBox1.ForeColor = Color.Green;
                checkBox1.Text = "Còn trống";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                btnBan2.Enabled = true;
                checkBox2.ForeColor = Color.Red;
                checkBox2.Text = "Đang sử dụng";
            }
            else
            {
                btnBan2.Enabled = false;
                checkBox2.ForeColor = Color.Green;
                checkBox2.Text = "Còn trống";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                btnBan3.Enabled = true;
                checkBox3.ForeColor = Color.Red;
                checkBox3.Text = "Đang sử dụng";
            }
            else
            {
                btnBan3.Enabled = false;
                checkBox3.ForeColor = Color.Green;
                checkBox3.Text = "Còn trống";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                btnBan4.Enabled = true;
                checkBox4.ForeColor = Color.Red;
                checkBox4.Text = "Đang sử dụng";
            }
            else
            {
                btnBan4.Enabled = false;
                checkBox4.ForeColor = Color.Green;
                checkBox4.Text = "Còn trống";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                btnBan5.Enabled = true;
                checkBox5.ForeColor = Color.Red;
                checkBox5.Text = "Đang sử dụng";
            }
            else
            {
                btnBan5.Enabled = false;
                checkBox5.ForeColor = Color.Green;
                checkBox5.Text = "Còn trống";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                btnBan6.Enabled = true;
                checkBox6.ForeColor = Color.Red;
                checkBox6.Text = "Đang sử dụng";
            }
            else
            {
                btnBan6.Enabled = false;
                checkBox6.ForeColor = Color.Green;
                checkBox6.Text = "Còn trống";
            }
        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            danhSachBan.ban1 b1 = new danhSachBan.ban1();
            b1.Show();
        }

        private void mThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mBan_Click(object sender, EventArgs e)
        {
            quanLyBan qlb = new quanLyBan();
            qlb.Show();
        }

        private void mThucDon_Click(object sender, EventArgs e)
        {
            quanLyThucDon qltd = new quanLyThucDon();
            qltd.Show();
        }

        private void mHoaDon_Click(object sender, EventArgs e)
        {
            main hd = new main();
            hd.Show();
        }
        

        private void goiMon_Load(object sender, EventArgs e)
        {
              login lg = new login();
              lg.ShowDialog();
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            danhSachBan.ban2 b2 = new danhSachBan.ban2();
            b2.Show();
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            danhSachBan.ban3 b3 = new danhSachBan.ban3();
            b3.Show();
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            danhSachBan.ban4 b4 = new danhSachBan.ban4();
            b4.Show();
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            danhSachBan.ban5 b5 = new danhSachBan.ban5();
            b5.Show();
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            danhSachBan.ban6 b6 = new danhSachBan.ban6();
            b6.Show();
        }

        private void mNhanVien_Click(object sender, EventArgs e)
        {
            qlNhanVien nv = new qlNhanVien();
            nv.Show();
        }
    }
}
