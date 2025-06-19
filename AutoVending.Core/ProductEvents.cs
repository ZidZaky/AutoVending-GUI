using System;

namespace AutoVending.Core
{
    public static class ProductEvents
    {
        public static event Action OnProductsChanged;

        public static void TriggerProductsChanged()
        {
            OnProductsChanged?.Invoke();
        }
    }
}