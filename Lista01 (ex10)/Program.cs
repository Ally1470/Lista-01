using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01__ex10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacaoDolar;
            double quantidadeDolares;

            Console.Write("Digite a cotação do dólar:");
            cotacaoDolar = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de dólares:");
            quantidadeDolares = double.Parse(Console.ReadLine());

            double valorEmReais = cotacaoDolar * quantidadeDolares;

            Console.WriteLine("O valor correspondente em Reais (R$) é: R$ ");
            Console.WriteLine(valorEmReais);
        }
    }
}
