using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.ModelTests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void None_AddOneToQuantity_IntOne()
    {
      // Arrange
      string userInput = "1";

      // Act
      Pastry testPastry = new Pastry(userInput);

      // Assert
      Assert.AreEqual(1, testPastry.Quantity);
    }
  }
}