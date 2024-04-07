using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01__ex05_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int media;

            Console.Write("Digite o primeiro valor:");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor:");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor:");
            c = int.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor:");
            d = int.Parse(Console.ReadLine());

            media = (a+b+c+d)/4;
            Console.Write("A média é: ");

            Console.WriteLine(media);
        }
    }
}
