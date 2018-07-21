using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace ERP_System
{
    public partial class Form13 : Form
    {
        Form1 conn = new Form1();
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("select CID from Customer where CStatus='Active'", conn.oleDbConnection2);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CID"]).ToString();
            }
            conn.oleDbConnection2.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Customer where CID='" + comboBox1.Text + "'", conn.oleDbConnection2);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr["Cname"].ToString();
                textBox2.Text = dr["CAddress"].ToString();
                textBox3.Text = dr["City"].ToString();
                textBox4.Text = dr["PH1"].ToString();
                textBox5.Text = dr["PH2"].ToString();
                textBox6.Text = dr["ContectPerson"].ToString();
                textBox7.Text = dr["CPPH"].ToString();
                textBox8.Text = dr["CEmail"].ToString();
                textBox9.Text = dr["CreditLimit"].ToString();
                textBox10.Text = dr["CStatus"].ToString();
                textBox11.Text = dr["CGroup"].ToString();
            }
            conn.oleDbConnection2.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 conn = new Form1();
            conn.Show();
            conn.menuStrip1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("Update Customer set CName=@CName, CAddress=@CAddress, City=@City, PH1=@PH1, PH2=@PH2, ContectPerson=@ContectPerson, CPPH=@CPPH, CEmail=@CEmail, CreditLimit=@CreditLimit, CGroup=@CGroup where CID=@CID", conn.oleDbConnection2);
            cmd.Parameters.AddWithValue("@CName", textBox1.Text);
            cmd.Parameters.AddWithValue("@CAddress", textBox2.Text);
            cmd.Parameters.AddWithValue("@City", textBox3.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox4.Text);
            cmd.Parameters.AddWithValue("@PH2", textBox5.Text);
            cmd.Parameters.AddWithValue("@ContectPerson", textBox6.Text);
            cmd.Parameters.AddWithValue("@CPPH", textBox7.Text);
            cmd.Parameters.AddWithValue("@CEmail", textBox8.Text);
            cmd.Parameters.AddWithValue("@CreditLimit", textBox9.Text);
            cmd.Parameters.AddWithValue("@CGroup", textBox11.Text);
            cmd.Parameters.AddWithValue("@CID", comboBox1.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Customer has been updated");
            conn.oleDbConnection2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Customer", conn.oleDbConnection2);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.oleDbConnection2.Close();
        }
    }
}
