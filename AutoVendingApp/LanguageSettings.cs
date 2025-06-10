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

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            LanguageManager.LanguageChanged -= ApplyLanguage;
            base.OnFormClosed(e);
        }

    }
}
