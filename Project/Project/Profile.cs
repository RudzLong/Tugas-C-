using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            label1.Text = Status.user;
            if (Status.Hak()== true)
            {
                label2.Text = "Admin";
            }
            else
            {
                label2.Text = "Staff";
                radButton4.Visible = false;
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
            Status.status = false;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GantiPass gp = new GantiPass();
            gp.Show();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            Dosen dosen = new Dosen();
            this.Hide();
            dosen.Show();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.Show();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
