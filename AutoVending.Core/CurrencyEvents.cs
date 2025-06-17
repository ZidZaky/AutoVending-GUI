using System;

namespace AutoVending.Core
{
    public static class CurrencyEvents
    {
        public static event Action CurrencyChanged;

        public static void NotifyCurrencyChanged()
        {
            CurrencyChanged?.Invoke();
        }
    }
}