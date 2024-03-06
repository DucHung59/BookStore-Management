using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FormBaoCao : Form
    {
        string connectionString =
            ConfigurationManager.ConnectionStrings["BTL"].ConnectionString;
        public FormBaoCao()
        {
            InitializeComponent();
        }
        public void showReport(string reportFilter, string nameTable, string reportFileName)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = sqlConnection.CreateCommand())
                    {
                        cmd.CommandText = nameTable;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            using (DataTable table = new DataTable())
                            {
                                adapter.Fill(table);
                                ReportDocument reportdocument = new ReportDocument();
                                string path = string.Format("{0}\\BaoCao\\{1}", Application.StartupPath, reportFileName);
                                reportdocument.Load(path);
                                reportdocument.Database.Tables[nameTable].SetDataSource(table);
                                //reportdocument.SetParameterValue("NguoiLapBieu", "NVN");
                                if (reportFilter != null)
                                {
                                    reportdocument.RecordSelectionFormula = reportFilter;
                                }
                                crystalReportViewer1.ReportSource = reportdocument;

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

        public void showReportSach()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = sqlConnection.CreateCommand())
                    {
                        cmd.CommandText = "Select_Sach";
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            using (DataTable table = new DataTable())
                            {
                                adapter.Fill(table);
                                ReportDocument reportdocument = new ReportDocument();
                                string path = string.Format("{0}\\BaoCao\\DSSach.rpt", Application.StartupPath);
                                reportdocument.Load(path);
                                reportdocument.Database.Tables["Select_Sach"].SetDataSource(table);
                                
                                crystalReportViewer1.ReportSource = reportdocument;

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

        
    }
}
