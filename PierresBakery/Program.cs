using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      // UI code here
      Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
      Console.WriteLine("|                                          Welcome to Pierre's Bakery                                       |");
      Console.WriteLine("|                                           Here are Today's prices                                         |");
      Console.WriteLine("| Bread: A single loaf costs $5                        | Pastry: A single pastry for $2                     |");
      Console.WriteLine("| Buy 2, get 1 free (every 3rd loaf of bread is free.) | Buy 3 get $1 off (every 3rd pastry we take $1 off) |");
      Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
      Console.Write("Would you like to add to cart Bread or Pastry today: ");
      string breadOrPastry = Console.ReadLine();
      Console.Write($"How much {breadOrPastry} would you like to add: ");
      int quantity = 0;
      try
      {
        quantity = Convert.ToInt32(Console.ReadLine());
      }
      catch (FormatException e)
      {
        Console.WriteLine($"\n   {e}: Please input a whole number quantity");
        return;
      }
      

      int totalCost = 0; 
      if (breadOrPastry.ToUpper() == "PASTRY")
      {
        Pastry pastry = new Pastry(quantity);
        totalCost += pastry.Cost;
      }
      else if (breadOrPastry.ToUpper() == "BREAD")
      {
        Bread bread = new Bread(quantity);
        totalCost += bread.Cost;
      }
      else 
      {
        Console.WriteLine("We are sorry, we do not provide that option here.");
      }

      Console.Write($"\nCart Total: {totalCost}\n");
      Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
    }
  }
}