namespace PierresBakery.Models
{
  public class Bread : StoreItem
  {
      public Bread(int quantInput) : base(quantInput)
      {

      }

    public override int setCost(int quantNum)
    {
      for (int i = 1; i <= quantNum; i++)
      {
        if (i % 3 == 0)
        {
          continue;
        }
        else
        {
          Cost += 5;
        }
      }
      return Cost;
    }
  }
}