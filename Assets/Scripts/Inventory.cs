using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    public int Gold { get; set; }

    public void DepositGold(int amount)
    {
        Gold += amount;
    }
    public void DebitGold(int amount)
    {
        if (Gold >= amount)
            Gold -= amount;
    }
}
