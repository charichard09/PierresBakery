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
        _quantity = value;
      }
    }

    public Cart(int quantInput)
    {
      _quantity = quantInput;
    }
  }
}