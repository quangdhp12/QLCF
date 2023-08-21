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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.textBoxID.Text == "admin")
            {
                if (this.textBoxPass.Text == "1")
                {
                    this.Close();
                }
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
            textBoxID.Text = "";
            textBoxPass.Text = "";
            textBoxID.Focus();
        }
    }
}
