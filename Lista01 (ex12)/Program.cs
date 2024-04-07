using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01__ex12_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double p1;
            double p2;
            double p3;
            double p4;
            double p5;
            double pagamento;
            double troco;

            Console.Write("Digite o preço do primeiro produto:");
            p1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço do segundo produto:");
            p2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço do terceiro produto:");
            p3 = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço do quarto produto:");
            p4 = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço do quinto produto:");
            p5 = double.Parse(Console.ReadLine());

            double totalCompra = p1 + p2 + p3 + p4 + p5;

            Console.Write("Digite o valor do pagamento:");
            pagamento = double.Parse(Console.ReadLine());

            troco = pagamento - totalCompra;

            Console.WriteLine("O troco a ser devolvido é: R$ ");
            Console.WriteLine(troco);
        }
    }
}
