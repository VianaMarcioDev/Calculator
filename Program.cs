using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
          Multiplicacao();
           
        }

        static void Soma()
        {
           Console.Clear();
           Console.WriteLine("Digite o primeiro valor: ");
           float primeiroValor = float.Parse(Console.ReadLine()); 
           Console.WriteLine("Digite o segundo valor: ");
           float segundoValor = float.Parse(Console.ReadLine());

           float soma = primeiroValor + segundoValor;

           Console.WriteLine();
           Console.WriteLine($"O resultado da soma entre {primeiroValor} e {segundoValor} é {soma}.");
           Console.ReadKey();

        }

        static void Subtracao()
        {
           Console.Clear();
           Console.WriteLine("Digite o primeiro valor: ");
           float primeiroValor = float.Parse(Console.ReadLine()); 
           Console.WriteLine("Digite o segundo valor: ");
           float segundoValor = float.Parse(Console.ReadLine());

           float subtracao = primeiroValor - segundoValor;

           Console.WriteLine();
           Console.WriteLine($"O resultado da subtração entre {primeiroValor} e {segundoValor} é {subtracao}.");
           Console.ReadKey();
        }

        static void Divisao()
        {
           Console.Clear();
           Console.WriteLine("Digite o primeiro valor: ");
           float primeiroValor = float.Parse(Console.ReadLine()); 
           Console.WriteLine("Digite o segundo valor: ");
           float segundoValor = float.Parse(Console.ReadLine());

           float divisao = primeiroValor / segundoValor;

           Console.WriteLine();
           Console.WriteLine($"O resultado da divisao entre {primeiroValor} e {segundoValor} é {divisao}.");
           Console.ReadKey();
        }

        static void Multiplicacao()
        {
           Console.Clear();
           Console.WriteLine("Digite o primeiro valor: ");
           float primeiroValor = float.Parse(Console.ReadLine()); 
           Console.WriteLine("Digite o segundo valor: ");
           float segundoValor = float.Parse(Console.ReadLine());

           float multiplicacao = primeiroValor * segundoValor;

           Console.WriteLine();
           Console.WriteLine($"O resultado da multiplicação entre {primeiroValor} e {segundoValor} é {multiplicacao}.");
           Console.ReadKey();
        }
    }
}