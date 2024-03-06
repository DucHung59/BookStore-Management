namespace WDF_BTL
{
    partial class HoaDonNhap
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
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btnThoatApp = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnInDS = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.tbMaNXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.sSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.CustomFormat = "";
            this.dtpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(205, 101);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(200, 28);
            this.dtpNgayNhap.TabIndex = 125;
            // 
            // btnThoatApp
            // 
            this.btnThoatApp.Location = new System.Drawing.Point(683, 183);
            this.btnThoatApp.Name = "btnThoatApp";
            this.btnThoatApp.Size = new System.Drawing.Size(191, 57);
            this.btnThoatApp.TabIndex = 124;
            this.btnThoatApp.Text = "Thoát chương trình";
            this.btnThoatApp.UseVisualStyleBackColor = true;
            this.btnThoatApp.Click += new System.EventHandler(this.btnThoatApp_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(781, 118);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 40);
            this.btnLoad.TabIndex = 123;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(910, 66);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 40);
            this.btnTimKiem.TabIndex = 122;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnInDS
            // 
            this.btnInDS.Location = new System.Drawing.Point(652, 118);
            this.btnInDS.Margin = new System.Windows.Forms.Padding(2);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(125, 40);
            this.btnInDS.TabIndex = 121;
            this.btnInDS.Text = "In Hoá đơn nhập";
            this.btnInDS.UseVisualStyleBackColor = true;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(910, 118);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 40);
            this.btnThoat.TabIndex = 120;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(781, 66);
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
            this.btn_Sua.Location = new System.Drawing.Point(652, 66);
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
            this.btnReset.Location = new System.Drawing.Point(523, 118);
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
            this.btn_Them.Location = new System.Drawing.Point(523, 66);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(125, 40);
            this.btn_Them.TabIndex = 116;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tbMaNV
            // 
            this.tbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNV.Location = new System.Drawing.Point(205, 147);
            this.tbMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaNV.Multiline = true;
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(200, 28);
            this.tbMaNV.TabIndex = 115;
            // 
            // tbMaNXB
            // 
            this.tbMaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNXB.Location = new System.Drawing.Point(205, 195);
            this.tbMaNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaNXB.Multiline = true;
            this.tbMaNXB.Name = "tbMaNXB";
            this.tbMaNXB.Size = new System.Drawing.Size(200, 28);
            this.tbMaNXB.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 113;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSoHD,
            this.dNgayNhap,
            this.sMaNXB,
            this.sMaNV});
            this.dgv_hoadon.Location = new System.Drawing.Point(289, 276);
            this.dgv_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowHeadersWidth = 51;
            this.dgv_hoadon.RowTemplate.Height = 24;
            this.dgv_hoadon.Size = new System.Drawing.Size(555, 275);
            this.dgv_hoadon.TabIndex = 112;
            this.dgv_hoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellContentClick);
            // 
            // sSoHD
            // 
            this.sSoHD.DataPropertyName = "sSoHDN";
            this.sSoHD.HeaderText = "Mã Hoá Đơn";
            this.sSoHD.MinimumWidth = 6;
            this.sSoHD.Name = "sSoHD";
            this.sSoHD.Width = 125;
            // 
            // dNgayNhap
            // 
            this.dNgayNhap.DataPropertyName = "dNgayNhap";
            this.dNgayNhap.HeaderText = "Ngày nhập";
            this.dNgayNhap.MinimumWidth = 6;
            this.dNgayNhap.Name = "dNgayNhap";
            this.dNgayNhap.Width = 125;
            // 
            // sMaNXB
            // 
            this.sMaNXB.DataPropertyName = "sMaNXB";
            this.sMaNXB.HeaderText = "Mã NXB";
            this.sMaNXB.MinimumWidth = 6;
            this.sMaNXB.Name = "sMaNXB";
            this.sMaNXB.Width = 125;
            // 
            // sMaNV
            // 
            this.sMaNV.DataPropertyName = "sMaNV";
            this.sMaNV.HeaderText = "Mã Nhân Viên";
            this.sMaNV.MinimumWidth = 6;
            this.sMaNV.Name = "sMaNV";
            this.sMaNV.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 111;
            this.label8.Text = "Mã NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 110;
            this.label3.Text = "Ngày Mua";
            // 
            // tbMaHD
            // 
            this.tbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHD.Location = new System.Drawing.Point(205, 57);
            this.tbMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaHD.Multiline = true;
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(200, 28);
            this.tbMaHD.TabIndex = 109;
            this.tbMaHD.TextChanged += new System.EventHandler(this.tbMaHD_TextChanged);
            this.tbMaHD.Validating += new System.ComponentModel.CancelEventHandler(this.tbMaHD_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 108;
            this.label2.Text = "Mã Hoá Đơn";
            // 
            // HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 622);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.btnThoatApp);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.tbMaNXB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_hoadon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMaHD);
            this.Controls.Add(this.label2);
            this.Name = "HoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hoá đơn bán";
            this.Load += new System.EventHandler(this.HoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Button btnThoatApp;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.TextBox tbMaNXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNV;
    }
}