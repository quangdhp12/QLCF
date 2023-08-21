namespace qlcf
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuanLyBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuanLyThucDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.banBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.thucdonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thucdonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.douong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucdonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucdonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDanhMuc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mDanhMuc
            // 
            this.mDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mQuanLyBan,
            this.mQuanLyThucDon,
            this.mThoat});
            this.mDanhMuc.Image = global::qlcf.Properties.Resources.menu_tan_icon;
            this.mDanhMuc.Name = "mDanhMuc";
            this.mDanhMuc.Size = new System.Drawing.Size(110, 24);
            this.mDanhMuc.Text = "Danh mục";
            // 
            // mQuanLyBan
            // 
            this.mQuanLyBan.Name = "mQuanLyBan";
            this.mQuanLyBan.Size = new System.Drawing.Size(224, 26);
            this.mQuanLyBan.Text = "Quản lý bàn";
            this.mQuanLyBan.Click += new System.EventHandler(this.mQuanLyBan_Click);
            // 
            // mQuanLyThucDon
            // 
            this.mQuanLyThucDon.Name = "mQuanLyThucDon";
            this.mQuanLyThucDon.Size = new System.Drawing.Size(224, 26);
            this.mQuanLyThucDon.Text = "Quản lý thực đơn";
            this.mQuanLyThucDon.Click += new System.EventHandler(this.mQuanLyThucDon_Click);
            // 
            // mThoat
            // 
            this.mThoat.Name = "mThoat";
            this.mThoat.Size = new System.Drawing.Size(224, 26);
            this.mThoat.Text = "Đóng";
            this.mThoat.Click += new System.EventHandler(this.mThoat_Click);
            // 
            // banBindingSource
            // 
            this.banBindingSource.DataMember = "ban";
            // 
            // banBindingSource1
            // 
            this.banBindingSource1.DataMember = "ban";
            // 
            // thucdonBindingSource
            // 
            this.thucdonBindingSource.DataMember = "thucdon";
            // 
            // thucdonBindingSource1
            // 
            this.thucdonBindingSource1.DataMember = "thucdon";
            // 
            // dataHoaDon
            // 
            this.dataHoaDon.AllowUserToAddRows = false;
            this.dataHoaDon.AllowUserToDeleteRows = false;
            this.dataHoaDon.AllowUserToResizeColumns = false;
            this.dataHoaDon.AllowUserToResizeRows = false;
            this.dataHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.maban,
            this.douong,
            this.soluong,
            this.thanhtien});
            this.dataHoaDon.Location = new System.Drawing.Point(36, 145);
            this.dataHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataHoaDon.Name = "dataHoaDon";
            this.dataHoaDon.ReadOnly = true;
            this.dataHoaDon.RowHeadersVisible = false;
            this.dataHoaDon.RowHeadersWidth = 51;
            this.dataHoaDon.Size = new System.Drawing.Size(672, 267);
            this.dataHoaDon.TabIndex = 7;
            // 
            // mahoadon
            // 
            this.mahoadon.DataPropertyName = "goiid";
            this.mahoadon.HeaderText = "Mã Hóa Đơn";
            this.mahoadon.MinimumWidth = 6;
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.ReadOnly = true;
            this.mahoadon.Width = 125;
            // 
            // maban
            // 
            this.maban.DataPropertyName = "tenban";
            this.maban.HeaderText = "Tên Bàn";
            this.maban.MinimumWidth = 6;
            this.maban.Name = "maban";
            this.maban.ReadOnly = true;
            this.maban.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maban.Width = 125;
            // 
            // douong
            // 
            this.douong.DataPropertyName = "tendouong";
            this.douong.HeaderText = "Tên Đồ Uống";
            this.douong.MinimumWidth = 6;
            this.douong.Name = "douong";
            this.douong.ReadOnly = true;
            this.douong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.douong.Width = 125;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 125;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            this.thanhtien.Width = 125;
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(215)))));
            this.btnTroLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTroLai.Location = new System.Drawing.Point(563, 86);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(145, 28);
            this.btnTroLai.TabIndex = 8;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(36, 50);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(517, 22);
            this.txtTimKiem.TabIndex = 14;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTim.Location = new System.Drawing.Point(563, 50);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(145, 28);
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Location = new System.Drawing.Point(32, 92);
            this.lbTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(102, 16);
            this.lbTimKiem.TabIndex = 16;
            this.lbTimKiem.Text = "Tìm một bản ghi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tổng số hóa đơn:";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(600, 430);
            this.lbTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(10, 16);
            this.lbTong.TabIndex = 18;
            this.lbTong.Text = ".";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 468);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.dataHoaDon);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "main";
            this.Text = "Quản Lý Cà Phê";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucdonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucdonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mQuanLyBan;
        private System.Windows.Forms.ToolStripMenuItem mQuanLyThucDon;
        private System.Windows.Forms.ToolStripMenuItem mThoat;
        private System.Windows.Forms.DataGridView dataHoaDon;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.BindingSource banBindingSource;
        private System.Windows.Forms.BindingSource thucdonBindingSource;
        private System.Windows.Forms.BindingSource banBindingSource1;
        private System.Windows.Forms.BindingSource thucdonBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maban;
        private System.Windows.Forms.DataGridViewTextBoxColumn douong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTong;
    }
}