using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using AutoVendingApp;
using AutoVending.Core;
using System.Collections.Generic;
using System.Linq;
using System;

namespace UnitTest
{
    [TestClass]
    public class AddProductTest
    {
        private Mock<IProductService> mockProductService;
        private AddProduct addProductForm;
        private List<Item> produkAwal;

        [TestInitialize]
        public void Setup()
        {
            produkAwal = new List<Item>
            {
                new Item(1, "Coca Cola", 5000, 10),
                new Item(2, "Pepsi", 4500, 15)
            };
            mockProductService = new Mock<IProductService>();
            mockProductService.Setup(service => service.GetProducts()).Returns(produkAwal);
            mockProductService.Setup(service => service.GetNextAvailableId()).Returns(3);
            addProductForm = new AddProduct(mockProductService.Object);
        }

        [TestMethod]
        public void Constructor_HarusMemuatProdukDariService()
        {
            var produkDiForm = addProductForm.GetProductsBindingList();
            Assert.AreEqual(2, produkDiForm.Count, "Jumlah produk yang dimuat salah.");
            mockProductService.Verify(service => service.GetProducts(), Times.Once());
        }

        [TestMethod]
        public void AddNewProduct_HarusMenambahItemBaruKeList()
        {
            addProductForm.buttonAddNewProduct_Click(null, EventArgs.Empty);
            var produkDiForm = addProductForm.GetProductsBindingList();
            Assert.AreEqual(3, produkDiForm.Count, "Jumlah produk seharusnya bertambah menjadi 3.");
            Assert.AreEqual(3, produkDiForm.Last().Id, "ID produk baru seharusnya 3.");
            Assert.AreEqual("Produk Baru", produkDiForm.Last().NamaProduk, "Nama default produk baru salah.");
            mockProductService.Verify(service => service.GetNextAvailableId(), Times.Once());
        }

        [TestMethod]
        public void SaveAllData_HarusMemanggilSaveProducts()
        {
            addProductForm.buttonAddNewProduct_Click(null, EventArgs.Empty);
            var produkSaatIni = addProductForm.GetProductsBindingList().ToList();

            addProductForm.SaveAllData_Click(null, EventArgs.Empty);

            mockProductService.Verify(
                service => service.SaveProducts(It.Is<List<Item>>(list => list.Count == 3)),
                Times.Once()
            );
        }

        [TestMethod]
        public void DeleteProduct_HarusMenghapusItemDariListDanSave()
        {
            var itemUntukDihapus = addProductForm.GetProductsBindingList().First(p => p.Id == 1);

            var jumlahAwal = addProductForm.GetProductsBindingList().Count;

            addProductForm.GetProductsBindingList().Remove(itemUntukDihapus);

            addProductForm.SaveAllData_Click(null, EventArgs.Empty);

            var produkDiForm = addProductForm.GetProductsBindingList();
            Assert.AreEqual(jumlahAwal - 1, produkDiForm.Count, "Jumlah produk seharusnya berkurang satu.");
            Assert.IsFalse(produkDiForm.Contains(itemUntukDihapus), "Item yang dihapus seharusnya sudah tidak ada di list.");

            mockProductService.Verify(
               service => service.SaveProducts(It.Is<List<Item>>(list => list.Count == 1)),
               Times.Once()
           );
        }
    }
}