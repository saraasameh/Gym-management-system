using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void connectedModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show();
        }

        private void disconnectedModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport1 r = new FormReport1();
            r.Show();
        }

        private void secondReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport2 r2 = new FormReport2();
            r2.Show();
        }
    }
}
