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
    public partial class FormReport2 : Form
    {
        CrystalReport2 cr2;
        public FormReport2()
        {
            InitializeComponent();
        }

        private void FormReport2_Load(object sender, EventArgs e)
        {
            cr2 = new CrystalReport2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr2;
        }
    }
}
