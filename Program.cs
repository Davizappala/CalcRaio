using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circunferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculo valor = new calculo();

            Console.WriteLine("Digite o valor do raio");

            valor.Raio(int.Parse(Console.ReadLine()));

            valor.pi();
        }
    }
}
