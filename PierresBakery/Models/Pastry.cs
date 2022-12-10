namespace PierresBakery.Models
{
  public class Pastry : StoreItem
  {
    public Pastry(int quantInput) : base(quantInput) {}

    public override int setCost(int quantNum)
    {
      for (int i = 1; i <= quantNum; i++)
      {
        if (i % 3 == 0)
        {
          Cost += 2;
          Cost -= 1;
        }
        else 
        {
          Cost += 2;
        }
      }
      return Cost;
    }
  }
}