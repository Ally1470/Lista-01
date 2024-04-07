using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01__Ex_02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int area;

            Console.Write("Digite o valor da aresta do quadrado: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("O valor da área é: ");
            area = a * a;
            Console.WriteLine(area);
        }
    }
}
