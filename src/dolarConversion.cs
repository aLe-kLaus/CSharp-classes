using System;

class DolarConversion
{
  public static void Main(string[] args)
  {
    double dollarQuote;
    double dollarAmount;
    double brRealAmount;

    Console.Write("Enter with the dollar quotation: ");
    dollarQuote = double.Parse(Console.ReadLine());

    Console.Write("Enter with the dollar amount: ");
    dollarAmount = double.Parse(Console.ReadLine());

    brRealAmount = dollarAmount * dollarQuote;

    Console.Write(dollarAmount + "$ is " + brRealAmount + "R$");

  }
}