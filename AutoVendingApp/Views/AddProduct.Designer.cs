namespace AutoVendingApp
{
    partial class AddProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.ItemsVending = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvProduk = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteUniversal = new System.Windows.Forms.Button();
            this.SaveAllData = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.flowLayoutPanel4.SuspendLayout();
            this.ItemsVending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.label13);
            this.flowLayoutPanel4.Controls.Add(this.Status);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(872, 898);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(147, 0);
            this.flowLayoutPanel4.TabIndex = 16;
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
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Status.Location = new System.Drawing.Point(117, 0);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(28, 200);
            this.Status.TabIndex = 1;
            this.Status.Text = "Operational";
            // 
            // ItemsVending
            // 
            this.ItemsVending.BackColor = System.Drawing.SystemColors.Window;
            this.ItemsVending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemsVending.Controls.Add(this.dgvProduk);
            this.ItemsVending.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemsVending.Location = new System.Drawing.Point(13, 15);
            this.ItemsVending.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsVending.Name = "ItemsVending";
            this.ItemsVending.Size = new System.Drawing.Size(555, 937);
            this.ItemsVending.TabIndex = 17;
            // 
            // dgvProduk
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NamaProduk,
            this.HargaProduk,
            this.Stok});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduk.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduk.Location = new System.Drawing.Point(3, 3);
            this.dgvProduk.Name = "dgvProduk";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduk.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduk.RowHeadersWidth = 51;
            this.dgvProduk.RowTemplate.Height = 24;
            this.dgvProduk.Size = new System.Drawing.Size(547, 468);
            this.dgvProduk.TabIndex = 28;
            this.dgvProduk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduk_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(576, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tambahkan Product";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnDeleteUniversal
            // 
            this.btnDeleteUniversal.Location = new System.Drawing.Point(582, 151);
            this.btnDeleteUniversal.Name = "btnDeleteUniversal";
            this.btnDeleteUniversal.Size = new System.Drawing.Size(170, 34);
            this.btnDeleteUniversal.TabIndex = 29;
            this.btnDeleteUniversal.Text = "Delete Selected Data";
            this.btnDeleteUniversal.UseVisualStyleBackColor = true;
            this.btnDeleteUniversal.Click += new System.EventHandler(this.btnDeleteUniversal_Click);
            // 
            // SaveAllData
            // 
            this.SaveAllData.Location = new System.Drawing.Point(582, 102);
            this.SaveAllData.Name = "SaveAllData";
            this.SaveAllData.Size = new System.Drawing.Size(170, 34);
            this.SaveAllData.TabIndex = 30;
            this.SaveAllData.Text = "Save All Data";
            this.SaveAllData.UseVisualStyleBackColor = true;
            this.SaveAllData.Click += new System.EventHandler(this.SaveAllData_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // NamaProduk
            // 
            this.NamaProduk.DataPropertyName = "NamaProduk";
            this.NamaProduk.FillWeight = 60F;
            this.NamaProduk.HeaderText = "Nama Produk";
            this.NamaProduk.MinimumWidth = 6;
            this.NamaProduk.Name = "NamaProduk";
            this.NamaProduk.Width = 150;
            // 
            // HargaProduk
            // 
            this.HargaProduk.DataPropertyName = "Harga";
            this.HargaProduk.FillWeight = 60F;
            this.HargaProduk.HeaderText = "Harga Produk";
            this.HargaProduk.MinimumWidth = 6;
            this.HargaProduk.Name = "HargaProduk";
            this.HargaProduk.Width = 75;
            // 
            // Stok
            // 
            this.Stok.DataPropertyName = "Stok";
            this.Stok.HeaderText = "Stok Produk";
            this.Stok.MinimumWidth = 6;
            this.Stok.Name = "Stok";
            this.Stok.Width = 75;
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Location = new System.Drawing.Point(582, 59);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(170, 23);
            this.buttonAddNewProduct.TabIndex = 31;
            this.buttonAddNewProduct.Text = "Add New Product";
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
            this.buttonAddNewProduct.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 502);
            this.Controls.Add(this.buttonAddNewProduct);
            this.Controls.Add(this.SaveAllData);
            this.Controls.Add(this.btnDeleteUniversal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemsVending);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ItemsVending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.FlowLayoutPanel ItemsVending;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProduk;
        private System.Windows.Forms.Button btnDeleteUniversal;
        private System.Windows.Forms.Button SaveAllData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
        private System.Windows.Forms.Button buttonAddNewProduct;
    }
}