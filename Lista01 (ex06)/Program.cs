using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01__ex06_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double media;
            
            Console.Write("Digite o primeiro valor:");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor:");
            b = double.Parse(Console.ReadLine());

            Console.Write("A média geométrica dos dois valores é: ");
            media = Math.Sqrt(a * b);   
            Console.WriteLine(media);
        }
    }
}
