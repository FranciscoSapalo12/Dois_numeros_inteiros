using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dois_números_inteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enunciado============================================================
            /*1.Crie um algoritmo que le dois números inteiros apresenta a sua soma
             * 
             */
            //Estrutura de dados===================================================
            int n1, n2;
            int soma;

            //Algortimo

            Console.WriteLine("Insira o primeiro número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("A soma" + n1 + "com" + n2 + "é" + soma);
            Console.ReadLine();
        }
    }
}
