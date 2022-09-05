using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    public int Gold { get; set; }
    public int MaxGold { get; set; }
    public Inventory()
    {
        MaxGold = 200;
        Gold = 0;
    }

    public void DepositGold(int amount)
    {
        if (Gold + amount <= MaxGold)
            Gold += amount;
    }
    public void DebitGold(int amount)
    {
        if (Gold >= amount)
            Gold -= amount;
    }
}
