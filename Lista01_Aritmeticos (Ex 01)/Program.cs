using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01_Aritmeticos__Ex_01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;

            Console.Write("Digite a base do retangulo:");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("A área do retângulo é: ");
            area = b * a;
            Console.WriteLine(area);
        }
    }
}
