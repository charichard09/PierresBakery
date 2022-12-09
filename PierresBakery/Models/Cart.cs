using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Cart
  {
    private static List<StoreItem> _currentCart = new List<StoreItem> {};
    public static void AddItem(StoreItem item)
    {
      _currentCart.Add(item);
    }

    public static List<StoreItem> GetCurrentCart()
    {
      return _currentCart;
    }
  }
}