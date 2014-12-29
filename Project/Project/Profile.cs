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

        private void button3_Click(object sender, EventArgs e)
        {

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
                label2.Text = "Staff Biasa";
                //button4.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
<<<<<<< HEAD

        private void button2_Click(object sender, EventArgs e)
        {
            Dosen dosen = new Dosen();
            dosen.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.Show();
        }
=======
>>>>>>> parent of 32b644c... Revert "Penambahan coding dan bbrp form"
    }
}
