using System.Collections.Generic;
using System.IO;
using AutoVending.Core;
using Newtonsoft.Json;

namespace AutoVendingVend.Core
{
    public class ProductService
    {
        private readonly string filePath = "products.json";
        public List<Item> GetProducts()
        {
            if (!File.Exists(filePath))
            {
                return new List<Item>();
            }

            string jsonContent = File.ReadAllText(filePath);
            var productList = JsonConvert.DeserializeObject<List<Item>>(jsonContent);
            return productList ?? new List<Item>();
        }
    }
}