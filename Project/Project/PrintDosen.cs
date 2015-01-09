using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project
{
    public partial class PrintDosen : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public PrintDosen()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void PrintDosen_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            connection.Open();
            string query = @"SELECT DosenList.NID, DosenList.Nama AS NamaDosen, DosenList.[Kelas Mengajar], DosenList.Jurusan AS JurusanDosen, DosenList.[Tanggal Masuk]
FROM DosenList, Mahasiswa;";
            OleDbDataAdapter da = new OleDbDataAdapter(query, connection);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "DataTable2");
            CrystalReportDosen cr = new CrystalReportDosen();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            connection.Close();
        }
    }
}
