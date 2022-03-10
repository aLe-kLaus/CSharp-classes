using System;

class Calculator2
{
  public static void Main(string[] args)
  {
    string userContinue = "s";

    while (userContinue == "s" || userContinue == "S")
    {
      int num = 0;
      int num2 = 0;
      int result = 0;
      string operation = "";

      Console.Write("Entre com a operação (Adição: 1, Subtração: 2, Multiplicação: 3, Divisão: 4): ");
      operation = Console.ReadLine();

      Console.Write("Entre com o primeiro número: ");
      num = int.Parse(Console.ReadLine());

      Console.Write("Entre com o segundo número: ");
      num2 = int.Parse(Console.ReadLine());

      switch (operation)
      {
        case "1":
          result = num + num2;
          Console.WriteLine(num + " + " + num2 + " = " + result);
          break;
        case "2":
          result = num - num2;
          Console.WriteLine(num + " - " + num2 + " = " + result);
          break;
        case "3":
          result = num * num2;
          Console.WriteLine(num + " * " + num2 + " = " + result);
          break;
        case "4":
          result = num / num2;
          Console.WriteLine(num + " / " + num2 + " = " + result);
          break;
        default:
          Console.WriteLine("Invalid Operation");
          break;
      }
      Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");
      Console.WriteLine("Deseja continuar? (s/n)");
      userContinue = Console.ReadLine();
      Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");
    }
    Console.ReadKey(true);
  }
}