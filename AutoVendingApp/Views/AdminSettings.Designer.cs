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
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioYEN = new System.Windows.Forms.RadioButton();
            this.radioEUR = new System.Windows.Forms.RadioButton();
            this.radioIDR = new System.Windows.Forms.RadioButton();
            this.radioUSD = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idTransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banyakProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuTransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textWaktuAkhir = new System.Windows.Forms.TextBox();
            this.textWaktuMulai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioYEN);
            this.panel1.Controls.Add(this.radioEUR);
            this.panel1.Controls.Add(this.radioIDR);
            this.panel1.Controls.Add(this.radioUSD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 151);
            this.panel1.TabIndex = 17;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 85);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "YEN";
            this.radioButton3.UseVisualStyleBackColor = true;
            // radioYEN
            // 
            this.radioYEN.AutoSize = true;
            this.radioYEN.Location = new System.Drawing.Point(20, 120);
            this.radioYEN.Margin = new System.Windows.Forms.Padding(4);
            this.radioYEN.Name = "radioYEN";
            this.radioYEN.Size = new System.Drawing.Size(56, 20);
            this.radioYEN.TabIndex = 4;
            this.radioYEN.TabStop = true;
            this.radioYEN.Text = "YEN";
            this.radioYEN.UseVisualStyleBackColor = true;
            this.radioYEN.CheckedChanged += new System.EventHandler(this.radioYEN_CheckedChanged);
            // 
            // radioEUR
            // 
            this.radioEUR.AutoSize = true;
            this.radioEUR.Location = new System.Drawing.Point(20, 92);
            this.radioEUR.Margin = new System.Windows.Forms.Padding(4);
            this.radioEUR.Name = "radioEUR";
            this.radioEUR.Size = new System.Drawing.Size(57, 20);
            this.radioEUR.TabIndex = 3;
            this.radioEUR.TabStop = true;
            this.radioEUR.Text = "EUR";
            this.radioEUR.UseVisualStyleBackColor = true;
            this.radioEUR.CheckedChanged += new System.EventHandler(this.radioEUR_CheckedChanged);
            // 
            // radioIDR
            // 
            this.radioIDR.AutoSize = true;
            this.radioIDR.Location = new System.Drawing.Point(20, 35);
            this.radioIDR.Margin = new System.Windows.Forms.Padding(4);
            this.radioIDR.Name = "radioIDR";
            this.radioIDR.Size = new System.Drawing.Size(47, 20);
            this.radioIDR.TabIndex = 2;
            this.radioIDR.TabStop = true;
            this.radioIDR.Text = "RP";
            this.radioIDR.UseVisualStyleBackColor = true;
            this.radioIDR.CheckedChanged += new System.EventHandler(this.radioIDR_CheckedChanged);
            // 
            // radioUSD
            // 
            this.radioUSD.AutoSize = true;
            this.radioUSD.Location = new System.Drawing.Point(20, 63);
            this.radioUSD.Margin = new System.Windows.Forms.Padding(4);
            this.radioUSD.Name = "radioUSD";
            this.radioUSD.Size = new System.Drawing.Size(57, 20);
            this.radioUSD.TabIndex = 1;
            this.radioUSD.TabStop = true;
            this.radioUSD.Text = "USD";
            this.radioUSD.UseVisualStyleBackColor = true;
            this.radioUSD.CheckedChanged += new System.EventHandler(this.radioUSD_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mata Uang Yang Diterima Mesin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(485, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 339);
            this.panel2.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransaksi,
            this.namaProduk,
            this.banyakProduk,
            this.waktuTransaksi});
            this.dataGridView1.Location = new System.Drawing.Point(4, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 290);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "USD";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mata Uang Yang Diterima Mesin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(364, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 245);
            this.panel2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(383, 198);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            //this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Transaksi";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nama Produk";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Jumlah";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Bayar";
            this.columnHeader4.Width = 100;
            // idTransaksi
            // 
            this.idTransaksi.HeaderText = "No";
            this.idTransaksi.MinimumWidth = 6;
            this.idTransaksi.Name = "idTransaksi";
            this.idTransaksi.ReadOnly = true;
            this.idTransaksi.Width = 125;
            // 
            // namaProduk
            // 
            this.namaProduk.HeaderText = "Nama Produk";
            this.namaProduk.MinimumWidth = 6;
            this.namaProduk.Name = "namaProduk";
            this.namaProduk.Width = 125;
            // 
            // banyakProduk
            // 
            this.banyakProduk.HeaderText = "QTY";
            this.banyakProduk.MinimumWidth = 6;
            this.banyakProduk.Name = "banyakProduk";
            this.banyakProduk.Width = 125;
            // 
            // waktuTransaksi
            // 
            this.waktuTransaksi.HeaderText = "Waktu Transaksi";
            this.waktuTransaksi.MinimumWidth = 6;
            this.waktuTransaksi.Name = "waktuTransaksi";
            this.waktuTransaksi.Width = 125;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 45);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(376, 246);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(54, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "History Transaksi";
            this.label7.Location = new System.Drawing.Point(213, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 31);
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
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 31);
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
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Waktu Akhir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Waktu Akhir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Waktu Mulai";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Waktu Operasional Vending";
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
            this.flowLayoutPanel4.Location = new System.Drawing.Point(794, 215);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(894, 380);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(147, 51);
            this.flowLayoutPanel4.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label13.Location = new System.Drawing.Point(4, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Machine Status";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Status.Location = new System.Drawing.Point(4, 17);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(113, 25);
            this.Status.TabIndex = 1;
            this.Status.Text = "Operational";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 403);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(16, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(462, 82);
            this.panel4.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Weekday",
            "Weekend",
            "24 Hours"});
            this.comboBox1.Location = new System.Drawing.Point(20, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
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
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 272);
            this.ClientSize = new System.Drawing.Size(1067, 444);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminSettings";
            this.Text = "AdminSettings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioUSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioEUR;
        private System.Windows.Forms.RadioButton radioIDR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textWaktuAkhir;
        private System.Windows.Forms.TextBox textWaktuMulai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn banyakProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuTransaksi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radioYEN;
    }
}