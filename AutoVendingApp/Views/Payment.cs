using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AutoVending.Core;
using QRCoder;

namespace AutoVendingApp
{
    public partial class Payment : Form
    {
        private Dictionary<Item, int> keranjangBelanja;
        private decimal totalPembayaran;
        public bool TransaksiBerhasil { get; private set; } = false;

        public Payment(Dictionary<Item, int> keranjang)
        {
            InitializeComponent();
            this.keranjangBelanja = keranjang;
            ApplyLanguage();
            LanguageManager.LanguageChanged += ApplyLanguage;
        }

        public Payment(Dictionary<Item, int> keranjang, bool isTest)
        {
            
            this.keranjangBelanja = keranjang;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            LanguageManager.LanguageChanged -= ApplyLanguage;
            base.OnFormClosed(e);
        }

        private void ApplyLanguage()
        {
            this.Text = LanguageManager.GetString("PaymentForm_Title");
            labelCart.Text = LanguageManager.GetString("labelCart");
            label_totalBayar.Text = LanguageManager.GetString("label_totalBayar");
            Bayar.Text = LanguageManager.GetString("Button_KonfirmasiPembayaran");
            labelQRPembayaran.Text = LanguageManager.GetString("labelQRPembayaran");
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (labelPaymentState != null)
            {
                labelPaymentState.Text = "Current State: ProcessingPayment";
            }

            totalPembayaran = HitungTotal();

            TampilkanDetailPembayaran();
            GenerateQRCode();
        }
        public decimal HitungTotal()
        {
            decimal total = 0;
            if (keranjangBelanja == null) return 0;

            foreach (var entry in keranjangBelanja)
            {
                total += entry.Key.Harga * entry.Value;
            }
            return total;
        }

        private void TampilkanDetailPembayaran()
        {
            if (listBoxRincian != null)
            {
                listBoxRincian.Items.Clear();
                foreach (var entry in keranjangBelanja)
                {
                    listBoxRincian.Items.Add($"{entry.Key.NamaProduk} (x{entry.Value})");
                }
            }
            if (labelTotalBayar != null)
            {
                labelTotalBayar.Text = $"Rp {totalPembayaran:N0}";
            }
        }

        private void GenerateQRCode()
        {
            if (pictureBoxQRCode != null)
            {
                string payloadQRIS = $"Total: {totalPembayaran}";
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(payloadQRIS, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                pictureBoxQRCode.Image = qrCodeImage;
            }
        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pembayaran berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.TransaksiBerhasil = true;
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}