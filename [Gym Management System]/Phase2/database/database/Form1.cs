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
    public partial class Form1 : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott; Password=tiger;";
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select coach_id from coach";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select f_name,m_name, l_name, e_mail, phone_number, super_coach" +
                " from coach where coach_id =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", comboBox1.Text);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox4.Text = dr[1].ToString();
                textBox5.Text = dr[2].ToString();
                textBox2.Text = dr[3].ToString();
                textBox3.Text = dr[4].ToString();
                textBox6.Text = dr[5].ToString();
            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into coach (coach_id, f_name, m_name, l_name, e_mail,  phone_number, super_coach)  values (:id, :fname,:mname, :lname,  :e_mail,  :phone_number, :super_coach)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", Convert.ToInt32( comboBox1.Text));
            cmd.Parameters.Add("fname", textBox1.Text);
            cmd.Parameters.Add("mname", textBox4.Text);
            cmd.Parameters.Add("lname", textBox5.Text);
            cmd.Parameters.Add("email", textBox2.Text);
            cmd.Parameters.Add("phone", Convert.ToInt32( textBox3.Text));
            cmd.Parameters.Add("manager", textBox6.Text);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                comboBox1.Items.Add(comboBox1.Text);
                MessageBox.Show("New coach inserted");
                comboBox1.Text = "";
                textBox1.Clear();
                textBox4.Clear();
                textBox5.Clear(); 
                textBox2.Clear(); 
                textBox3.Clear();
                textBox6.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "")
                MessageBox.Show("Select a coach first!");

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetworkoutID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", comboBox1.Text);
            cmd.Parameters.Add("workid", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }

            dr.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "viewduration";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", comboBox2.SelectedItem.ToString());
            cmd.Parameters.Add("duration", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();
            
            textBox7.Text = cmd.Parameters[1].Value.ToString();
                
            
        }
    }
}
