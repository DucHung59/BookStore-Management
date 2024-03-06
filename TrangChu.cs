using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WDF_BTL;

namespace WDF_BTL
{
    public partial class TrangChu : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BTL"].ConnectionString;
        public TrangChu()
        {
            InitializeComponent();
        }


        private void msNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
        }

        private void msDSSach_Click(object sender, EventArgs e)
        {
            FormBaoCao form = new FormBaoCao();
            form.Show();
            form.showReport("", "Select_Sach", "DSSach.rpt");
        }

        private void msKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void msSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.Show();
        }

        private void msHDBan_Click(object sender, EventArgs e)
        {
            HoaDonBan hdb = new HoaDonBan();
            hdb.Show();
        }


        private void msCTHDBan_Click(object sender, EventArgs e)
        {
            DialogHDB hdb = new DialogHDB();
            hdb.ShowDialog();
        }

        private void msCTHDNhap_Click(object sender, EventArgs e)
        {
            DialogHDN hdn = new DialogHDN();
            hdn.ShowDialog();
        }

        private void msDSNV_Click(object sender, EventArgs e)
        {
            FormBaoCao form = new FormBaoCao();
            form.Show();
            form.showReport("", "Select_NV", "DSNV.rpt");
        }

        private void msDSKH_Click(object sender, EventArgs e)
        {
            FormBaoCao form = new FormBaoCao();
            form.Show();
            form.showReport("", "Select_KH", "DSKH.rpt");
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.Show();
        }

        private void chiTiếtBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTBan ctban = new CTBan();
            ctban.Show();
        }

        private void chiTiếtNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTNhap ctnhap = new CTNhap();
            ctnhap.Show();
        }

        private void msHDNhap_Click(object sender, EventArgs e)
        {
            HoaDonNhap hdn = new HoaDonNhap();
            hdn.Show();
        }
    }
}
