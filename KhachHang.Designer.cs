namespace WDF_BTL
{
    partial class KhachHang
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnInDS = new System.Windows.Forms.Button();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.tbDiaChiKH = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtpNgaySinhKH = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tMaKH = new System.Windows.Forms.Label();
            this.tbSdtKH = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoatApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTonGiao = new System.Windows.Forms.ComboBox();
            this.sMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTonGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInBaoCaoTK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(844, 85);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 40);
            this.btnTimKiem.TabIndex = 47;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnInDS
            // 
            this.btnInDS.Location = new System.Drawing.Point(586, 137);
            this.btnInDS.Margin = new System.Windows.Forms.Padding(2);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(125, 40);
            this.btnInDS.TabIndex = 46;
            this.btnInDS.Text = "In DSKH";
            this.btnInDS.UseVisualStyleBackColor = true;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(42, 182);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(65, 22);
            this.lbDiaChi.TabIndex = 45;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // tbDiaChiKH
            // 
            this.tbDiaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChiKH.Location = new System.Drawing.Point(198, 179);
            this.tbDiaChiKH.Name = "tbDiaChiKH";
            this.tbDiaChiKH.Size = new System.Drawing.Size(200, 28);
            this.tbDiaChiKH.TabIndex = 44;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(717, 200);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 40);
            this.btnThoat.TabIndex = 43;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaKH,
            this.sTenKH,
            this.dNgaySinh,
            this.sDiachi,
            this.sSDT,
            this.sTonGiao});
            this.dgvKhachHang.Location = new System.Drawing.Point(33, 316);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 82;
            this.dgvKhachHang.RowTemplate.Height = 33;
            this.dgvKhachHang.Size = new System.Drawing.Size(1019, 360);
            this.dgvKhachHang.TabIndex = 42;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(715, 85);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(125, 40);
            this.btn_Xoa.TabIndex = 41;
            this.btn_Xoa.Text = "Xoá bỏ";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(586, 85);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(125, 40);
            this.btn_Sua.TabIndex = 40;
            this.btn_Sua.Text = "Chỉnh sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(457, 137);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 40);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpNgaySinhKH
            // 
            this.dtpNgaySinhKH.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhKH.CustomFormat = "";
            this.dtpNgaySinhKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhKH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhKH.Location = new System.Drawing.Point(198, 212);
            this.dtpNgaySinhKH.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinhKH.Name = "dtpNgaySinhKH";
            this.dtpNgaySinhKH.Size = new System.Drawing.Size(200, 28);
            this.dtpNgaySinhKH.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Số điện thoại";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(457, 85);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(125, 40);
            this.btn_Them.TabIndex = 28;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // tMaKH
            // 
            this.tMaKH.AutoSize = true;
            this.tMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMaKH.Location = new System.Drawing.Point(41, 85);
            this.tMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tMaKH.Name = "tMaKH";
            this.tMaKH.Size = new System.Drawing.Size(135, 22);
            this.tMaKH.TabIndex = 26;
            this.tMaKH.Text = "Mã Khách hàng";
            // 
            // tbSdtKH
            // 
            this.tbSdtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSdtKH.Location = new System.Drawing.Point(198, 146);
            this.tbSdtKH.Margin = new System.Windows.Forms.Padding(2);
            this.tbSdtKH.Name = "tbSdtKH";
            this.tbSdtKH.Size = new System.Drawing.Size(200, 28);
            this.tbSdtKH.TabIndex = 24;
            this.tbSdtKH.TextChanged += new System.EventHandler(this.tbSdtKH_TextChanged);
            this.tbSdtKH.Validating += new System.ComponentModel.CancelEventHandler(this.tbSdtKH_Validating);
            // 
            // tbTenKH
            // 
            this.tbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKH.Location = new System.Drawing.Point(198, 114);
            this.tbTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(200, 28);
            this.tbTenKH.TabIndex = 25;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaKH.Location = new System.Drawing.Point(198, 82);
            this.tbMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(200, 28);
            this.tbMaKH.TabIndex = 23;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(715, 137);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 40);
            this.btnLoad.TabIndex = 48;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 36);
            this.label4.TabIndex = 92;
            this.label4.Text = "Quản lý Khách Hàng";
            // 
            // btnThoatApp
            // 
            this.btnThoatApp.Location = new System.Drawing.Point(586, 199);
            this.btnThoatApp.Name = "btnThoatApp";
            this.btnThoatApp.Size = new System.Drawing.Size(125, 40);
            this.btnThoatApp.TabIndex = 97;
            this.btnThoatApp.Text = "Thoát chương trình";
            this.btnThoatApp.UseVisualStyleBackColor = true;
            this.btnThoatApp.Click += new System.EventHandler(this.btnThoatApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 98;
            this.label1.Text = "Tôn giáo";
            // 
            // cbbTonGiao
            // 
            this.cbbTonGiao.FormattingEnabled = true;
            this.cbbTonGiao.Items.AddRange(new object[] {
            "Kinh",
            "Mường",
            "Hoa",
            "Tày"});
            this.cbbTonGiao.Location = new System.Drawing.Point(198, 245);
            this.cbbTonGiao.Name = "cbbTonGiao";
            this.cbbTonGiao.Size = new System.Drawing.Size(200, 24);
            this.cbbTonGiao.TabIndex = 99;
            this.cbbTonGiao.SelectedIndexChanged += new System.EventHandler(this.cbbTonGiao_SelectedIndexChanged);
            // 
            // sMaKH
            // 
            this.sMaKH.DataPropertyName = "sMaKH";
            this.sMaKH.HeaderText = "Mã Khách hàng";
            this.sMaKH.MinimumWidth = 10;
            this.sMaKH.Name = "sMaKH";
            // 
            // sTenKH
            // 
            this.sTenKH.DataPropertyName = "sTenKH";
            this.sTenKH.HeaderText = "Họ tên khách hàng";
            this.sTenKH.MinimumWidth = 10;
            this.sTenKH.Name = "sTenKH";
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.DataPropertyName = "dNgaysinh";
            this.dNgaySinh.HeaderText = "Ngày Sinh";
            this.dNgaySinh.MinimumWidth = 6;
            this.dNgaySinh.Name = "dNgaySinh";
            this.dNgaySinh.ReadOnly = true;
            // 
            // sDiachi
            // 
            this.sDiachi.DataPropertyName = "sDiachi";
            this.sDiachi.HeaderText = "Địa Chỉ";
            this.sDiachi.MinimumWidth = 6;
            this.sDiachi.Name = "sDiachi";
            // 
            // sSDT
            // 
            this.sSDT.DataPropertyName = "sSDT";
            this.sSDT.HeaderText = "Số điện thoại";
            this.sSDT.MinimumWidth = 6;
            this.sSDT.Name = "sSDT";
            this.sSDT.ReadOnly = true;
            // 
            // sTonGiao
            // 
            this.sTonGiao.DataPropertyName = "sTonGiao";
            this.sTonGiao.HeaderText = "Tôn Giáo";
            this.sTonGiao.MinimumWidth = 6;
            this.sTonGiao.Name = "sTonGiao";
            // 
            // btnInBaoCaoTK
            // 
            this.btnInBaoCaoTK.Location = new System.Drawing.Point(844, 137);
            this.btnInBaoCaoTK.Name = "btnInBaoCaoTK";
            this.btnInBaoCaoTK.Size = new System.Drawing.Size(125, 40);
            this.btnInBaoCaoTK.TabIndex = 101;
            this.btnInBaoCaoTK.Text = "Báo Cáo TK";
            this.btnInBaoCaoTK.UseVisualStyleBackColor = true;
            this.btnInBaoCaoTK.Click += new System.EventHandler(this.btnInBaoCaoTK_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 697);
            this.Controls.Add(this.btnInBaoCaoTK);
            this.Controls.Add(this.cbbTonGiao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoatApp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.tbDiaChiKH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dtpNgaySinhKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tMaKH);
            this.Controls.Add(this.tbSdtKH);
            this.Controls.Add(this.tbTenKH);
            this.Controls.Add(this.tbMaKH);
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox tbDiaChiKH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tMaKH;
        private System.Windows.Forms.TextBox tbSdtKH;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoatApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTonGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTonGiao;
        private System.Windows.Forms.Button btnInBaoCaoTK;
    }
}