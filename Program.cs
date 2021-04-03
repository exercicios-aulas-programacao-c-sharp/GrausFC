using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            const double primeiroFator = 32.0;
            const double divisor = 1.8;
            
            double celsius;
            double fahenheit;

            Console.Write("°F = ");
            fahenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahenheit - primeiroFator) / divisor;
            Console.WriteLine($"{fahenheit}°F equivalem a {celsius:N1}°C");
        }
    }
}
