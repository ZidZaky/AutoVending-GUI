using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoVendingApp
{
    public partial class AdminSettings: Form
    {
        public AdminSettings()
        {
            InitializeComponent();
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            // Hapus data lama agar tidak duplikat saat dipanggil lagi
            listView1.Items.Clear();

            // ---- INI HANYA DATA CONTOH ----
            // Nanti, Anda akan mengambil data ini dari database atau file log
            var transactionList = new List<Transaction>
    {
        new Transaction { TransactionId = 1, ProductName = "Snack Kentang", Quantity = 1, TotalAmount = 5000 },
        new Transaction { TransactionId = 2, ProductName = "Teh Kotak", Quantity = 2, TotalAmount = 7000 },
        new Transaction { TransactionId = 3, ProductName = "Cokelat Susu", Quantity = 1, TotalAmount = 7000 }
    };
            // --------------------------------

            // Looping melalui setiap data transaksi dan menambahkannya ke listview
            foreach (var tx in transactionList)
            {
                // Buat baris baru (ListViewItem)
                // Kolom pertama (ID Transaksi) dimasukkan saat pembuatan item
                ListViewItem item = new ListViewItem(tx.TransactionId.ToString());

                // Kolom-kolom berikutnya ditambahkan sebagai SubItems
                item.SubItems.Add(tx.ProductName);
                item.SubItems.Add(tx.Quantity.ToString());
                item.SubItems.Add($"Rp {tx.TotalAmount:N0}"); // Format sebagai mata uang

                // Tambahkan baris yang sudah jadi ke dalam ListView
                listView1.Items.Add(item);
            }
        }
    }
}
