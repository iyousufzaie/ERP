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
    public partial class Form9 : Form
    {
        Form1 conn = new Form1();
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

            this.textBox8.ReadOnly = true;
            this.textBox9.ReadOnly = true;
            this.textBox10.ReadOnly = true;
            int c = 0;

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(InvoiceID) from Invoice ", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }

            textBox1.Text = "0" + c.ToString() + "-" + System.DateTime.Today.Year; 
            OleDbCommand cmm = new OleDbCommand("Select GRNID from GRN where Status ='Close' ", conn.oleDbConnection1);
            OleDbDataReader drr = cmm.ExecuteReader();

            while (drr.Read())
            {
                comboBox1.Items.Add(drr["GRNID"]).ToString();
            }



            conn.oleDbConnection1.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 conn = new Form1();
            conn.Show();
            conn.menuStrip1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Invoice(InvoiceID,VendorID,VendorName,GRNDate,CDate,AmountPayable) values(@InvoiceID,@VendorID,@VendorName,@GRNDate,@CDate,@AmountPayable)", conn.oleDbConnection1);

            cmd.Parameters.AddWithValue("@InvoiceID", textBox1.Text);
            cmd.Parameters.AddWithValue("@VendorID", textBox5.Text);
            cmd.Parameters.AddWithValue("@VendorName", textBox6.Text);
            cmd.Parameters.AddWithValue("@GRNDate", textBox2.Text);
            cmd.Parameters.AddWithValue("@CDate", dateTimePicker1);
            cmd.Parameters.AddWithValue("@AmountPayable", textBox8.Text);
           

            cmd.ExecuteNonQuery();

            conn.oleDbConnection1.Close();
            MessageBox.Show("Kindly pay the amount");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from GRN where GRNID = '" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                textBox2.Text = dr["GRDate"].ToString();
                textBox4.Text = dr["POID"].ToString();
                textBox6.Text = dr["VName"].ToString();

            }
            conn.oleDbConnection1.Close();
            conn.oleDbConnection1.Open();
            OleDbCommand cmm = new OleDbCommand("Select * from PO where VName = @VName", conn.oleDbConnection1);
            cmm.Parameters.AddWithValue("VName", textBox6.Text);
            OleDbDataReader drr = cmm.ExecuteReader();
            if (drr.Read())
            {
                textBox3.Text = drr["TotalAmount"].ToString();
                textBox5.Text = drr["VID"].ToString();

            }
            conn.oleDbConnection1.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox3.Text);
            int disc = Convert.ToInt32(textBox7.Text);
            int discount = (price * disc) / 100;
            int d = price - discount;
            textBox8.Text = d.ToString();
        }
    }
}
