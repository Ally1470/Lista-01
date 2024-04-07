using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01__ex09_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro;
            double area;

            Console.Write("Digite o valor do diâmetro do circulo:");
            diametro = double.Parse(Console.ReadLine());

            area = (diametro * diametro) * 3.1415;

            Console.Write("O valor do diâmetro é: ");
            Console.WriteLine(area);
        }
    }
}
