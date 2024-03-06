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
    public partial class NhanVien : Form
    {
        string connectionString = 
            ConfigurationManager.ConnectionStrings["BTL"].ConnectionString;
        DataView dataView_gridView = new DataView();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void LoadDataToGridView(string filter = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "Select_NV";
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {

                            using (DataTable dt_gridView = new DataTable())
                            {
                                adapter.Fill(dt_gridView);
                                if (dt_gridView.Rows.Count > 0)
                                {
                                    dataView_gridView = dt_gridView.DefaultView;
                                    dgvNhanVien.AutoGenerateColumns = false;

                                    if (!string.IsNullOrEmpty(filter))
                                    {
                                        dataView_gridView.RowFilter = filter;
                                    }
                                    dgvNhanVien.DataSource = dataView_gridView;
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



        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string idNV = tbMaNV.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "CheckPK_NV";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNV", idNV);

                    connection.Open();
                    var idkh_sql = cmd.ExecuteScalar();
                    connection.Close();

                    if (idkh_sql == null)
                    {
                        //Mô hình ngắt kết nối
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            cmd.CommandText = "SELECT * FROM tblNhanVien";
                            cmd.CommandType = CommandType.Text;
                            adapter.SelectCommand = cmd;
                            using (DataTable dtNhanVien = new DataTable("tblNhanVien"))
                            {
                                adapter.Fill(dtNhanVien);
                                //add tung datatable vao dataset
                                using (DataSet dataSet = new DataSet())
                                {
                                    dataSet.Tables.Add(dtNhanVien);
                                    //them moi ban ghi vao datatable
                                    DataRow newRow = dtNhanVien.NewRow();
                                    newRow["sMaNV"] = tbMaNV.Text;
                                    newRow["sTenNV"] = tbTenNV.Text;
                                    newRow["sSDT"] = tbSdtNV.Text;
                                    newRow["sDiachi"] = tbDiaChiNV.Text;
                                    newRow["dNgaysinh"] = dtpNgaySinhNV.Value.ToString("yyyy/MM/d");
                                    newRow["sCMND"] = tbCMNDNV.Text;
                                    //..
                                    dtNhanVien.Rows.Add(newRow);

                                    //them ban ghi vao CSDL bang lenh InsertCommand
                                    cmd.CommandText = "Insert_NV";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.
                                        Add("@maNV", SqlDbType.VarChar, 30, "sMaNV").Value = tbMaNV.Text;
                                    cmd.Parameters.
                                        Add("@tenNV", SqlDbType.NVarChar, 70, "sTenNV").Value = tbTenNV.Text;
                                    cmd.Parameters.
                                        Add("@sdt", SqlDbType.VarChar, 10, "sSDT").Value = tbSdtNV.Text;
                                    cmd.Parameters.
                                        Add("@diaChi", SqlDbType.NVarChar, 30, "sDiachi").Value = tbDiaChiNV.Text;
                                    cmd.Parameters.
                                        Add("@ngaySinh", SqlDbType.Date, 12, "dNgaySinh").Value = dtpNgaySinhNV.Value.ToString("yyyy/MM/d");
                                    cmd.Parameters.Add("@cmnd", SqlDbType.VarChar, 10, "sCMND").Value = tbCMNDNV.Text;
                                    adapter.InsertCommand = cmd;
                                    adapter.Update(dataSet, "tblNhanVien");
                                    LoadDataToGridView();
                                    MessageBox.Show("Thêm mới thành công!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên " + idNV + " đã tồn tại!");
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbMaNV.Text =
            tbTenNV.Text = 
            tbSdtNV.Text =
            tbDiaChiNV.Text = 
            tbCMNDNV.Text = string.Empty;
            dtpNgaySinhNV.ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int index = dgvNhanVien.CurrentRow.Index;
            string manv = dataView_gridView[index]["sMaNV"].ToString();
            try
            {
                //hien dialog de xac nhan 1 lan nua
                DialogResult dialog_delete = MessageBox.
                    Show("Bạn muốn xoá khách hàng " + manv + " thật không?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                if (dialog_delete == DialogResult.Yes)
                {
                    //using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    //{
                    //    using (SqlCommand cmd = sqlConnection.CreateCommand())
                    //    {
                    //        cmd.CommandText = "Delete_NV";
                    //        cmd.CommandType = CommandType.StoredProcedure;
                    //        cmd.Parameters.
                    //            Add("@maNV", SqlDbType.VarChar, 30, "sMaNV").Value = tbMaNV.Text;
                    //        sqlConnection.Open();
                    //        cmd.ExecuteNonQuery();
                    //        sqlConnection.Close();
                    //        MessageBox.Show("Đã Xoá!");
                    //        LoadDataToGridView();
                    //    }
                    //}
                    //khai bao connection
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        //khai bao command va cac thong so command de Select_tblNhanVien
                        using (SqlCommand cmd = sqlConnection.CreateCommand())
                        {
                            cmd.CommandText = "Select_NV";
                            cmd.CommandType = CommandType.StoredProcedure;
                            //khai bao adapter
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                //khai bao datatable, adapter.Fill(datatable)
                                using (DataTable tblNhanVien = new DataTable("tblNhanVien"))
                                {
                                    adapter.Fill(tblNhanVien);
                                    //add tung datatable vao dataset
                                    using (DataSet ds = new DataSet())
                                    {
                                        ds.Tables.Add(tblNhanVien);
                                        tblNhanVien.PrimaryKey = new DataColumn[] { tblNhanVien.Columns["sMaNV"] };
                                        DataRow row = tblNhanVien.Rows.Find(tbMaNV.Text);
                                        row.Delete();

                                        cmd.CommandText = "Delete_NV";
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.Add("@maNV", SqlDbType.NVarChar, 10, "sMaNV").Value = tbMaNV.Text;

                                        adapter.DeleteCommand = cmd;
                                        adapter.Update(ds, "tblNhanVien");
                                        
                                        MessageBox.Show("Đã Xoá!");
                                        LoadDataToGridView();
                                    }

                                }
                            }

                        }
                    }

                    
                    
                    
                    //Tim khoa chinh can xoa
                    //DataTable dt = new DataTable();
                    //dt.PrimaryKey = new DataColumn[] { dt.Columns["sMaSV"] };
                    //DataRow row = dt.Rows.Find(tb_maSV.Text);
                    //row.Delete();
                    //thuc hien DeleteCommand va adapter.Update(dataset)
                    //LoadDataToGridView();
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
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filter = "sMaNV IS NOT NULL";
            if (!string.IsNullOrEmpty(tbMaNV.Text))
            {
                filter += string.Format(" AND sMaNV LIKE '%{0}%'", tbMaNV.Text);
            }
            if (!string.IsNullOrEmpty(tbTenNV.Text))
            {
                filter += string.Format(" AND sTenNV LIKE '%{0}%'", tbTenNV.Text);
            }

            LoadDataToGridView(filter);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                //Sử dụng mô hình ngắt kết nối
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "Select * from tblNhanVien";
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dtKhachHang = new DataTable("tblNhanVien"))
                            {
                                adapter.Fill(dtKhachHang);
                                //add tung datatable vao dataset
                                using (DataSet dataSet = new DataSet())
                                {
                                    dataSet.Tables.Add(dtKhachHang);

                                    //Chinh sua du lieu trong dtSINHVIEN cua dataset
                                    //tim khoa chinh
                                    dtKhachHang.PrimaryKey = new DataColumn[] { dtKhachHang.Columns["sMaNV"] };
                                    DataRow row = dtKhachHang.Rows.Find(tbMaNV.Text);
                                    row["sMaNV"] = tbMaNV.Text;
                                    row["sTenNV"] = tbTenNV.Text;
                                    row["sSDT"] = tbSdtNV.Text;
                                    row["sDiachi"] = tbDiaChiNV.Text;
                                    row["dNgaysinh"] = dtpNgaySinhNV.Value.ToString("yyyy/MM/d");
                                    row["sCMND"] = tbCMNDNV.Text;
                                    //..

                                    //them ban ghi vao CSDL bang lenh InsertCommand
                                    cmd.CommandText = "Update_NV";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.
                                        Add("@maNV", SqlDbType.VarChar, 30, "sMaNV").Value = tbMaNV.Text;
                                    cmd.Parameters.
                                        Add("@tenNV", SqlDbType.NVarChar, 70, "sTenNV").Value = tbTenNV.Text;
                                    cmd.Parameters.
                                        Add("@sdt", SqlDbType.VarChar, 10, "sSDT").Value = tbSdtNV.Text;
                                    cmd.Parameters.
                                        Add("@diaChi", SqlDbType.NVarChar, 30, "sDiachi").Value = tbDiaChiNV.Text;
                                    cmd.Parameters.
                                        Add("@ngaySinh", SqlDbType.Date, 12, "dNgaySinh").Value = dtpNgaySinhNV.Value.ToString("yyyy/MM/d");
                                    cmd.Parameters.Add("@cmnd", SqlDbType.VarChar, 10, "sCMND").Value = tbCMNDNV.Text;
                                    adapter.UpdateCommand = cmd;
                                    adapter.Update(dataSet, "tblNhanVien");
                                    LoadDataToGridView();
                                    MessageBox.Show("Cập nhật thành công!");
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

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNhanVien.CurrentRow.Index;

            tbMaNV.Text = dataView_gridView[index]["sMaNV"].ToString();
            tbTenNV.Text = dataView_gridView[index]["sTenNV"].ToString();
            tbDiaChiNV.Text = dataView_gridView[index]["sDiachi"].ToString();
            tbSdtNV.Text = dataView_gridView[index]["sSDT"].ToString();
            tbCMNDNV.Text = dataView_gridView[index]["sCMND"].ToString();
            dtpNgaySinhNV.Text = dataView_gridView[index]["dNgaysinh"].ToString();
        }

        private void btnThoatApp_Click(object sender, EventArgs e)
        {
            DialogResult drThoat = MessageBox.Show("Bạn có chắc chắn thoát không?", "Quản lý Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drThoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            string reportFilter = "NOT(ISNULL({Select_NV.sMaNV}))";
            if(!string.IsNullOrEmpty(tbMaNV.Text))
            {
                reportFilter += string.Format(" AND {0} LIKE '*{1}*'", "{Select_NV.sMaNV}", tbMaNV.Text);
            }


            FormBaoCao form = new FormBaoCao();
            form.Show();
            form.showReport(reportFilter, "Select_NV", "DSNV.rpt");
        }
    }
}
