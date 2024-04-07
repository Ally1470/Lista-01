using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01__Ex04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;

            Console.Write("Digite o valor da base do triângulo:");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do triângulo:");
            a = int.Parse(Console.ReadLine());

            Console.Write("A área do Triangulo é: ");
            area =  (b * a)/2;
            Console.WriteLine(area);
        }
    }
}
