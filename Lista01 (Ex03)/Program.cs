using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01__Ex03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            int area;

            Console.Write("Digite o valor da diagonal do quadrado: ");
            d = int.Parse(Console.ReadLine());

            Console.Write("O valor da área é: ");
            area = (d * d)/2;
            Console.WriteLine(area);
        }
    }
}
