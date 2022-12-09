using System;

namespace PierresBakery.Models
{
  public abstract class Cart
  {
    public int Cost { get; set; }
    public int Quantity { get; set; }

    public Cart(int quantInput)
    {
      Quantity = quantInput;
      Cost = setCost(quantInput);
    }

    public abstract int setCost(int quantNum);
  }
}