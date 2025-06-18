using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AutoVending.Core;

namespace AutoVendingApp
{
    public partial class AddProduct : Form
    {
        private BindingList<Item> _products;
        private readonly IProductService _productService;
        private FormState _currentState;

        public enum FormState { Idle, EditingProduct, AddingNewProduct, DeletingProduct }

        //injector
        public AddProduct() : this(new ProductService()) { }

        public AddProduct(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;

            _products = new BindingList<Item>(_productService.GetProducts());

            InitializeDataGridView();
            SetupEventHandlers();
            SetState(FormState.Idle);
        }

        public BindingList<Item> GetProductsBindingList()
        {
            return _products;
        }

        private void SetupEventHandlers()
        {
            this.FormClosing += AddProduct_FormClosing;
            dgvProduk.CellValidating += dgvProduk_CellValidating;
            dgvProduk.DataError += dgvProduk_DataError;
            dgvProduk.CellEndEdit += dgvProduk_CellEndEdit;
            dgvProduk.SelectionChanged += dgvProduk_SelectionChanged;

            // untuk test
            //SaveAllData.Click += SaveAllData_Click;
            //btnDeleteUniversal.Click += btnDeleteUniversal_Click;
            //buttonAddNewProduct.Click += buttonAddNewProduct_Click;
        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Saat form ditutup, anggap selalu save
            SaveAllData_Click(sender, e);
        }

        private void InitializeDataGridView()
        {
            dgvProduk.DataSource = _products;
            dgvProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduk.MultiSelect = false;

            if (dgvProduk.Columns.Contains("Id"))
            {
                dgvProduk.Columns["Id"].ReadOnly = true;
            }

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

        private void SaveAllData_Click(object sender, EventArgs e)
        {
            dgvProduk.EndEdit();

            _productService.SaveProducts(_products.ToList());
            MessageBox.Show("Data produk berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetState(FormState.Idle);
        }

        public void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            SetState(FormState.AddingNewProduct);

            int newId = _productService.GetNextAvailableId();
            Item newItem = new Item(newId, "Produk Baru", 0, 0);

            _products.Add(newItem);

            int newRowIndex = dgvProduk.Rows.Count - 1;
            dgvProduk.ClearSelection();
            dgvProduk.Rows[newRowIndex].Selected = true;
            dgvProduk.FirstDisplayedScrollingRowIndex = newRowIndex;

            dgvProduk.CurrentCell = dgvProduk.Rows[newRowIndex].Cells["NamaProduk"];
            dgvProduk.BeginEdit(true);

            MessageBox.Show("Baris produk baru telah ditambahkan. Silakan isi detailnya.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void btnDeleteUniversal_Click(object sender, EventArgs e)
        {
            SetState(FormState.DeletingProduct);

            if (dgvProduk.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Anda yakin ingin menghapus produk yang dipilih?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Item productToRemove = dgvProduk.SelectedRows[0].DataBoundItem as Item;

                    if (productToRemove != null)
                    {
                        _products.Remove(productToRemove);

                        _productService.SaveProducts(_products.ToList());
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

        #region "Event Handlers Lainnya"
        private void dgvProduk_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = dgvProduk.Columns[e.ColumnIndex].Name;

            if (columnName == "HargaProduk")
            {
                if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal hargaValue) || hargaValue < 0)
                {

                    e.Cancel = true;

                    MessageBox.Show("Harga Produk harus berupa angka dan tidak boleh negatif.", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    dgvProduk.Rows[e.RowIndex].ErrorText = "Harga harus angka positif.";
                }
            }
            else if (columnName == "Stok")
            {
                // Coba konversi nilai baru ke integer
                if (!int.TryParse(e.FormattedValue.ToString(), out int stokValue) || stokValue < 0)
                {

                    e.Cancel = true;

                    MessageBox.Show("Stok Produk harus berupa bilangan bulat dan tidak boleh negatif.", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    dgvProduk.Rows[e.RowIndex].ErrorText = "Stok harus bilangan bulat positif.";
                }
            }
        }
        private void dgvProduk_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduk.Rows[e.RowIndex].ErrorText = string.Empty;
        }
        private void dgvProduk_DataError(object sender, DataGridViewDataErrorEventArgs e) {  }
        private void label3_Click(object sender, EventArgs e) { }
        private void SetState(FormState newState) { _currentState = newState; }
        private void dgvProduk_SelectionChanged(object sender, EventArgs e) {  }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void dgvProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        #endregion
    }
}