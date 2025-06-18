using System;

namespace AutoVending.Core
{
    public enum VendingState
    {
        Idle,           
        SelectingItems,
        ProcessingPayment,
        TurnedOff,
    }
}
