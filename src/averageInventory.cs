using System;

class AverageInventory
{
  public static void Main(string[] args)
  {
    int minInventory = 50;
    int maxInventory = 200;
    int avgInventory;

    avgInventory = (minInventory + maxInventory) / 2;

    Console.WriteLine("The average inventory is: " + avgInventory);
  }
}