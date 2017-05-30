using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlStatusBarLisaChiang_300925122
{
    public partial class UserControlStatusBarLisaChiang_300925122: UserControl
    {
        public UserControlStatusBarLisaChiang_300925122()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.duffsfamouswings.ca/content/home/home.html");
        }
    }
}
