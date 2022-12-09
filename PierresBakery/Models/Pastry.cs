namespace PierresBakery.Models
{
  public class Pastry : Cart
  {
    public Pastry(int quantInput) : base(quantInput)
    {

    }

    public override int setCost(int quantNum)
    {
      return Cost;
    }
  }
}