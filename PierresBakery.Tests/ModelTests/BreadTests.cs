using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.ModelTests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void None_AddOneToQuantity_IntOne()
    {
      // Arrange
      string userInput = "1";

      // Act
      Bread testBread = new Bread(userInput);

      // Assert
      Assert.AreEqual(1, testBread.Quantity);
    }
  }
}