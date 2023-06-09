﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.fundamentos
{
    internal class OperadoresAritimeticos
    {
        public static void Executar()
        {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine("Opreço Final é:{0} ",  totalComDesconto);

            //imc

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow (altura, 2);
            Console.WriteLine($"IMC é {imc}.");

            // número Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}
