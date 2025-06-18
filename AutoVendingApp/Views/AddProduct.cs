using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // Pastikan ini ada
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoVending.Core;
using AutoVendingVend.Core;

namespace AutoVendingApp
{
    public partial class AddProduct : Form
    {
        private BindingList<Item> _products; // Gunakan BindingList agar DGV otomatis update
        private readonly ProductService _productService;

        public enum FormState
        {
            Idle,
            EditingProduct,
            AddingNewProduct,
            DeletingProduct
        }

        private FormState _currentState;

        public AddProduct()
        {
            InitializeComponent();

            _productService = new ProductService();

            // Muat data dari ProductService dan gunakan BindingList
            _products = new BindingList<Item>(_productService.GetProducts());

            InitializeDataGridView();

            // Tambahkan event handlers untuk validasi dan error
            dgvProduk.CellValidating += dgvProduk_CellValidating;
            dgvProduk.DataError += dgvProduk_DataError;
            dgvProduk.CellEndEdit += dgvProduk_CellEndEdit; // Penting untuk mengupdate model setelah edit

            // Pastikan tombol SaveAllData dan DeleteUniversal terhubung
            SaveAllData.Click += SaveAllData_Click;
            btnDeleteUniversal.Click += btnDeleteUniversal_Click;
            // Tambahkan tombol untuk menambah produk baru jika belum ada
            // Misalnya, Anda bisa menambahkan buttonAddProduct di form designer
            // dan event handler-nya di sini
            // buttonAddProduct.Click += buttonAddProduct_Click; // Jika ada tombol untuk Add New

            SetState(FormState.Idle);
            this.FormClosing += AddProduct_FormClosing;
        }
        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Opsional: Konfirmasi dengan pengguna sebelum menyimpan atau membuang perubahan
            // DialogResult result = MessageBox.Show("Apakah Anda ingin menyimpan perubahan?", "Simpan Perubahan", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            // if (result == DialogResult.Yes)
            // {
            dgvProduk.EndEdit(); // Penting untuk menyimpan perubahan yang sedang diedit
            _productService.SaveProducts(_products.ToList());
            // }
            // else if (result == DialogResult.Cancel)
            // {
            //    e.Cancel = true; // Batalkan penutupan form
            // }
        }


        private void InitializeDataGridView()
        {
            dgvProduk.DataSource = _products; // Binding ke BindingList
            dgvProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduk.MultiSelect = false;

            // Pastikan DataPropertyName di Designer.cs sudah benar:
            // ID: HeaderText="ID", Name="ID", DataPropertyName="Id" (pastikan ini ditambahkan manual)
            // NamaProduk: HeaderText="Nama Produk", Name="NamaProduk", DataPropertyName="NamaProduk"
            // HargaProduk: HeaderText="Harga Produk", Name="HargaProduk", DataPropertyName="Harga"
            // StokProduk: HeaderText="Stok Produk", Name="StokProduk", DataPropertyName="Stok"

            // Set kolom ID sebagai ReadOnly karena kita akan mengaturnya otomatis
            // atau pastikan pengguna tidak mengeditnya secara manual
            if (dgvProduk.Columns.Contains("ID"))
            {
                dgvProduk.Columns["ID"].ReadOnly = true;
            }
            if (dgvProduk.Columns.Contains("Id")) // Jika DataPropertyName adalah "Id"
            {
                dgvProduk.Columns["Id"].ReadOnly = true;
            }


            // Coba pilih baris pertama jika ada
            if (dgvProduk.Rows.Count > 0)
            {
                dgvProduk.Rows[0].Selected = true;
            }
            else
            {
                dgvProduk.ClearSelection();
            }

            dgvProduk_SelectionChanged(this, EventArgs.Empty);
        }

        // --- Logika untuk Menyimpan Perubahan (Item 1) ---
        private void SaveAllData_Click(object sender, EventArgs e)
        {
            // Penting: Mengakhiri mode edit sel saat ini sebelum menyimpan
            // Ini memastikan perubahan yang sedang diketik masuk ke dalam BindingList
            dgvProduk.EndEdit();

            // Simpan seluruh daftar _products ke JSON
            _productService.SaveProducts(_products.ToList()); // Konversi BindingList ke List biasa
            MessageBox.Show("Data produk berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetState(FormState.Idle); // Kembali ke state Idle
        }

        // --- Logika untuk Menambah Produk Baru (Item 2) ---
        // Anda perlu sebuah tombol di UI untuk "Add New Product".
        // Misalkan ada button bernama 'buttonAddNewProduct'.

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            SetState(FormState.AddingNewProduct);

            int newId = _productService.GetNextAvailableId();
            Item newItem = new Item(newId, "Produk Baru", 0, 0); // Buat item baru dengan default values

            _products.Add(newItem); // Tambahkan ke BindingList, DGV akan otomatis update

            // Pilih baris baru yang ditambahkan dan scroll ke sana
            int newRowIndex = dgvProduk.Rows.Count - 1;
            dgvProduk.ClearSelection();
            dgvProduk.Rows[newRowIndex].Selected = true;
            dgvProduk.FirstDisplayedScrollingRowIndex = newRowIndex;

            // Langsung masuk ke mode edit untuk sel NamaProduk
            dgvProduk.CurrentCell = dgvProduk.Rows[newRowIndex].Cells["NamaProduk"]; // Sesuaikan dengan nama kolom yang benar
            dgvProduk.BeginEdit(true);

            MessageBox.Show("Baris produk baru telah ditambahkan. Silakan isi detailnya.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // --- Logika untuk Menghapus Produk (Item 3) ---
        private void btnDeleteUniversal_Click(object sender, EventArgs e)
        {
            SetState(FormState.DeletingProduct);

            if (dgvProduk.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Anda yakin ingin menghapus produk yang dipilih?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    // Ambil item yang terikat dari baris yang dipilih
                    Item productToRemove = dgvProduk.SelectedRows[0].DataBoundItem as Item;

                    if (productToRemove != null)
                    {
                        _products.Remove(productToRemove); // BindingList otomatis menghapus dari DGV

                        // Langsung simpan perubahan ke JSON setelah penghapusan
                        _productService.SaveProducts(_products.ToList()); // <--- BARIS INI KRUSIAL
                        MessageBox.Show("Produk berhasil dihapus dan perubahan disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih produk yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SetState(FormState.Idle);
        }

        // --- Event Validasi dan Error (Pastikan sudah ada dari sebelumnya, tapi cek lagi) ---

        private void dgvProduk_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = dgvProduk.Columns[e.ColumnIndex].Name;

            // Validasi untuk kolom HargaProduk
            if (columnName == "HargaProduk") // Ini adalah Name dari DataGridViewTextBoxColumn
            {
                if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal priceValue) || priceValue < 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("Harga Produk harus berupa angka valid (misal: 5000) dan tidak boleh negatif.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvProduk.Rows[e.RowIndex].ErrorText = "Input harus angka desimal positif.";
                }
                else
                {
                    dgvProduk.Rows[e.RowIndex].ErrorText = "";
                }
            }
            // Validasi untuk kolom StokProduk
            else if (columnName == "Stok") // Ini adalah Name dari DataGridViewTextBoxColumn
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int stokValue) || stokValue < 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("Stok Produk harus berupa bilangan bulat positif.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvProduk.Rows[e.RowIndex].ErrorText = "Input harus bilangan bulat positif.";
                }
                else
                {
                    dgvProduk.Rows[e.RowIndex].ErrorText = "";
                }
            }
        }

        // Event ini dipicu setelah editing sel selesai, berguna untuk memastikan data model terupdate
        private void dgvProduk_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Ini akan secara otomatis memperbarui objek Item di dalam BindingList
            // karena DataPropertyName sudah diatur dengan benar.
            // Anda bisa menambahkan logika tambahan di sini jika diperlukan.
            dgvProduk.Rows[e.RowIndex].ErrorText = ""; // Hapus error text setelah edit selesai
        }

        private void dgvProduk_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            string columnName = dgvProduk.Columns[e.ColumnIndex].Name;
            MessageBox.Show($"Terjadi kesalahan format data pada kolom '{columnName}' di baris {e.RowIndex + 1}. " +
                            "Pastikan Anda memasukkan tipe data yang benar (angka desimal untuk harga, bilangan bulat untuk stok).",
                            "Kesalahan Input Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // --- Automata dan Event lain yang tidak terkait langsung dengan CRUD ---
        private void label3_Click(object sender, EventArgs e) { }

        private void SetState(FormState newState)
        {
            _currentState = newState;
            // Anda bisa menambahkan logika untuk mengaktifkan/menonaktifkan kontrol berdasarkan state
            // Misalnya, button Save hanya aktif di EditingProduct atau AddingNewProduct
        }

        private void dgvProduk_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduk.SelectedRows.Count > 0 && dgvProduk.SelectedRows[0].DataBoundItem != null)
            {
                SetState(FormState.EditingProduct);
            }
            else if (_products.Any())
            {
                if (dgvProduk.Rows.Count > 0)
                {
                    dgvProduk.Rows[0].Selected = true;
                    SetState(FormState.EditingProduct);
                }
                else
                {
                    SetState(FormState.Idle);
                }
            }
            else
            {
                SetState(FormState.Idle);
            }
        }

        private void dgvProduk_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Jika Anda ingin kolom ID selalu menampilkan indeks baris + 1
            // Walaupun DataPropertyName sudah diatur ke "Id", ini bisa menimpa tampilan
            // Namun, karena Id di JSON sudah ada, mungkin lebih baik biarkan DataGridView menampilkannya langsung
            // Jika Anda tetap ingin ini, pastikan kolom ID di DGV ReadOnly agar tidak ada konflik data
            // if (e.ColumnIndex >= 0 && dgvProduk.Columns[e.ColumnIndex].Name == "ID" && e.RowIndex >= 0)
            // {
            //     e.Value = e.RowIndex + 1; // Menampilkan indeks baris + 1
            //     e.FormattingApplied = true;
            // }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void dgvProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        // private void button1_Click_1(object sender, EventArgs e) { } // Hapus ini jika sudah diganti SaveAllData_Click
    }
}