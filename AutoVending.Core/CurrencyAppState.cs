namespace AutoVending.Core
{
    public static class CurrencyAppState
    {
        private static string _selectedCurrency;

        public static string SelectedCurrency
        {
            get
            {
                if (string.IsNullOrEmpty(_selectedCurrency))
                {
                    // Anda perlu memastikan ada class CurrencyManager dengan method GetDefaultCurrency
                    // Untuk sementara, kita bisa set default di sini jika belum ada
                    _selectedCurrency = "IDR";
                }
                return _selectedCurrency;
            }
            set => _selectedCurrency = value;
        }
    }
}