namespace WDF_BTL
{
    partial class CTNhap
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
            this.tbTenSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.btnThoatApp = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tbSoLuongNhap = new System.Windows.Forms.TextBox();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_cthoadon = new System.Windows.Forms.DataGridView();
            this.sSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTenSach
            // 
            this.tbTenSach.Enabled = false;
            this.tbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenSach.Location = new System.Drawing.Point(165, 109);
            this.tbTenSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenSach.Multiline = true;
            this.tbTenSach.Name = "tbTenSach";
            this.tbTenSach.Size = new System.Drawing.Size(200, 28);
            this.tbTenSach.TabIndex = 146;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 145;
            this.label4.Text = "Tên Sách";
            // 
            // cbMaSach
            // 
            this.cbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(165, 64);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(200, 30);
            this.cbMaSach.TabIndex = 144;
            this.cbMaSach.SelectedIndexChanged += new System.EventHandler(this.cbMaSach_SelectedIndexChanged);
            // 
            // btnThoatApp
            // 
            this.btnThoatApp.Location = new System.Drawing.Point(574, 145);
            this.btnThoatApp.Name = "btnThoatApp";
            this.btnThoatApp.Size = new System.Drawing.Size(191, 57);
            this.btnThoatApp.TabIndex = 143;
            this.btnThoatApp.Text = "Thoát chương trình";
            this.btnThoatApp.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(605, 85);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 40);
            this.btnLoad.TabIndex = 142;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(802, 40);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 40);
            this.btnTimKiem.TabIndex = 141;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(736, 85);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 40);
            this.btnThoat.TabIndex = 140;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(673, 40);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(125, 40);
            this.btn_Xoa.TabIndex = 139;
            this.btn_Xoa.Text = "Xoá bỏ";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(544, 40);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(125, 40);
            this.btn_Sua.TabIndex = 138;
            this.btn_Sua.Text = "Chỉnh sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(475, 85);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 40);
            this.btnReset.TabIndex = 137;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(415, 40);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(125, 40);
            this.btn_Them.TabIndex = 136;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tbSoLuongNhap
            // 
            this.tbSoLuongNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuongNhap.Location = new System.Drawing.Point(165, 154);
            this.tbSoLuongNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoLuongNhap.Multiline = true;
            this.tbSoLuongNhap.Name = "tbSoLuongNhap";
            this.tbSoLuongNhap.Size = new System.Drawing.Size(200, 28);
            this.tbSoLuongNhap.TabIndex = 135;
            // 
            // tbDonGia
            // 
            this.tbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDonGia.Location = new System.Drawing.Point(165, 199);
            this.tbDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDonGia.Multiline = true;
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(200, 28);
            this.tbDonGia.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 133;
            this.label1.Text = "Số Lượng nhập";
            // 
            // dgv_cthoadon
            // 
            this.dgv_cthoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cthoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSoHD,
            this.dNgayMua,
            this.sMaKH,
            this.sMaNV});
            this.dgv_cthoadon.Location = new System.Drawing.Point(189, 265);
            this.dgv_cthoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_cthoadon.Name = "dgv_cthoadon";
            this.dgv_cthoadon.RowHeadersWidth = 51;
            this.dgv_cthoadon.RowTemplate.Height = 24;
            this.dgv_cthoadon.Size = new System.Drawing.Size(576, 275);
            this.dgv_cthoadon.TabIndex = 132;
            this.dgv_cthoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cthoadon_CellContentClick);
            // 
            // sSoHD
            // 
            this.sSoHD.DataPropertyName = "sSoHDN";
            this.sSoHD.HeaderText = "Số Hoá Đơn";
            this.sSoHD.MinimumWidth = 6;
            this.sSoHD.Name = "sSoHD";
            this.sSoHD.Width = 125;
            // 
            // dNgayMua
            // 
            this.dNgayMua.DataPropertyName = "sMaSach";
            this.dNgayMua.HeaderText = "Mã Sách";
            this.dNgayMua.MinimumWidth = 6;
            this.dNgayMua.Name = "dNgayMua";
            this.dNgayMua.Width = 125;
            // 
            // sMaKH
            // 
            this.sMaKH.DataPropertyName = "iSoLuongNhap";
            this.sMaKH.HeaderText = "Số lượng nhập";
            this.sMaKH.MinimumWidth = 6;
            this.sMaKH.Name = "sMaKH";
            this.sMaKH.Width = 125;
            // 
            // sMaNV
            // 
            this.sMaNV.DataPropertyName = "fDonGia";
            this.sMaNV.HeaderText = "Đơn giá";
            this.sMaNV.MinimumWidth = 6;
            this.sMaNV.Name = "sMaNV";
            this.sMaNV.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 131;
            this.label8.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 130;
            this.label3.Text = "Mã Sách";
            // 
            // tbSoHD
            // 
            this.tbSoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoHD.Location = new System.Drawing.Point(165, 19);
            this.tbSoHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoHD.Multiline = true;
            this.tbSoHD.Name = "tbSoHD";
            this.tbSoHD.Size = new System.Drawing.Size(200, 28);
            this.tbSoHD.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 128;
            this.label2.Text = "Số Hoá Đơn";
            // 
            // CTNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 551);
            this.Controls.Add(this.tbTenSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMaSach);
            this.Controls.Add(this.btnThoatApp);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tbSoLuongNhap);
            this.Controls.Add(this.tbDonGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_cthoadon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSoHD);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CTNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTNhap";
            this.Load += new System.EventHandler(this.CTNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTenSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.Button btnThoatApp;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tbSoLuongNhap;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_cthoadon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNV;
    }
}