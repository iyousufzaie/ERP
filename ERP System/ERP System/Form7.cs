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
    public partial class Form7 : Form
    {
        string[] pid = new string[50];
        int[] qty = new int[50];
        int[] pprice = new int[50];

        int counter = 0;

        Form1 conn = new Form1();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select Deptname from Dept ", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Deptname"]).ToString();
            }


            OleDbCommand cmm = new OleDbCommand("Select VID from PO where Approve = 'APPROVED' ", conn.oleDbConnection1);
            OleDbDataReader drr = cmm.ExecuteReader();

            while (drr.Read())
            {
                comboBox2.Items.Add(drr["VID"]).ToString();
            }


            OleDbCommand cm = new OleDbCommand("Select Pid from Products ", conn.oleDbConnection1);
            OleDbDataReader ddr = cm.ExecuteReader();
            while (ddr.Read())
            {

                comboBox3.Items.Add(ddr["Pid"]).ToString();
            }

            conn.oleDbConnection1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 conn = new Form1();
            conn.Show();
            conn.menuStrip1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            conn.oleDbConnection1.Open();

            OleDbCommand cmd = new OleDbCommand("select count(POID) from PO where VDept= '" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }

            textBox1.Text = comboBox1.Text + "-" + c.ToString() + "-" + System.DateTime.Today.Year;

            conn.oleDbConnection1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from PO where VID = '" + comboBox2.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                
                textBox2.Text = dr["Vname"].ToString();
                textBox3.Text = dr["VDept"].ToString();
                textBox4.Text = dr["VCPPH"].ToString();

            }

            conn.oleDbConnection1.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from Products where Pid = '" + comboBox3.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox5.Text = dr["ProductType"].ToString();
                textBox6.Text = dr["PName"].ToString();
                textBox7.Text = dr["BasePrice"].ToString();
                //textBox8.Text = dr["PQty"].ToString();


            }

            conn.oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox9.Text +=  "PID :  " + comboBox3.Text + Environment.NewLine;
            textBox9.Text +=  " PModel  :  " + textBox5.Text + Environment.NewLine;
            textBox9.Text +=  " PName   :  " + textBox6.Text + Environment.NewLine;
            textBox9.Text +=  "  PPrice   :  " + textBox7.Text + Environment.NewLine;
            textBox9.Text +=  " PQuantity   :  " + textBox8.Text + Environment.NewLine;
            pid[counter] = comboBox3.Text;
            //qty[counter] = Convert.ToInt32(textBox8.Text);
            pprice[counter] = Convert.ToInt32(textBox7.Text);
            counter++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach (int p in pprice)
            {
                s += p + s;

            }

            conn.oleDbConnection1.Open();


                OleDbCommand cmm = new OleDbCommand("update PO set POID=@POID,  BasePrice=@BasePrice,PName=@PName,ProductType=@ProductType where PID=@PID", conn.oleDbConnection1);

                cmm.Parameters.AddWithValue("@POID", textBox1.Text);
                
               // cmm.Parameters.AddWithValue("@PQty", textBox8.Text);
                cmm.Parameters.AddWithValue("@BasePrice", textBox7.Text);
                cmm.Parameters.AddWithValue("@PNAME", textBox6.Text);
                cmm.Parameters.AddWithValue("@ProductType", textBox5.Text);
                cmm.Parameters.AddWithValue("@Pid", comboBox3.Text);
                cmm.ExecuteNonQuery();

                MessageBox.Show("PLEASE TAKE YOUR PURCHASE ORDER SLIP");
                conn.oleDbConnection1.Close();

            

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
