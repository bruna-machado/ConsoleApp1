using System;
using System.Globalization;

namespace CursoCSharp.fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {

            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");


        }
    }
}
