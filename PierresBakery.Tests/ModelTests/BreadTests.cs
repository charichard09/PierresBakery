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
      int userInput = Convert.ToInt32("1");

      Bread testBread = new Bread(userInput);

      Assert.AreEqual(1, testBread.Quantity);
    }

    [TestMethod]
    public void setCost_OnInstatiationTotalCart_Int()
    {
      int userInput = Convert.ToInt32("6");

      Bread testBread = new Bread(userInput);

      Assert.AreEqual(20, testBread.Cost);
    }
  }
}