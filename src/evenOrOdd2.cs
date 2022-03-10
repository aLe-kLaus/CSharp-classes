using System;

class EvenOrOdd2
{
  public static void Main(string[] args)
  {
    int num = 0;
    int evenTotal = 0;
    int oddTotal = 0;
    while (num >= 0)
    {
      string result = "";
      Console.Write("Entre com o numero: ");
      num = int.Parse(Console.ReadLine());
      if (num > 0)
      {
        switch (num % 2)
        {
          case 1:
            result = "impar";
            oddTotal += num;
            break;
          case 0:
            result = "par";
            evenTotal += num;
            break;
        }
        Console.WriteLine("Esse numero é: " + result);
      }
    }
    Console.WriteLine("A soma de todos os numeros pares: " + evenTotal);
    Console.WriteLine("A soma de todos os numeros impares: " + oddTotal);
    Console.ReadKey(true);
    return;
  }
}