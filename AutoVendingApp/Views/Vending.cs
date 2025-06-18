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
        private VendingState currentState;
        private List<Item> daftarProduk;
        private Dictionary<Item, int> keranjangBelanja = new Dictionary<Item, int>();
        private bool isMesinMenyala = true;
        public readonly IProductService productService;

        private List<Button> tombolProduk;
        private List<Label> labelHarga;

        public Vending(IProductService productService)
        {
           
            this.keranjangBelanja = new Dictionary<Item, int>();
            this.productService = productService; 

            this.isMesinMenyala = true;
            SetState(VendingState.Idle);
        }

        public Vending()
        {
            InitializeComponent();

            this.productService = new ProductService();
            ApplyLanguage();
            LanguageManager.LanguageChanged += ApplyLanguage;
            InisialisasiKontrolUI();
            InisialisasiProduk();
            SetState(VendingState.Idle);
            CurrencyEvents.CurrencyChanged += UpdateCurrencyDisplay;
            UpdateCurrencyDisplay();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            LanguageManager.LanguageChanged -= ApplyLanguage;
            base.OnFormClosed(e);
        }

        private void ApplyLanguage()
        {
            
            this.Text = LanguageManager.GetString("VendingForm_Title");
            WelcomeMessage.Text = LanguageManager.GetString("WelcomeMessage");
            UserGuideTitle.Text = LanguageManager.GetString("UserGuideTitle");
            OperationalTitle.Text = LanguageManager.GetString("OperationalTitle");
            SettingsLabel.Text = LanguageManager.GetString("SettingsTitle");
            button21.Text = LanguageManager.GetString("LanguageButton");
            label19.Text = LanguageManager.GetString("CartLabel");
            buttonCheckout.Text = LanguageManager.GetString("PaymentButton");
            labelTotal.Text = LanguageManager.GetString("TotalPaymentLabel");


        }

        private void UpdateCurrencyDisplay()
        {
            InisialisasiProduk();

        }

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

        private void InisialisasiProduk()
        {
            this.daftarProduk = productService.GetProducts();

            string selectedCurrency = CurrencyAppState.SelectedCurrency;
            string symbol = CurrencyManager.GetSymbol(selectedCurrency);


            for (int i = 0; i < daftarProduk.Count; i++)
            {
                if (i >= tombolProduk.Count) break;

                Item produk = daftarProduk[i];

                decimal hargaConverted = CurrencyManager.Convert("IDR", selectedCurrency, produk.Harga);

                labelHarga[i].Text = $"{symbol} {hargaConverted:N2}";
                tombolProduk[i].Tag = produk;
                tombolProduk[i].Text = produk.NamaProduk;
            }
        }


        private void TombolProduk_Click(object sender, EventArgs e)
        {
            if (currentState == VendingState.ProcessingPayment || !isMesinMenyala) return;

            Button tombol = sender as Button;
            if (tombol?.Tag is Item produkTerpilih)
            {
                TambahProdukKeKeranjang(produkTerpilih);

                SetState(VendingState.SelectingItems);
                UpdateTampilanKeranjang();
            }
        }

        public void TambahProdukKeKeranjang(Item produk)
        {
            if (produk == null) return;

            if (keranjangBelanja.ContainsKey(produk))
            {
                keranjangBelanja[produk]++;
            }
            else
            {
                keranjangBelanja.Add(produk, 1);
            }
        }

        public IReadOnlyDictionary<Item, int> GetKeranjangBelanja()
        {
            return keranjangBelanja;
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
                        var transactionService = new TransactionService();
                        var newTransaction = new Transaction
                        {
                            Id = Guid.NewGuid(),
                            Timestamp = DateTime.Now,
                            Items = keranjangBelanja.Select(kvp => new TransactionItem
                            {
                                ProductName = kvp.Key.NamaProduk,
                                Quantity = kvp.Value,
                                PricePerItem = kvp.Key.Harga
                            }).ToList(),
                            TotalPrice = keranjangBelanja.Sum(kvp => kvp.Key.Harga * kvp.Value),
                            Currency = CurrencyAppState.SelectedCurrency
                        };
                        transactionService.AddTransaction(newTransaction);
                      
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

            if (MachineState != null)
            {
                MachineState.Text = newState.ToString();
            }
            if (!isMesinMenyala)
            {
                MachineState.Text = "offline";
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
            labelTotal.Text = $"Total: Rp {total:N0}";
        }

        private void TombolPower(object sender, EventArgs e)
        {
            isMesinMenyala = !isMesinMenyala;
            SetState(currentState);

        }

        
        private void buttonAdminSettings_Click(object sender, EventArgs e)
        {
            LoginAdmin admin = new LoginAdmin();
            admin.Show();
        }

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            LanguageSettings settingsForm = new LanguageSettings();
            settingsForm.ShowDialog();
        }

    }
}