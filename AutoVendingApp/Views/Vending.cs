using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoVendingApp
{
    public partial class Vending: Form
    {
        private bool isMesinMenyala = true;
        private List<Item> daftarProduk = new List<Item>();
        private List<Button> tombolProduk;
        private List<Label> labelHarga;
        public Vending()
        {
            InitializeComponent();
            InisialisasiKontrolUI();
            InisialisasiProduk();
            ApplyLanguage();
            LanguageManager.LanguageChanged += ApplyLanguage;
        }

        private void ApplyLanguage()
        {
            this.Text = LanguageManager.GetString("VendingForm_Title");
            Title.Text = LanguageManager.GetString("VendingForm_Title");
            
        }

        // PENTING: Unsubscribe dari event saat form ditutup untuk menghindari memory leak
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            LanguageManager.LanguageChanged -= ApplyLanguage;
            base.OnFormClosed(e);
        }

        private void InisialisasiKontrolUI()
        {
            // Daftarkan semua tombol produk
            tombolProduk = new List<Button> {
    button1, button2, button3, button4,
    button5, button6, button7, button8,
    button9, button10, button11, button12,
    button13, button14, button15, button16,
    button17, button18, button19, button20
};

            labelHarga = new List<Label> {
    hargaLabel1, hargaLabel2, hargaLabel3, hargaLabel4,
    hargaLabel5, hargaLabel6, hargaLabel7, hargaLabel8,
    hargaLabel9, hargaLabel10, hargaLabel11, hargaLabel12,
    hargaLabel13, hargaLabel14, hargaLabel15, hargaLabel16,
    hargaLabel17, hargaLabel18, hargaLabel19, hargaLabel20
};
        }

        private void InisialisasiProduk()
        {
            daftarProduk.Add(new Item { Id = 1, NamaProduk = "Snack Kentang", Harga = 5000, Stok = 10 });
            daftarProduk.Add(new Item { Id = 2, NamaProduk = "Teh Kotak", Harga = 3500, Stok = 15 });
            daftarProduk.Add(new Item { Id = 3, NamaProduk = "Cokelat Susu", Harga = 7000, Stok = 8 });
            daftarProduk.Add(new Item { Id = 4, NamaProduk = "Wafer Keju", Harga = 2000, Stok = 20 });


            for (int i = 0; i < daftarProduk.Count; i++)
            {
                // Pastikan tidak mencoba mengakses slot yang tidak ada
                if (i >= tombolProduk.Count) break;

                Item produk = daftarProduk[i];

                // Isi data ke kontrol UI yang sesuai
                labelHarga[i].Text = $"Rp {produk.Harga:N0}"; // Format mata uang tanpa desimal
                tombolProduk[i].Tag = produk;
                tombolProduk[i].Text = produk.NamaProduk; // Ubah teks tombol menjadi lebih relevan
            }
        }

        private void TombolProduk_Click(object sender, EventArgs e)
        {
            
            Button tombolYangDiklik = sender as Button;

            if (tombolYangDiklik != null && tombolYangDiklik.Tag is Item)
            {
                
                Item itemTerpilih = tombolYangDiklik.Tag as Item;

                Payment formBayar = new Payment(itemTerpilih);
                formBayar.ShowDialog(); 
            }
        }

        private void TombolPower(object sender, EventArgs e)
        {
            // Balikkan status mesin
            // Jika sedang true (menyala), akan menjadi false (mati). Begitu juga sebaliknya.
            isMesinMenyala = !isMesinMenyala;

            // Terapkan status baru ke panel produk
            ItemsVending.Enabled = isMesinMenyala;

            // (Opsional) Beri feedback visual kepada pengguna
            if (isMesinMenyala)
            {
                // Jika mesin menyala
                labelPower.Text = "Turn Off";
                TombolPowerVending.BackColor = Color.Red;
                Status.Text = "Operational"; // Asumsi Anda punya label untuk status
                PanelStatus.ForeColor = Color.Green;
            }
            else
            {
                // Jika mesin mati
                labelPower.Text = "Turn On";
                TombolPowerVending.BackColor = Color.Green;
                Status.Text = "Out of Service";
                PanelStatus.ForeColor = Color.Red;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            LanguageSettings halamanBahasa = new LanguageSettings();
            halamanBahasa.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            AdminSettings admin = new AdminSettings();
            AdminSettings.Show();
        }
    }
}
