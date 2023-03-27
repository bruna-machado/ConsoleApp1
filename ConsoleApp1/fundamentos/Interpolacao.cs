using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            var marca = "Dell";
            double preco = 5800.00;

            //Concatenando


            //Console.WriteLine("O " + nome + " da marca " 
                //+ marca + " custa " + preco+".");

            //interpolação
            Console.WriteLine("o {0} da marca {1} custa {2}.",
                nome, marca, preco );

            Console.WriteLine($"A marca {marca} é legal!");
            Console.WriteLine($"1 + 1 = {1 + 1}!");
        }
    }
}
