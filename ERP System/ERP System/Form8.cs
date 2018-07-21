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
    public partial class Form8 : Form
    {
        Form1 conn = new Form1();
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            int c = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(GRNID) from GRN", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }
            textBox1.Text = "GRN-0" + c.ToString();

            OleDbCommand cmm = new OleDbCommand("select POID from PO where status='Open'", conn.oleDbConnection1);
            OleDbDataReader drr = cmm.ExecuteReader();
            while (drr.Read())
            {
                comboBox1.Items.Add(drr["POID"]).ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update GRN set GRNID=@GRNID, SNO=@SNO, VName=@VName,  DDate=@DDate, GRDate=@GRDate where POID=@POID", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@GRNID", textBox1.Text);
            cmd.Parameters.AddWithValue("@SNO", textBox2.Text);
            cmd.Parameters.AddWithValue("@VName", textBox3.Text);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@GRDate", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@POID", comboBox1.Text);
            

            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Good Receiving Note has been created");
            

            
            OleDbCommand cmm = new OleDbCommand("select * from GRNProducts  " , conn.oleDbConnection1);
            OleDbDataReader dr = cmm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from PO where POID='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader ddr = cmd.ExecuteReader();

            while (ddr.Read())
            {
                textBox2.Text = ddr["SNO"].ToString();
                textBox3.Text = ddr["VName"].ToString();
                dateTimePicker1.Text = ddr["DDate"].ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 conn = new Form1();
            conn.Show();
            conn.menuStrip1.Visible = true;
        }
    }
}
