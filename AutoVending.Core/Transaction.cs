using System;
using System.Collections.Generic;

namespace AutoVending.Core
{
    public class Transaction
    {
        public Guid Id { get; set; } 
        public DateTime Timestamp { get; set; } 
        public List<TransactionItem> Items { get; set; }
        public decimal TotalPrice { get; set; }
        public string Currency { get; set; }
    }

    public class TransactionItem
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerItem { get; set; } 
    }
}