namespace WDF_BTL
{
    partial class NhanVien
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnInDS = new System.Windows.Forms.Button();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.tbDiaChiNV = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtpNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tMaKH = new System.Windows.Forms.Label();
            this.tbSdtNV = new System.Windows.Forms.TextBox();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCMNDNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoatApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(714, 134);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 40);
            this.btnLoad.TabIndex = 67;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(843, 82);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 40);
            this.btnTimKiem.TabIndex = 66;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnInDS
            // 
            this.btnInDS.Location = new System.Drawing.Point(585, 134);
            this.btnInDS.Margin = new System.Windows.Forms.Padding(2);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(125, 40);
            this.btnInDS.TabIndex = 65;
            this.btnInDS.Text = "In DSNV";
            this.btnInDS.UseVisualStyleBackColor = true;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(41, 179);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(65, 22);
            this.lbDiaChi.TabIndex = 64;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // tbDiaChiNV
            // 
            this.tbDiaChiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChiNV.Location = new System.Drawing.Point(197, 176);
            this.tbDiaChiNV.Name = "tbDiaChiNV";
            this.tbDiaChiNV.Size = new System.Drawing.Size(200, 28);
            this.tbDiaChiNV.TabIndex = 63;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(843, 134);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 40);
            this.btnThoat.TabIndex = 62;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.sTenKH,
            this.dNgaySinh,
            this.sDiachi,
            this.sSDT,
            this.sCCCD});
            this.dgvNhanVien.Location = new System.Drawing.Point(44, 279);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 82;
            this.dgvNhanVien.RowTemplate.Height = 33;
            this.dgvNhanVien.Size = new System.Drawing.Size(975, 360);
            this.dgvNhanVien.TabIndex = 61;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "sMaNV";
            this.manv.HeaderText = "Mã Nhân viên";
            this.manv.MinimumWidth = 10;
            this.manv.Name = "manv";
            // 
            // sTenKH
            // 
            this.sTenKH.DataPropertyName = "sTenNV";
            this.sTenKH.HeaderText = "Họ tên nhân viên";
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
            // sCCCD
            // 
            this.sCCCD.DataPropertyName = "sCMND";
            this.sCCCD.HeaderText = "Số CMND";
            this.sCCCD.MinimumWidth = 6;
            this.sCCCD.Name = "sCCCD";
            this.sCCCD.ReadOnly = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(714, 82);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(125, 40);
            this.btn_Xoa.TabIndex = 60;
            this.btn_Xoa.Text = "Xoá bỏ";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(585, 82);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(125, 40);
            this.btn_Sua.TabIndex = 59;
            this.btn_Sua.Text = "Chỉnh sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(456, 134);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 40);
            this.btnReset.TabIndex = 58;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpNgaySinhNV
            // 
            this.dtpNgaySinhNV.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhNV.CustomFormat = "";
            this.dtpNgaySinhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhNV.Location = new System.Drawing.Point(197, 209);
            this.dtpNgaySinhNV.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinhNV.Name = "dtpNgaySinhNV";
            this.dtpNgaySinhNV.Size = new System.Drawing.Size(200, 28);
            this.dtpNgaySinhNV.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 55;
            this.label2.Text = "Số điện thoại";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(456, 82);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(125, 40);
            this.btn_Them.TabIndex = 54;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 53;
            this.label6.Text = "Tên nhân viên";
            // 
            // tMaKH
            // 
            this.tMaKH.AutoSize = true;
            this.tMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMaKH.Location = new System.Drawing.Point(40, 82);
            this.tMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tMaKH.Name = "tMaKH";
            this.tMaKH.Size = new System.Drawing.Size(117, 22);
            this.tMaKH.TabIndex = 52;
            this.tMaKH.Text = "Mã nhân viên";
            // 
            // tbSdtNV
            // 
            this.tbSdtNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSdtNV.Location = new System.Drawing.Point(197, 143);
            this.tbSdtNV.Margin = new System.Windows.Forms.Padding(2);
            this.tbSdtNV.Name = "tbSdtNV";
            this.tbSdtNV.Size = new System.Drawing.Size(200, 28);
            this.tbSdtNV.TabIndex = 50;
            // 
            // tbTenNV
            // 
            this.tbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNV.Location = new System.Drawing.Point(197, 111);
            this.tbTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(200, 28);
            this.tbTenNV.TabIndex = 51;
            // 
            // tbMaNV
            // 
            this.tbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNV.Location = new System.Drawing.Point(197, 79);
            this.tbMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(200, 28);
            this.tbMaNV.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "CCCD";
            // 
            // tbCMNDNV
            // 
            this.tbCMNDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCMNDNV.Location = new System.Drawing.Point(197, 241);
            this.tbCMNDNV.Margin = new System.Windows.Forms.Padding(2);
            this.tbCMNDNV.Name = "tbCMNDNV";
            this.tbCMNDNV.Size = new System.Drawing.Size(200, 28);
            this.tbCMNDNV.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 36);
            this.label4.TabIndex = 92;
            this.label4.Text = "Quản lý Nhân Viên";
            // 
            // btnThoatApp
            // 
            this.btnThoatApp.Location = new System.Drawing.Point(616, 199);
            this.btnThoatApp.Name = "btnThoatApp";
            this.btnThoatApp.Size = new System.Drawing.Size(191, 57);
            this.btnThoatApp.TabIndex = 97;
            this.btnThoatApp.Text = "Thoát chương trình";
            this.btnThoatApp.UseVisualStyleBackColor = true;
            this.btnThoatApp.Click += new System.EventHandler(this.btnThoatApp_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 650);
            this.Controls.Add(this.btnThoatApp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCMNDNV);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.tbDiaChiNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dtpNgaySinhNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tMaKH);
            this.Controls.Add(this.tbSdtNV);
            this.Controls.Add(this.tbTenNV);
            this.Controls.Add(this.tbMaNV);
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox tbDiaChiNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tMaKH;
        private System.Windows.Forms.TextBox tbSdtNV;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCMNDNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCCCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoatApp;
    }
}