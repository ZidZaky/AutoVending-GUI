namespace AutoVendingApp
{
    partial class AdminSettings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioYEN = new System.Windows.Forms.RadioButton();
            this.radioEUR = new System.Windows.Forms.RadioButton();
            this.radioIDR = new System.Windows.Forms.RadioButton();
            this.radioUSD = new System.Windows.Forms.RadioButton();
            this.title_MataUang = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.idTransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banyakProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioYEN);
            this.panel1.Controls.Add(this.radioEUR);
            this.panel1.Controls.Add(this.radioIDR);
            this.panel1.Controls.Add(this.radioUSD);
            this.panel1.Controls.Add(this.title_MataUang);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 123);
            this.panel1.TabIndex = 17;
            // 
            // radioYEN
            // 
            this.radioYEN.AutoSize = true;
            this.radioYEN.Location = new System.Drawing.Point(15, 98);
            this.radioYEN.Name = "radioYEN";
            this.radioYEN.Size = new System.Drawing.Size(47, 17);
            this.radioYEN.TabIndex = 4;
            this.radioYEN.TabStop = true;
            this.radioYEN.Text = "YEN";
            this.radioYEN.UseVisualStyleBackColor = true;
            this.radioYEN.CheckedChanged += new System.EventHandler(this.radioYEN_CheckedChanged);
            // 
            // radioEUR
            // 
            this.radioEUR.AutoSize = true;
            this.radioEUR.Location = new System.Drawing.Point(15, 75);
            this.radioEUR.Name = "radioEUR";
            this.radioEUR.Size = new System.Drawing.Size(48, 17);
            this.radioEUR.TabIndex = 3;
            this.radioEUR.TabStop = true;
            this.radioEUR.Text = "EUR";
            this.radioEUR.UseVisualStyleBackColor = true;
            this.radioEUR.CheckedChanged += new System.EventHandler(this.radioEUR_CheckedChanged);
            // 
            // radioIDR
            // 
            this.radioIDR.AutoSize = true;
            this.radioIDR.Location = new System.Drawing.Point(15, 28);
            this.radioIDR.Name = "radioIDR";
            this.radioIDR.Size = new System.Drawing.Size(40, 17);
            this.radioIDR.TabIndex = 2;
            this.radioIDR.TabStop = true;
            this.radioIDR.Text = "RP";
            this.radioIDR.UseVisualStyleBackColor = true;
            this.radioIDR.CheckedChanged += new System.EventHandler(this.radioIDR_CheckedChanged);
            // 
            // radioUSD
            // 
            this.radioUSD.AutoSize = true;
            this.radioUSD.Location = new System.Drawing.Point(15, 51);
            this.radioUSD.Name = "radioUSD";
            this.radioUSD.Size = new System.Drawing.Size(48, 17);
            this.radioUSD.TabIndex = 1;
            this.radioUSD.TabStop = true;
            this.radioUSD.Text = "USD";
            this.radioUSD.UseVisualStyleBackColor = true;
            this.radioUSD.CheckedChanged += new System.EventHandler(this.radioUSD_CheckedChanged);
            // 
            // title_MataUang
            // 
            this.title_MataUang.AutoSize = true;
            this.title_MataUang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.title_MataUang.Location = new System.Drawing.Point(12, 9);
            this.title_MataUang.Name = "title_MataUang";
            this.title_MataUang.Size = new System.Drawing.Size(211, 17);
            this.title_MataUang.TabIndex = 0;
            this.title_MataUang.Text = "Mata Uang Yang Diterima Mesin";
            this.title_MataUang.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewHistory);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(364, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 275);
            this.panel2.TabIndex = 18;
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransaksi,
            this.namaProduk,
            this.banyakProduk});
            this.dataGridViewHistory.Location = new System.Drawing.Point(-53, 37);
            this.dataGridViewHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.RowHeadersWidth = 51;
            this.dataGridViewHistory.RowTemplate.Height = 24;
            this.dataGridViewHistory.Size = new System.Drawing.Size(470, 236);
            this.dataGridViewHistory.TabIndex = 21;
            this.dataGridViewHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(283, 201);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(108, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "History Transaksi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Admin Dashboard";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.label13);
            this.flowLayoutPanel4.Controls.Add(this.Status);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(12, 169);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(111, 42);
            this.flowLayoutPanel4.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Machine Status";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Status.Location = new System.Drawing.Point(3, 13);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(91, 20);
            this.Status.TabIndex = 1;
            this.Status.Text = "Operational";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idTransaksi
            // 
            this.idTransaksi.HeaderText = "Tanggal";
            this.idTransaksi.MinimumWidth = 6;
            this.idTransaksi.Name = "idTransaksi";
            this.idTransaksi.ReadOnly = true;
            this.idTransaksi.Width = 125;
            // 
            // namaProduk
            // 
            this.namaProduk.HeaderText = "List Produk";
            this.namaProduk.MinimumWidth = 6;
            this.namaProduk.Name = "namaProduk";
            this.namaProduk.Width = 125;
            // 
            // banyakProduk
            // 
            this.banyakProduk.HeaderText = "Total Bayar";
            this.banyakProduk.MinimumWidth = 6;
            this.banyakProduk.Name = "banyakProduk";
            this.banyakProduk.Width = 125;
            // 
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminSettings";
            this.Text = "AdminSettings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioUSD;
        private System.Windows.Forms.Label title_MataUang;
        private System.Windows.Forms.RadioButton radioEUR;
        private System.Windows.Forms.RadioButton radioIDR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.RadioButton radioYEN;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn banyakProduk;
    }
}