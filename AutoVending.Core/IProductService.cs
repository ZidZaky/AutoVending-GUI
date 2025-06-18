// FILE: AutoVending.Core/IProductService.cs (INI YANG BENAR)

using System.Collections.Generic;

namespace AutoVending.Core
{
    public interface IProductService
    {
        List<Item> GetProducts();

        // TAMBAHKAN DUA BARIS INI
        void SaveProducts(List<Item> products);
        int GetNextAvailableId();
    }
}