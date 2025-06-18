using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AutoVending.Core; // Pastikan namespace Core Anda benar
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

            // --- BAGIAN BARU UNTUK BAHASA ---
            // 1. Terapkan bahasa saat form pertama kali dimuat
            ApplyLanguage();
            // 2. Berlangganan (subscribe) event agar form ini tahu jika ada perubahan bahasa
            LanguageManager.LanguageChanged += ApplyLanguage;
            // ---------------------------------
        }

        // Penting: Berhenti berlangganan saat form ditutup untuk mencegah memory leak
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            LanguageManager.LanguageChanged -= ApplyLanguage;
            base.OnFormClosed(e);
        }

        /// <summary>
        /// Method ini bertugas untuk mengambil semua teks dari LanguageManager
        /// dan menerapkannya ke kontrol-kontrol di form Payment.
        /// </summary>
        private void ApplyLanguage()
        {
            // Mengambil teks terjemahan menggunakan kunci dari file JSON
            this.Text = LanguageManager.GetString("PaymentForm_Title");

            // Asumsi kontrol Anda memiliki nama-nama berikut di Desain Form.
            // Sesuaikan jika perlu.
            labelCart.Text = LanguageManager.GetString("labelCart");
            label_totalBayar.Text = LanguageManager.GetString("label_totalBayar"); // label10 adalah "Total Bayar:"
            Bayar.Text = LanguageManager.GetString("Button_KonfirmasiPembayaran");
            labelQRPembayaran.Text = LanguageManager.GetString("labelQRPembayaran"); // label3 adalah "Lakukan Pembayaran"
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (labelPaymentState != null)
            {
                labelPaymentState.Text = "Current State: ProcessingPayment";
            }

            HitungTotal();
            TampilkanDetailPembayaran();
            GenerateQRCode();
        }

        private void HitungTotal()
        {
            totalPembayaran = 0;
            foreach (var entry in keranjangBelanja)
            {
                totalPembayaran += entry.Key.Harga * entry.Value;
            }
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
                // Bagian ini hanya menampilkan angkanya saja
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

        // Event handler kosong yang mungkin dibuat oleh designer bisa diabaikan atau dihapus
        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}