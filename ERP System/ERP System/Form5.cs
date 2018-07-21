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
    public partial class Form5 : Form
    {
        Form1 conn = new Form1();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select Pid from Products", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Pid"]).ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Products where Pid='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr["PName"].ToString();
                textBox2.Text = dr["BasePrice"].ToString();
                textBox3.Text = dr["WeightInPounds"].ToString();
                textBox4.Text = dr["InventoryStatus"].ToString();
                textBox5.Text = dr["EstimatedDElivery"].ToString();
                textBox6.Text = dr["AmountOnHand"].ToString();
                textBox7.Text = dr["AllowPerOrder"].ToString();
                textBox8.Text = dr["WarrantyPeriod"].ToString();
                textBox9.Text = dr["ProductType"].ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update Products set PName=@PName, BasePrice=@BasePrice, WeightInPounds=@WeightInPounds, InventoryStatus=@InventoryStatus, EstimatedDelivery=@EstimatedDelivery, AmountOnHand=@AmountOnHand, AllowPerOrder=@AllowPerOrder, warrantyPeriod=@WarrantyPeriod, ProductType=@ProductType where Pid=@Pid", conn.oleDbConnection1);
            
            cmd.Parameters.AddWithValue("@PName", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@BasePrice", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@WeightInPounds", this.textBox3.Text);
            cmd.Parameters.AddWithValue("@InventoryStatus", this.textBox4.Text);
            cmd.Parameters.AddWithValue("@EstimatedDelivery", this.textBox5.Text);
            cmd.Parameters.AddWithValue("@AmountOnHand", this.textBox6.Text);
            cmd.Parameters.AddWithValue("@AllowPerOrder", this.textBox7.Text);
            cmd.Parameters.AddWithValue("@WarrantyPeriod", this.textBox8.Text);
            cmd.Parameters.AddWithValue("@ProductType", this.textBox9.Text);
            cmd.Parameters.AddWithValue("@Pid", this.comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been updated");
            conn.oleDbConnection1.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 conn = new Form1();
            conn.Show();
            conn.menuStrip1.Visible = true;
        }
    }
}
