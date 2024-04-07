using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01__ex11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;

            Console.Write("Digite o valor de X: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Y: ");
            y = double.Parse(Console.ReadLine());

            double resultado = Math.Pow(x, y);

            Console.WriteLine("O resultado de x elevado a y é: ");
            Console.WriteLine(resultado);
        }
    }
}
