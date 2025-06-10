namespace AutoVendingApp
{
    partial class LanguageSettings
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.radioJava = new System.Windows.Forms.RadioButton();
            this.radioEnglish = new System.Windows.Forms.RadioButton();
            this.radioIndonesia = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Language Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.radioJava);
            this.panel1.Controls.Add(this.radioEnglish);
            this.panel1.Controls.Add(this.radioIndonesia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 123);
            this.panel1.TabIndex = 19;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.label13);
            this.flowLayoutPanel4.Controls.Add(this.Status);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(219, 62);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(111, 48);
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
            // 
            // radioJava
            // 
            this.radioJava.AutoSize = true;
            this.radioJava.Location = new System.Drawing.Point(15, 85);
            this.radioJava.Name = "radioJava";
            this.radioJava.Size = new System.Drawing.Size(48, 17);
            this.radioJava.TabIndex = 3;
            this.radioJava.TabStop = true;
            this.radioJava.Text = "Java";
            this.radioJava.UseVisualStyleBackColor = true;
            this.radioJava.Click += new System.EventHandler(this.radioLanguage_CheckedChanged);
            // 
            // radioEnglish
            // 
            this.radioEnglish.AutoSize = true;
            this.radioEnglish.Location = new System.Drawing.Point(15, 62);
            this.radioEnglish.Name = "radioEnglish";
            this.radioEnglish.Size = new System.Drawing.Size(59, 17);
            this.radioEnglish.TabIndex = 2;
            this.radioEnglish.TabStop = true;
            this.radioEnglish.Text = "English";
            this.radioEnglish.UseVisualStyleBackColor = true;
            this.radioEnglish.Click += new System.EventHandler(this.radioLanguage_CheckedChanged);
            // 
            // radioIndonesia
            // 
            this.radioIndonesia.AutoSize = true;
            this.radioIndonesia.Location = new System.Drawing.Point(15, 39);
            this.radioIndonesia.Name = "radioIndonesia";
            this.radioIndonesia.Size = new System.Drawing.Size(71, 17);
            this.radioIndonesia.TabIndex = 1;
            this.radioIndonesia.TabStop = true;
            this.radioIndonesia.Text = "Indonesia";
            this.radioIndonesia.UseVisualStyleBackColor = true;
            this.radioIndonesia.Click += new System.EventHandler(this.radioLanguage_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bahasa Yang Tersedia";
            // 
            // LanguageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 180);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "LanguageSettings";
            this.Text = "LanguageSettings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioJava;
        private System.Windows.Forms.RadioButton radioEnglish;
        private System.Windows.Forms.RadioButton radioIndonesia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Status;
    }
}