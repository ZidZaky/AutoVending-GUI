namespace AutoVendingApp
{
    partial class Payment
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "resfgdrfhjnmk.",
            "jawa",
            "7000"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 7.8F));
            this.panel42 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel43 = new System.Windows.Forms.Panel();
            this.TotalBayar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.Bayar = new System.Windows.Forms.Button();
            this.panel42.SuspendLayout();
            this.panel43.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel42
            // 
            this.panel42.BackColor = System.Drawing.SystemColors.Window;
            this.panel42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel42.Controls.Add(this.Bayar);
            this.panel42.Controls.Add(this.label32);
            this.panel42.Controls.Add(this.label30);
            this.panel42.Controls.Add(this.listView1);
            this.panel42.Controls.Add(this.panel43);
            this.panel42.Controls.Add(this.label4);
            this.panel42.Location = new System.Drawing.Point(16, 32);
            this.panel42.Margin = new System.Windows.Forms.Padding(4);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(555, 578);
            this.panel42.TabIndex = 16;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label32.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label32.Location = new System.Drawing.Point(309, 322);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(97, 20);
            this.label32.TabIndex = 40;
            this.label32.Text = "Rp. 350.000";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label30.Location = new System.Drawing.Point(124, 322);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(144, 20);
            this.label30.TabIndex = 38;
            this.label30.Text = "Total Pembelian : ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(15, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(520, 250);
            this.listView1.TabIndex = 37;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nama Produk";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Harga";
            this.columnHeader3.Width = 100;
            // 
            // panel43
            // 
            this.panel43.BackColor = System.Drawing.SystemColors.Window;
            this.panel43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel43.Controls.Add(this.TotalBayar);
            this.panel43.Controls.Add(this.label10);
            this.panel43.Location = new System.Drawing.Point(4, 382);
            this.panel43.Margin = new System.Windows.Forms.Padding(4);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(545, 60);
            this.panel43.TabIndex = 12;
            // 
            // TotalBayar
            // 
            this.TotalBayar.AutoSize = true;
            this.TotalBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TotalBayar.Location = new System.Drawing.Point(249, 16);
            this.TotalBayar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalBayar.Name = "TotalBayar";
            this.TotalBayar.Size = new System.Drawing.Size(157, 24);
            this.TotalBayar.TabIndex = 14;
            this.TotalBayar.Text = "Rp.[Total Harga],-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total Bayar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(4, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Produk yang Dicheckout";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(593, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lakukan Pembayaran";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel6.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel6.Controls.Add(this.label16);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(599, 78);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(489, 471);
            this.flowLayoutPanel6.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label16.Location = new System.Drawing.Point(4, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Pay QRIS";
            // 
            // Bayar
            // 
            this.Bayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Bayar.Location = new System.Drawing.Point(111, 473);
            this.Bayar.Margin = new System.Windows.Forms.Padding(4);
            this.Bayar.Name = "Bayar";
            this.Bayar.Size = new System.Drawing.Size(300, 55);
            this.Bayar.TabIndex = 27;
            this.Bayar.Text = "Bayar";
            this.Bayar.UseVisualStyleBackColor = true;
            this.Bayar.Click += new System.EventHandler(this.Bayar_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 679);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.panel42);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Payment";
            this.Text = "Payment";
            this.panel42.ResumeLayout(false);
            this.panel42.PerformLayout();
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Label TotalBayar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Bayar;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}