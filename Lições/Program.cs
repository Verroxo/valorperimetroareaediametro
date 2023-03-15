using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lições
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor para ser calculado área: ");
            double raio = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(raio, 2);

            double diametro = 2 * raio;

            double perimetro = 2 * Math.PI * raio;

            Console.WriteLine("O valor de sua área é de: " + area);
            Console.WriteLine("O valor de seu diamêtro é de :" + diametro);
            Console.WriteLine("O valor de seu perimetro é de : " + perimetro);

            Console.ReadKey();
        }
    }
}
