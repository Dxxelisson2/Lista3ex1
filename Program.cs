using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            {
                int valor;

                do
                {
                    Console.WriteLine("Digite um valor positivo!");
                    valor = int.Parse(Console.ReadLine());

                    if (valor < 0)
                    {
                        Console.WriteLine("Valor inválido! Digite novamente.");
                    }
                    else if (valor > 0)
                    {
                        Console.WriteLine("Você digitou um valor positivo. Parabéns!");
                    }
                } while (valor <= 0);

            }
        }

    }
}

