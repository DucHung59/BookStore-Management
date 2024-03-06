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
    public partial class HoaDonNhap : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BTL"].ConnectionString;
        DataView dataView_gridView = new DataView();
        ErrorProvider errorProvider = new ErrorProvider();
        public HoaDonNhap()
        {
            InitializeComponent();
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void LoadDataToGridView(string filter = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "Select_HDNhap";
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            using (DataTable dt_gridView = new DataTable())
                            {
                                //dt_gridView.Clear();
                                adapter.SelectCommand = command;
                                adapter.Fill(dt_gridView);

                                if (dt_gridView.Rows.Count > 0)
                                {
                                    dataView_gridView = dt_gridView.DefaultView;
                                    dgv_hoadon.AutoGenerateColumns = false;
                                    //dgv_sinhvien.DataSource = dt_gridView;
                                    //Loc du lieu tu dataView
                                    if (!string.IsNullOrEmpty(filter))
                                    {
                                        dataView_gridView.RowFilter = filter;
                                    }
                                    dgv_hoadon.DataSource = dataView_gridView;
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

        private void dgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_hoadon.CurrentRow.Index;

            tbMaHD.Text = dataView_gridView[index]["sSoHDN"].ToString();
            dtpNgayNhap.Text = dataView_gridView[index]["dNgayNhap"].ToString();
            tbMaNV.Text = dataView_gridView[index]["sMaNV"].ToString();
            tbMaNXB.Text = dataView_gridView[index]["sMaNXB"].ToString();
        }

        private string check_maNVKH(string procheckNV, string values, string idCheck)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = procheckNV;
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "CheckPK_HDN";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@soHDN", tbMaHD.Text);
                    connection.Open();
                    var idhd_sql = command.ExecuteScalar();
                    connection.Close();
                    string idNV_sql = check_maNVKH("CheckPK_NV", "@maNV", tbMaNV.Text);
                    string idNXB_sql = check_maNVKH("CheckPK_NXB", "@maNXB", tbMaNXB.Text);
                    if (idhd_sql == null && idNXB_sql != null && idNV_sql != null)
                    {
                        string InsertHD = "Insert_HDNhap";
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                            {
                                sqlCommand.CommandText = InsertHD;
                                sqlCommand.CommandType = CommandType.StoredProcedure;

                                sqlCommand.Parameters.Add("@soHDN", SqlDbType.VarChar, 10).Value = tbMaHD.Text;
                                sqlCommand.Parameters.Add("@ngayNhap", SqlDbType.DateTime).Value = dtpNgayNhap.Value.ToString("yyyy/MM/d");
                                sqlCommand.Parameters.Add("@maNV", SqlDbType.VarChar, 10).Value = tbMaNV.Text;
                                sqlCommand.Parameters.Add("@maNXB", SqlDbType.VarChar, 10).Value = tbMaNXB.Text;

                                sqlConnection.Open();
                                sqlCommand.ExecuteNonQuery();
                                sqlConnection.Close();

                                LoadDataToGridView();
                                //layDSSV();
                                //Reset();
                                MessageBox.Show("Thêm thành công!");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, kiểm tra Mã Hoá Đơn, Mã NV, Mã KH có thể không TỒN TẠI");
                        return;
                    }

                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //int index = dgv_hoadon.CurrentRow.Index;
            //string idhdn = dataView_gridView[index]["sSoHDN"].ToString();
            //try
            //{
            //    //hien dialog de xac nhan 1 lan nua
            //    DialogResult dialog_delete = MessageBox.
            //        Show("Bạn muốn xoá khách hàng " + idhdn + " thật không?",
            //                "Warning",
            //                MessageBoxButtons.YesNo,
            //                MessageBoxIcon.Warning);
            //    if (dialog_delete == DialogResult.Yes)
            //    {
            //        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //        {
            //            using (SqlCommand cmd = sqlConnection.CreateCommand())
            //            {
            //                cmd.CommandText = "Delete_HDNhap";
            //                cmd.CommandType = CommandType.StoredProcedure;
            //                cmd.Parameters.
            //                    Add("@soHDN", SqlDbType.VarChar, 30, "sSoHDN").Value = tbMaHD.Text;
            //                sqlConnection.Open();
            //                cmd.ExecuteNonQuery();
            //                sqlConnection.Close();
            //                MessageBox.Show("Đã Xoá!");
            //                LoadDataToGridView();
            //            }
            //        }

            //    }
            //    else
            //    {
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            string idHDNhap = tbMaHD.Text;

            using (SqlConnection sqlConnection1 = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection1.CreateCommand())
                {
                    sqlCommand.CommandText = "CheckPK_HDN";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@soHDN", idHDNhap);

                    sqlConnection1.Open();
                    var idhdnhap_sql = sqlCommand.ExecuteScalar();
                    sqlConnection1.Close();

                    if (idhdnhap_sql != null)
                    {
                        try
                        {
                            //hien dialog de xac nhan 1 lan nua
                            DialogResult dialog_delete = MessageBox.
                                Show("Bạn có muốn xoá hoá đơn có mã " + idHDNhap + " không?",
                                        "Warning",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);

                            if (dialog_delete == DialogResult.Yes)
                            {
                                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                {
                                    using (SqlCommand cmd = sqlConnection.CreateCommand())
                                    {
                                        cmd.CommandText = "Select_HDNhap";
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                                        {
                                            //lay danh sach sinh vien vao DataTable
                                            using (DataTable dt_tblHoaDonNhap = new DataTable("tblHoaDonNhap"))
                                            {
                                                adapter.Fill(dt_tblHoaDonNhap);
                                                //add cac datatable vao dataset
                                                using (DataSet ds = new DataSet())
                                                {
                                                    ds.Tables.Add(dt_tblHoaDonNhap);
                                                    dt_tblHoaDonNhap.PrimaryKey = new DataColumn[] { dt_tblHoaDonNhap.Columns["sSoHDN"] };
                                                    DataRow dataRow = dt_tblHoaDonNhap.Rows.Find(tbMaHD.Text);
                                                    dataRow.Delete();

                                                    //xoa trong DB 
                                                    cmd.CommandText = "Delete_HDNhap";
                                                    cmd.CommandType = CommandType.StoredProcedure;
                                                    cmd.Parameters.Add("@soHDN", SqlDbType.NVarChar, 10, "sSoHDN").Value = tbMaHD.Text;

                                                    adapter.DeleteCommand = cmd;
                                                    adapter.Update(ds, "tblHoaDonNhap");
                                                    MessageBox.Show("Đã xoá!");
                                                    LoadDataToGridView();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã hoá đơn: " + idHDNhap + " không tồn tại");
                        return;
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string idHD = tbMaHD.Text;
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

                    if (idhd_sql != null)
                    {
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                using (SqlCommand command = connection.CreateCommand())
                                {
                                    command.CommandText = "Select_HDNhap";
                                    command.CommandType = CommandType.StoredProcedure;
                                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                    {
                                        using (DataTable dtHoaDon = new DataTable("tblHoaDonNhap"))
                                        {
                                            adapter.Fill(dtHoaDon);
                                            //add tung datatable vao dataset
                                            using (DataSet dataSet = new DataSet())
                                            {
                                                dataSet.Tables.Add(dtHoaDon);

                                                //Chinh sua du lieu trong dtHoaDon cua dataset
                                                //tim khoa chinh
                                                dtHoaDon.PrimaryKey = new DataColumn[] { dtHoaDon.Columns["sSoHDN"] };
                                                //dtSINHVIEN.PrimaryKey = new DataColumn[] { dtSINHVIEN.Columns["iMaSV"] };
                                                DataRow row = dtHoaDon.Rows.Find(tbMaHD.Text);
                                                row["dNgayNhap"] = dtpNgayNhap.Value.ToString("yyyy/MM/d");
                                                row["sMaNV"] = tbMaNV.Text;
                                                row["sMaNXB"] = tbMaNXB.Text;

                                                //thuc hien UpdateCommand
                                                command.CommandText = "Update_HDNhap";
                                                command.CommandType = CommandType.StoredProcedure;
                                                command.Parameters.Clear();
                                                command.Parameters.Add("@soHDN", SqlDbType.VarChar, 10, "sSoHDN").Value = tbMaHD.Text;
                                                command.Parameters.AddWithValue("@ngayNhap", dtpNgayNhap.Value.ToString("yyyy/MM/d"));
                                                command.Parameters.AddWithValue("@maNV", tbMaNV.Text);
                                                command.Parameters.AddWithValue("@maNXB", tbMaNXB.Text);
                                                adapter.UpdateCommand = command;
                                                adapter.Update(dataSet, "tblHoaDonNhap");
                                                MessageBox.Show("Cập nhật thành công!");

                                                LoadDataToGridView();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Da co loi xay ra" + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ma Hoa Don: " + idHD + " khong ton tai");
                        return;
                    }
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filter = "sSoHDN IS NOT NULL";
            if (!string.IsNullOrEmpty(tbMaHD.Text))
            {
                filter += string.Format(" AND sSoHDN LIKE '%{0}%'", tbMaHD.Text);
            }

            LoadDataToGridView(filter);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbMaHD.Text = tbMaNV.Text = tbMaNXB.Text = string.Empty;
            dtpNgayNhap.ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThoatApp_Click(object sender, EventArgs e)
        {
            DialogResult drThoat = MessageBox.Show("Bạn có chắc chắn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(drThoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tbMaHD_TextChanged(object sender, EventArgs e)
        {
            if (tbMaHD.Text.Length <= 0)
            {
                errorProvider.SetError(tbMaHD, "Mã hoá đơn không được để trống!!");
            }
        }

        private void tbMaHD_Validating(object sender, CancelEventArgs e)
        {
            if (tbMaHD.Text.Length <= 0)
            {
                errorProvider.SetError(tbMaHD, "Mã hoá đơn không được để trống!!");
            }
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "CheckPK_HDN";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@soHDN", tbMaHD.Text);

                    sqlConnection.Open();
                    var idhdb = cmd.ExecuteScalar();
                    sqlConnection.Close();
                    if (idhdb != null)
                    {
                        string reportFilter = "NOT(ISNULL({Select_HDNhapTongHop.sSoHDN}))";
                        if (!string.IsNullOrEmpty(tbMaHD.Text))
                        {
                            reportFilter += string.Format(" AND {0} LIKE '*{1}*'",
                                    "{Select_HDNhapTongHop.sSoHDN}", tbMaHD.Text);
                        }

                        FormBaoCao form = new FormBaoCao();
                        form.Show();
                        form.showReport(reportFilter, "Select_HDNhapTongHop", "CTHoaDonNhap.rpt");
                    }
                    else
                    {
                        MessageBox.Show("Mã hoá đơn " + tbMaHD.Text + " không tồn tại!");
                    }
                }
            }
        }
    }
}
