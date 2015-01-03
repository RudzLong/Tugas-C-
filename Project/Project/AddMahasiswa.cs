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
    public partial class AddMahasiswa : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public AddMahasiswa()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TugasC#.accdb;
Persist Security Info=False;";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                comboBox3.Items.Remove("TI-A");
                comboBox3.Items.Remove("TI-B");
                comboBox3.Items.Add("SI-A");
                comboBox3.Items.Add("SI-B");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox3.Items.Add("TI-A");
                comboBox3.Items.Add("TI-B");
                comboBox3.Items.Remove("SI-A");
                comboBox3.Items.Remove("SI-B");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AddMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mahasiswa mhs = new Mahasiswa();
            mhs.Show();
        }
    }
}
