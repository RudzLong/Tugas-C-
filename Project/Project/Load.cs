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
    public partial class Load : Form
    {
        Timer tmr;
        public Load()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void load_Load(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 5000;
            tmr.Start();
            tmr.Tick += timer1_Tick;
        }
    }
}
