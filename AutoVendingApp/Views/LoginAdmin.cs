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
        private const string AdminUsername = "admin";
        private const string AdminPassword = "admin123";

        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputUsername = textBox1.Text;
            string inputPassword = textBox2.Text;

            if (inputUsername == AdminUsername && inputPassword == AdminPassword)
            {
                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminSettings adminForm = new AdminSettings();
                adminForm.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox2.Clear();
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }

        private void LanguageSettings_Load(object sender, EventArgs e)
        {
            
        }
    }
}