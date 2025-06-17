using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AutoVendingApp
{
    public class Currency
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("conversion_rate")]
        public double ConversionRate { get; set; }
    }

    public class CurrencyData
    {
        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("currencies")]
        public Dictionary<string, Currency> Currencies { get; set; }
    }

    public static class CurrencyManager
    {
        private static readonly string currencyFilePath = "Json/currency.json";
        private static CurrencyData _currencyData;

        public static void Load()
        {
            try
            {
                string json = File.ReadAllText(currencyFilePath);
                _currencyData = JsonConvert.DeserializeObject<CurrencyData>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data mata uang: " + ex.Message);
                _currencyData = new CurrencyData
                {
                    DefaultCurrency = "IDR",
                    Currencies = new Dictionary<string, Currency>()
                };
            }
        }

        public static string GetSymbol(string code) =>
            _currencyData.Currencies.ContainsKey(code) ? _currencyData.Currencies[code].Symbol : "";

        public static string GetName(string code) =>
            _currencyData.Currencies.ContainsKey(code) ? _currencyData.Currencies[code].Name : "";

        public static double GetRate(string code) =>
            _currencyData.Currencies.ContainsKey(code) ? _currencyData.Currencies[code].ConversionRate : 1;

        public static decimal Convert(string fromCode, string toCode, decimal amount)
        {
            decimal fromRate = (decimal)GetRate(fromCode);
            decimal toRate = (decimal)GetRate(toCode);

            if (fromRate == 0 || toRate == 0) return amount;

            decimal amountInBase = amount / fromRate;
            return amountInBase * toRate;
        }

        public static string GetDefaultCurrency() => _currencyData.DefaultCurrency;
    }
}
