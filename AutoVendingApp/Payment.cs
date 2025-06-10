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
    public partial class Payment: Form
    {
        private Item produkYangDibeli;
        public Payment(Item produk)
        {
            InitializeComponent();
            this.produkYangDibeli = produk;
            TampilkanDetailProduk();
        }

        private void TampilkanDetailProduk()
        {
            if (produkYangDibeli != null)
            {
                SelectedProduct.Text = $"{produkYangDibeli.Id} - {produkYangDibeli.NamaProduk}";
                HargaProduk.Text = $"Rp {produkYangDibeli.Harga:N0}";
                TotalBayar.Text = $"Rp {produkYangDibeli.Harga:N0}";
            }
        }

        private void Bayar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pembayaran untuk {produkYangDibeli.NamaProduk} berhasil!");

            produkYangDibeli.Stok--;

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
