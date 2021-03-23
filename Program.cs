using System;

namespace exercicioSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 = 0;
            double soma = 0.0;

            Console.Write("Entre com um número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Entre com outro número: ");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.Write("SOMA = " + soma);
        }
    }
}
