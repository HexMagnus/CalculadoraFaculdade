       //Bibliotecas Utilizadas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CalculadoraFaculdade
{
    class Program
    {

        //Método Principal, declaracao de variaveis e entrada de dados
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer:");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");

            int calculos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número desejado: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número desejado: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            // Estrutura de Condição(switch-case)

            switch (calculos)
            {
                case 1:
                    {
                        resultado = Soma( n1,n2);
                        break;

                    }
                case 2:
                    {
                        resultado = Subtracao(n1, n2);
                        break;

                    }
                case 3:
                    {
                        resultado = Multiplicacao(n1, n2);
                        break;

                    }
                case 4:
                    {
                        resultado = Divisao(n1, n2);
                        break;

                    }

            default:
                Console.WriteLine("Operação Inválida");
            break;

            }


            // Impressão dos dados no posicionamento vetorial
            Console.WriteLine("Resultado de {0} e {1} é {2}  ",n1, n2, resultado);

            Console.ReadLine();

            //Métodos Auxiliares
        }
        public static int Soma(int n1, int n2)
        {
            {
                int resultado = n1 + n2;
                return resultado;
            }

        }
        public static int Subtracao(int n1, int n2)
        {
            {
                int resultado = n1 - n2;
                return resultado;
            }

        }
        public static int Multiplicacao(int n1, int n2)
        {
            {
                int resultado = n1 * n2;
                return resultado;
            }

        }
        public static int Divisao(int n1, int n2)
        {
            {
                int resultado = n1 / n2;
                return resultado;
            }

        }
    }
}