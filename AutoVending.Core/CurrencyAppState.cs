namespace AutoVending.Core
{
    public static class CurrencyAppState
    {
        // Default ke IDR jika belum pernah di-set
        public static string SelectedCurrency { get; set; } = "IDR";
    }
}