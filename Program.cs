using System;

namespace Calculator
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Menu();
    }
    static void Menu()
    {
      Console.Clear();
      Console.WriteLine($"====CALCULADORA====");
      Console.WriteLine($"1- Soma");
      Console.WriteLine($"2- Subtração");
      Console.WriteLine($"3- Divisão");
      Console.WriteLine($"4- Multiplicação");
      Console.WriteLine($"5- Bhaskara");

      Console.WriteLine($"0- Sair");
      Console.WriteLine($"===================");
      Console.Write($"Operação: ");
      short op = Convert.ToInt16(Console.ReadLine());
      switch (op)
      {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: Bhaskara(); break;
        case 0: System.Environment.Exit(0); break;
        default: Menu(); break;
      }
    }
    static void Soma()
    {
      Console.Clear();
      Console.WriteLine($"====SOMA====");

      Console.Write($"Primeiro Valor: ");
      float v1 = float.Parse(Console.ReadLine());
      Console.Write($"Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());
      Console.WriteLine($"");
      Console.WriteLine($"O resultado da soma é {v1 + v2}");
      Console.ReadKey();
      Menu();
    }
    static void Subtracao()
    {
      Console.Clear();
      Console.WriteLine($"====SUBTRAÇÃO====");

      Console.Write($"Primeiro Valor: ");
      float v1 = float.Parse(Console.ReadLine());
      Console.Write($"Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());
      Console.WriteLine($"");
      Console.WriteLine($"O resultado da subtração é {v1 - v2}");
      Console.ReadKey();
      Menu();
    }
    static void Divisao()
    {
      Console.Clear();
      Console.WriteLine($"====DIVISÃO====");

      Console.Write($"Primeiro Valor: ");
      float v1 = float.Parse(Console.ReadLine());
      Console.Write($"Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());
      Console.WriteLine($"");
      Console.WriteLine($"O resultado da divisão é {v1 / v2}");
      Console.ReadKey();
      Menu();
    }
    static void Multiplicacao()
    {
      Console.Clear();
      Console.WriteLine($"====MULTIPLICAÇÃO====");
      Console.Write($"Primeiro Valor: ");
      float v1 = float.Parse(Console.ReadLine());
      Console.Write($"Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());
      Console.WriteLine($"");
      Console.WriteLine($"O resultado da multiplicação é {v1 * v2}");
      Console.ReadKey();
      Menu();
    }
    static void Bhaskara()
    {
      Console.Clear();
      Console.WriteLine($"====BHASKARA====");


      // Coleta dos dados e armazenamento nas variáveis
      Console.Write($"Informe a: ");
      int a = int.Parse(Console.ReadLine());
      Console.Write($"Informe b: ");
      int b = int.Parse(Console.ReadLine());
      Console.Write($"Informe c: ");
      int c = int.Parse(Console.ReadLine());

      // Calculo do delta e das raízes
      int delta = (int)(Math.Pow(b, 2) - (4 * a * c));
      if (a == 0 || delta < 0)
      {
        Console.WriteLine($"Impossível Calcular");
      }
      else
      {
        int x1 = (int)((-b + Math.Sqrt(delta)) / (2 * a));
        int x2 = (int)((-b - Math.Sqrt(delta)) / (2 * a));
        Console.WriteLine($"Delta= {delta}\nx1= {x1}\nx2= {x2}");
      }
      Console.ReadKey();
      Menu();
    }
  }
}