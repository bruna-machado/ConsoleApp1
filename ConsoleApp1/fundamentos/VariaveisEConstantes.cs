using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            // "double" ou valor real pode mudar durante o programa, já o "const double" não pode ser alterado o valor que foi 
            //atribuido a ele inicialmente.

            raio = 5.5;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é "+ area);

            //tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo "+ estaChovendo);

            // tipos inteiros

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("saldo de gols "+ saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario: "+ salario);

            int menorValorInt = int.MinValue;// Mais usado do tipo inteiro!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000;
            Console.WriteLine("Populaçao mundial "+ populacaoMundial);

            //tipos reais

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador "+ precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00;// mais usa dos reais
            Console.WriteLine("Valor Apple " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas =  decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas " + distanciaEntreEstrelas);

            // tipos caractere

            char letra = 'a';
            Console.WriteLine("letra " + letra);


            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine("texo "+ texto);
        
        
        }
    }
}
