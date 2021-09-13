using System;

namespace MilhasparaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double ml, convkm;

            Console.Write("Digite a medida em Milhas: ");
            ml = double.Parse(Console.ReadLine());

            convkm = ml * 1.609;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{convkm} Km");
            Console.ResetColor();
        }
    }
}
