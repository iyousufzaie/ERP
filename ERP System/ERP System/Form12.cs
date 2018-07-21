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
    public partial class Form12 : Form
    {
        Form1 conn = new Form1();
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("Select deptname from Dept", conn.oleDbConnection2);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["deptname"]).ToString();
            }
            conn.oleDbConnection2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("insert into SO(SOID, SODate, DDate, Status, Approve, CDept, CName, CID, CContectPerson, CCPPH, TotalAmount)values(@SOID, @SODate, @DDate, @Status, @Approve, @CDept, @CName, @CID, @CContectPerson, @CCPPH, @TotalAmount);", conn.oleDbConnection2);
            cmd.Parameters.AddWithValue("@SOID", textBox1.Text);
            cmd.Parameters.AddWithValue("@SODate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@Status", textBox7.Text);
            cmd.Parameters.AddWithValue("@Approve", textBox8.Text);
            cmd.Parameters.AddWithValue("@CDept", textBox2.Text);
            cmd.Parameters.AddWithValue("@CName", textBox3.Text);
            cmd.Parameters.AddWithValue("@CID", textBox4.Text);
            cmd.Parameters.AddWithValue("@CContectPerson", textBox5.Text);
            cmd.Parameters.AddWithValue("@CCPPH", textBox6.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", textBox9.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been inserted");
            conn.oleDbConnection2.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;


            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("select count(SOID) from SO where CDept='" + comboBox1.Text + "'", conn.oleDbConnection2);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }

            if (comboBox1.Text == "Consumer")
            {
                textBox1.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Sales")
            {
                textBox1.Text = "Sal-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "HR")
            {
                textBox1.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "IT")
            {
                textBox1.Text = "IT-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            conn.oleDbConnection2.Close();

            int i = 0;
            conn.oleDbConnection2.Open();
            OleDbCommand cmm = new OleDbCommand("select count(CID) from SO where CDept='" + comboBox1.Text + "'", conn.oleDbConnection2);
            OleDbDataReader drr = cmm.ExecuteReader();
            if (drr.Read())
            {
                i = Convert.ToInt32(drr[0]);
                i++;
            }

            conn.oleDbConnection2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 conn = new Form1();
            conn.Show();
            conn.menuStrip1.Visible = true;
        }
    }
}
