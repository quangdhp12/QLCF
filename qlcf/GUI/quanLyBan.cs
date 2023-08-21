using System;
using System.Data;
using System.Windows.Forms;
using qlcfBAL;
using qlcf.GUI;

namespace qlcf
{
    public partial class quanLyBan : Form
    {
        private BanBUS banBUS;
        private string banid;

        public quanLyBan()
        {
            InitializeComponent();
            banBUS = new BanBUS();

            private void quanLyBan_Load(object sender, EventArgs e)
            {
                LoadBanData();
            }

            private void LoadBanData()
            {
                DataTable dt = new DataTable();
                dt = banBUS.LayDanhSachBan();
                dataBan.DataSource = dt;
            }

            private void dataBan_RowEnter(object sender, DataGridViewCellEventArgs e)
            {
                int dong;
                dong = e.RowIndex;
                banid = dataBan.Rows[dong].Cells[0].Value.ToString();
                txtMaBan.Text = dataBan.Rows[dong].Cells[0].Value.ToString();
                txtTenBan.Text = dataBan.Rows[dong].Cells[1].Value.ToString();
            }

            private void btnDong_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btnThem_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txtMaBan.Text))
                {
                    MessageBox.Show("Mã bàn không được bỏ trống");
                }
                else if (txtMaBan.Text.Length > 10)
                {
                    MessageBox.Show("Mã bàn không được vượt quá 10 ký tự");
                }
                else if (string.IsNullOrEmpty(txtTenBan.Text))
                {
                    MessageBox.Show("Tên bàn không được bỏ trống");
                }
                else
                {
                    try
                    {
                        banBUS.ThemBan(txtMaBan.Text, txtTenBan.Text);
                        MessageBox.Show("Thêm bàn thành công");
                        LoadBanData();
                    }
                    catch
                    {
                        MessageBox.Show(txtTenBan.Text + " đã tồn tại");
                    }
                }
            }

            private void btnReset_Click(object sender, EventArgs e)
            {
                txtMaBan.ResetText();
                txtTenBan.ResetText();
                txtMaBan.Focus();
            }

            private void btnXoa_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txtMaBan.Text))
                {
                    MessageBox.Show("Vui lòng chọn một bàn");
                }
                else
                {
                    try
                    {
                        banBUS.XoaBan(banid);
                        MessageBox.Show("Xóa bàn thành công");
                        LoadBanData();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi khi xóa bàn");
                    }
                }
            }
        }

        private void btnSua_Click1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBan.Text))
            {
                MessageBox.Show("Vui lòng chọn một Bàn");
            }
            else if (txtMaBan.Text.Length > 10)
            {
                MessageBox.Show("Mã bàn không được vượt quá 10 ký tự");
            }
            else if (string.IsNullOrEmpty(txtTenBan.Text))
            {
                MessageBox.Show("Tên bàn không được bỏ trống");
            }
            else
            {
                try
                {
                    banBUS.SuaBan(banid, txtMaBan.Text, txtTenBan.Text);
                    MessageBox.Show("Sửa bàn thành công");
                    LoadBanData();
                }
                catch
                {
                    MessageBox.Show("Lỗi khi sửa bàn");
                }
            }
        }
    } }
