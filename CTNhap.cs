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
    public partial class CTNhap : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BTL"].ConnectionString;
        DataTable dt_combobox = new DataTable();
        DataView dataView_gridView = new DataView();
        public CTNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CTNhap_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();

            LoadDataToGridView();
        }


        private void LoadDataToComboBox()
        {
            try
            {
                //Đoạn lệnh cần thực hiện
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandText = "Select sMaSach from tblSach";
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = command;
                            adapter.Fill(dt_combobox);
                            //Hiển thị dữ liệu từ dataTable lên Combobox
                            if (dt_combobox.Rows.Count > 0)
                            {
                                //Cách 1: bound
                                //cb_malop.DataSource = dataTable;
                                //cb_malop.ValueMember = "sMaLop";
                                //cb_malop.DisplayMember = "sMaLop";


                                //Cách 2: unbound
                                foreach (DataRow row in dt_combobox.Rows)
                                {
                                    cbMaSach.Items.Add(row["sMaSach"]);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Khong ton tai ban ghi nao");
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void LoadDataToGridView(string filter = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "Select_CTHDNhap";
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {

                            using (DataTable dt_gridView = new DataTable())
                            {
                                adapter.Fill(dt_gridView);
                                if (dt_gridView.Rows.Count > 0)
                                {
                                    dataView_gridView = dt_gridView.DefaultView;
                                    dgv_cthoadon.AutoGenerateColumns = false;

                                    if (!string.IsNullOrEmpty(filter))
                                    {
                                        dataView_gridView.RowFilter = filter;
                                    }
                                    dgv_cthoadon.DataSource = dataView_gridView;
                                }
                                else
                                {
                                    MessageBox.Show("Khong ton tai du lieu!");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbMaSach.SelectedIndex;
            string masach = dt_combobox.Rows[index]["sMaSach"].ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select_TenSach";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@maSach", masach);

                    connection.Open();
                    var a = command.ExecuteScalar();
                    connection.Close();

                    tbTenSach.Text = a.ToString();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbSoHD.Text = tbSoLuongNhap.Text = tbTenSach.Text = tbDonGia.Text = string.Empty;
            cbMaSach.ResetText();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void dgv_cthoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dgv_cthoadon.CurrentRow.Index;

            tbSoHD.Text = dataView_gridView[index]["sSoHDN"].ToString();
            cbMaSach.Text = dataView_gridView[index]["sMaSach"].ToString();
            tbSoLuongNhap.Text = dataView_gridView[index]["iSoLuongNhap"].ToString();
            tbDonGia.Text = dataView_gridView[index]["fDonGia"].ToString();
        }

        private string check(string procCheck, string values, string idCheck)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = procCheck;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue(values, idCheck);
                    sqlConnection.Open();
                    string idCHECK = (string)sqlCommand.ExecuteScalar();
                    sqlConnection.Close();
                    return idCHECK;
                }
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "CheckPK_HDN";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@soHDN", tbSoHD.Text);
                        connection.Open();
                        var idhd_sql = command.ExecuteScalar();
                        connection.Close();

                        var idsach = check("CheckPK_Sach", "@maSach", cbMaSach.Text);
                        if (idhd_sql != null)
                        {
                            if (idsach != null)
                            {
                                string InsertHD = "Insert_CTHDNhap";
                                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                {
                                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                                    {
                                        sqlCommand.CommandText = InsertHD;
                                        sqlCommand.CommandType = CommandType.StoredProcedure;

                                        sqlCommand.Parameters.Add("@soHD", SqlDbType.VarChar, 10).Value = tbSoHD.Text;

                                        sqlCommand.Parameters.Add("@maSach", SqlDbType.VarChar).Value = cbMaSach.Text;
                                        sqlCommand.Parameters.Add("@sl", SqlDbType.Int, 10).Value = tbSoLuongNhap.Text;
                                        sqlCommand.Parameters.Add("@donGia", SqlDbType.Float, 10).Value = tbDonGia.Text;

                                        sqlConnection.Open();
                                        sqlCommand.ExecuteNonQuery();
                                        sqlConnection.Close();

                                        LoadDataToGridView();
                                        MessageBox.Show("Thêm thành công!");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không có sách tương ứng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không có hoá đơn " + tbSoHD.Text + " tương ứng!");
                            return;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra!" + ex.Message);
                throw;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "CheckPK_HDN";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@soHDN", tbSoHD.Text);

                        sqlConnection.Open();
                        var idhd_sql = sqlCommand.ExecuteScalar();
                        sqlConnection.Close();

                        string idS_sql = check("CheckPK_Sach", "@maSach", cbMaSach.Text);
                        if (idhd_sql != null)
                        {
                            if (idS_sql != null)
                            {
                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    using (SqlCommand command = connection.CreateCommand())
                                    {
                                        command.CommandText = "Update_CTHDNhap";
                                        command.CommandType = CommandType.StoredProcedure;
                                        command.Parameters.Clear();

                                        command.Parameters.Add("@soHD", SqlDbType.VarChar, 10).Value = tbSoHD.Text;
                                        command.Parameters.Add("@maSach", SqlDbType.VarChar, 10).Value = cbMaSach.Text;
                                        command.Parameters.Add("@sl", SqlDbType.Int).Value = tbSoLuongNhap.Text;
                                        command.Parameters.Add("@donGia", SqlDbType.Float).Value = tbDonGia.Text;

                                        connection.Open();
                                        command.ExecuteNonQuery();
                                        connection.Close();

                                        LoadDataToGridView();
                                        MessageBox.Show("Cập nhật thành công");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mã sách : " + cbMaSach.Text + " không tồn tại!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã hóa đơn : " + tbSoHD.Text + " không tồn tại!");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra" + ex);

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string idHD = tbSoHD.Text;
            string idSach = cbMaSach.Text;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "CheckPK_HDN";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@soHDN", idHD);

                        sqlConnection.Open();
                        var idhd_sql = sqlCommand.ExecuteScalar();
                        sqlConnection.Close();

                        string idS_sql = check("CheckPK_Sach", "@maSach", idSach);
                        if (idhd_sql != null)
                        {
                            if (idS_sql != null)
                            {
                                DialogResult dialog_delete = MessageBox.
                                Show(" Bạn có muốn xóa thật không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (dialog_delete == DialogResult.Yes)
                                {
                                    using (SqlConnection connection = new SqlConnection(connectionString))
                                    {
                                        using (SqlCommand command = connection.CreateCommand())
                                        {
                                            command.CommandText = "Delete_CTHDNhap";
                                            command.CommandType = CommandType.StoredProcedure;
                                            command.Parameters.Clear();

                                            command.Parameters.Add("@soHD", SqlDbType.VarChar, 10).Value = tbSoHD.Text;
                                            command.Parameters.Add("@maSach", SqlDbType.VarChar, 10).Value = cbMaSach.Text;

                                            connection.Open();
                                            command.ExecuteNonQuery();
                                            connection.Close();

                                            LoadDataToGridView();
                                            MessageBox.Show("Xóa thành công!");
                                        }
                                    }
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mã sách : " + idSach + " không tồn tại!");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã hóa đơn : " + idHD + " không tồn tại!");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra" + ex);

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filter = "sSoHDN IS NOT NULL and sMaSach IS NOT NULL";
            if (!string.IsNullOrEmpty(tbSoHD.Text))
            {
                filter += string.Format(" AND sSoHDN LIKE '%{0}%'", tbSoHD.Text);
            }
            if (!string.IsNullOrEmpty(cbMaSach.Text))
            {
                filter += string.Format(" AND sMaSach LIKE '%{0}%'", cbMaSach.Text);
            }

            LoadDataToGridView(filter);
        }

        private void btnThoatApp_Click(object sender, EventArgs e)
        {
            DialogResult drThoat = MessageBox.Show("Bạn có chắc chắn thoát chương trình không?", "Quản lý sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (drThoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
