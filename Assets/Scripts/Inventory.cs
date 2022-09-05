using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    public int Gold { get; set; }
    public int MaxGold { get; set; }
    public List<Item> Items { get; set; }
    public int MaxSize { get; set; }

    public Inventory()
    {
        Items = new List<Item>();
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

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        Items.Remove(item);
    }

    public bool CheckForEmptySlot()
    {
        return MaxSize > Items.Count;
    }
}

public class Item
{

}
