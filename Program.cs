using System;
using System.Globalization;

namespace exercicioCalcularRaioCirculo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Fórmula da Área: area = PI * raio * raio
            // Considerando o valor de PI = 3.14159

            double raio, area, pi = 3.14159;

            Console.WriteLine("Entre com o valor do raio: ");
            raio = double.Parse(Console.ReadLine());

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Área = " + area.ToString( "F4" ,CultureInfo.InvariantCulture));

        }
    }
}
