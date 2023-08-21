namespace qlcf
{
    partial class quanLyThucDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanLyThucDon));
            this.danhSachThucDon = new System.Windows.Forms.GroupBox();
            this.lbTong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataThucDon = new System.Windows.Forms.DataGridView();
            this.mathucdon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDoUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.btnLai = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.themThucDon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.xoaThucDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.textDonGia = new System.Windows.Forms.TextBox();
            this.suaThucDon = new System.Windows.Forms.Button();
            this.textTenDoUong = new System.Windows.Forms.TextBox();
            this.textMaDoUong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.danhSachThucDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataThucDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // danhSachThucDon
            // 
            this.danhSachThucDon.Controls.Add(this.lbTong);
            this.danhSachThucDon.Controls.Add(this.label6);
            this.danhSachThucDon.Controls.Add(this.dataThucDon);
            this.danhSachThucDon.ForeColor = System.Drawing.Color.Black;
            this.danhSachThucDon.Location = new System.Drawing.Point(32, 90);
            this.danhSachThucDon.Margin = new System.Windows.Forms.Padding(4);
            this.danhSachThucDon.Name = "danhSachThucDon";
            this.danhSachThucDon.Padding = new System.Windows.Forms.Padding(4);
            this.danhSachThucDon.Size = new System.Drawing.Size(491, 410);
            this.danhSachThucDon.TabIndex = 17;
            this.danhSachThucDon.TabStop = false;
            this.danhSachThucDon.Text = "Thông tin";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(183, 373);
            this.lbTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(10, 16);
            this.lbTong.TabIndex = 16;
            this.lbTong.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 373);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tổng số thực đơn:";
            // 
            // dataThucDon
            // 
            this.dataThucDon.AllowUserToAddRows = false;
            this.dataThucDon.AllowUserToDeleteRows = false;
            this.dataThucDon.AllowUserToResizeColumns = false;
            this.dataThucDon.AllowUserToResizeRows = false;
            this.dataThucDon.ColumnHeadersHeight = 29;
            this.dataThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathucdon,
            this.tenDoUong,
            this.donGia});
            this.dataThucDon.Location = new System.Drawing.Point(40, 23);
            this.dataThucDon.Margin = new System.Windows.Forms.Padding(4);
            this.dataThucDon.Name = "dataThucDon";
            this.dataThucDon.ReadOnly = true;
            this.dataThucDon.RowHeadersVisible = false;
            this.dataThucDon.RowHeadersWidth = 51;
            this.dataThucDon.Size = new System.Drawing.Size(405, 334);
            this.dataThucDon.TabIndex = 0;
            this.dataThucDon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataThucDon_RowEnter);
            // 
            // mathucdon
            // 
            this.mathucdon.DataPropertyName = "douongid";
            this.mathucdon.HeaderText = "Mã đồ uống";
            this.mathucdon.MinimumWidth = 6;
            this.mathucdon.Name = "mathucdon";
            this.mathucdon.ReadOnly = true;
            this.mathucdon.Width = 125;
            // 
            // tenDoUong
            // 
            this.tenDoUong.DataPropertyName = "tendouong";
            this.tenDoUong.HeaderText = "Tên đồ uống";
            this.tenDoUong.MinimumWidth = 6;
            this.tenDoUong.Name = "tenDoUong";
            this.tenDoUong.ReadOnly = true;
            this.tenDoUong.Width = 125;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "dongia";
            dataGridViewCellStyle1.NullValue = null;
            this.donGia.DefaultCellStyle = dataGridViewCellStyle1;
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            this.donGia.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTim);
            this.groupBox3.Controls.Add(this.btnLai);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(585, 398);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(449, 103);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.ForeColor = System.Drawing.Color.Red;
            this.lbTim.Location = new System.Drawing.Point(107, 65);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(13, 16);
            this.lbTim.TabIndex = 14;
            this.lbTim.Text = "  ";
            // 
            // btnLai
            // 
            this.btnLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(215)))));
            this.btnLai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.btnLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLai.Location = new System.Drawing.Point(313, 59);
            this.btnLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnLai.Name = "btnLai";
            this.btnLai.Size = new System.Drawing.Size(100, 28);
            this.btnLai.TabIndex = 13;
            this.btnLai.Text = "Trở lại";
            this.btnLai.UseVisualStyleBackColor = false;
            this.btnLai.Click += new System.EventHandler(this.btnLai_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(215)))));
            this.btnTim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTim.Location = new System.Drawing.Point(313, 23);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tìm kiếm";
            // 
            // textTimKiem
            // 
            this.textTimKiem.Location = new System.Drawing.Point(111, 26);
            this.textTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.textTimKiem.Name = "textTimKiem";
            this.textTimKiem.Size = new System.Drawing.Size(181, 22);
            this.textTimKiem.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.themThucDon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.xoaThucDon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnNhapLai);
            this.groupBox2.Controls.Add(this.textDonGia);
            this.groupBox2.Controls.Add(this.suaThucDon);
            this.groupBox2.Controls.Add(this.textTenDoUong);
            this.groupBox2.Controls.Add(this.textMaDoUong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(585, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(449, 320);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn giá";
            // 
            // themThucDon
            // 
            this.themThucDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(215)))));
            this.themThucDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.themThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themThucDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.themThucDon.Location = new System.Drawing.Point(193, 222);
            this.themThucDon.Margin = new System.Windows.Forms.Padding(4);
            this.themThucDon.Name = "themThucDon";
            this.themThucDon.Size = new System.Drawing.Size(100, 28);
            this.themThucDon.TabIndex = 10;
            this.themThucDon.Text = "Thêm";
            this.themThucDon.UseVisualStyleBackColor = false;
            this.themThucDon.Click += new System.EventHandler(this.themThucDon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên đồ uống";
            // 
            // xoaThucDon
            // 
            this.xoaThucDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(215)))));
            this.xoaThucDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.xoaThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoaThucDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.xoaThucDon.Location = new System.Drawing.Point(313, 272);
            this.xoaThucDon.Margin = new System.Windows.Forms.Padding(4);
            this.xoaThucDon.Name = "xoaThucDon";
            this.xoaThucDon.Size = new System.Drawing.Size(100, 28);
            this.xoaThucDon.TabIndex = 1;
            this.xoaThucDon.Text = "Xóa";
            this.xoaThucDon.UseVisualStyleBackColor = false;
            this.xoaThucDon.Click += new System.EventHandler(this.xoaThucDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã đồ uống";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(215)))));
            this.btnNhapLai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.btnNhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNhapLai.Location = new System.Drawing.Point(193, 272);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(100, 28);
            this.btnNhapLai.TabIndex = 1;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // textDonGia
            // 
            this.textDonGia.Location = new System.Drawing.Point(148, 159);
            this.textDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.textDonGia.Name = "textDonGia";
            this.textDonGia.Size = new System.Drawing.Size(264, 23);
            this.textDonGia.TabIndex = 5;
            // 
            // suaThucDon
            // 
            this.suaThucDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(215)))));
            this.suaThucDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.suaThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suaThucDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.suaThucDon.Location = new System.Drawing.Point(313, 222);
            this.suaThucDon.Margin = new System.Windows.Forms.Padding(4);
            this.suaThucDon.Name = "suaThucDon";
            this.suaThucDon.Size = new System.Drawing.Size(100, 28);
            this.suaThucDon.TabIndex = 1;
            this.suaThucDon.Text = "Sửa";
            this.suaThucDon.UseVisualStyleBackColor = false;
            this.suaThucDon.Click += new System.EventHandler(this.suaThucDon_Click);
            // 
            // textTenDoUong
            // 
            this.textTenDoUong.Location = new System.Drawing.Point(148, 105);
            this.textTenDoUong.Margin = new System.Windows.Forms.Padding(4);
            this.textTenDoUong.Name = "textTenDoUong";
            this.textTenDoUong.Size = new System.Drawing.Size(264, 23);
            this.textTenDoUong.TabIndex = 4;
            // 
            // textMaDoUong
            // 
            this.textMaDoUong.BackColor = System.Drawing.SystemColors.Window;
            this.textMaDoUong.Location = new System.Drawing.Point(148, 48);
            this.textMaDoUong.Margin = new System.Windows.Forms.Padding(4);
            this.textMaDoUong.Name = "textMaDoUong";
            this.textMaDoUong.Size = new System.Drawing.Size(264, 23);
            this.textMaDoUong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(108, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách thực đơn";
            // 
            // quanLyThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 537);
            this.Controls.Add(this.danhSachThucDon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "quanLyThucDon";
            this.Text = "Quản lý cà phê";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.danhSachThucDon.ResumeLayout(false);
            this.danhSachThucDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataThucDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataThucDon;
        private System.Windows.Forms.Button xoaThucDon;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button suaThucDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDonGia;
        private System.Windows.Forms.TextBox textTenDoUong;
        private System.Windows.Forms.TextBox textMaDoUong;
        private System.Windows.Forms.Button themThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathucdon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLai;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTimKiem;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox danhSachThucDon;
    }
}

