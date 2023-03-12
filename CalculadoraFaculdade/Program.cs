using System;
using System.Collections.Generic;

namespace CalculadoraMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> valores = new List<double>();

            while (true)
            {
                double valor, media;

                Console.WriteLine(">> Digite um valor (ou digite 'calcular' para calcular a média, ou 'sair' para encerrar o programa):");
                string input = Console.ReadLine();

                if (input.ToLower() == "sair")
                {
                    break;
                }
                else if (input.ToLower() == "calcular")
                {
                    if (valores.Count > 0)
                    {
                        media = calcularMedia(valores);

                        Console.WriteLine(">> A média aritmética dos valores digitados é: {0:F2}", media);
                    }
                    else
                    {
                        Console.WriteLine(">> Nenhum valor foi digitado ainda.");
                    }
                }
                else if (double.TryParse(input, out valor))
                {
                    valores.Add(valor);

                    Console.WriteLine(">> Valor adicionado à lista.");
                }
                else
                {
                    Console.WriteLine(">> Valor inválido. Por favor, digite um número válido.");
                }
            }

            Console.WriteLine(">> O programa foi encerrado. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static double calcularMedia(List<double> valores)
        {
            double soma = 0;

            foreach (double valor in valores)
            {
                soma += valor;
            }

            return soma / valores.Count;
        }
    }
}
