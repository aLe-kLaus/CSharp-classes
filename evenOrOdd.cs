using System;

class EvenOrOdd
{
  public static void Main(string[] args)
  {
    int num;
    string result = "";

    Console.Write("Enter a number: ");
    num = int.Parse(Console.ReadLine());

    switch (num % 2)
    {
      case 1:
        result = "odd";
        break;
      case 0:
        result = "even";
        break;
    }

    Console.Write("This number is " + result);
    Console.ReadKey(true);
  }
}