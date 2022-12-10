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
      string userInput = "1";

      Pastry testPastry = new Pastry(Convert.ToInt32(userInput));

      Assert.AreEqual(1, testPastry.Quantity);
    }

    [TestMethod]
    public void setCost_OnInstatiationTotalCart_Int()
    {
      int userInput = Convert.ToInt32("6");

      Pastry testPastry = new Pastry(userInput);

      Assert.AreEqual(10, testPastry.Cost);
    }
  }
}