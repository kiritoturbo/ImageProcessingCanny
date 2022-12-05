using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuatToanCanny
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Canny_edge_detector");
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void help_Load(object sender, EventArgs e)
        {

        }
    }
}
