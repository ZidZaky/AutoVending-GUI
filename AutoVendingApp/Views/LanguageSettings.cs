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
    public partial class LanguageSettings : Form
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
            label3.Text = LanguageManager.GetString("Language_Title");
            labelPilihBahasa.Text = LanguageManager.GetString("labelPilihBahasa");
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
            RadioButton terpilih = sender as RadioButton;
            if (terpilih == null || !terpilih.Checked)
            {
                return;
            }

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