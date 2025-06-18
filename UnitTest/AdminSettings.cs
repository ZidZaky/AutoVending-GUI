// FILE: UnitTest/CurrencyManagerTest.cs

using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoVendingApp; // Namespace utama Anda
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class AdminSettings
    {
        [TestInitialize]
        public void Setup()
        {
            var dataKursPalsu = new CurrencyData
            {
                DefaultCurrency = "IDR",
                Currencies = new Dictionary<string, Currency>
                {
                    { "IDR", new Currency { Name = "Indonesian Rupiah", Symbol = "Rp", ConversionRate = 16000 } },
                    { "USD", new Currency { Name = "US Dollar", Symbol = "$", ConversionRate = 1 } },
                    { "EUR", new Currency { Name = "Euro", Symbol = "€", ConversionRate = 0.9 } },
                    { "YEN", new Currency { Name = "Japanese Yen", Symbol = "¥", ConversionRate = 150 } }
                }
            };

            CurrencyManager.LoadForTest(dataKursPalsu);
        }

        [TestMethod]
        public void Convert_FromIdrToUsd_HarusMengembalikanNilaiYangBenar()
        {
            decimal jumlahIDR = 32000m; 
            decimal hasilDiharapkan = 2m;

            decimal hasilAktual = CurrencyManager.Convert("IDR", "USD", jumlahIDR);

            Assert.AreEqual(hasilDiharapkan, hasilAktual, "Konversi dari IDR ke USD salah.");
        }

        [TestMethod]
        public void Convert_FromUsdToIdr_HarusMengembalikanNilaiYangBenar()
        {
            decimal jumlahUSD = 10m;
            decimal hasilDiharapkan = 160000m;

            decimal hasilAktual = CurrencyManager.Convert("USD", "IDR", jumlahUSD);

            Assert.AreEqual(hasilDiharapkan, hasilAktual, "Konversi dari USD ke IDR salah.");
        }

        [TestMethod]
        public void Convert_DariEurKeYen_HarusMengembalikanNilaiYangBenar()
        {
            decimal jumlahEUR = 18m;
            decimal hasilDiharapkan = 3000m;

            decimal hasilAktual = CurrencyManager.Convert("EUR", "YEN", jumlahEUR);

            Assert.AreEqual(hasilDiharapkan, hasilAktual, "Konversi dari EUR ke YEN salah.");
        }

        [TestMethod]
        public void Convert_MataUangSama_HarusMengembalikanNilaiAsli()
        {
            decimal jumlahAwal = 12345.67m;

            decimal hasilAktual = CurrencyManager.Convert("IDR", "IDR", jumlahAwal);

            Assert.AreEqual(jumlahAwal, hasilAktual, "Konversi ke mata uang yang sama seharusnya tidak mengubah nilai.");
        }

        [TestMethod]
        public void Convert_KodeAwalTidakValid_HarusMengembalikanNilaiAsli()
        {
            decimal jumlahAwal = 999m;

            decimal hasilAktual = CurrencyManager.Convert("XXX", "USD", jumlahAwal);

            Assert.AreEqual(jumlahAwal, hasilAktual, "Konversi dari kode tidak valid seharusnya mengembalikan nilai asli.");
        }

        [TestMethod]
        public void GetSymbol_KodeValid_HarusMengembalikanSimbolYangBenar()
        {
            string kode = "EUR";
            string simbolDiharapkan = "€";

            string simbolAktual = CurrencyManager.GetSymbol(kode);

            Assert.AreEqual(simbolDiharapkan, simbolAktual, "GetSymbol tidak mengembalikan simbol yang benar.");
        }
    }
}