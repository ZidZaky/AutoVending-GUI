using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AutoVending.Core;
using AutoVendingVend.Core; // Pastikan namespace ini benar

namespace AutoVendingApp
{
    public partial class Vending : Form
    {
        // === STATE & DATA (Gabungan dari kedua versi) ===
        private VendingState currentState;
        private List<Item> daftarProduk = new List<Item>();
        private Dictionary<Item, int> keranjangBelanja = new Dictionary<Item, int>();
        private bool isMesinMenyala = true;
        private readonly ProductService productService;

        // === KONTROL UI ===
        private List<Button> tombolProduk;
        private List<Label> labelHarga;

        public Vending()
        {
            InitializeComponent();
            this.productService = new ProductService();
            InisialisasiKontrolUI();
            InisialisasiProduk();
            SetState(VendingState.Idle); // Mengatur state awal dari versi canggih
        }

        // DARI VERSI BARU ANDA: Inisialisasi kontrol secara manual
        private void InisialisasiKontrolUI()
        {
            tombolProduk = new List<Button> {
                button1, button2, button3, button4, button5, button6, button7, button8,
                button9, button10, button11, button12, button13, button14, button15,
                button16, button17, button18, button19, button20
            };

            labelHarga = new List<Label> {
                hargaLabel1, hargaLabel2, hargaLabel3, hargaLabel4, hargaLabel5, hargaLabel6,
                hargaLabel7, hargaLabel8, hargaLabel9, hargaLabel10, hargaLabel11, hargaLabel12,
                hargaLabel13, hargaLabel14, hargaLabel15, hargaLabel16, hargaLabel17,
                hargaLabel18, hargaLabel19, hargaLabel20
            };
        }

        // GABUNGAN: Menggunakan data produk hardcoded agar produk kembali tampil
        private void InisialisasiProduk()
        {
            this.daftarProduk = productService.GetProducts();

            // Data produk ditambahkan kembali agar tidak kosong
            daftarProduk.Add(new Item { Id = 5, NamaProduk = "Snack Kentang", Harga = 5000, Stok = 10 });
            daftarProduk.Add(new Item { Id = 6, NamaProduk = "Teh Kotak", Harga = 3500, Stok = 15 });
            daftarProduk.Add(new Item { Id = 7, NamaProduk = "Cokelat Susu", Harga = 7000, Stok = 8 });
            daftarProduk.Add(new Item { Id = 8, NamaProduk = "Wafer Keju", Harga = 2000, Stok = 20 });
            // ... Tambahkan 16 produk lainnya di sini jika ingin semua slot terisi


            // Logika untuk menampilkan data ke UI
            for (int i = 0; i < daftarProduk.Count; i++)
            {
                if (i >= tombolProduk.Count) break;
                Item produk = daftarProduk[i];
                labelHarga[i].Text = $"Rp {produk.Harga:N0}";
                tombolProduk[i].Tag = produk;
                tombolProduk[i].Text = produk.NamaProduk;
            }
        }

        // DARI VERSI CANGGIH: Logika klik produk untuk MENAMBAH KE KERANJANG
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

        // DARI VERSI CANGGIH: Logika untuk checkout
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

        // DARI VERSI CANGGIH: State Machine yang digabung dengan logika power
        private void SetState(VendingState newState)
        {
            currentState = newState;

            // Jika mesin mati, nonaktifkan semua, abaikan state
            if (!isMesinMenyala)
            {
                if (ItemsVending != null) ItemsVending.Enabled = false;
                if (buttonCheckout != null) buttonCheckout.Enabled = false;
                return;
            }

            // Atur UI berdasarkan state jika mesin menyala
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

        // DARI VERSI CANGGIH: Method untuk update tampilan keranjang
        private void UpdateTampilanKeranjang()
        {
            // Pastikan Anda punya ListBox bernama 'listBoxCart' dan Label 'labelTotal' di desain
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
            labelTotal.Text = $"Total: Rp {total:N0}";
        }

        // DARI VERSI BARU ANDA: Logika tombol power dipertahankan
        private void TombolPower(object sender, EventArgs e)
        {
            isMesinMenyala = !isMesinMenyala;

            // Panggil SetState untuk menerapkan status enable/disable yang benar
            SetState(currentState);

            if (isMesinMenyala)
            {
                labelPower.Text = "Turn Off";
                TombolPowerVending.BackColor = Color.Red;
                Status.Text = "Operational";
                PanelStatus.ForeColor = Color.Green;
            }
            else
            {
                labelPower.Text = "Turn On";
                TombolPowerVending.BackColor = Color.Green;
                Status.Text = "Out of Service";
                PanelStatus.ForeColor = Color.Red;
            }
        }
    }
}