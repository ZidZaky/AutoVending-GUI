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
            this.Bayar = new System.Windows.Forms.Button();
            this.panel43 = new System.Windows.Forms.Panel();
            this.labelTotalBayar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.listBoxRincian = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPaymentState = new System.Windows.Forms.Label();
            this.panel42.SuspendLayout();
            this.panel43.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel42
            // 
            this.panel42.BackColor = System.Drawing.SystemColors.Window;
            this.panel42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel42.Controls.Add(this.listBoxRincian);
            this.panel42.Controls.Add(this.Bayar);
            this.panel42.Controls.Add(this.panel43);
            this.panel42.Controls.Add(this.label4);
            this.panel42.Location = new System.Drawing.Point(12, 26);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(417, 415);
            this.panel42.TabIndex = 16;
            // 
            // Bayar
            // 
            this.Bayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Bayar.Location = new System.Drawing.Point(85, 343);
            this.Bayar.Name = "Bayar";
            this.Bayar.Size = new System.Drawing.Size(225, 45);
            this.Bayar.TabIndex = 27;
            this.Bayar.Text = "Konfirmasi Pembayaran";
            this.Bayar.UseVisualStyleBackColor = true;
            this.Bayar.Click += new System.EventHandler(this.buttonBayar_Click);
            // 
            // panel43
            // 
            this.panel43.BackColor = System.Drawing.SystemColors.Window;
            this.panel43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel43.Controls.Add(this.labelTotalBayar);
            this.panel43.Controls.Add(this.label10);
            this.panel43.Location = new System.Drawing.Point(3, 273);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(409, 49);
            this.panel43.TabIndex = 12;
            // 
            // labelTotalBayar
            // 
            this.labelTotalBayar.AutoSize = true;
            this.labelTotalBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelTotalBayar.Location = new System.Drawing.Point(187, 13);
            this.labelTotalBayar.Name = "labelTotalBayar";
            this.labelTotalBayar.Size = new System.Drawing.Size(125, 18);
            this.labelTotalBayar.TabIndex = 14;
            this.labelTotalBayar.Text = "Rp.[Total Harga],-";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Produk yang Dicheckout";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(445, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lakukan Pembayaran";
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(450, 56);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(363, 330);
            this.pictureBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQRCode.TabIndex = 17;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // listBoxRincian
            // 
            this.listBoxRincian.FormattingEnabled = true;
            this.listBoxRincian.Location = new System.Drawing.Point(15, 29);
            this.listBoxRincian.Name = "listBoxRincian";
            this.listBoxRincian.Size = new System.Drawing.Size(387, 238);
            this.listBoxRincian.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelPaymentState);
            this.panel1.Location = new System.Drawing.Point(450, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 49);
            this.panel1.TabIndex = 15;
            // 
            // labelPaymentState
            // 
            this.labelPaymentState.AutoSize = true;
            this.labelPaymentState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelPaymentState.Location = new System.Drawing.Point(10, 9);
            this.labelPaymentState.Name = "labelPaymentState";
            this.labelPaymentState.Size = new System.Drawing.Size(94, 18);
            this.labelPaymentState.TabIndex = 14;
            this.labelPaymentState.Text = "VendingState";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.panel42);
            this.Controls.Add(this.label3);
            this.Name = "Payment";
            this.Text = "Payment";
            this.panel42.ResumeLayout(false);
            this.panel42.PerformLayout();
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Label labelTotalBayar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bayar;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.ListBox listBoxRincian;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPaymentState;
    }
}