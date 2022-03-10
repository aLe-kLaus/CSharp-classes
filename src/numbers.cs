using System;

class Numbers
{
  public static void Main(string[] args)
  {
    int highest = 0;
    int lowest = 0;
    int total = 0;
    for (int i = 1; i <= 10; i++)
    {
      Console.Write("Entre com o " + i + "º " + "número: ");
      int newVal = int.Parse(Console.ReadLine());
      total = total + newVal;
      if (newVal > highest)
      {
        highest = newVal;
      }
      if (i == 1)
      {
        lowest = newVal;
      }
      if (newVal < lowest)
      {
        lowest = newVal;
      }
    }
    Console.WriteLine("O valor mais alto digitado foi: " + highest);
    Console.WriteLine("O valor mais baixo digitado foi: " + lowest);
    Console.WriteLine("A media dos valores digitados e: " + total / 10);
  }
}