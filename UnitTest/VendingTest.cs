// FILE: UnitTest/VendingTests.cs

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq; // <-- Library untuk membuat object palsu (mock)
using AutoVendingApp; // <-- Namespace aplikasi utama Anda
using AutoVending.Core; // <-- Namespace untuk Item, IProductService
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class VendingTests
    {
        // Variabel ini akan kita gunakan di setiap test method.
        private Mock<IProductService> mockProductService;
        private Vending vendingForm;

        // Atribut [TestInitialize] berarti method ini akan dijalankan SECARA OTOMATIS
        // SEBELUM SETIAP test method di bawah ini dieksekusi.
        // Ini memastikan setiap tes dimulai dari kondisi yang bersih dan baru.
        [TestInitialize]
        public void Setup()
        {
            // ARRANGE (Persiapan Awal)
            // 1. Buat sebuah "service palsu" menggunakan Moq. Kita tidak butuh service asli
            //    karena kita hanya fokus menguji logika keranjang belanja.
            mockProductService = new Mock<IProductService>();

            // 2. Buat instance dari Vending FORM menggunakan constructor khusus untuk testing
            //    yang sudah kita buat sebelumnya. "Suntikkan" service palsu kita ke dalamnya.
            vendingForm = new Vending(mockProductService.Object);
        }

        [TestMethod]
        // Nama method test yang deskriptif: ApaYangDiuji_Kondisi_HasilYangDiharapkan
        public void TambahProdukKeKeranjang_ProdukBaru_HarusMenambahkanProdukDenganJumlahSatu()
        {
            // ARRANGE (Persiapan Lanjutan)
            // Buat sebuah produk dummy untuk tes ini
            var produkTes = new Item { Id = 1, NamaProduk = "Coca Cola", Harga = 5000 };

            // ACT (Aksi)
            // Panggil method yang sebenarnya ingin kita uji
            vendingForm.TambahProdukKeKeranjang(produkTes);

            // ASSERT (Verifikasi)
            // Dapatkan kondisi terakhir dari keranjang belanja setelah aksi dilakukan
            var keranjang = vendingForm.GetKeranjangBelanja();

            // Periksa apakah hasilnya sesuai dengan yang kita harapkan:
            Assert.AreEqual(1, keranjang.Count, "Seharusnya ada 1 jenis item di keranjang.");
            Assert.IsTrue(keranjang.ContainsKey(produkTes), "Produk tes seharusnya ada di dalam keranjang.");
            Assert.AreEqual(1, keranjang[produkTes], "Jumlah produk seharusnya 1 setelah ditambah pertama kali.");
        }

        [TestMethod]
        public void TambahProdukKeKeranjang_ProdukYangSamaDuaKali_HarusMenambahJumlahProdukMenjadiDua()
        {
            // ARRANGE
            var produkTes = new Item { Id = 1, NamaProduk = "Coca Cola", Harga = 5000 };

            // ACT
            // Panggil method yang sama DUA KALI
            vendingForm.TambahProdukKeKeranjang(produkTes);
            vendingForm.TambahProdukKeKeranjang(produkTes); // Panggilan kedua

            // ASSERT
            var keranjang = vendingForm.GetKeranjangBelanja();

            Assert.AreEqual(1, keranjang.Count, "Seharusnya tetap ada 1 JENIS item di keranjang.");
            Assert.AreEqual(2, keranjang[produkTes], "Jumlah produk seharusnya menjadi 2.");
        }

        [TestMethod]
        public void TambahProdukKeKeranjang_DuaProdukBerbeda_HarusAdaDuaJenisItemDiKeranjang()
        {
            // ARRANGE
            var produkTes1 = new Item { Id = 1, NamaProduk = "Coca Cola", Harga = 5000 };
            var produkTes2 = new Item { Id = 2, NamaProduk = "Pepsi", Harga = 4500 };

            // ACT
            vendingForm.TambahProdukKeKeranjang(produkTes1);
            vendingForm.TambahProdukKeKeranjang(produkTes2);

            // ASSERT
            var keranjang = vendingForm.GetKeranjangBelanja();

            Assert.AreEqual(2, keranjang.Count, "Seharusnya ada 2 jenis item di keranjang.");
            Assert.AreEqual(1, keranjang[produkTes1], "Jumlah Coca Cola seharusnya 1.");
            Assert.AreEqual(1, keranjang[produkTes2], "Jumlah Pepsi seharusnya 1.");
        }

        [TestMethod]
        public void TambahProdukKeKeranjang_InputProdukNull_KeranjangHarusTetapKosong()
        {
            // ARRANGE
            // Tidak ada produk yang disiapkan, kita akan mengirim null.

            // ACT
            vendingForm.TambahProdukKeKeranjang(null);

            // ASSERT
            var keranjang = vendingForm.GetKeranjangBelanja();

            Assert.AreEqual(0, keranjang.Count, "Keranjang seharusnya tetap kosong jika produk yang ditambahkan null.");
        }
    }
}