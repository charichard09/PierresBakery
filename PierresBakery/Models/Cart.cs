using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Cart
  {
    public static List<StoreItem> CurrentCart { get; set; }
    public static void AddItem(StoreItem item)
    {
      CurrentCart.Add(item);
    }
  }
}