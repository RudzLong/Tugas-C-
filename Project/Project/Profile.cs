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

        //private void ganti_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    dlg.Filter = "*JPG FileStyleUriParser(*.jpg)|*.jpg|PNG Files(*png)|*.png|All Files(*.*)|*.*";
            
        //    if(dlg.ShowDialog() == DialogResult.OK)
        //    {
        //        string piclog = dlg.FileName.ToString();
        //        pictureBox1.ImageLocation = piclog;
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            Dosen dosen = new Dosen();
            this.Hide();
            dosen.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GantiPass gp = new GantiPass();
            gp.Show();
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
    }
}
