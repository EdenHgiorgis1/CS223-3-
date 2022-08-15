using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validationss
{
    public partial class MdiContainer : Form
    {
        string uname;
        public MdiContainer(String uname)
        {
            InitializeComponent();
            this.uname = uname; 
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Form1 form1 = new Form1(uname);
            form1.MdiParent = this;
            form1.Dock = DockStyle.Fill;
            form1.Show();
        }
    }
}
