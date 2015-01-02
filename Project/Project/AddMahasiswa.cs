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
    public partial class AddMahasiswa : Form
    {
        public AddMahasiswa()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
    }
}
