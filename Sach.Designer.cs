namespace WDF_BTL
{
    partial class Sach
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTenNXB = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnInDS = new System.Windows.Forms.Button();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.tbTenTG = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stentacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tMaKH = new System.Windows.Forms.Label();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.tbTenSach = new System.Windows.Forms.TextBox();
            this.tbMaSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaNXB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTheLoai = new System.Windows.Forms.TextBox();
            this.btnThoatApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 90;
            this.label1.Text = "Tên NXB";
            // 
            // tbTenNXB
            // 
            this.tbTenNXB.Enabled = false;
            this.tbTenNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNXB.Location = new System.Drawing.Point(231, 256);
            this.tbTenNXB.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenNXB.Name = "tbTenNXB";
            this.tbTenNXB.Size = new System.Drawing.Size(200, 28);
            this.tbTenNXB.TabIndex = 89;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(748, 113);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 40);
            this.btnLoad.TabIndex = 88;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(877, 61);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 40);
            this.btnTimKiem.TabIndex = 87;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnInDS
            // 
            this.btnInDS.Location = new System.Drawing.Point(619, 113);
            this.btnInDS.Margin = new System.Windows.Forms.Padding(2);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(125, 40);
            this.btnInDS.TabIndex = 86;
            this.btnInDS.Text = "In DS Sách";
            this.btnInDS.UseVisualStyleBackColor = true;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(74, 158);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(111, 22);
            this.lbDiaChi.TabIndex = 85;
            this.lbDiaChi.Text = "Tên Tác Giả";
            // 
            // tbTenTG
            // 
            this.tbTenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTG.Location = new System.Drawing.Point(231, 155);
            this.tbTenTG.Name = "tbTenTG";
            this.tbTenTG.Size = new System.Drawing.Size(200, 28);
            this.tbTenTG.TabIndex = 84;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(877, 113);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 40);
            this.btnThoat.TabIndex = 83;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.sTenKH,
            this.fdongia,
            this.stentacgia,
            this.sTheLoai,
            this.sMaNXB,
            this.TenNXB});
            this.dgvSach.Location = new System.Drawing.Point(82, 292);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 82;
            this.dgvSach.RowTemplate.Height = 33;
            this.dgvSach.Size = new System.Drawing.Size(975, 360);
            this.dgvSach.TabIndex = 82;
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            // 
            // masach
            // 
            this.masach.DataPropertyName = "sMaSach";
            this.masach.HeaderText = "Mã Sách";
            this.masach.MinimumWidth = 10;
            this.masach.Name = "masach";
            // 
            // sTenKH
            // 
            this.sTenKH.DataPropertyName = "sTenSach";
            this.sTenKH.HeaderText = "Tên Sách";
            this.sTenKH.MinimumWidth = 10;
            this.sTenKH.Name = "sTenKH";
            // 
            // fdongia
            // 
            this.fdongia.DataPropertyName = "fDonGia";
            this.fdongia.HeaderText = "Đơn giá";
            this.fdongia.MinimumWidth = 6;
            this.fdongia.Name = "fdongia";
            this.fdongia.ReadOnly = true;
            // 
            // stentacgia
            // 
            this.stentacgia.DataPropertyName = "sTenTG";
            this.stentacgia.HeaderText = "Tên Tác Giả";
            this.stentacgia.MinimumWidth = 6;
            this.stentacgia.Name = "stentacgia";
            // 
            // sTheLoai
            // 
            this.sTheLoai.DataPropertyName = "sTheLoai";
            this.sTheLoai.HeaderText = "Thể Loại";
            this.sTheLoai.MinimumWidth = 6;
            this.sTheLoai.Name = "sTheLoai";
            this.sTheLoai.ReadOnly = true;
            // 
            // sMaNXB
            // 
            this.sMaNXB.DataPropertyName = "sMaNXB";
            this.sMaNXB.HeaderText = "Mã Nhà xuất bản";
            this.sMaNXB.MinimumWidth = 6;
            this.sMaNXB.Name = "sMaNXB";
            this.sMaNXB.ReadOnly = true;
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "sTenNXB";
            this.TenNXB.HeaderText = "Tên NXB";
            this.TenNXB.MinimumWidth = 6;
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(748, 61);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(125, 40);
            this.btn_Xoa.TabIndex = 81;
            this.btn_Xoa.Text = "Xoá bỏ";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(619, 61);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(125, 40);
            this.btn_Sua.TabIndex = 80;
            this.btn_Sua.Text = "Chỉnh sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(490, 113);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 40);
            this.btnReset.TabIndex = 79;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 76;
            this.label2.Text = "Đơn Giá";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(490, 61);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(125, 40);
            this.btn_Them.TabIndex = 75;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 74;
            this.label6.Text = "Tên Sách";
            // 
            // tMaKH
            // 
            this.tMaKH.AutoSize = true;
            this.tMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMaKH.Location = new System.Drawing.Point(74, 61);
            this.tMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tMaKH.Name = "tMaKH";
            this.tMaKH.Size = new System.Drawing.Size(80, 22);
            this.tMaKH.TabIndex = 73;
            this.tMaKH.Text = "Mã Sách";
            // 
            // tbDonGia
            // 
            this.tbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDonGia.Location = new System.Drawing.Point(231, 122);
            this.tbDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(200, 28);
            this.tbDonGia.TabIndex = 71;
            // 
            // tbTenSach
            // 
            this.tbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenSach.Location = new System.Drawing.Point(231, 90);
            this.tbTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenSach.Name = "tbTenSach";
            this.tbTenSach.Size = new System.Drawing.Size(200, 28);
            this.tbTenSach.TabIndex = 72;
            // 
            // tbMaSach
            // 
            this.tbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaSach.Location = new System.Drawing.Point(231, 58);
            this.tbMaSach.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaSach.Name = "tbMaSach";
            this.tbMaSach.Size = new System.Drawing.Size(200, 28);
            this.tbMaSach.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 36);
            this.label4.TabIndex = 91;
            this.label4.Text = "Quản lý Sách";
            // 
            // cbMaNXB
            // 
            this.cbMaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNXB.FormattingEnabled = true;
            this.cbMaNXB.Location = new System.Drawing.Point(231, 221);
            this.cbMaNXB.Name = "cbMaNXB";
            this.cbMaNXB.Size = new System.Drawing.Size(200, 30);
            this.cbMaNXB.TabIndex = 92;
            this.cbMaNXB.SelectedIndexChanged += new System.EventHandler(this.cbMaNXB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 93;
            this.label3.Text = "Mã Nhà Xuất Bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 95;
            this.label5.Text = "Thể Loại";
            // 
            // tbTheLoai
            // 
            this.tbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTheLoai.Location = new System.Drawing.Point(231, 189);
            this.tbTheLoai.Name = "tbTheLoai";
            this.tbTheLoai.Size = new System.Drawing.Size(200, 28);
            this.tbTheLoai.TabIndex = 94;
            // 
            // btnThoatApp
            // 
            this.btnThoatApp.Location = new System.Drawing.Point(643, 189);
            this.btnThoatApp.Name = "btnThoatApp";
            this.btnThoatApp.Size = new System.Drawing.Size(191, 57);
            this.btnThoatApp.TabIndex = 96;
            this.btnThoatApp.Text = "Thoát chương trình";
            this.btnThoatApp.UseVisualStyleBackColor = true;
            this.btnThoatApp.Click += new System.EventHandler(this.btnThoatApp_Click);
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 663);
            this.Controls.Add(this.btnThoatApp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTheLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMaNXB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenNXB);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.tbTenTG);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tMaKH);
            this.Controls.Add(this.tbDonGia);
            this.Controls.Add(this.tbTenSach);
            this.Controls.Add(this.tbMaSach);
            this.Name = "Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTenNXB;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox tbTenTG;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tMaKH;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.TextBox tbTenSach;
        private System.Windows.Forms.TextBox tbMaSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaNXB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn stentacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.Button btnThoatApp;
    }
}