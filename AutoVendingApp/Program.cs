using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoVendingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
<<<<<<< HEAD
            LanguageManager.LoadLanguages();
=======
            CurrencyManager.Load();

>>>>>>> 932b8f98f7d285bc35496e7296747f823e2e5b8e
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AddProduct());
        }
    }
}
