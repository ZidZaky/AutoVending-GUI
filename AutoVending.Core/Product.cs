using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVendingApp
{
    // Definisikan kelas Product
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        // Tambahkan konstruktor untuk kemudahan inisialisasi
        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }
    }
}