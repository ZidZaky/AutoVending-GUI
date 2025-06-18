// FILE: UnitTest/LanguageManagerTest.cs

using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoVendingApp;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class LanguageSettings
    {
        [TestInitialize]
        public void Setup()
        {
            var dataBahasaPalsu = new Dictionary<string, Dictionary<string, string>>
            {
                {
                    "id", new Dictionary<string, string>
                    {
                        { "VendingForm_Title", "Mesin Penjual Otomatis" },
                        { "WelcomeMessage", "Selamat Datang" }
                    }
                },
                {
                    "en", new Dictionary<string, string>
                    {
                        { "VendingForm_Title", "Vending Machine" },
                        { "WelcomeMessage", "Welcome" }
                    }
                },
                {
                    "jv", new Dictionary<string, string>
                    {
                        { "VendingForm_Title", "Mesin Dolanan Otomatis" },
                        { "WelcomeMessage", "Sugeng Rawuh" }
                    }
                }
            };

            LanguageManager.LoadLanguagesForTest(dataBahasaPalsu);
        }

        [TestMethod]
        public void GetString_SaatBahasaDefault_HarusMengembalikanStringIndonesia()
        {
            string hasil = LanguageManager.GetString("WelcomeMessage");

            Assert.AreEqual("Selamat Datang", hasil, "String yang dikembalikan untuk bahasa Indonesia salah.");
        }

        [TestMethod]
        public void GetString_SetelahSetLanguageKeInggris_HarusMengembalikanStringInggris()
        {
            LanguageManager.SetLanguage("en");
            string hasil = LanguageManager.GetString("WelcomeMessage");

            Assert.AreEqual("Welcome", hasil, "String yang dikembalikan setelah ganti bahasa ke Inggris salah.");
        }

        [TestMethod]
        public void GetString_SetelahSetLanguageKeJawa_HarusMengembalikanStringJawa()
        {
            LanguageManager.SetLanguage("jv");
            string hasil = LanguageManager.GetString("WelcomeMessage");

            Assert.AreEqual("Sugeng Rawuh", hasil, "String yang dikembalikan setelah ganti bahasa ke Jawa salah.");
        }

        [TestMethod]
        public void GetString_KunciTidakDitemukan_HarusMengembalikanKunciItuSendiri()
        {
            string hasil = LanguageManager.GetString("Kunci_Yang_Tidak_Ada");

            Assert.AreEqual("Kunci_Yang_Tidak_Ada", hasil, "Seharusnya mengembalikan nama kunci jika tidak ditemukan.");
        }

        [TestMethod]
        public void SetLanguage_KodeBahasaTidakValid_TidakBolehMengubahBahasa()
        {
            string bahasaAwal = LanguageManager.GetString("WelcomeMessage");
            Assert.AreEqual("Selamat Datang", bahasaAwal);

            LanguageManager.SetLanguage("fr");
            string bahasaSetelahGanti = LanguageManager.GetString("WelcomeMessage");

            Assert.AreEqual("Selamat Datang", bahasaSetelahGanti, "Bahasa seharusnya tidak berubah jika kodenya tidak valid.");
        }

        [TestMethod]
        public void SetLanguage_SaatBahasaDiubah_HarusMemicuEventLanguageChanged()
        {
            bool eventTerpanggil = false;
            LanguageManager.LanguageChanged += () => { eventTerpanggil = true; };

            LanguageManager.SetLanguage("en");

            Assert.IsTrue(eventTerpanggil, "Event LanguageChanged seharusnya terpicu saat bahasa diganti.");
        }
    }
}