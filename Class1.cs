using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circunferencia
{
    internal class calculo
    {

         public int valor, raio;

        public void Raio(int raio)
        {
            this.raio = raio;

           
        }

        public void circulo(int pelota)
        {
            this.valor = pelota;
        }

        public void pi()
        {
            double Calc = 2 * 3.14 * raio;

            Console.WriteLine($"O resultado é: {Calc}");
            
        }
       

    }
}
