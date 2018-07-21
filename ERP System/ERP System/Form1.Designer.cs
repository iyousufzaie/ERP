namespace ERP_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pURCHASEORDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicePayableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryChalanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceReceiveableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pURCHASEORDERToolStripMenuItem,
            this.vendorToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem1,
            this.gRNToolStripMenuItem,
            this.invoicePayableToolStripMenuItem,
            this.salesOrderToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.sOProductsToolStripMenuItem,
            this.salesOrderToolStripMenuItem1,
            this.deliveryChalanToolStripMenuItem,
            this.invoiceReceiveableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(212, 438);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pURCHASEORDERToolStripMenuItem
            // 
            this.pURCHASEORDERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pURCHASEORDERToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.pURCHASEORDERToolStripMenuItem.Name = "pURCHASEORDERToolStripMenuItem";
            this.pURCHASEORDERToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.pURCHASEORDERToolStripMenuItem.Text = "PURCHASE ORDER";
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.vendorToolStripMenuItem.Text = "> Vendor";
            this.vendorToolStripMenuItem.Click += new System.EventHandler(this.vendorToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.productsToolStripMenuItem.Text = "> Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem1
            // 
            this.purchaseOrderToolStripMenuItem1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.purchaseOrderToolStripMenuItem1.Name = "purchaseOrderToolStripMenuItem1";
            this.purchaseOrderToolStripMenuItem1.Size = new System.Drawing.Size(199, 29);
            this.purchaseOrderToolStripMenuItem1.Text = "> Purchase Order";
            this.purchaseOrderToolStripMenuItem1.Click += new System.EventHandler(this.purchaseOrderToolStripMenuItem1_Click);
            // 
            // gRNToolStripMenuItem
            // 
            this.gRNToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.gRNToolStripMenuItem.Name = "gRNToolStripMenuItem";
            this.gRNToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.gRNToolStripMenuItem.Text = "> GRN";
            this.gRNToolStripMenuItem.Click += new System.EventHandler(this.gRNToolStripMenuItem_Click);
            // 
            // invoicePayableToolStripMenuItem
            // 
            this.invoicePayableToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.invoicePayableToolStripMenuItem.Name = "invoicePayableToolStripMenuItem";
            this.invoicePayableToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.invoicePayableToolStripMenuItem.Text = "> Invoice Payable";
            this.invoicePayableToolStripMenuItem.Click += new System.EventHandler(this.invoicePayableToolStripMenuItem_Click);
            this.invoicePayableToolStripMenuItem.ForeColorChanged += new System.EventHandler(this.invoicePayableToolStripMenuItem_Click);
            // 
            // salesOrderToolStripMenuItem
            // 
            this.salesOrderToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.salesOrderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOrderToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.salesOrderToolStripMenuItem.Name = "salesOrderToolStripMenuItem";
            this.salesOrderToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.salesOrderToolStripMenuItem.Text = "SALES ORDER";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.customerToolStripMenuItem.Text = "> Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // sOProductsToolStripMenuItem
            // 
            this.sOProductsToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.sOProductsToolStripMenuItem.Name = "sOProductsToolStripMenuItem";
            this.sOProductsToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.sOProductsToolStripMenuItem.Text = "> SO Products";
            this.sOProductsToolStripMenuItem.Click += new System.EventHandler(this.sOProductsToolStripMenuItem_Click);
            this.sOProductsToolStripMenuItem.ForeColorChanged += new System.EventHandler(this.sOProductsToolStripMenuItem_Click);
            // 
            // salesOrderToolStripMenuItem1
            // 
            this.salesOrderToolStripMenuItem1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.salesOrderToolStripMenuItem1.Name = "salesOrderToolStripMenuItem1";
            this.salesOrderToolStripMenuItem1.Size = new System.Drawing.Size(199, 29);
            this.salesOrderToolStripMenuItem1.Text = "> Sales Order";
            this.salesOrderToolStripMenuItem1.Click += new System.EventHandler(this.salesOrderToolStripMenuItem1_Click);
            // 
            // deliveryChalanToolStripMenuItem
            // 
            this.deliveryChalanToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.deliveryChalanToolStripMenuItem.Name = "deliveryChalanToolStripMenuItem";
            this.deliveryChalanToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.deliveryChalanToolStripMenuItem.Text = "> Delivery Chalan";
            this.deliveryChalanToolStripMenuItem.Click += new System.EventHandler(this.deliveryChalanToolStripMenuItem_Click);
            // 
            // invoiceReceiveableToolStripMenuItem
            // 
            this.invoiceReceiveableToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.invoiceReceiveableToolStripMenuItem.Name = "invoiceReceiveableToolStripMenuItem";
            this.invoiceReceiveableToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.invoiceReceiveableToolStripMenuItem.Text = "> Invoice Receiveable";
            this.invoiceReceiveableToolStripMenuItem.Click += new System.EventHandler(this.invoiceReceiveableToolStripMenuItem_Click);
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\Iqra Notes\\CS-3\\VP\\ERP-purchasi" +
    "ng.accdb\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(485, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign In To ERP System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(428, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(428, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(629, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(629, 262);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(334, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Location = new System.Drawing.Point(826, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\Iqra Notes\\CS-3\\VP\\ERp selling " +
    "- Copy.accdb\"";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(887, 438);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem pURCHASEORDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicePayableToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Data.OleDb.OleDbConnection oleDbConnection1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deliveryChalanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceReceiveableToolStripMenuItem;
        public System.Data.OleDb.OleDbConnection oleDbConnection2;
    }
}

