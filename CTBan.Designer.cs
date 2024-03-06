namespace WDF_BTL
{
    partial class CTBan
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
            this.btnThoatApp = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tbSoLuongMua = new System.Windows.Forms.TextBox();
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
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.tbTenSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoatApp
            // 
            this.btnThoatApp.Location = new System.Drawing.Point(582, 145);
            this.btnThoatApp.Name = "btnThoatApp";
            this.btnThoatApp.Size = new System.Drawing.Size(191, 57);
            this.btnThoatApp.TabIndex = 124;
            this.btnThoatApp.Text = "Thoát chương trình";
            this.btnThoatApp.UseVisualStyleBackColor = true;
            this.btnThoatApp.Click += new System.EventHandler(this.btnThoatApp_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(612, 85);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 40);
            this.btnLoad.TabIndex = 123;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(804, 40);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 40);
            this.btnTimKiem.TabIndex = 122;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(743, 85);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 40);
            this.btnThoat.TabIndex = 120;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(675, 40);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(125, 40);
            this.btn_Xoa.TabIndex = 119;
            this.btn_Xoa.Text = "Xoá bỏ";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(546, 40);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(125, 40);
            this.btn_Sua.TabIndex = 118;
            this.btn_Sua.Text = "Chỉnh sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(482, 85);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 40);
            this.btnReset.TabIndex = 117;
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
            this.btn_Them.TabIndex = 116;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tbSoLuongMua
            // 
            this.tbSoLuongMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuongMua.Location = new System.Drawing.Point(169, 157);
            this.tbSoLuongMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoLuongMua.Multiline = true;
            this.tbSoLuongMua.Name = "tbSoLuongMua";
            this.tbSoLuongMua.Size = new System.Drawing.Size(200, 28);
            this.tbSoLuongMua.TabIndex = 115;
            // 
            // tbDonGia
            // 
            this.tbDonGia.Enabled = false;
            this.tbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDonGia.Location = new System.Drawing.Point(169, 202);
            this.tbDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDonGia.Multiline = true;
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(200, 28);
            this.tbDonGia.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 113;
            this.label1.Text = "Số Lượng mua";
            // 
            // dgv_cthoadon
            // 
            this.dgv_cthoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cthoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSoHD,
            this.dNgayMua,
            this.sMaKH,
            this.sMaNV});
            this.dgv_cthoadon.Location = new System.Drawing.Point(197, 265);
            this.dgv_cthoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_cthoadon.Name = "dgv_cthoadon";
            this.dgv_cthoadon.RowHeadersWidth = 51;
            this.dgv_cthoadon.RowTemplate.Height = 24;
            this.dgv_cthoadon.Size = new System.Drawing.Size(576, 275);
            this.dgv_cthoadon.TabIndex = 112;
            this.dgv_cthoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cthoadon_CellContentClick);
            // 
            // sSoHD
            // 
            this.sSoHD.DataPropertyName = "sSoHD";
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
            this.sMaKH.DataPropertyName = "iSoLuongMua";
            this.sMaKH.HeaderText = "Số lượng mua";
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
            this.label8.TabIndex = 111;
            this.label8.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 110;
            this.label3.Text = "Mã Sách";
            // 
            // tbSoHD
            // 
            this.tbSoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoHD.Location = new System.Drawing.Point(169, 22);
            this.tbSoHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoHD.Multiline = true;
            this.tbSoHD.Name = "tbSoHD";
            this.tbSoHD.Size = new System.Drawing.Size(200, 28);
            this.tbSoHD.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 108;
            this.label2.Text = "Số Hoá Đơn";
            // 
            // cbMaSach
            // 
            this.cbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(169, 67);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(200, 30);
            this.cbMaSach.TabIndex = 125;
            this.cbMaSach.SelectedIndexChanged += new System.EventHandler(this.cbMaSach_SelectedIndexChanged);
            // 
            // tbTenSach
            // 
            this.tbTenSach.Enabled = false;
            this.tbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenSach.Location = new System.Drawing.Point(169, 112);
            this.tbTenSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenSach.Multiline = true;
            this.tbTenSach.Name = "tbTenSach";
            this.tbTenSach.Size = new System.Drawing.Size(200, 28);
            this.tbTenSach.TabIndex = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 126;
            this.label4.Text = "Tên Sách";
            // 
            // CTBan
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
            this.Controls.Add(this.tbSoLuongMua);
            this.Controls.Add(this.tbDonGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_cthoadon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSoHD);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CTBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTBan";
            this.Load += new System.EventHandler(this.CTBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoatApp;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tbSoLuongMua;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_cthoadon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.TextBox tbTenSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNV;
    }
}