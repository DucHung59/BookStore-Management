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
    public partial class DialogHDN : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BTL"].ConnectionString;

        public DialogHDN()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "CheckPK_HDN";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@soHDN", tbMaHD.Text);
                    
                    sqlConnection.Open();
                    var idhdn = cmd.ExecuteScalar();
                    sqlConnection.Close();
                    if (idhdn != null)
                    {
                        string reportFilter = "NOT(ISNULL({Select_HDNhapTongHop.sSoHDN}))";
                        if(!string.IsNullOrEmpty(tbMaHD.Text))
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
                        MessageBox.Show("Mã hoá đơn "+ tbMaHD.Text + " không tồn tại");
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
