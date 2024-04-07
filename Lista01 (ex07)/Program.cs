using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01__ex07_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double milhasMaritimas;
            double metro;

            Console.Write("Digite o número de milhas marítimas:");
            milhasMaritimas = double.Parse(Console.ReadLine());

            metro = (milhasMaritimas * 1852) / 1000;

            Console.Write("O Valor de milha maritimas em quilometros é: ");
            Console.WriteLine(metro);
        }
    }
}
