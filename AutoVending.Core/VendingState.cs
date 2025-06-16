using System;

namespace AutoVending.Core
{
    // Definisi state untuk Vending Machine (Automata)
    public enum VendingState
    {
        Idle,           // Mesin siap menerima input, keranjang kosong
        SelectingItems, // Pengguna sedang menambahkan item ke keranjang
        ProcessingPayment // Form pembayaran ditampilkan, form utama di-lock
    }
}
