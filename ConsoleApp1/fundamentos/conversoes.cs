using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            //conversao implicita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);
            
            //conversao explicita
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("notaTruncada:{0}", notaTruncada);

            // conversao de string para inteiro/ inteiro para string
            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int. Parse(idadeString);
            Console.WriteLine("Idade inserida:{0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); 
            Console.WriteLine("Resultado:{0}", idadeInteiro);

            Console.WriteLine("Digite o primeiro numero");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out  numero1);
            Console.WriteLine("resultado1: {0}",numero1);

            Console.WriteLine("Digite segundo numero");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("resultado2: {0}", numero2);
        }
   

        
    }
}
