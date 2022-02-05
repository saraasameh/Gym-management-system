using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace database
{
    public partial class Form2 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("please enter Age!");
            }
            else
            {
                string constr = "Data Source=ORCL;User Id=scott; Password=tiger;";

                string strcmd = @"Select member_id , f_name, m_name, l_name, e_mail,
                            joining_date, address, age, gender, phone_number, coach_id
                            from member
                            where age >= :mem_age ";

                adapter = new OracleDataAdapter(strcmd, constr);
                adapter.SelectCommand.Parameters.Add("mem_age", int.Parse(textBox1.Text));
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Saved");
        }
    }
}
