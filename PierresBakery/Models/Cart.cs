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

    public static int CurrentTotal()
    {
      int total = 0;

      foreach (StoreItem item in _currentCart)
      {
        total += item.Cost;
      }
      return total;
    }

    public static void ClearAll()
    {
      _currentCart.Clear();
    }
  }
}