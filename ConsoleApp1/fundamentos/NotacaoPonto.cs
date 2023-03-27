using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, " Word!").
                Replace("Word!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);

        }
    }
}
