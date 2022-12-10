namespace PierresBakery.Models
{
  public abstract class StoreItem
  {
    public int Cost { get; set; }
    public int Quantity { get; set; }

    public StoreItem(int quantInput)
    {
      Quantity = quantInput;
      Cost = setCost(quantInput);
    }

    public abstract int setCost(int quantNum);
  }
}