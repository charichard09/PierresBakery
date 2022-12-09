using System;

namespace PierresBakery.Models
{
  public abstract class Cart
  {
    private int _quantity;
    public int Quantity
    {
      get
      {
        return _quantity;
      }
      set
      {
        _quantity = Convert.ToInt32(value);
      }
    }
  }
}