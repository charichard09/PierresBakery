using System;
using PierresBakery.Models;
using System.Text.RegularExpressions;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      // UI code here
      Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
      Console.WriteLine("| Welcome to Pierre's Bakery");
      Console.WriteLine("| Here are Today's prices");
      Console.WriteLine("| Bread: A single loaf costs $5                        | Pastry: A single pastry for $2");
      Console.WriteLine("| Buy 2, get 1 free (every 3rd loaf of bread is free.) | Buy 3 get $1 off (every 3rd pastry we take $1 off)");
      Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

      string addAnother = "yes";

      while (addAnother == "yes" || addAnother == "y")
      {
        Console.Write("Would you like to add to cart Bread or Pastry today: ");
        string breadOrPastry = Console.ReadLine();
        if (!Regex.IsMatch(breadOrPastry, @"bread", RegexOptions.IgnoreCase) && !Regex.IsMatch(breadOrPastry, @"pastry", RegexOptions.IgnoreCase))
        {
          Console.WriteLine($"We are sorry, we do not provide {breadOrPastry} here. Please enter 'bread' or 'pastry'.");
          continue;
        }

        Console.Write($"How much {breadOrPastry} would you like to add: ");
        string quantityString = Console.ReadLine();
        int quantityNum = 0;
        if (Regex.IsMatch(quantityString, @"\d+"))
        {
          quantityNum = Convert.ToInt32(quantityString);
        }
        else
        {
          Console.WriteLine($"{quantityString} is not a valid number. Please input a whole number quantity");
          continue;
        }
        
        if (breadOrPastry.ToUpper() == "PASTRY")
        {
          Pastry pastry = new Pastry(quantityNum);
          Cart.AddItem(pastry);
        }
        else if (breadOrPastry.ToUpper() == "BREAD")
        {
          Bread bread = new Bread(quantityNum);
          Cart.AddItem(bread);
        }
        
        Console.WriteLine("Would you like to add another item? (yes/no)");
        addAnother = Console.ReadLine().ToLower();
      }

      Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
      Console.WriteLine("Cart:");
      foreach (StoreItem item in Cart.GetCurrentCart())
      {
        if (item.GetType() == typeof(Bread))
        {
          Console.WriteLine($"{item.Quantity} Bread @ ${item.Cost}");
        } 
        else 
        {
          Console.WriteLine($"{item.Quantity} Pastry @ ${item.Cost}");
        }
      }
      Console.Write($"Cart Total: ${Cart.CurrentTotal()}\n");
      Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
    }
  }
}