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
            this.panel42 = new System.Windows.Forms.Panel();
            this.listBoxRincian = new System.Windows.Forms.ListBox();
            this.Bayar = new System.Windows.Forms.Button();
            this.panel43 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotalBayar = new System.Windows.Forms.Label();
            this.label_totalBayar = new System.Windows.Forms.Label();
            this.TotalBayar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelCart = new System.Windows.Forms.Label();
            this.labelQRPembayaran = new System.Windows.Forms.Label();
            this.labelPaymentState = new System.Windows.Forms.Label();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.panel42.SuspendLayout();
            this.panel43.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel42
            // 
            this.panel42.BackColor = System.Drawing.SystemColors.Window;
            this.panel42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel42.Controls.Add(this.listBoxRincian);
            this.panel42.Controls.Add(this.Bayar);
            this.panel42.Controls.Add(this.panel43);
            this.panel42.Controls.Add(this.labelCart);
            this.panel42.Location = new System.Drawing.Point(12, 26);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(417, 394);
            this.panel42.TabIndex = 16;
            // 
            // listBoxRincian
            // 
            this.listBoxRincian.FormattingEnabled = true;
            this.listBoxRincian.Location = new System.Drawing.Point(15, 36);
            this.listBoxRincian.Name = "listBoxRincian";
            this.listBoxRincian.Size = new System.Drawing.Size(375, 199);
            this.listBoxRincian.TabIndex = 28;
            // 
            // Bayar
            // 
            this.Bayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Bayar.Location = new System.Drawing.Point(91, 321);
            this.Bayar.Name = "Bayar";
            this.Bayar.Size = new System.Drawing.Size(225, 45);
            this.Bayar.TabIndex = 27;
            this.Bayar.Text = "Bayar";
            this.Bayar.UseVisualStyleBackColor = true;
            this.Bayar.Click += new System.EventHandler(this.buttonBayar_Click);
            // 
            // panel43
            // 
            this.panel43.BackColor = System.Drawing.SystemColors.Window;
            this.panel43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel43.Controls.Add(this.panel1);
            this.panel43.Controls.Add(this.TotalBayar);
            this.panel43.Controls.Add(this.label10);
            this.panel43.Location = new System.Drawing.Point(3, 249);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(409, 49);
            this.panel43.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTotalBayar);
            this.panel1.Controls.Add(this.label_totalBayar);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 49);
            this.panel1.TabIndex = 15;
            // 
            // labelTotalBayar
            // 
            this.labelTotalBayar.AutoSize = true;
            this.labelTotalBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelTotalBayar.Location = new System.Drawing.Point(127, 13);
            this.labelTotalBayar.Name = "labelTotalBayar";
            this.labelTotalBayar.Size = new System.Drawing.Size(39, 18);
            this.labelTotalBayar.TabIndex = 27;
            this.labelTotalBayar.Text = "Rp.0";
            // 
            // label_totalBayar
            // 
            this.label_totalBayar.AutoSize = true;
            this.label_totalBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalBayar.Location = new System.Drawing.Point(8, 13);
            this.label_totalBayar.Name = "label_totalBayar";
            this.label_totalBayar.Size = new System.Drawing.Size(104, 18);
            this.label_totalBayar.TabIndex = 13;
            this.label_totalBayar.Text = "Total Bayar :";
            // 
            // TotalBayar
            // 
            this.TotalBayar.AutoSize = true;
            this.TotalBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TotalBayar.Location = new System.Drawing.Point(187, 13);
            this.TotalBayar.Name = "TotalBayar";
            this.TotalBayar.Size = new System.Drawing.Size(125, 18);
            this.TotalBayar.TabIndex = 14;
            this.TotalBayar.Text = "Rp.[Total Harga],-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total Bayar :";
            // 
            // labelCart
            // 
            this.labelCart.AutoSize = true;
            this.labelCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCart.Location = new System.Drawing.Point(3, 5);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(170, 18);
            this.labelCart.TabIndex = 7;
            this.labelCart.Text = "Produk yang Dicheckout";
            this.labelCart.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelQRPembayaran
            // 
            this.labelQRPembayaran.AutoSize = true;
            this.labelQRPembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelQRPembayaran.Location = new System.Drawing.Point(445, 26);
            this.labelQRPembayaran.Name = "labelQRPembayaran";
            this.labelQRPembayaran.Size = new System.Drawing.Size(224, 26);
            this.labelQRPembayaran.TabIndex = 14;
            this.labelQRPembayaran.Text = "Lakukan Pembayaran";
            // 
            // labelPaymentState
            // 
            this.labelPaymentState.AutoSize = true;
            this.labelPaymentState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelPaymentState.Location = new System.Drawing.Point(453, 348);
            this.labelPaymentState.Name = "labelPaymentState";
            this.labelPaymentState.Size = new System.Drawing.Size(42, 18);
            this.labelPaymentState.TabIndex = 14;
            this.labelPaymentState.Text = "State";
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(450, 56);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(314, 289);
            this.pictureBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQRCode.TabIndex = 17;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 432);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.labelPaymentState);
            this.Controls.Add(this.panel42);
            this.Controls.Add(this.labelQRPembayaran);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel42.ResumeLayout(false);
            this.panel42.PerformLayout();
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Label TotalBayar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelCart;
        private System.Windows.Forms.Label labelQRPembayaran;
        private System.Windows.Forms.Button Bayar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_totalBayar;
        private System.Windows.Forms.Label labelPaymentState;
        private System.Windows.Forms.ListBox listBoxRincian;
        private System.Windows.Forms.Label labelTotalBayar;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
    }
}