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
    public partial class Form15 : Form
    {
        Form1 conn = new Form1();
            
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            this.textBox8.ReadOnly = true;
            int c = 0;

            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("select count(InvoiceID) from Invoice ", conn.oleDbConnection2);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }

            textBox1.Text = "0" + c.ToString();
            OleDbCommand cmdd = new OleDbCommand("Select DCID from DeliveryChalan where Status ='Open' ", conn.oleDbConnection2);
            OleDbDataReader drr = cmdd.ExecuteReader();

            while (drr.Read())
            {
                comboBox1.Items.Add(drr["DCID"]).ToString();
            }


            conn.oleDbConnection2.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Invoice(InvoiceID,CustomerID,CustomerName,DDate,CDate,AmountPayable,DCID) values(@InvoiceID,@CustomerID,@CustomerName,@DDate,@CDate,@AmountPayable,@DCID)", conn.oleDbConnection2);

            cmd.Parameters.AddWithValue("@InvoiceID", textBox1.Text);
            cmd.Parameters.AddWithValue("@CustomerID", textBox5.Text);
            cmd.Parameters.AddWithValue("@CustomerName", textBox6.Text);
            cmd.Parameters.AddWithValue("@DDate", textBox2.Text);
            cmd.Parameters.AddWithValue("@CDate", dateTimePicker1);
            cmd.Parameters.AddWithValue("@AmountPayable", textBox8.Text);
            cmd.Parameters.AddWithValue("@DCID", comboBox1.Text);

            cmd.ExecuteNonQuery();

            conn.oleDbConnection2.Close();
            MessageBox.Show("Kindly pay the amount");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from DeliveryChalan where DCID = '" + comboBox1.Text + "'", conn.oleDbConnection2);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                textBox2.Text = dr["DDate"].ToString();
                textBox4.Text = dr["SOID"].ToString();
                textBox6.Text = dr["CName"].ToString();

            }
            conn.oleDbConnection2.Close();

            conn.oleDbConnection2.Open();
            OleDbCommand cmd1 = new OleDbCommand("Select * from SO where CName = @CName", conn.oleDbConnection2);
            cmd1.Parameters.AddWithValue("CName", textBox6.Text);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                textBox3.Text = dr1["TotalAmount"].ToString();
                textBox5.Text = dr1["CID"].ToString();

            }
            conn.oleDbConnection2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int price = Convert.ToInt32(textBox3.Text);
            int disc = Convert.ToInt32(textBox7.Text);
            int discount = (price * disc) / 100;
            int d = price - discount;
            textBox8.Text = d.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from DeliveryChalanProducts where DCID = '" + comboBox1.Text + "'", conn.oleDbConnection2);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                textBox9.Text = dr["PModel"].ToString();
                textBox10.Text = dr["PQty"].ToString();
            }
            conn.oleDbConnection2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 conn = new Form1();
            conn.Show();
            conn.menuStrip1.Visible = true;
        }
    }
}
