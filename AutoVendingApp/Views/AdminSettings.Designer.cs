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
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
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
            this.radioYEN.Size = new System.Drawing.Size(57, 21);
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
            this.radioEUR.Size = new System.Drawing.Size(58, 21);
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
            this.radioIDR.Size = new System.Drawing.Size(48, 21);
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
            this.radioUSD.Size = new System.Drawing.Size(58, 21);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textWaktuAkhir);
            this.panel3.Controls.Add(this.textWaktuMulai);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(16, 296);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 101);
            this.panel3.TabIndex = 18;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Waktu Akhir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Waktu Mulai";
            // 
            // textWaktuAkhir
            // 
            this.textWaktuAkhir.Location = new System.Drawing.Point(216, 65);
            this.textWaktuAkhir.Margin = new System.Windows.Forms.Padding(4);
            this.textWaktuAkhir.Name = "textWaktuAkhir";
            this.textWaktuAkhir.Size = new System.Drawing.Size(132, 22);
            this.textWaktuAkhir.TabIndex = 2;
            // 
            // textWaktuMulai
            // 
            this.textWaktuMulai.Location = new System.Drawing.Point(20, 65);
            this.textWaktuMulai.Margin = new System.Windows.Forms.Padding(4);
            this.textWaktuMulai.Name = "textWaktuMulai";
            this.textWaktuMulai.Size = new System.Drawing.Size(132, 22);
            this.textWaktuMulai.TabIndex = 1;
            this.textWaktuMulai.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Custom Jam Operasional Vending";
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
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(16, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Pilih Jam Operasional Vending";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(377, 403);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(499, 403);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(108, 23);
            this.AddProduct.TabIndex = 23;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.ClientSize = new System.Drawing.Size(1067, 444);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnBack);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuTransaksi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radioYEN;
        private System.Windows.Forms.Button AddProduct;
    }
}