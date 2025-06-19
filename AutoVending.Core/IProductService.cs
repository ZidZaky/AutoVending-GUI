
using System.Collections.Generic;

namespace AutoVending.Core
{
    public interface IProductService
    {
        List<Item> GetProducts();

        void SaveProducts(List<Item> products);
        int GetNextAvailableId();
    }
}