using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewEditModeTest
{
    
    [Test]
    [Category("Inventory")]
    public void DepositGold_True_DepositedGold()
    {
        //Arrange
        Inventory inventory = new Inventory();
        int expected = 10;

        //Act
        inventory.DepositGold(10);

        //Assert
        Assert.AreEqual(expected, inventory.Gold);
    }
    [Test]
    [Category("Inventory")]
    [TestCase(100)]
    [TestCase(500)]
    public void DepositGold_True_DoesntExceedMaxGold(int amount)
    {
        //Arrange
        Inventory inventory = new Inventory();        

        //Act
        inventory.DepositGold(amount);

        //Assert
        Assert.LessOrEqual(inventory.Gold, inventory.MaxGold);
    }
    [Test]
    [Category("Inventory")]
    public void InventoryGold_True_StartAtZeroMaxGold()
    {
        //Arrange
        Inventory inventory = new Inventory();

        //Assert
        Assert.AreEqual(0, inventory.Gold);
    }
    [Test]
    [Category("Inventory")]
    public void DebitGold_True_GoldDebitRemoved()
    {
        //Arrange
        Inventory inventory = new Inventory();
        int expected = 20;

        //Act
        inventory.DepositGold(50);
        inventory.DebitGold(30);

        //Assert
        Assert.AreEqual(expected, inventory.Gold);
    }
    [Test]
    [Category("Inventory")]
    [TestCase(50, 60, 50)]
    [TestCase(100, 80, 20)]
    [TestCase(201, 1200, 201)]
    public void DebitGold_True_GoldNeverBelowZero(int deposit, int debit, int expected)
    {
        //Arrange
        Inventory inventory = new Inventory();

        //Act
        inventory.DepositGold(deposit);
        inventory.DebitGold(debit);

        //Assert
        Assert.AreEqual(expected, inventory.Gold);
    }




    [Test]
    [Category("Inventory")]
    public void AddItem_True_ItemAddedToInventory()
    {
        //Arrange
        Inventory inventory = new Inventory();
        Item item = new Item();

        //Act
        inventory.AddItem(item);

        //Assert
        Assert.AreEqual(item, inventory.Items[0]);
    }

    [Test]
    [Category("Inventory")]
    public void RemoveItem_True_ItemRemovedFromInventory()
    {
        //Arrange
        Inventory inventory = new Inventory();
        Item item = new Item();

        //Act
        inventory.AddItem(item);
        inventory.RemoveItem(item);

        //Assert
        Assert.AreEqual(0, inventory.Items.Count);
    }

    [Test]
    [Category("Inventory")]
    public void CheckForEmptySlot_True_EmptySlotAvailable()
    {
        //Arrange
        Inventory inventory = new Inventory();
        inventory.MaxSize = 5;

        //Act
        for (int i = 0; i < 4; i++)
        {
            inventory.AddItem(new Item());
        }

        //Assert
        Assert.IsTrue(inventory.CheckForEmptySlot());
    }
}
