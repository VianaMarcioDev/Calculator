using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();
           Console.WriteLine("Digite o primeiro valor: ");
           float primeiroValor = float.Parse(Console.ReadLine()); 
           Console.WriteLine("Digite o segundo valor: ");
           float segundoValor = float.Parse(Console.ReadLine());

           float soma = primeiroValor + segundoValor;

           Console.WriteLine();
           Console.WriteLine($"O resultado da soma entre {primeiroValor} e {segundoValor} é {soma}.");
           
        }
    }
}