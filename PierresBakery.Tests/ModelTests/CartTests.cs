using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery.ModelTests
{
  [TestClass]
  public class CartTests
  {
    [TestMethod]
    public void AddItem_WillTakeBreadAndStore_Bread()
    {
      // Arrange
      Bread testBread = new Bread(6);

      // Act
      Cart.AddItem(testBread);

      // Assert
      foreach (StoreItem item in Cart.GetCurrentCart())
      {
        Assert.AreEqual(typeof(Bread), item.GetType());
      }
    }

    [TestMethod]
    public void AddItem_WillTakePastryAndStore_Pastry()
    {
      // Arrange
      Pastry testPastry = new Pastry(6);

      // Act
      Cart.AddItem(testPastry);

      // Assert
      foreach (StoreItem item in Cart.GetCurrentCart())
      {
        Assert.AreEqual(typeof(Pastry), item.GetType());
      }
    }
  }
}