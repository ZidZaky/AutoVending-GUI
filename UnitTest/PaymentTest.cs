// FILE: UnitTest/PaymentTest.cs

using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoVendingApp;
using AutoVending.Core;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class PaymentTest
    {
        [TestMethod]
        public void HitungTotal_KeranjangDenganSatuJenisItem_HarusMengembalikanTotalYangBenar()
        {
            var keranjangPalsu = new Dictionary<Item, int>();

            var item1 = new Item(1, "Coca Cola", 5000, 10);
            keranjangPalsu.Add(item1, 3);

            var paymentForm = new Payment(keranjangPalsu, true);

            decimal totalDiharapkan = 15000;

            decimal totalAktual = paymentForm.HitungTotal();

            Assert.AreEqual(totalDiharapkan, totalAktual, "Total untuk satu item salah hitung.");
        }

        [TestMethod]
        public void HitungTotal_KeranjangDenganBeberapaItem_HarusMengembalikanTotalGabungan()
        {
            var keranjangPalsu = new Dictionary<Item, int>();
            var item1 = new Item(1, "Coca Cola", 5000, 10);
            var item2 = new Item(2, "Fanta", 4000, 2);      
            var item3 = new Item(3, "Sprite", 4500, 1);   

            keranjangPalsu.Add(item1, 1);
            keranjangPalsu.Add(item2, 2);
            keranjangPalsu.Add(item3, 1);

            var paymentForm = new Payment(keranjangPalsu, true);

            decimal totalDiharapkan = 17500;

            decimal totalAktual = paymentForm.HitungTotal();

            Assert.AreEqual(totalDiharapkan, totalAktual, "Total untuk beberapa item salah hitung.");
        }

        [TestMethod]
        public void HitungTotal_KeranjangKosong_HarusMengembalikanNol()
        {
            var keranjangKosong = new Dictionary<Item, int>();
            var paymentForm = new Payment(keranjangKosong, true);

            decimal totalDiharapkan = 0;

            decimal totalAktual = paymentForm.HitungTotal();

            Assert.AreEqual(totalDiharapkan, totalAktual, "Total untuk keranjang kosong seharusnya nol.");
        }

        [TestMethod]
        public void HitungTotal_KeranjangNull_HarusMengembalikanNol()
        {
            var paymentForm = new Payment(null, true);

            decimal totalDiharapkan = 0;

            decimal totalAktual = paymentForm.HitungTotal();

            Assert.AreEqual(totalDiharapkan, totalAktual, "Total untuk keranjang null seharusnya nol.");
        }
    }
}