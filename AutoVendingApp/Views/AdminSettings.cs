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
            CurrencyManager.Load();
            InitializeCurrencyRadioButtons();
        }

        private void InitializeCurrencyRadioButtons()
        {
            // Set radio button checked based on current/default currency
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

    }

    public static class CurrencyAppState
    {
        private static string _selectedCurrency;

        public static string SelectedCurrency
        {
            get
            {
                // Pastikan CurrencyManager sudah di-load
                if (string.IsNullOrEmpty(_selectedCurrency))
                {
                    // Tambahan pengecekan untuk menghindari NullReference jika _currencyData masih null
                    try
                    {
                        _selectedCurrency = CurrencyManager.GetDefaultCurrency();
                    }
                    catch
                    {
                        _selectedCurrency = "IDR"; // fallback agar aplikasi tidak crash
                    }
                }

                return _selectedCurrency;
            }
            set => _selectedCurrency = value;
        }
    }

    public static class CurrencyEvents
    {
        public static event Action CurrencyChanged;

        public static void NotifyCurrencyChanged()
        {
            CurrencyChanged?.Invoke();
        }
    }
}