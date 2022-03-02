using System;

class Average
{
  public static void Main(string[] args)
  {
    int num;
    int num2;
    int num3;
    int num4;
    int num5;
    int result;
    int average;

    Console.Write("Enter the first number: ");
    num = int.Parse(Console.ReadLine());
    Console.Write("Enter the second number: ");
    num2 = int.Parse(Console.ReadLine());
    Console.Write("Enter the third number: ");
    num3 = int.Parse(Console.ReadLine());
    Console.Write("Enter the fourth number: ");
    num4 = int.Parse(Console.ReadLine());
    Console.Write("Enter the fifth number: ");
    num5 = int.Parse(Console.ReadLine());
    result = num + num2 + num3 + num4 + num5;
    average = result / 5;

    Console.Write("The average of 5 is " + average);
    Console.ReadKey(true);
  }
}