using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AutoVending.Core;

namespace AutoVendingApp
{
    public partial class Vending : Form
    {
        // ... (properti lain tetap sama) ...
        private VendingState currentState;
        private List<Item> daftarProduk = new List<Item>();
        private Dictionary<Item, int> keranjangBelanja = new Dictionary<Item, int>();
        private bool isMesinMenyala = true;
        private List<Button> tombolProduk;
        private List<Label> labelHargaList;

        public Vending()
        {
            InitializeComponent();
            InisialisasiKontrolUI();
            InisialisasiProduk();
            SetState(VendingState.Idle);
        }

        // ... (GetAllControls dan InisialisasiKontrolUI tetap sama) ...
        private IEnumerable<Control> GetAllControls(Control container)
        {
            var controls = container.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllControls(ctrl)).Concat(controls);
        }

        private void InisialisasiKontrolUI()
        {
            // Daftarkan semua tombol produk
            tombolProduk = new List<Button> {
                button1, button2, button3, button4,
                button5, button6, button7, button8,
                button9, button10, button11, button12
            };
        }

        private void InisialisasiProduk()
        {
            daftarProduk.Add(new Item { Id = 1, NamaProduk = "Snack Kentang", Harga = 5000, Stok = 10 });
            daftarProduk.Add(new Item { Id = 2, NamaProduk = "Teh Kotak", Harga = 3500, Stok = 15 });
            daftarProduk.Add(new Item { Id = 3, NamaProduk = "Cokelat Susu", Harga = 7000, Stok = 8 });
            daftarProduk.Add(new Item { Id = 4, NamaProduk = "Wafer Keju", Harga = 2000, Stok = 20 });
            if (tombolProduk.Count == 0 || labelHargaList.Count == 0)
            {
                MessageBox.Show("Peringatan: Tidak ada Tombol atau Label produk yang ditemukan. Periksa nama kontrol di Form Designer.", "Inisialisasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < daftarProduk.Count; i++)
            {
                if (i >= tombolProduk.Count) break;
                Item produk = daftarProduk[i];
                tombolProduk[i].Text = produk.NamaProduk;
                tombolProduk[i].Tag = produk;
                if (i < labelHargaList.Count)
                {
                    labelHargaList[i].Text = $"Rp {produk.Harga:N0}";
                }
            }
        }
        private void TombolProduk_Click(object sender, EventArgs e)
        {
            if (currentState == VendingState.ProcessingPayment || !isMesinMenyala) return;
            Button tombol = sender as Button;
            if (tombol?.Tag is Item produkTerpilih)
            {
                if (keranjangBelanja.ContainsKey(produkTerpilih))
                {
                    keranjangBelanja[produkTerpilih]++;
                }
                else
                {
                    keranjangBelanja.Add(produkTerpilih, 1);
                }
                SetState(VendingState.SelectingItems);
                UpdateTampilanKeranjang();
            }
        }
        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (keranjangBelanja.Any())
            {
                SetState(VendingState.ProcessingPayment);
                using (Payment formBayar = new Payment(keranjangBelanja))
                {
                    formBayar.ShowDialog();
                    if (formBayar.TransaksiBerhasil)
                    {
                        foreach (var itemDiKeranjang in keranjangBelanja)
                        {
                            var itemDiDaftar = daftarProduk.FirstOrDefault(p => p.Id == itemDiKeranjang.Key.Id);
                            if (itemDiDaftar != null)
                            {
                                itemDiDaftar.Stok -= itemDiKeranjang.Value;
                            }
                        }
                    }
                }
                keranjangBelanja.Clear();
                UpdateTampilanKeranjang();
                SetState(VendingState.Idle);
            }
        }

        private void SetState(VendingState newState)
        {
            currentState = newState;

            // --- BARIS BARU: Update teks pada label state ---
            if (labelCurrentState != null)
            {
                labelCurrentState.Text = $"Current State: {currentState}";
            }
            // ----------------------------------------------------

            if (!isMesinMenyala)
            {
                if (ItemsVending != null) ItemsVending.Enabled = false;
                if (buttonCheckout != null) buttonCheckout.Enabled = false;
                return;
            }

            switch (currentState)
            {
                case VendingState.Idle:
                    if (ItemsVending != null) ItemsVending.Enabled = true;
                    if (buttonCheckout != null) buttonCheckout.Enabled = false;
                    break;
                case VendingState.SelectingItems:
                    if (ItemsVending != null) ItemsVending.Enabled = true;
                    if (buttonCheckout != null) buttonCheckout.Enabled = true;
                    break;
                case VendingState.ProcessingPayment:
                    if (ItemsVending != null) ItemsVending.Enabled = false;
                    if (buttonCheckout != null) buttonCheckout.Enabled = false;
                    break;
            }
        }

        // ... (UpdateTampilanKeranjang tetap sama) ...
        private void UpdateTampilanKeranjang()
        {
            if (listBoxCart == null || labelTotal == null) return;
            listBoxCart.Items.Clear();
            decimal total = 0;
            foreach (var entry in keranjangBelanja)
            {
                Item produk = entry.Key;
                int jumlah = entry.Value;
                listBoxCart.Items.Add($"{produk.NamaProduk} (x{jumlah}) - Rp {produk.Harga * jumlah:N0}");
                total += produk.Harga * jumlah;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
}
