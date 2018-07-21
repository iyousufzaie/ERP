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
    public partial class Form4 : Form
    {
        Form1 conn = new Form1();
        public Form4()
        {
            
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Vendor(VID, VName,VCode, VCity, PH1, PH2, VAddress, CPName, CPPH, VEmail, VFax, VGroup, VStatus)values(@VID, @VName,@Vcode, @VCity, @PH1, @PH2, @VAddress, @CPName, @CPPH, @VEmail,@VFax,@VGroup,@VStatus);", conn.oleDbConnection1);

            cmd.Parameters.AddWithValue("@VID", textBox1.Text);
            cmd.Parameters.AddWithValue("@VName", textBox2.Text);
            cmd.Parameters.AddWithValue("@VCode", textBox3.Text);
            cmd.Parameters.AddWithValue("@VCity", textBox4.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox5.Text);
            cmd.Parameters.AddWithValue("@PH2", textBox6.Text);
            cmd.Parameters.AddWithValue("@VAddress", textBox7.Text);
            cmd.Parameters.AddWithValue("@CPName", textBox8.Text);
            cmd.Parameters.AddWithValue("@CPPH", textBox9.Text);
            cmd.Parameters.AddWithValue("@VEmail", textBox10.Text);
            cmd.Parameters.AddWithValue("@VFax", textBox11.Text);
            cmd.Parameters.AddWithValue("@VGroup", textBox12.Text);
            cmd.Parameters.AddWithValue("@VStatus", textBox13.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been inserted");
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
            OleDbCommand cmd = new OleDbCommand("update Vendor set VStatus='Inactive' where VID='" + textBox1.Text + "'", conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been updated");
            conn.oleDbConnection1.Close();
            MessageBox.Show("Your Vendor Has Been Disapproved");
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update Vendor set VStatus='Active' where VID='" + textBox1.Text + "'", conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been updated");
            conn.oleDbConnection1.Close();
        }
    }
}
