using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace AutoVending.Core
{
    public class TransactionService
    {
        private readonly string _filePath = "transactions.json";
        private List<Transaction> _transactions;

        public TransactionService()
        {
            // Muat transaksi dari file saat service dibuat
            _transactions = LoadTransactions();
        }

        private List<Transaction> LoadTransactions()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Transaction>(); // Jika file belum ada, mulai dengan list kosong
            }
            string json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Transaction>>(json) ?? new List<Transaction>();
        }

        public List<Transaction> GetAllTransactions()
        {
            return _transactions;
        }

        public void AddTransaction(Transaction transaction)
        {
            // Tambahkan transaksi baru ke daftar di memori
            _transactions.Add(transaction);
            // Tulis kembali seluruh daftar ke file JSON
            SaveChanges();
        }

        private void SaveChanges()
        {
            string json = JsonConvert.SerializeObject(_transactions, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}