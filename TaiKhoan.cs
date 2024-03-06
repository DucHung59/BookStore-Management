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
    public partial class TaiKhoan : Form
    {
        private DataView dataView_gridView = new DataView();
        string connectionString = ConfigurationManager.ConnectionStrings["BTL"].ConnectionString;
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int index = dgvTaiKhoan.CurrentRow.Index;
            string idtk = dataView_gridView[index]["sTK"].ToString();
            try
            {
                //hien dialog de xac nhan 1 lan nua
                DialogResult dialog_delete = MessageBox.
                    Show("Bạn có chắc xoá tài khoản " + idtk + " không?",
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
                            cmd.CommandText = "Select_TK";
                            cmd.CommandType = CommandType.StoredProcedure;
                            //khai bao adapter
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                //khai bao datatable, adapter.Fill(datatable)
                                using (DataTable tblTaiKhoan = new DataTable("tblTaiKhoan"))
                                {
                                    adapter.Fill(tblTaiKhoan);
                                    //add tung datatable vao dataset
                                    using (DataSet ds = new DataSet())
                                    {
                                        ds.Tables.Add(tblTaiKhoan);
                                        tblTaiKhoan.PrimaryKey = new DataColumn[] { tblTaiKhoan.Columns["sTK"] };
                                        DataRow row = tblTaiKhoan.Rows.Find(tbTK.Text);
                                        row.Delete();

                                        cmd.CommandText = "Delete_TK";
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.Add("@tk", SqlDbType.NVarChar, 10, "sTK").Value = tbTK.Text;

                                        adapter.DeleteCommand = cmd;
                                        adapter.Update(ds, "tblTaiKhoan");

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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = sql.CreateCommand())
                {
                    cmd.CommandText = "check_tk";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tk", tbTK.Text);
                    
                    sql.Open();
                    var idtk = cmd.ExecuteScalar();
                    sql.Close();
                    
                    if(idtk == null)
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            cmd.CommandText = "Select * from tblTaiKhoan";
                            cmd.CommandType= CommandType.Text;
                            da.SelectCommand = cmd;
                            using (DataTable tblTaiKhoan = new DataTable("tblTaiKhoan"))
                            {
                                da.Fill(tblTaiKhoan);
                                using (DataSet ds = new DataSet())
                                {
                                    ds.Tables.Add(tblTaiKhoan);
                                    DataRow newRow = tblTaiKhoan.NewRow();
                                    newRow["sTK"] = tbTK.Text;
                                    newRow["sMK"] = tbMK.Text;
                                    tblTaiKhoan.Rows.Add(newRow);

                                    cmd.CommandText = "Insert_TK";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@tk", tbTK.Text);
                                    cmd.Parameters.AddWithValue("@mk", tbMK.Text);

                                    da.InsertCommand = cmd;
                                    da.Update(ds, "tblTaiKhoan");
                                    LoadDataToGridView();
                                    MessageBox.Show("Thêm mới thành công!");
                                }
                            }
                        }
                    } 
                    else
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!");
                    }
                }
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
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
                        command.CommandText = "Select_TK";
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {

                            using (DataTable dt_gridView = new DataTable())
                            {
                                adapter.Fill(dt_gridView);
                                if (dt_gridView.Rows.Count > 0)
                                {
                                    dataView_gridView = dt_gridView.DefaultView;
                                    dgvTaiKhoan.AutoGenerateColumns = false;

                                    if (!string.IsNullOrEmpty(filter))
                                    {
                                        dataView_gridView.RowFilter = filter;
                                    }
                                    dgvTaiKhoan.DataSource = dataView_gridView;
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvTaiKhoan.CurrentRow.Index;

            tbTK.Text = dataView_gridView[index]["sTK"].ToString();
            tbMK.Text = dataView_gridView[index]["sMK"].ToString();
        }

        private void btnThoatApp_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
