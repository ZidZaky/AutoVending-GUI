using System.Collections.Generic;
using System.IO;
using AutoVending.Core;
using Newtonsoft.Json;
using System.Linq;

namespace AutoVending.Core
{
    public class ProductService : IProductService
    {
        private readonly string filePath = "Resources/products.json";

        public List<Item> GetProducts()
        {
            if (!File.Exists(filePath))
            {
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                SaveProducts(new List<Item>());
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

        public int GetNextAvailableId()
        {
            List<Item> currentProducts = GetProducts();
            if (currentProducts != null && currentProducts.Any())
            {
                return currentProducts.Max(p => p.Id) + 1;
            }
            return 1;
        }
    }
}