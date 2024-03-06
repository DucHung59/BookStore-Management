using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDF_BTL
{
    public partial class Login : Form
    {
        String connectionString =
           ConfigurationManager.ConnectionStrings["BTL"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void cbHien_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHien.Checked == true)
            {
                tbMK.PasswordChar = '\0';
            }
            else
            {
                tbMK.PasswordChar = '*';
            }
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = tbTK.Text;
            string mk = tbMK.Text;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "CheckPK_TK";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@tk", tk);
                        sqlCommand.Parameters.AddWithValue("@mk", mk);

                        sqlConnection.Open();
                        var checkTK = sqlCommand.ExecuteScalar();
                        sqlConnection.Close();

                        if (checkTK == null)
                        {
                            MessageBox.Show("Tên đăng nhâp hoặc mật khẩu không chính xác!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            TrangChu trangChu = new TrangChu();
                            trangChu.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra" + ex);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không!", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            else
            {
                Application.Exit();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void tbTK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
            {
                tbMK.Focus();
            }
        }

        private void tbMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Up")
            {
                tbTK.Focus();
            }
        }
    }
}
