using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AutoVendingVend.Core;
using AutoVending.Core;

namespace AutoVendingApp
{
    public partial class Payment : Form
    {
        // ... (properti lain tetap sama) ...
        private Dictionary<Item, int> keranjangBelanja;
        private decimal totalPembayaran;
        public bool TransaksiBerhasil { get; private set; } = false;

        public Payment(Dictionary<Item, int> keranjang)
        {
            InitializeComponent();
            this.keranjangBelanja = keranjang;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // --- BARIS BARU: Menampilkan state saat form dimuat ---
            if (labelPaymentState != null)
            {
                labelPaymentState.Text = "Current State: ProcessingPayment";
            }
            // --------------------------------------------------------

            HitungTotal();
            TampilkanDetailPembayaran();
            GenerateQRCode();
        }

        // ... (Sisa method lain di file ini tetap sama) ...
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
                labelTotalBayar.Text = $"Total Bayar: Rp {totalPembayaran:N0}";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}