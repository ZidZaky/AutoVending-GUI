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
    public partial class AddProduct : Form
    {
        private List<Product> _products = new List<Product>();

        private Dictionary<int, (TextBox productNameTb, TextBox priceTb, Button actionButton)> _productInputMap;

        // --- Automata (State Machine) ---
        // Definisi state-state yang mungkin untuk form ini
        public enum FormState
        {
            Idle,
            EditingProduct,
            AddingNewProduct,
            DeletingProduct
        }

        // Variabel untuk menyimpan state form saat ini
        private FormState _currentState;

        public AddProduct()
        {
            InitializeComponent();

            _productInputMap = new Dictionary<int, (TextBox, TextBox, Button)>
            {
                {0, (textBox1, textBox2, button1)},
                {1, (textBox4, textBox3, button2)},
                {2, (textBox6, textBox5, button3)},
                {3, (textBox8, textBox7, button4)},
                {4, (textBox10, textBox9, button5)},
                {5, (textBox12, textBox11, button6)},
                {6, (textBox14, textBox13, button7)},
                {7, (textBox16, textBox15, button8)},
                {8, (textBox18, textBox17, button9)},
                {9, (textBox20, textBox19, button10)},
                {10, (textBox22, textBox21, button11)},
                {11, (textBox24, textBox23, button12)},
                {12, (textBox26, textBox25, button13)},
                {13, (textBox28, textBox27, button14)},
                {14, (textBox30, textBox29, button15)},
                {15, (textBox32, textBox31, button16)},
                {16, (textBox34, textBox33, button17)},
                {17, (textBox36, textBox35, button18)},
                {18, (textBox38, textBox37, button19)},
                {19, (textBox40, textBox39, button20)}
            };

            _products.Add(new Product("Kopi Hitam", 5000));
            _products.Add(new Product("Teh Manis", 4500));
            _products.Add(new Product("Air Mineral", 3000));
            _products.Add(new Product("Soda", 6000));
            _products.Add(new Product("Jus Jeruk", 7000));
            _products.Add(new Product("Susu Coklat", 5500));
            _products.Add(new Product("Roti Bakar", 8000));
            _products.Add(new Product("Biskuit", 3500));
            _products.Add(new Product("Coklat Bar", 4000));
            _products.Add(new Product("Permen Karet", 2000));


            InitializeDataGridView();
            // Automata: Mengatur state awal form
            SetState(FormState.Idle);
        }

        private void InitializeDataGridView() //untuk meng-select data berdasarkan selection di DataDridView Produk
        {
            dgvProduk.DataSource = _products;
            dgvProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduk.MultiSelect = false;

            dgvProduk.SelectionChanged += dgvProduk_SelectionChanged;
            dgvProduk.CellFormatting += dgvProduk_CellFormatting;

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

        private void AddProduct_Load(object sender, EventArgs e) //mengatur fokus yang bergantung dari input textfield di form
        {
            if (_products.Any() && _productInputMap.ContainsKey(0)) //jika sudah pernah diinputkan, maka fokus ke index tersebut
            {
                _productInputMap[0].productNameTb.Focus();
            }
            else if (_productInputMap.ContainsKey(0)) //jika belum pernah, maka tetap difokuskan pada index tersebut
            {
                _productInputMap[0].productNameTb.Focus();
            }
        }

        // --- Automata: Metode untuk mengubah state form ---
        private void SetState(FormState newState)
        {
            _currentState = newState;
            // Table-Driven: Memanggil metode untuk menerapkan perubahan UI berdasarkan state baru
            ApplyStateUIChanges(newState);
        }

        // --- Table-Driven: Metode yang berisi logika perubahan UI berdasarkan state ---
        private void ApplyStateUIChanges(FormState state)
        {
            ClearAllProductTextBoxes();

            // Logika untuk mengisi TextField berdasarkan seleksi DGV (jika ada)
            if (dgvProduk.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProduk.SelectedRows[0];
                Product selectedProduct = selectedRow.DataBoundItem as Product;
                int selectedRowIndex = selectedRow.Index;

                if (selectedProduct != null && _productInputMap.ContainsKey(selectedRowIndex))
                {
                    _productInputMap[selectedRowIndex].productNameTb.Text = selectedProduct.ProductName;
                    _productInputMap[selectedRowIndex].priceTb.Text = selectedProduct.Price.ToString();
                }
            }


            // Table-Driven: Logika untuk menentukan teks dan status tombol "Add/Update" untuk setiap slot
            for (int i = 0; i < 20; i++)
            {
                if (_productInputMap.ContainsKey(i))
                {
                    TextBox nameTb = _productInputMap[i].productNameTb;
                    Button btn = _productInputMap[i].actionButton;

                    if (string.IsNullOrWhiteSpace(nameTb.Text))
                    {
                        btn.Text = "Tambah Produk Baru";
                        btn.Enabled = true;
                    }
                    else
                    {
                        btn.Text = "Update Produk";
                        btn.Enabled = true;
                    }
                }
            }

            // Table-Driven: Logika untuk mengupdate status tombol delete universal berdasarkan state
            if (btnDeleteUniversal != null)
            {
                btnDeleteUniversal.Enabled = (state == FormState.EditingProduct && dgvProduk.SelectedRows.Count > 0);
            }

            // Table-Driven: Atur fokus berdasarkan state
            switch (state)
            {
                case FormState.Idle:
                    if (!_products.Any()) //status idle jika tidak ada DGV yang diseleksi dan tidak ada input aktif
                    {
                        dgvProduk.ClearSelection();
                        ClearAllProductTextBoxes();
                    }
                    if (_productInputMap.ContainsKey(0))
                    {
                        if (string.IsNullOrWhiteSpace(_productInputMap[0].productNameTb.Text))
                        {
                            _productInputMap[0].productNameTb.Focus();
                        }
                        else if (_products.Any())
                        {
                            dgvProduk.Focus();
                        }
                    }
                    break;
                case FormState.EditingProduct: //status edit jika ada DGV yang diseleksi 
                    if (dgvProduk.SelectedRows.Count > 0) //jika ada yang diseleksi, maka blablabla
                    {
                        int selectedRowIndex = dgvProduk.SelectedRows[0].Index;
                        if (_productInputMap.ContainsKey(selectedRowIndex))
                        {
                            _productInputMap[selectedRowIndex].productNameTb.Focus();
                        }
                    }
                    break;
                case FormState.AddingNewProduct: //status adding jika pengguna mengetikkan input pada textfield yang belum terdaftar di DGV
                    var firstEmptySlot = _productInputMap.FirstOrDefault(
                        p => string.IsNullOrWhiteSpace(p.Value.productNameTb.Text));
                    if (firstEmptySlot.Value.productNameTb != null)
                    {
                        firstEmptySlot.Value.productNameTb.Focus();
                    }
                    else if (_productInputMap.ContainsKey(0))
                    {
                        _productInputMap[0].productNameTb.Focus();
                    }
                    break;
                case FormState.DeletingProduct:
                    break;
            }
        }


        private void HandleProductAction(int productIndex, TextBox nameTextBox, TextBox priceTextBox, Button actionButton)
        {
            string productName = nameTextBox.Text.Trim();
            decimal productPrice;

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Nama produk tidak boleh kosong.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTextBox.Focus();
                return;
            }

            if (!decimal.TryParse(priceTextBox.Text.Trim(), out productPrice))
            {
                MessageBox.Show("Harga produk tidak valid. Mohon masukkan angka yang benar.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                priceTextBox.Focus();
                return;
            }

            bool isAddingNew = string.IsNullOrWhiteSpace(actionButton.Text) || actionButton.Text == "Tambah Produk Baru";

            if (isAddingNew)
            {
                Product newProduct = new Product(productName, productPrice);
                _products.Add(newProduct);
                MessageBox.Show("Produk baru berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nameTextBox.Clear();
                priceTextBox.Clear();
                nameTextBox.Focus();
                // Automata: Transisi ke state AddingNewProduct setelah menambah produk baru
                SetState(FormState.AddingNewProduct);
            }
            else
            {
                if (productIndex < _products.Count)
                {
                    _products[productIndex].ProductName = productName;
                    _products[productIndex].Price = productPrice;
                    MessageBox.Show("Produk berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Automata: Tetap di state EditingProduct setelah update
                    SetState(FormState.EditingProduct);
                }
                else
                {
                    MessageBox.Show("Tidak dapat memperbarui: Produk tidak ditemukan di slot ini.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Automata: Kembali ke Idle jika ada error pada update
                    SetState(FormState.Idle);
                    return;
                }
            }

            dgvProduk.DataSource = null;
            dgvProduk.DataSource = _products;

            int targetRowIndex = productIndex;
            if (isAddingNew && _products.Count > 0)
            {
                targetRowIndex = _products.Count - 1;
            }

            if (targetRowIndex >= 0 && targetRowIndex < dgvProduk.Rows.Count)
            {
                dgvProduk.ClearSelection();
                dgvProduk.Rows[targetRowIndex].Selected = true;
                dgvProduk.FirstDisplayedScrollingRowIndex = targetRowIndex;
            }
            else if (_products.Any())
            {
                dgvProduk.ClearSelection();
                dgvProduk.Rows[0].Selected = true;
            }
            else
            {
                dgvProduk.ClearSelection();
            }

            // Automata: Memicu event SelectionChanged untuk memastikan UI diperbarui sesuai state
            dgvProduk_SelectionChanged(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e) { HandleProductAction(0, textBox1, textBox2, button1); }
        private void button2_Click(object sender, EventArgs e) { HandleProductAction(1, textBox4, textBox3, button2); }
        private void button3_Click(object sender, EventArgs e) { HandleProductAction(2, textBox6, textBox5, button3); }
        private void button4_Click(object sender, EventArgs e) { HandleProductAction(3, textBox8, textBox7, button4); }
        private void button5_Click(object sender, EventArgs e) { HandleProductAction(4, textBox10, textBox9, button5); }
        private void button6_Click(object sender, EventArgs e) { HandleProductAction(5, textBox12, textBox11, button6); }
        private void button7_Click(object sender, EventArgs e) { HandleProductAction(6, textBox14, textBox13, button7); }
        private void button8_Click(object sender, EventArgs e) { HandleProductAction(7, textBox16, textBox15, button8); }
        private void button9_Click(object sender, EventArgs e) { HandleProductAction(8, textBox18, textBox17, button9); }
        private void button10_Click(object sender, EventArgs e) { HandleProductAction(9, textBox20, textBox19, button10); }
        private void button11_Click(object sender, EventArgs e) { HandleProductAction(10, textBox22, textBox21, button11); }
        private void button12_Click(object sender, EventArgs e) { HandleProductAction(11, textBox24, textBox23, button12); }
        private void button13_Click(object sender, EventArgs e) { HandleProductAction(12, textBox26, textBox25, button13); }
        private void button14_Click(object sender, EventArgs e) { HandleProductAction(13, textBox28, textBox27, button14); }
        private void button15_Click(object sender, EventArgs e) { HandleProductAction(14, textBox30, textBox29, button15); }
        private void button16_Click(object sender, EventArgs e) { HandleProductAction(15, textBox32, textBox31, button16); }
        private void button17_Click(object sender, EventArgs e) { HandleProductAction(16, textBox34, textBox33, button17); }
        private void button18_Click(object sender, EventArgs e) { HandleProductAction(17, textBox36, textBox35, button18); }
        private void button19_Click(object sender, EventArgs e) { HandleProductAction(18, textBox38, textBox37, button19); }
        private void button20_Click(object sender, EventArgs e) { HandleProductAction(19, textBox40, textBox39, button20); }


        private void btnDeleteUniversal_Click(object sender, EventArgs e)
        {
            // Automata: Transisi ke state DeletingProduct saat tombol delete diklik
            SetState(FormState.DeletingProduct);

            if (dgvProduk.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Anda yakin ingin menghapus produk yang dipilih?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dgvProduk.SelectedRows[0];
                    Product productToRemove = selectedRow.DataBoundItem as Product;

                    if (productToRemove != null)
                    {
                        int removedIndex = _products.IndexOf(productToRemove);

                        _products.Remove(productToRemove);

                        dgvProduk.DataSource = null;
                        dgvProduk.DataSource = _products;

                        if (_productInputMap.ContainsKey(removedIndex))
                        {
                            _productInputMap[removedIndex].productNameTb.Clear();
                            _productInputMap[removedIndex].priceTb.Clear();
                            _productInputMap[removedIndex].productNameTb.Focus();
                        }
                        else
                        {
                            ClearAllProductTextBoxes();
                            if (_productInputMap.Any())
                            {
                                var firstAvailableSlot = _productInputMap.Values.FirstOrDefault(p => string.IsNullOrWhiteSpace(p.productNameTb.Text));
                                if (firstAvailableSlot.productNameTb != null)
                                {
                                    firstAvailableSlot.productNameTb.Focus();
                                }
                                else if (_productInputMap.ContainsKey(0))
                                {
                                    _productInputMap[0].productNameTb.Focus();
                                }
                            }
                            else if (_productInputMap.ContainsKey(0))
                            {
                                _productInputMap[0].productNameTb.Focus();
                            }
                        }

                        MessageBox.Show("Produk berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih produk yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Automata: Kembali ke state Idle setelah operasi delete selesai
            SetState(FormState.Idle);
        }


        // --- Automata: Event handler yang memicu transisi state berdasarkan seleksi DGV ---
        private void dgvProduk_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduk.SelectedRows.Count > 0 && dgvProduk.SelectedRows[0].DataBoundItem != null)
            {
                SetState(FormState.EditingProduct); // Transisi ke EditingProduct
            }
            else if (_products.Any())
            {
                if (dgvProduk.Rows.Count > 0)
                {
                    dgvProduk.Rows[0].Selected = true;
                    SetState(FormState.EditingProduct); // Kembali ke EditingProduct jika ada produk
                }
                else
                {
                    SetState(FormState.Idle); // Transisi ke Idle jika tidak ada produk
                }
            }
            else
            {
                SetState(FormState.Idle); // Transisi ke Idle jika tidak ada seleksi dan tidak ada produk
            }
        }

        private void ClearAllProductTextBoxes()
        {
            foreach (var entry in _productInputMap.Values)
            {
                entry.productNameTb.Clear();
                entry.priceTb.Clear();
            }
        }

        private void dgvProduk_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvProduk.Columns[e.ColumnIndex].Name == "ID" && e.RowIndex >= 0)
            {
                e.Value = e.RowIndex + 1;
                e.FormattingApplied = true;
            }
        }

        // --- Automata: Event handler yang memicu transisi state berdasarkan perubahan teks TextBox ---
        private void TextBox_Product_TextChanged(object sender, EventArgs e)
        {
            TextBox changedTextBox = sender as TextBox;
            if (changedTextBox != null)
            {
                var relatedSlot = _productInputMap.FirstOrDefault(p => p.Value.productNameTb == changedTextBox || p.Value.priceTb == changedTextBox);

                if (relatedSlot.Value.productNameTb != null)
                {
                    if (string.IsNullOrWhiteSpace(relatedSlot.Value.productNameTb.Text) && string.IsNullOrWhiteSpace(relatedSlot.Value.priceTb.Text))
                    {
                        if (_products.Any()) //jika tidak ada operasi dilakukan, maka ..
                        {
                            SetState(FormState.Idle); // Transisi ke Idle
                        }
                        else
                        {
                            SetState(FormState.AddingNewProduct); // Transisi ke AddingNewProduct
                        }
                    }
                    else
                    {
                        int slotIndex = relatedSlot.Key;
                        if (slotIndex < _products.Count)
                        {
                            SetState(FormState.EditingProduct); // Transisi ke EditingProduct
                        }
                        else
                        {
                            SetState(FormState.AddingNewProduct); // Transisi ke AddingNewProduct
                        }
                    }
                }
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void dgvProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}