using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduza a coordenada de x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduza a coordenada de y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("O ponto situa-se no Quadrante 1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("O ponto situa-se no Quadrante 2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("O ponto situa-se no Quadrante 3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("O ponto situa-se no Quadrante 4");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("O ponto situa-se na Origem do Referencial");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("O ponto situa-se no Eixo YY");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("O ponto situa-se no Eixo XX");
            }
        }
    }
}
