using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFaculdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer:");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");

            Console.ReadLine();

            int calculos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número desejado: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número desejado: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado;

            switch (calculos)
            {
                case 1:
                    {
                        resultado = n1 + n2;
                        break;

                    }
            }
        }
    }
}   








