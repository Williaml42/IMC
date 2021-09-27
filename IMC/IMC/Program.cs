using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso:");
            double massa = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura");
            double altura = double.Parse(Console.ReadLine());
            double imc = massa / (altura * altura);
            Console.WriteLine();
            Console.WriteLine("Seu imc é:"+ imc);
        }
    }
}
