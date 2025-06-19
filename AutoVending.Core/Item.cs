using System;

namespace AutoVending.Core
{
    public class Item
    {
        public int Id { get; set; }
        public string NamaProduk { get; set; }
        public decimal Harga { get; set; }
        public int Stok { get; set; }

        public Item(int id, string namaProduk, decimal harga, int stok)
        {
            Id = id;
            NamaProduk = namaProduk;
            Harga = harga;
            Stok = stok;
        }

        public override bool Equals(object obj)
        {
            return obj is Item item && Id == item.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}