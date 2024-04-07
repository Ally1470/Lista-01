using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01__ex08_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Celsius;

            Console.Write("Digite a temperatura em graus Celsius: ");
            Celsius = double.Parse(Console.ReadLine());

            double Fahrenheit = (Celsius * 9 / 5) + 32;

            Console.Write("A temperatura equivalente em Fahrenheit é: ");
            Console.WriteLine(Fahrenheit);
        }
    }
}
