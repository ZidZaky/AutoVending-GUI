using System;
using System.Collections.Generic;

namespace AutoVending.Core
{
    public class Transaction
    {
        public Guid Id { get; set; } // ID unik untuk setiap transaksi
        public DateTime Timestamp { get; set; } // Waktu transaksi terjadi
        public List<TransactionItem> Items { get; set; } // Daftar barang yang dibeli
        public decimal TotalPrice { get; set; } // Total harga dalam mata uang dasar (IDR)
        public string Currency { get; set; } // Mata uang yang digunakan saat transaksi
    }

    public class TransactionItem
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerItem { get; set; } // Harga per item saat itu
    }
}