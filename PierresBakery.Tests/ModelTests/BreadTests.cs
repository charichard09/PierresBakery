using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.ModelTests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void None_AddOneToQuantity_IntOne()
    {
      // Arrange
      int userInput = Convert.ToInt32("1");

      // Act
      Bread testBread = new Bread(userInput);

      // Assert
      Assert.AreEqual(1, testBread.Quantity);
    }

    [TestMethod]
    public void setCost_OnInstatiationTotalCart_Int()
    {
      // Arrange
      int userInput = Convert.ToInt32("6");

      // Act
      Bread testBread = new Bread(userInput);

      //Assert
      Assert.AreEqual(20, testBread.Cost);
    }
  }
}