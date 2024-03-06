namespace WDF_BTL
{
    partial class TaiKhoan
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
            this.label6 = new System.Windows.Forms.Label();
            this.tMaKH = new System.Windows.Forms.Label();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThoatApp = new System.Windows.Forms.Button();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.clmTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Mật khẩu";
            // 
            // tMaKH
            // 
            this.tMaKH.AutoSize = true;
            this.tMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMaKH.Location = new System.Drawing.Point(40, 66);
            this.tMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tMaKH.Name = "tMaKH";
            this.tMaKH.Size = new System.Drawing.Size(90, 22);
            this.tMaKH.TabIndex = 30;
            this.tMaKH.Text = "Tài khoản";
            // 
            // tbMK
            // 
            this.tbMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMK.Location = new System.Drawing.Point(150, 95);
            this.tbMK.Margin = new System.Windows.Forms.Padding(2);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(200, 28);
            this.tbMK.TabIndex = 29;
            // 
            // tbTK
            // 
            this.tbTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTK.Location = new System.Drawing.Point(150, 63);
            this.tbTK.Margin = new System.Windows.Forms.Padding(2);
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(200, 28);
            this.tbTK.TabIndex = 28;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(598, 66);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(125, 40);
            this.btn_Xoa.TabIndex = 43;
            this.btn_Xoa.Text = "Xoá bỏ";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(469, 66);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(125, 40);
            this.btn_Them.TabIndex = 42;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(469, 111);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 40);
            this.btnLoad.TabIndex = 50;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(598, 111);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 40);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThoatApp
            // 
            this.btnThoatApp.Location = new System.Drawing.Point(503, 157);
            this.btnThoatApp.Name = "btnThoatApp";
            this.btnThoatApp.Size = new System.Drawing.Size(191, 57);
            this.btnThoatApp.TabIndex = 98;
            this.btnThoatApp.Text = "Thoát chương trình";
            this.btnThoatApp.UseVisualStyleBackColor = true;
            this.btnThoatApp.Click += new System.EventHandler(this.btnThoatApp_Click);
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTK,
            this.clmMK});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(27, 156);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 82;
            this.dgvTaiKhoan.RowTemplate.Height = 33;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(413, 267);
            this.dgvTaiKhoan.TabIndex = 99;
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
            // 
            // clmTK
            // 
            this.clmTK.DataPropertyName = "sTK";
            this.clmTK.HeaderText = "Tài khoản";
            this.clmTK.MinimumWidth = 6;
            this.clmTK.Name = "clmTK";
            this.clmTK.ReadOnly = true;
            // 
            // clmMK
            // 
            this.clmMK.DataPropertyName = "sMK";
            this.clmMK.HeaderText = "Mật khẩu";
            this.clmMK.MinimumWidth = 6;
            this.clmMK.Name = "clmMK";
            this.clmMK.ReadOnly = true;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.btnThoatApp);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tMaKH);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.tbTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tMaKH;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThoatApp;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMK;
    }
}