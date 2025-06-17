using System;

namespace AutoVending.Core
{
    // Kelas ini sekarang menjadi bagian dari library inti
    // dan bisa digunakan di seluruh solusi (solution).
    public class Item
    {
        public int Id { get; set; }
        public string NamaProduk { get; set; }
        public decimal Harga { get; set; }
        public int Stok { get; set; }

        // Override Equals dan GetHashCode agar perbandingan objek di Dictionary/List berfungsi dengan baik.
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