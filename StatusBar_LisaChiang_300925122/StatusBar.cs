using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusBar_LisaChiang_300925122
{
    public partial class StatusBar : Form
    {
        public StatusBar()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.duffsfamouswings.ca/content/home/home.html");
        }
    }
}
