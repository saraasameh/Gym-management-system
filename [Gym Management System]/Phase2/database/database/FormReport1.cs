using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace database
{
    public partial class FormReport1 : Form
    {
        CrystalReport1 cr1;
        public FormReport1()
        {
            InitializeComponent();
        }

        private void FormReport1_Load(object sender, EventArgs e)
        {
            cr1 = new CrystalReport1();
            foreach(ParameterDiscreteValue v in cr1.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr1.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr1;

        }
    }
}
