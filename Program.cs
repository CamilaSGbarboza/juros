using System;

namespace juros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------Juros Simples------");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Capital (R$):");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Taxa de juros (%):");
            double i = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Tempo (meses):");
            double t = Convert.ToDouble(Console.ReadLine());

            double j = c * t * i;
            double m = c + j;

            Console.WriteLine();
            Console.WriteLine($"Juros (R$):{j}");
            Console.WriteLine($"Montante (R$):{m}");





        }
    }
}
