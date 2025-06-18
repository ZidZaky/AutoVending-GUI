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
    public partial class LoginAdmin : Form
    {
        // --- DATA STATIS UNTUK LOGIN ---
        // Anda bisa mengubah username dan password di sini.
        private const string AdminUsername = "admin";
        private const string AdminPassword = "admin123";
        // ---------------------------------

        public LoginAdmin()
        {
            InitializeComponent();
        }

        // Method ini akan berjalan saat tombol 'Login' (button1) diklik
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Ambil input dari pengguna
            string inputUsername = textBox1.Text;
            string inputPassword = textBox2.Text;

            // 2. Lakukan pengecekan sederhana
            if (inputUsername == AdminUsername && inputPassword == AdminPassword)
            {
                // Jika login BERHASIL
                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Buka halaman AdminSettings
                AdminSettings adminForm = new AdminSettings();
                adminForm.Show();

                // Tutup halaman login ini
                this.Close();
            }
            else
            {
                // Jika login GAGAL
                MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Kosongkan field password dan fokuskan kembali ke username
                textBox2.Clear();
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }

        // Method Load yang kosong ini bisa dihapus jika tidak digunakan
        private void LanguageSettings_Load(object sender, EventArgs e)
        {
            // Kosong
        }
    }
}