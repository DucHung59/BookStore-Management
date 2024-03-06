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
    public partial class HoaDonBan : Form
    {
        string connectionString =
            ConfigurationManager.ConnectionStrings["BTL"].ConnectionString;
        DataView dataView_gridView = new DataView();
        ErrorProvider errorProvider = new ErrorProvider();
        public HoaDonBan()
        {
            InitializeComponent();
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
            string idNV = tbMaNV.Text;
            string idKH = tbMaKH.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "CheckPK_HDBan";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@maHD", tbMaHD.Text);
                    connection.Open();
                    var idhd_sql = command.ExecuteScalar();
                    connection.Close();
                    string idNV_sql = check_maNVKH("CheckPK_NV", "@maNV", idNV);
                    string idKH_sql = check_maNVKH("CheckPK_KH", "@maKH", idKH);
                    if (idhd_sql == null && idNV_sql != null && idKH_sql != null)
                    {
                        string InsertHD = "Insert_HDBan";
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                            {
                                sqlCommand.CommandText = InsertHD;
                                sqlCommand.CommandType = CommandType.StoredProcedure;

                                sqlCommand.Parameters.Add("@maHD", SqlDbType.VarChar, 10).Value = tbMaHD.Text;

                                sqlCommand.Parameters.Add("@ngayMua", SqlDbType.DateTime).Value = dtpNgayMua.Value.ToString("yyyy/MM/d");
                                sqlCommand.Parameters.Add("@maNV", SqlDbType.VarChar, 10).Value = tbMaNV.Text;
                                sqlCommand.Parameters.Add("@maKH", SqlDbType.VarChar, 10).Value = tbMaKH.Text;

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
                    else if (idKH_sql==null) {
                        DialogResult drCheckKH = MessageBox.Show("Bạn có muốn thêm mới khách hàng?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (drCheckKH == DialogResult.Yes)
                        {
                            KhachHang kh = new KhachHang();
                            kh.Show();
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

        private void dgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_hoadon.CurrentRow.Index;

            tbMaHD.Text = dataView_gridView[index]["sSoHD"].ToString();
            dtpNgayMua.Text = dataView_gridView[index]["dNgayMua"].ToString();
            tbMaNV.Text = dataView_gridView[index]["sMaNV"].ToString();
            tbMaKH.Text = dataView_gridView[index]["sMaKH"].ToString();
        }

        private void LoadDataToGridView(string filter = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "Select_HDBan";
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

        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string idHD = tbMaHD.Text;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "CheckPK_HDBan";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@maHD", idHD);

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
                                    command.CommandText = "Select_HDBan";
                                    command.CommandType = CommandType.StoredProcedure;
                                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                    {
                                        using (DataTable dtHoaDon = new DataTable("tblHoaDonBan"))
                                        {
                                            adapter.Fill(dtHoaDon);
                                            //add tung datatable vao dataset
                                            using (DataSet dataSet = new DataSet())
                                            {
                                                dataSet.Tables.Add(dtHoaDon);

                                                //Chinh sua du lieu trong dtHoaDon cua dataset
                                                //tim khoa chinh
                                                dtHoaDon.PrimaryKey = new DataColumn[] { dtHoaDon.Columns["sSoHD"] };
                                                //dtSINHVIEN.PrimaryKey = new DataColumn[] { dtSINHVIEN.Columns["iMaSV"] };
                                                DataRow row = dtHoaDon.Rows.Find(tbMaHD.Text);
                                                row["dNgayMua"] = dtpNgayMua.Value.ToString("yyyy/MM/d");
                                                row["sMaNV"] = tbMaNV.Text;
                                                row["sMaKH"] = tbMaKH.Text;

                                                //thuc hien UpdateCommand
                                                command.CommandText = "Update_HDBan";
                                                command.CommandType = CommandType.StoredProcedure;
                                                command.Parameters.Clear();
                                                command.Parameters.Add("@maHD", SqlDbType.VarChar, 10, "sSoHD").Value = tbMaHD.Text;
                                                command.Parameters.AddWithValue("@ngayMua", dtpNgayMua.Value.ToString("yyyy/MM/d"));
                                                command.Parameters.AddWithValue("@maNV", tbMaNV.Text);
                                                command.Parameters.AddWithValue("@maKH", tbMaKH.Text);
                                                adapter.UpdateCommand = command;
                                                adapter.Update(dataSet, "tblHoaDonBan");
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //int index = dgv_hoadon.CurrentRow.Index;
            //string idhdb = dataView_gridView[index]["sSoHD"].ToString();
            //try
            //{
            //    //hien dialog de xac nhan 1 lan nua
            //    DialogResult dialog_delete = MessageBox.
            //        Show("Bạn muốn xoá khách hàng " + idhdb + " thật không?",
            //                "Warning",
            //                MessageBoxButtons.YesNo,
            //                MessageBoxIcon.Warning);
            //    if (dialog_delete == DialogResult.Yes)
            //    {
            //        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //        {
            //            using (SqlCommand cmd = sqlConnection.CreateCommand())
            //            {
            //                cmd.CommandText = "Delete_HDBan";
            //                cmd.CommandType = CommandType.StoredProcedure;
            //                cmd.Parameters.
            //                    Add("@maHD", SqlDbType.VarChar, 30, "sSoHD").Value = tbMaHD.Text;
            //                sqlConnection.Open();
            //                cmd.ExecuteNonQuery();
            //                sqlConnection.Close();
            //                MessageBox.Show("Đã Xoá!");
            //                LoadDataToGridView();
            //            }
            //        }
            //        //khai bao connection
            //        //khai bao command va cac thong so command de Select_tblSINHVIEN
            //        //khai bao adapter
            //        //khai bao datatable, adapter.Fill(datatable)
            //        //add tung datatable vao dataset
            //        //Tim khoa chinh can xoa
            //        //DataTable dt = new DataTable();
            //        //dt.PrimaryKey = new DataColumn[] { dt.Columns["sMaSV"] };
            //        //DataRow row = dt.Rows.Find(tb_maSV.Text);
            //        //row.Delete();
            //        //thuc hien DeleteCommand va adapter.Update(dataset)
            //        //LoadDataToGridView();
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

            string idHDBan = tbMaHD.Text;

            using (SqlConnection sqlConnection1 = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection1.CreateCommand())
                {
                    sqlCommand.CommandText = "CheckPK_HDBan";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@maHD", idHDBan);

                    sqlConnection1.Open();
                    var idhdban_sql = sqlCommand.ExecuteScalar();
                    sqlConnection1.Close();

                    if (idhdban_sql != null)
                    {
                        try
                        {
                            //hien dialog de xac nhan 1 lan nua
                            DialogResult dialog_delete = MessageBox.
                                Show("Bạn có muốn xoá hoá đơn có mã " + idHDBan + " không?",
                                        "Warning",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);

                            if (dialog_delete == DialogResult.Yes)
                            {
                                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                {
                                    using (SqlCommand cmd = sqlConnection.CreateCommand()) {
                                        cmd.CommandText = "Select_HDBan";
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                                        {
                                            //lay danh sach sinh vien vao DataTable
                                            using (DataTable dt_tblHoaDonBan = new DataTable("tblHoaDonBan"))
                                            {
                                                adapter.Fill(dt_tblHoaDonBan);
                                                //add cac datatable vao dataset
                                                using (DataSet ds = new DataSet())
                                                {
                                                    ds.Tables.Add(dt_tblHoaDonBan);
                                                    dt_tblHoaDonBan.PrimaryKey = new DataColumn[] { dt_tblHoaDonBan.Columns["sSoHD"] };
                                                    DataRow dataRow = dt_tblHoaDonBan.Rows.Find(idHDBan);
                                                    dataRow.Delete();

                                                    //xoa trong DB 
                                                    cmd.CommandText = "Delete_HDBan";
                                                    cmd.CommandType = CommandType.StoredProcedure;
                                                    cmd.Parameters.Add("@maHD", SqlDbType.NVarChar, 10, "sSoHD").Value = tbMaHD.Text;

                                                    adapter.DeleteCommand = cmd;
                                                    adapter.Update(ds, "tblHoaDonBan");
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
                        MessageBox.Show("Mã hoá đơn: " + idHDBan + " không tồn tại");
                        return;
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filter = "sSoHD IS NOT NULL";
            if (!string.IsNullOrEmpty(tbMaHD.Text))
            {
                filter += string.Format(" AND sSoHD LIKE '%{0}%'", tbMaHD.Text);
            }

            LoadDataToGridView(filter);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbMaHD.Text = 
            tbMaNV.Text = 
            tbMaKH.Text = string.Empty;
            dtpNgayMua.ResetText();

            tbMaHD.Focus();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThoatApp_Click(object sender, EventArgs e)
        {
            DialogResult drThoat = MessageBox.Show("Bạn có chắc chắn không?", "Quản lý hoá đơn bán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(drThoat== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "CheckPK_HDBan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maHD",tbMaHD.Text);
                    sqlConnection.Open();
                    var idhdb = cmd.ExecuteScalar();
                    sqlConnection.Close();
                    if(idhdb != null)
                    {
                        string reportFilter = "NOT(ISNULL({Select_HDBanTongHop.sSoHD}))";
                        if (!string.IsNullOrEmpty(tbMaHD.Text))
                        {
                            reportFilter += string.Format(" AND {0} LIKE '*{1}*'",
                                    "{Select_HDBanTongHop.sSoHD}", tbMaHD.Text);
                        }

                        FormBaoCao hoadon = new FormBaoCao();
                        hoadon.Show();
                        hoadon.showReport(reportFilter, "Select_HDBanTongHop", "CTHoaDonBan.rpt");
                    }
                    else
                    {
                        MessageBox.Show("Mã hoá đơn " + tbMaHD.Text + " không tồn tại!");
                    }
                }
            }
            
        }

        private void tbMaHD_TextChanged(object sender, EventArgs e)
        {
            if(tbMaHD.Text.Length <= 0) {
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
    }
}
