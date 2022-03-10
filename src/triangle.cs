using System;

class Triangle
{
  public static void Main(string[] args)
  {
    int a;
    int b;
    int c;

    Console.Write("Entre com o primeiro lado: ");
    a = int.Parse(Console.ReadLine());
    Console.Write("Entre com o segundo lado: ");
    b = int.Parse(Console.ReadLine());
    Console.Write("Entre com o terceiro lado: ");
    c = int.Parse(Console.ReadLine());

    if (a < b + c && b < a + c && c < a + b)
    {
      if (a == b && a == c)
      {
        Console.WriteLine("Isso e um triangulo equilatero");
      }
      else if (a == b || a == c || c == b)
      {
        Console.WriteLine("Isso e um triangulo isoceles");
      }
      else
      {
        Console.WriteLine("Isso e um triangule escaleno");
      }
    }
    else
    {
      Console.Write("Isso nao e um triangulo");
    }

    Console.ReadKey(true);
  }
}