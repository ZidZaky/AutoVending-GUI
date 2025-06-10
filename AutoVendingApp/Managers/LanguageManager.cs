using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AutoVendingApp
{
    public static class LanguageManager
    {
        private static Dictionary<string, Dictionary<string, string>> _languages;
        private static string _currentLanguage = "id";

        public static event Action LanguageChanged;

 
        public static void LoadLanguages(string filePath = "Json/languages.json")
        {
            try
            {
                string json = File.ReadAllText(filePath);
                _languages = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat file bahasa: {ex.Message}");
                _languages = new Dictionary<string, Dictionary<string, string>>();
            }
        }

        public static void SetLanguage(string languageCode)
        {
            if (_languages.ContainsKey(languageCode))
            {
                _currentLanguage = languageCode;
                LanguageChanged?.Invoke();
            }
        }

        public static string GetString(string key)
        {
            if (_languages.ContainsKey(_currentLanguage) && _languages[_currentLanguage].ContainsKey(key))
            {
                return _languages[_currentLanguage][key];
            }
            return key;
        }
    }
}