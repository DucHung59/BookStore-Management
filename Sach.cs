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
    public partial class Sach : Form
    {

        string connectionString =
            ConfigurationManager.ConnectionStrings["BTL"].ConnectionString;
        DataView dataView_gridView = new DataView();
        DataTable dt_comboBox = new DataTable();
        public Sach()
        {
            InitializeComponent();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            LoadData_Combobox_MaNXB();

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
                        command.CommandText = "Select_Sach";
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {

                            using (DataTable dt_gridView = new DataTable())
                            {
                                adapter.Fill(dt_gridView);
                                if (dt_gridView.Rows.Count > 0)
                                {
                                    dataView_gridView = dt_gridView.DefaultView;
                                    dgvSach.AutoGenerateColumns = false;

                                    if (!string.IsNullOrEmpty(filter))
                                    {
                                        dataView_gridView.RowFilter = filter;
                                    }
                                    dgvSach.DataSource = dataView_gridView;
                                }
                                else
                                {
                                    MessageBox.Show("Không tồn tại dữ liệu!");
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

        private void cbMaNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbMaNXB.SelectedIndex;
            string malop = dt_comboBox.Rows[index]["sMaNXB"].ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select_TenNXB";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@maNXB", malop);

                    connection.Open();
                    var a = command.ExecuteScalar();
                    connection.Close();

                    tbTenNXB.Text = a.ToString();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void LoadData_Combobox_MaNXB()
        {
            string querySelect = "SELECT * FROM tblNhaXuatBan";
            try
            {
                //Đoạn lệnh cần thực hiện
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandText = querySelect;
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = command;
                            adapter.Fill(dt_comboBox);
                            //Hiển thị dữ liệu từ dataTable lên Combobox
                            if (dt_comboBox.Rows.Count > 0)
                            {
                                //Cách 1: bound
                                //cb_malop.DataSource = dataTable;
                                //cb_malop.ValueMember = "sMaLop";
                                //cb_malop.DisplayMember = "sMaLop";


                                //Cách 2: unbound
                                foreach (DataRow row in dt_comboBox.Rows)
                                {
                                    cbMaNXB.Items.Add(row["sMaNXB"]);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tồn tại bản ghi nào!");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbMaSach.Text =
            tbTenSach.Text =
            tbDonGia.Text =
            tbTenTG.Text = tbTheLoai.Text = string.Empty;
            cbMaNXB.ResetText();

        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSach.CurrentRow.Index;

            tbMaSach.Text = dataView_gridView[index]["sMaSach"].ToString();
            tbTenSach.Text = dataView_gridView[index]["sTenSach"].ToString();
            tbDonGia.Text = dataView_gridView[index]["fDonGia"].ToString();
            tbTenTG.Text = dataView_gridView[index]["sTenTG"].ToString();
            tbTheLoai.Text = dataView_gridView[index]["sTheLoai"].ToString();
            cbMaNXB.Text = dataView_gridView[index]["sMaNXB"].ToString();
            tbTenNXB.Text = dataView_gridView[index]["sTenNXB"].ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filter = "sMaSach IS NOT NULL";
            if (!string.IsNullOrEmpty(tbMaSach.Text))
            {
                filter += string.Format(" AND sMaSach LIKE '%{0}%'", tbMaSach.Text);
            }
            if (!string.IsNullOrEmpty(tbTenSach.Text))
            {
                filter += string.Format(" AND sTenSach LIKE '%{0}%'", tbTenSach.Text);
            }

            LoadDataToGridView(filter);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int index = dgvSach.CurrentRow.Index;
            string manv = dataView_gridView[index]["sMaSach"].ToString();
            try
            {
                //hien dialog de xac nhan 1 lan nua
                DialogResult dialog_delete = MessageBox.
                    Show("Bạn muốn xoá sách " + manv + " thật không?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                if (dialog_delete == DialogResult.Yes)
                {
                    //using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    //{
                    //    using (SqlCommand cmd = sqlConnection.CreateCommand())
                    //    {
                    //        cmd.CommandText = "Delete_Sach";
                    //        cmd.CommandType = CommandType.StoredProcedure;
                    //        cmd.Parameters.
                    //            Add("@maSach", SqlDbType.VarChar, 30, "sMaSach").Value = tbMaSach.Text;
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
                        using (SqlCommand command = sqlConnection.CreateCommand())
                        {
                            command.CommandText = "Select_Sach";
                            command.CommandType = CommandType.StoredProcedure;
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                using (DataTable tblSach = new DataTable("tblSach"))
                                {
                                    adapter.Fill(tblSach);
                                    using (DataSet dataSet = new DataSet())
                                    {
                                        dataSet.Tables.Add(tblSach);
                                        tblSach.PrimaryKey = new DataColumn[] { tblSach.Columns["sMaSach"] };
                                        DataRow row = tblSach.Rows.Find(tbMaSach.Text);
                                        row.Delete();

                                        command.CommandText = "Delete_Sach";
                                        command.CommandType = CommandType.StoredProcedure;
                                        command.Parameters.Add("@maSach", SqlDbType.VarChar, 10, "sMaSach").Value = tbMaSach.Text;

                                        adapter.DeleteCommand = command;
                                        adapter.Update(dataSet, "tblSach");

                                        MessageBox.Show("Đã Xoá!");
                                        LoadDataToGridView();
                                    }
                                }
                            }
                        }
                    }
                    //khai bao command va cac thong so command de Select_tblSINHVIEN
                    //khai bao adapter
                    //khai bao datatable, adapter.Fill(datatable)
                    //add tung datatable vao dataset
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string idSach = tbMaSach.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "CheckPK_Sach";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maSach", idSach);

                    connection.Open();
                    var idsach_sql = cmd.ExecuteScalar();
                    connection.Close();

                    if (idsach_sql == null)
                    {
                        //Mô hình ngắt kết nối
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            cmd.CommandText = "SELECT * FROM tblSach";
                            cmd.CommandType = CommandType.Text;
                            adapter.SelectCommand = cmd;
                            using (DataTable dtSach = new DataTable("tblSach"))
                            {
                                adapter.Fill(dtSach);
                                //add tung datatable vao dataset
                                using (DataSet dataSet = new DataSet())
                                {
                                    dataSet.Tables.Add(dtSach);
                                    //them moi ban ghi vao datatable
                                    DataRow newRow = dtSach.NewRow();
                                    newRow["sMaSach"] = tbMaSach.Text;
                                    newRow["sTenSach"] = tbTenSach.Text;
                                    newRow["fDonGia"] = tbDonGia.Text;
                                    newRow["sTheLoai"] = tbTheLoai.Text;
                                    newRow["sTenTG"] = tbTenTG.Text;
                                    newRow["sMaNXB"] = cbMaNXB.Text;
                                    //..
                                    dtSach.Rows.Add(newRow);

                                    //them ban ghi vao CSDL bang lenh InsertCommand
                                    cmd.CommandText = "Insert_Sach";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.
                                        Add("@maSach", SqlDbType.VarChar, 30, "sMaSach").Value = tbMaSach.Text;
                                    cmd.Parameters.
                                        Add("@tenSach", SqlDbType.NVarChar, 70, "sTenSach").Value = tbTenSach.Text;
                                    cmd.Parameters.
                                        Add("@donGia", SqlDbType.VarChar, 10, "fDonGia").Value = tbDonGia.Text;
                                    cmd.Parameters.
                                        Add("@theLoai", SqlDbType.NVarChar, 30, "sTheLoai").Value = tbTheLoai.Text;
                                    cmd.Parameters.
                                        Add("@tenTG", SqlDbType.NVarChar, 12, "sTenTG").Value = tbTenTG.Text;
                                    cmd.Parameters.
                                        Add("@maNXB", SqlDbType.VarChar, 10, "sMaNXB").Value = cbMaNXB.Text;
                                    
                                    adapter.InsertCommand = cmd;
                                    adapter.Update(dataSet, "tblSach");
                                    LoadDataToGridView();
                                    MessageBox.Show("Thêm mới thành công!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên " + idSach + " đã tồn tại!");
                    }
                }
            }
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
                        cmd.CommandText = "Select * from tblSach";
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dtSach = new DataTable("tblSach"))
                            {
                                adapter.Fill(dtSach);
                                //add tung datatable vao dataset
                                using (DataSet dataSet = new DataSet())
                                {
                                    dataSet.Tables.Add(dtSach);

                                    //Chinh sua du lieu trong dtSINHVIEN cua dataset
                                    //tim khoa chinh
                                    dtSach.PrimaryKey = new DataColumn[] { dtSach.Columns["sMaSach"] };
                                    DataRow row = dtSach.Rows.Find(tbMaSach.Text);
                                    row["sMaSach"] = tbMaSach.Text;
                                    row["sTenSach"] = tbTenSach.Text;
                                    row["fDonGia"] = tbDonGia.Text;
                                    row["sTheLoai"] = tbTheLoai.Text;
                                    row["sTenTG"] = tbTenTG.Text;
                                    row["sMaNXB"] = cbMaNXB.Text;
                                    //..

                                    //them ban ghi vao CSDL bang lenh InsertCommand
                                    cmd.CommandText = "Update_Sach";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.
                                        Add("@maSach", SqlDbType.VarChar, 30, "sMaSach").Value = tbMaSach.Text;
                                    cmd.Parameters.
                                        Add("@tenSach", SqlDbType.NVarChar, 70, "sTenSach").Value = tbTenSach.Text;
                                    cmd.Parameters.
                                        Add("@donGia", SqlDbType.VarChar, 10, "fDonGia").Value = tbDonGia.Text;
                                    cmd.Parameters.
                                        Add("@theLoai", SqlDbType.NVarChar, 30, "sTheLoai").Value = tbTheLoai.Text;
                                    cmd.Parameters.
                                        Add("@tenTG", SqlDbType.NVarChar, 12, "sTenTG").Value = tbTenTG.Text;
                                    cmd.Parameters.
                                        Add("@maNXB", SqlDbType.VarChar, 10, "sMaNXB").Value = cbMaNXB.Text;

                                    adapter.UpdateCommand = cmd;
                                    adapter.Update(dataSet, "tblSach");
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
            string reportFilter = "NOT(ISNULL({Select_Sach.sMaSach}))";
            if (!string.IsNullOrEmpty(tbMaSach.Text))
            {
                reportFilter += string.Format(" AND {0} LIKE '*{1}*'",
                        "{Select_Sach.sMaSach}", tbMaSach.Text);
            }
            //if (!string.IsNullOrEmpty(tbTen.Text))
            //{
            //    reportFilter += string.Format(" AND {0} LIKE '*{1}*'",
            //            "{Select_TONGHOP.sHoTen}", tbTen.Text);
            //}
            FormBaoCao baoCaoSach = new FormBaoCao();
            baoCaoSach.Show();
            baoCaoSach.showReport(reportFilter, "Select_Sach", "DSSach.rpt");
        }
    }
}
