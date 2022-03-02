using System;

class SellerCommission
{
  public static void Main(string[] args)
  {
    string sellerName = "John Doe";
    string productId = "1337";
    int selledQuantity = 25;
    double productPrice = 45.7;
    double sellerCommissionPercentage = 5;
    double totalSelled;
    double sellerCommission;

    totalSelled = selledQuantity * productPrice;
    sellerCommission = totalSelled * (sellerCommissionPercentage / 100);

    Console.WriteLine("The seller " + sellerName + " sold the product #" + productId + " " + selledQuantity + " times, and his commission is " + sellerCommission + "R$");
  }
}