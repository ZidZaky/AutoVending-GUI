using System.Collections.Generic;
using System.IO;
using AutoVending.Core;
using Newtonsoft.Json;
using System.Linq; // Tambahkan ini untuk .Max()

namespace AutoVendingVend.Core
{
    public class ProductService
    {
        private readonly string filePath = "Resources/products.json";

        public List<Item> GetProducts()
        {
            if (!File.Exists(filePath))
            {
                // Pastikan direktori 'Resources' ada
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                SaveProducts(new List<Item>()); // Buat file kosong jika tidak ada
                return new List<Item>();
            }

            string jsonContent = File.ReadAllText(filePath);
            var productList = JsonConvert.DeserializeObject<List<Item>>(jsonContent);
            return productList ?? new List<Item>();
        }

        public void SaveProducts(List<Item> products)
        {
            string directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string jsonContent = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(filePath, jsonContent);
        }

        // Metode untuk mendapatkan ID tertinggi (akan digunakan untuk produk baru)
        public int GetNextAvailableId()
        {
            List<Item> currentProducts = GetProducts(); // Ambil data terbaru
            if (currentProducts != null && currentProducts.Any())
            {
                return currentProducts.Max(p => p.Id) + 1;
            }
            return 1; // Jika belum ada produk, mulai dari ID 1
        }
    }
}