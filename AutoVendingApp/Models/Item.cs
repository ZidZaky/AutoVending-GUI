using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVendingApp
{
    public class Item
    {
        public int Id { get; set; }
        public string NamaProduk { get; set; }
        public decimal Harga { get; set; }
        public int Stok { get; set; }
    }
}
