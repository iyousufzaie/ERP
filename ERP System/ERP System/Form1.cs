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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.salesOrderToolStripMenuItem.ForeColor = Color.LightSeaGreen;
            this.menuStrip1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "iqra" && textBox2.Text == "1234")
            {
                this.menuStrip1.Visible = true;


            }
            else
            {
                MessageBox.Show("Your Password is incorrect");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vendorToolStripMenuItem.Checked == false)
            {
                vendorToolStripMenuItem.Checked = true;
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productsToolStripMenuItem.Checked == false)
            {
                productsToolStripMenuItem.Checked = true;
                Form5 f5 = new Form5();
                f5.Show();
            }
        }

        private void purchaseOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (purchaseOrderToolStripMenuItem1.Checked == false)
            {
                purchaseOrderToolStripMenuItem1.Checked = true;
                Form7 f7 = new Form7();
                f7.Show();
            }
        }

        private void gRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gRNToolStripMenuItem.Checked == false)
            {
                gRNToolStripMenuItem.Checked = true;
                Form8 f8 = new Form8();
                f8.Show();
            }
        }

        private void invoicePayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invoicePayableToolStripMenuItem.Checked == false)
            {
                invoicePayableToolStripMenuItem.Checked = true;
                Form9 f9 = new Form9();
                f9.Show();
            }
        }

        private void sOProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sOProductsToolStripMenuItem.Checked == false)
            {
                sOProductsToolStripMenuItem.Checked = true;
                Form11 f11 = new Form11();
                f11.Show();
            }
        }

        private void salesOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (salesOrderToolStripMenuItem.Checked == false)
            {
                salesOrderToolStripMenuItem.Checked = true;
                Form12 f12 = new Form12();
                f12.Show();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerToolStripMenuItem.Checked == false)
            {
                customerToolStripMenuItem.Checked = true;
                Form13 f13 = new Form13();
                f13.Show();
            }
        }

        private void deliveryChalanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deliveryChalanToolStripMenuItem.Checked == false)
            {
                deliveryChalanToolStripMenuItem.Checked = true;
                Form14 f14 = new Form14();
                f14.Show();
            }
        }

        private void invoiceReceiveableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invoiceReceiveableToolStripMenuItem.Checked == false)
            {
                invoiceReceiveableToolStripMenuItem.Checked = true;
                Form15 f15 = new Form15();
                f15.Show();
            }
        }
    }
}
