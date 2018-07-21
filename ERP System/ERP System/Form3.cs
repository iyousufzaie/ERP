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
    public partial class Form3 : Form
    {
        Form1 conn = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select VID from Vendor", conn.oleDbConnection1);

            OleDbDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                comboBox1.Items.Add(dr["VID"]).ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Vendor where VID='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                comboBox1.Text = dr["VID"].ToString();
                textBox1.Text = dr["VName"].ToString();
                textBox2.Text = dr["VCode"].ToString();
                textBox3.Text = dr["VCity"].ToString();
                textBox4.Text = dr["PH1"].ToString();
                textBox5.Text = dr["PH2"].ToString();
                textBox6.Text = dr["VAddress"].ToString();
                textBox7.Text = dr["CPName"].ToString();
                textBox8.Text = dr["CPPH"].ToString();
                textBox9.Text = dr["VEmail"].ToString();
                textBox10.Text = dr["VFax"].ToString();
                textBox11.Text = dr["VGroup"].ToString();
                textBox12.Text = dr["VStatus"].ToString();

            }
            conn.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update Vendor set VStatus='Active' where VID='" + comboBox1.Text + "'", conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been updated");
            conn.oleDbConnection1.Close();



            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update Vendor set  VName=@VName, VCode=@VCode, VCity=@VCity, PH1=@PH1, PH2=@PH2, VAddress=@VAddress, CPName=@CPName, CPPH=@CPPH, VEmail=@VEmail, VFax=@VFax, VGroup=@VGroup, VStatus=@VStatus where VID=@VID", conn.oleDbConnection1);
            
            cmd.Parameters.AddWithValue("@VName", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@VCode", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@VCity", this.textBox3.Text);
            cmd.Parameters.AddWithValue("@PH1", this.textBox4.Text);
            cmd.Parameters.AddWithValue("@PH2", this.textBox5.Text);
            cmd.Parameters.AddWithValue("@VAddress", this.textBox6.Text);
            cmd.Parameters.AddWithValue("@CPName", this.textBox7.Text);
            cmd.Parameters.AddWithValue("@CPPH", this.textBox8.Text);
            cmd.Parameters.AddWithValue("@VEmail", this.textBox9.Text);
            cmd.Parameters.AddWithValue("@VFax", this.textBox10.Text);
            cmd.Parameters.AddWithValue("@VGroup", this.textBox11.Text);
            cmd.Parameters.AddWithValue("@VStatus", this.textBox12.Text);
            cmd.Parameters.AddWithValue("@VID", this.comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been updated");
            conn.oleDbConnection1.Close(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 conn = new Form1();
         
            conn.Show();
            conn.menuStrip1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update Vendor set VStatus='Inactive' where VID='" + comboBox1.Text + "'", conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been updated");
            conn.oleDbConnection1.Close();
            MessageBox.Show("Your Vendor Has Been Disapproved");
            this.Show();
        }
    }
}
