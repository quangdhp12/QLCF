using System;

namespace qlcf
{
    partial class qlNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbhovaten = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.tbsodienthoai = new System.Windows.Forms.TextBox();
            this.tbngaycong = new System.Windows.Forms.TextBox();
            this.tbhesoluong = new System.Windows.Forms.TextBox();
            this.tbtienluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbmanhanvien = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.hoten,
            this.diachi,
            this.sdt,
            this.ngaycong,
            this.hsluong,
            this.luong});
            this.dataGridView1.Location = new System.Drawing.Point(16, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(940, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // manv
            // 
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            this.manv.Width = 125;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 125;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Width = 125;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 125;
            // 
            // ngaycong
            // 
            this.ngaycong.HeaderText = "Ngày Công";
            this.ngaycong.MinimumWidth = 6;
            this.ngaycong.Name = "ngaycong";
            this.ngaycong.ReadOnly = true;
            this.ngaycong.Width = 125;
            // 
            // hsluong
            // 
            this.hsluong.HeaderText = "Hệ số lương";
            this.hsluong.MinimumWidth = 6;
            this.hsluong.Name = "hsluong";
            this.hsluong.ReadOnly = true;
            this.hsluong.Width = 125;
            // 
            // luong
            // 
            this.luong.HeaderText = "Tiền lương";
            this.luong.MinimumWidth = 6;
            this.luong.Name = "luong";
            this.luong.ReadOnly = true;
            this.luong.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân viên";
            // 
            // tbhovaten
            // 
            this.tbhovaten.Location = new System.Drawing.Point(120, 354);
            this.tbhovaten.Margin = new System.Windows.Forms.Padding(4);
            this.tbhovaten.Name = "tbhovaten";
            this.tbhovaten.Size = new System.Drawing.Size(132, 22);
            this.tbhovaten.TabIndex = 2;
            this.tbhovaten.TextChanged += new System.EventHandler(this.tbhovaten_TextChanged);
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(396, 304);
            this.tbdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(132, 22);
            this.tbdiachi.TabIndex = 2;
            this.tbdiachi.TextChanged += new System.EventHandler(this.tbdiachi_TextChanged);
            // 
            // tbsodienthoai
            // 
            this.tbsodienthoai.Location = new System.Drawing.Point(396, 354);
            this.tbsodienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.tbsodienthoai.Name = "tbsodienthoai";
            this.tbsodienthoai.Size = new System.Drawing.Size(132, 22);
            this.tbsodienthoai.TabIndex = 2;
            this.tbsodienthoai.TextChanged += new System.EventHandler(this.tbsodienthoai_TextChanged);
            // 
            // tbngaycong
            // 
            this.tbngaycong.Location = new System.Drawing.Point(663, 304);
            this.tbngaycong.Margin = new System.Windows.Forms.Padding(4);
            this.tbngaycong.Name = "tbngaycong";
            this.tbngaycong.Size = new System.Drawing.Size(49, 22);
            this.tbngaycong.TabIndex = 2;
            this.tbngaycong.TextChanged += new System.EventHandler(this.tbngaycong_TextChanged);
            // 
            // tbhesoluong
            // 
            this.tbhesoluong.Location = new System.Drawing.Point(816, 304);
            this.tbhesoluong.Margin = new System.Windows.Forms.Padding(4);
            this.tbhesoluong.Name = "tbhesoluong";
            this.tbhesoluong.Size = new System.Drawing.Size(51, 22);
            this.tbhesoluong.TabIndex = 2;
            this.tbhesoluong.TextChanged += new System.EventHandler(this.tbhesoluong_TextChanged);
            // 
            // tbtienluong
            // 
            this.tbtienluong.Location = new System.Drawing.Point(663, 354);
            this.tbtienluong.Margin = new System.Windows.Forms.Padding(4);
            this.tbtienluong.Name = "tbtienluong";
            this.tbtienluong.Size = new System.Drawing.Size(204, 22);
            this.tbtienluong.TabIndex = 3;
            this.tbtienluong.TextChanged += new System.EventHandler(this.tbtienluong_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ và Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày công";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(723, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hệ số lương";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 358);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tiền lương";
            // 
            // tbmanhanvien
            // 
            this.tbmanhanvien.Location = new System.Drawing.Point(120, 308);
            this.tbmanhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.tbmanhanvien.Name = "tbmanhanvien";
            this.tbmanhanvien.Size = new System.Drawing.Size(132, 22);
            this.tbmanhanvien.TabIndex = 11;
            this.tbmanhanvien.TextChanged += new System.EventHandler(this.tbmanhanvien_TextChanged);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(184, 426);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 12;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(329, 426);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 13;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(483, 426);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 14;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(650, 426);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.Text = "Thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.Bbtnthoat_Click);
            // 
            // qlNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 468);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.tbmanhanvien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbtienluong);
            this.Controls.Add(this.tbsodienthoai);
            this.Controls.Add(this.tbhesoluong);
            this.Controls.Add(this.tbngaycong);
            this.Controls.Add(this.tbdiachi);
            this.Controls.Add(this.tbhovaten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "qlNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Bbtnthoat_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tbtienluong_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tbhesoluong_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tbngaycong_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tbsodienthoai_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tbdiachi_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tbhovaten_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tbmanhanvien_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnthem_click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycong;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbhovaten;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.TextBox tbsodienthoai;
        private System.Windows.Forms.TextBox tbngaycong;
        private System.Windows.Forms.TextBox tbhesoluong;
        private System.Windows.Forms.TextBox tbtienluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbmanhanvien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
    }
}