

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using AutoVendingApp;
using AutoVending.Core;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class VendingTests
    {
        private Mock<IProductService> mockProductService;
        private Vending vendingForm;

        [TestInitialize]
        public void Setup()
        {
            mockProductService = new Mock<IProductService>();
            vendingForm = new Vending(mockProductService.Object);
        }

        [TestMethod]
        public void TambahProdukKeKeranjang()
        {
            var produkTes = new Item(1, "Coca Cola", 5000, 10);

            vendingForm.TambahProdukKeKeranjang(produkTes);

            var keranjang = vendingForm.GetKeranjangBelanja();
            Assert.AreEqual(1, keranjang.Count, "Seharusnya ada 1 jenis item di keranjang.");
            Assert.IsTrue(keranjang.ContainsKey(produkTes), "Produk tes seharusnya ada di dalam keranjang.");
            Assert.AreEqual(1, keranjang[produkTes], "Jumlah produk seharusnya 1 setelah ditambah pertama kali.");
        }

        [TestMethod]
        public void TambahProdukKeKeranjang_ProdukYangSama()
        {
            var produkTes = new Item(1, "Coca Cola", 5000, 10);

            vendingForm.TambahProdukKeKeranjang(produkTes);
            vendingForm.TambahProdukKeKeranjang(produkTes);

            var keranjang = vendingForm.GetKeranjangBelanja();
            Assert.AreEqual(1, keranjang.Count, "Seharusnya tetap ada 1 JENIS item di keranjang.");
            Assert.AreEqual(2, keranjang[produkTes], "Jumlah produk seharusnya menjadi 2.");
        }

        [TestMethod]
        public void TambahProdukKeKeranjang_DuaProdukBerbeda()
        {
            var produkTes1 = new Item(1, "Coca Cola", 5000, 10); 
            var produkTes2 = new Item(2, "Pepsi", 4500, 5);   

            vendingForm.TambahProdukKeKeranjang(produkTes1);
            vendingForm.TambahProdukKeKeranjang(produkTes2);

            var keranjang = vendingForm.GetKeranjangBelanja();
            Assert.AreEqual(2, keranjang.Count, "Seharusnya ada 2 jenis item di keranjang.");
            Assert.AreEqual(1, keranjang[produkTes1], "Jumlah Coca Cola seharusnya 1.");
            Assert.AreEqual(1, keranjang[produkTes2], "Jumlah Pepsi seharusnya 1.");
        }

        [TestMethod]
        public void TambahProdukKeKeranjang_InputProdukNull()
        {
          
            vendingForm.TambahProdukKeKeranjang(null);

            var keranjang = vendingForm.GetKeranjangBelanja();
            Assert.AreEqual(0, keranjang.Count, "Keranjang seharusnya tetap kosong jika produk yang ditambahkan null.");
        }
    }
}