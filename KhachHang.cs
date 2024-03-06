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
using System.Data.SqlClient;

namespace WDF_BTL
{

    public partial class KhachHang : Form
    {
        private DataView dataView_gridView = new DataView();
        private string connectionString =
            ConfigurationManager.ConnectionStrings["BTL"].ConnectionString;

        ErrorProvider err = new ErrorProvider();
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();  
        }

        private void LoadDataToGridView(string filter ="")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "Select_KH";
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            
                            using (DataTable dt_gridView = new DataTable())
                            {
                                adapter.Fill(dt_gridView);
                                if (dt_gridView.Rows.Count > 0)
                                {
                                    dataView_gridView = dt_gridView.DefaultView;
                                    dgvKhachHang.AutoGenerateColumns = false;

                                    if (!string.IsNullOrEmpty(filter))
                                    {
                                        dataView_gridView.RowFilter = filter;
                                    }
                                    dgvKhachHang.DataSource = dataView_gridView;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbMaKH.Text =
            tbTenKH.Text =
            tbDiaChiKH.Text =
            tbSdtKH.Text = string.Empty;
            dtpNgaySinhKH.ResetText();
            cbbTonGiao.ResetText();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string idKH = tbMaKH.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "CheckPK_KH";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maKH", idKH);

                    connection.Open();
                    var idkh_sql = cmd.ExecuteScalar();
                    connection.Close();

                    if (idkh_sql == null)
                    {
                        //Mô hình ngắt kết nối
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            cmd.CommandText = "SELECT * FROM tblKhachHang";
                            cmd.CommandType = CommandType.Text;
                            adapter.SelectCommand = cmd;
                            using (DataTable dtKhachHang = new DataTable("tblKhachHang"))
                            {
                                adapter.Fill(dtKhachHang);
                                //add tung datatable vao dataset
                                using (DataSet dataSet = new DataSet())
                                {
                                    dataSet.Tables.Add(dtKhachHang);
                                    //them moi ban ghi vao datatable
                                    DataRow newRow = dtKhachHang.NewRow();
                                    newRow["sMaKH"] = tbMaKH.Text;
                                    newRow["sTenKH"] = tbTenKH.Text;
                                    newRow["sSDT"] = tbSdtKH.Text;
                                    newRow["sDiachi"] = tbDiaChiKH.Text;
                                    newRow["dNgaysinh"] = dtpNgaySinhKH.Value.ToString("yyyy/MM/d");
                                    //..
                                    dtKhachHang.Rows.Add(newRow);

                                    //them ban ghi vao CSDL bang lenh InsertCommand
                                    cmd.CommandText = "Insert_KH";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.
                                        Add("@maKH", SqlDbType.VarChar, 30, "sMaKH").Value = tbMaKH.Text;
                                    cmd.Parameters.
                                        Add("@tenKH", SqlDbType.NVarChar, 70, "sTenKH").Value = tbTenKH.Text;
                                    cmd.Parameters.
                                        Add("@sdt", SqlDbType.VarChar, 10, "sSDT").Value = tbSdtKH.Text;
                                    cmd.Parameters.
                                        Add("@diaChi", SqlDbType.NVarChar, 30, "sDiachi").Value = tbDiaChiKH.Text;
                                    cmd.Parameters.
                                        Add("@ngaySinh", SqlDbType.Date, 12, "dNgaySinh").Value = dtpNgaySinhKH.Value.ToString("yyyy/MM/d");
                                    adapter.InsertCommand = cmd;
                                    adapter.Update(dataSet, "tblKhachHang");
                                    LoadDataToGridView();
                                    MessageBox.Show("Thêm mới thành công!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã khách hàng " + idKH +" đã tồn tại!");
                    }
                }
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvKhachHang.CurrentRow.Index;

            tbMaKH.Text = dataView_gridView[index]["sMaKH"].ToString();
            tbTenKH.Text = dataView_gridView[index]["sTenKH"].ToString();
            tbDiaChiKH.Text = dataView_gridView[index]["sDiachi"].ToString();
            tbSdtKH.Text = dataView_gridView[index]["sSDT"].ToString();
            dtpNgaySinhKH.Text = dataView_gridView[index]["dNgaysinh"].ToString();
            cbbTonGiao.Text = dataView_gridView[index]["sTonGiao"].ToString();
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
                        cmd.CommandText = "Select * from tblKhachHang";
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dtKhachHang = new DataTable("tblKhachHang"))
                            {
                                adapter.Fill(dtKhachHang);
                                //add tung datatable vao dataset
                                using (DataSet dataSet = new DataSet())
                                {
                                    dataSet.Tables.Add(dtKhachHang);

                                    //Chinh sua du lieu trong dtSINHVIEN cua dataset
                                    //tim khoa chinh
                                    dtKhachHang.PrimaryKey = new DataColumn[] { dtKhachHang.Columns["sMaKH"] };
                                    DataRow row = dtKhachHang.Rows.Find(tbMaKH.Text);
                                    row["sMaKH"] = tbMaKH.Text;
                                    row["sTenKH"] = tbTenKH.Text;
                                    row["sSDT"] = tbSdtKH.Text;
                                    row["sDiachi"] = tbDiaChiKH.Text;
                                    row["dNgaysinh"] = dtpNgaySinhKH.Value.ToString("yyyy/MM/d");
                                    //..

                                    //them ban ghi vao CSDL bang lenh InsertCommand
                                    cmd.CommandText = "Update_KH";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.
                                        Add("@maKH", SqlDbType.VarChar, 30, "sMaKH").Value = tbMaKH.Text;
                                    cmd.Parameters.
                                        Add("@tenKH", SqlDbType.NVarChar, 70, "sTenKH").Value = tbTenKH.Text;
                                    cmd.Parameters.
                                        Add("@sdt", SqlDbType.VarChar, 10, "sSDT").Value = tbSdtKH.Text;
                                    cmd.Parameters.
                                        Add("@diaChi", SqlDbType.NVarChar, 30, "sDiachi").Value = tbDiaChiKH.Text;
                                    cmd.Parameters.
                                        Add("@ngaySinh", SqlDbType.Date, 12, "dNgaySinh").Value = dtpNgaySinhKH.Value.ToString("yyyy/MM/d");
                                    adapter.UpdateCommand = cmd;
                                    adapter.Update(dataSet, "tblKhachHang");
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int index = dgvKhachHang.CurrentRow.Index;
            string makh = dataView_gridView[index]["sMaKH"].ToString();
            try
            {
                //hien dialog de xac nhan 1 lan nua
                DialogResult dialog_delete = MessageBox.
                    Show("Bạn muốn xoá khách hàng " + makh + " thật không?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                if (dialog_delete == DialogResult.Yes)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        //khai bao command va cac thong so command de Select_tblKhachHang
                        using (SqlCommand cmd = sqlConnection.CreateCommand())
                        {
                            cmd.CommandText = "Select_KH";
                            cmd.CommandType = CommandType.StoredProcedure;
                            //khai bao adapter
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                //khai bao datatable, adapter.Fill(datatable)
                                using (DataTable dt_tblKhachHang = new DataTable("tblKhachHang"))
                                {
                                    adapter.Fill(dt_tblKhachHang);
                                    //add tung datatable vao dataset
                                    using (DataSet ds = new DataSet())
                                    {
                                        ds.Tables.Add(dt_tblKhachHang);
                                        dt_tblKhachHang.PrimaryKey = new DataColumn[] { dt_tblKhachHang.Columns["sMaKH"] };
                                        DataRow row = dt_tblKhachHang.Rows.Find(tbMaKH.Text);
                                        row.Delete();

                                        cmd.CommandText = "Delete_KH";
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.Add("@maKH", SqlDbType.NVarChar, 10, "sMaKH").Value = tbMaKH.Text;

                                        adapter.DeleteCommand = cmd;
                                        adapter.Update(ds, "tblKhachHang");

                                        MessageBox.Show("Đã Xoá!");
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filter = "sMaKH IS NOT NULL";
            if (!string.IsNullOrEmpty(tbMaKH.Text))
            {
                filter += string.Format(" AND sMaKH LIKE '%{0}%'", tbMaKH.Text);
            }
            if (!string.IsNullOrEmpty(tbTenKH.Text))
            {
                filter += string.Format(" AND sTenKH LIKE '%{0}%'", tbTenKH.Text);
            }

            LoadDataToGridView(filter);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            string reportFilter = "NOT(ISNULL({Select_KH.sMaKH}))";
            if (!string.IsNullOrEmpty(tbMaKH.Text))
            {
                reportFilter += string.Format(" AND {0} LIKE '*{1}*'", "{Select_KH.sMaKH}", tbMaKH.Text);
            }
            FormBaoCao form = new FormBaoCao();
            form.Show();
            form.showReport(reportFilter, "Select_KH", "DSKH.rpt");
        }

        private bool isPhoneNumber(string strValue)
        {
            foreach(char c in strValue)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void tbSdtKH_TextChanged(object sender, EventArgs e)
        {
            if(!isPhoneNumber(tbSdtKH.Text))
            {
                err.SetError(tbSdtKH, "Số điện thoại không đúng định dạng");
            }
            else
            {
                err.SetError(tbSdtKH, null);
            }
        }

        private void tbSdtKH_Validating(object sender, CancelEventArgs e)
        {
            if (!isPhoneNumber(tbSdtKH.Text))
            {
                e.Cancel = true;
                err.SetError(tbSdtKH, "Số điện thoại không đúng định dạng");
            }
            else
            {
                e.Cancel = false;
                err.SetError(tbSdtKH, null);
            }
        }

        private void cbbTonGiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string filter = "sMaKH IS NOT NULL";
            if (!string.IsNullOrEmpty(cbbTonGiao.Text))
            {
                filter += string.Format(" AND sTonGiao LIKE '%{0}%'", cbbTonGiao.Text);
            }
            LoadDataToGridView(filter);
        }

        private void btnInBaoCaoTK_Click(object sender, EventArgs e)
        {
            FormBaoCao form = new FormBaoCao();
            form.Show();
            form.showReport("", "Select_KH", "BaoCaoTK.rpt");
        }
    }
}
