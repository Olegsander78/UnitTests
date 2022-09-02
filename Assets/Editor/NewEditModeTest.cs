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
}
