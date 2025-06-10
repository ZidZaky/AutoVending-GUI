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
    public partial class LanguageSettings: Form
    {
        public LanguageSettings()
        {
            InitializeComponent();
            ApplyLanguage(); 
            LanguageManager.LanguageChanged += ApplyLanguage;
        }

        private void ApplyLanguage()
        {
           
            this.Text = LanguageManager.GetString("LanguageSettings_Title");                                                                   
        }

        private void buttonApplyLanguage_Click(object sender, EventArgs e)
        {
            if (radioIndonesia.Checked)
            {
                LanguageManager.SetLanguage("id");
            }
            else if (radioEnglish.Checked)
            {
                LanguageManager.SetLanguage("en");
            }
            else if (radioJava.Checked)
            {
                LanguageManager.SetLanguage("jv");
            }

            this.Close();
        }

        private void radioLanguage_CheckedChanged(object sender, EventArgs e)
        {
            // Pastikan ada radio button yang terpilih sebelum melakukan apa-apa
            RadioButton terpilih = sender as RadioButton;
            if (terpilih == null || !terpilih.Checked)
            {
                return; // Keluar jika event ini dipicu oleh radio button yang menjadi tidak aktif
            }

            // Cek radio button mana yang sekarang sedang aktif
            if (radioIndonesia.Checked)
            {
                LanguageManager.SetLanguage("id");
            }
            else if (radioEnglish.Checked)
            {
                LanguageManager.SetLanguage("en");
            }
            else if (radioJava.Checked)
            {
                LanguageManager.SetLanguage("jv");
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            LanguageManager.LanguageChanged -= ApplyLanguage;
            base.OnFormClosed(e);
        }

    }
}
