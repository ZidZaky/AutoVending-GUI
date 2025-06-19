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
            
            _transactions = LoadTransactions();
        }

        private List<Transaction> LoadTransactions()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Transaction>();
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
            _transactions.Add(transaction);
            SaveChanges();
        }

        private void SaveChanges()
        {
            string json = JsonConvert.SerializeObject(_transactions, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}