using AutoVending.Core;
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
    public partial class AdminSettings : Form
    {
        public AdminSettings()
        {
            InitializeComponent();
            LoadTransactionHistory();
            CurrencyManager.Load();
            InitializeCurrencyRadioButtons();
        }

        private void LoadTransactionHistory()
        {
            var service = new TransactionService();
            var transactions = service.GetAllTransactions();

            dataGridViewHistory.Rows.Clear();

            foreach (var trx in transactions.OrderByDescending(t => t.Timestamp))
            {
                string productDetails = string.Join(", ", trx.Items.Select(item => $"{item.ProductName} (x{item.Quantity})"));

                // Tambahkan baris baru ke tabel
                dataGridViewHistory.Rows.Add(
                    trx.Timestamp.ToString("dd-MM-yyyy HH:mm"), 
                    productDetails,                             
                    trx.TotalPrice.ToString("N0")              
                );
            }
        }

        private void InitializeCurrencyRadioButtons()
        {
            string currentCurrency = CurrencyAppState.SelectedCurrency;
            switch (currentCurrency)
            {
                case "IDR": radioIDR.Checked = true; break;
                case "USD": radioUSD.Checked = true; break;
                case "EUR": radioEUR.Checked = true; break;
                case "JPY": radioYEN.Checked = true; break;
            }
        }

        private void SetCurrency(string currencyCode)
        {
            CurrencyAppState.SelectedCurrency = currencyCode;
            CurrencyEvents.NotifyCurrencyChanged();

            string symbol = CurrencyManager.GetSymbol(currencyCode);
            double rate = CurrencyManager.GetRate(currencyCode);
            string name = CurrencyManager.GetName(currencyCode);

            Console.WriteLine($"Currency set: {name} ({symbol}) - Rate: {rate:N6}");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioUSD_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUSD.Checked)
                SetCurrency("USD");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioIDR_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIDR.Checked)
                SetCurrency("IDR");
        }

        private void radioEUR_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEUR.Checked)
                SetCurrency("EUR");
        }

        private void radioYEN_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYEN.Checked)
                SetCurrency("JPY");
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct();
            addProductForm.Show();
        }
    }

}