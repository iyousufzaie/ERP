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
    public partial class Form6 : Form
    {
        Form1 conn = new Form1();
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Vendor(Pid, PName, BasePrice, WeightInPounds, InventoryStatus, EstimatedDelivery, AmountOnHand, AllowPerOrder, WarrantyPeriod, ProductType)values(@Pid, @PName, @BasePrice, @WeightInPounds, @InventoryStatus, @EstimatedDelivery, @AmountOnHand, @AllowPerOrder, @WarrantyPeriod, @ProductType);", conn.oleDbConnection1);

            cmd.Parameters.AddWithValue("@Pid", textBox1.Text);
            cmd.Parameters.AddWithValue("@PName", textBox2.Text);
            cmd.Parameters.AddWithValue("@BasePrice", textBox3.Text);
            cmd.Parameters.AddWithValue("@WeightInPounds", textBox4.Text);
            cmd.Parameters.AddWithValue("@InventoryStatus", textBox5.Text);
            cmd.Parameters.AddWithValue("@EstimatedDelivery", textBox6.Text);
            cmd.Parameters.AddWithValue("@AmountOnHand", textBox7.Text);
            cmd.Parameters.AddWithValue("@AllowPerOrder", textBox8.Text);
            cmd.Parameters.AddWithValue("@WarrantyPeriod", textBox9.Text);
            cmd.Parameters.AddWithValue("@ProductType", textBox10.Text);
           
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been inserted");
            conn.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 conn = new Form1();
            conn.Show();
            conn.menuStrip1.Visible = true;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
