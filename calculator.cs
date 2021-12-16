using System;

class Hello
{
  public static void Main(string[] args)
  {
    string userContinue = "yes";

    while (userContinue == "yes")
    {
      int num = 0;
      int num2 = 0;
      int result = 0;
      string operation = "";

      Console.Write("Enter the first number: ");
      num = int.Parse(Console.ReadLine());

      Console.Write("Enter the operation (sum: +, minus: -, times: *, divided by: /): ");
      operation = Console.ReadLine();

      Console.Write("Enter the second number: ");
      num2 = int.Parse(Console.ReadLine());

      switch (operation)
      {
        case "+":
          result = num + num2;
          break;
        case "-":
          result = num - num2;
          break;
        case "*":
          result = num * num2;
          break;
        case "/":
          result = num / num2;
          break;
        default:
          Console.WriteLine("Invalid Operation");
          break;
      }

      Console.WriteLine(num + " " + operation + " " + num2 + " = " + result);
      Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");
      Console.WriteLine("Do you want to continue? (yes/no): ");
      userContinue = Console.ReadLine();
      Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");
    }
    Console.ReadKey(true);
  }
}