
using CursoCSharp.fundamentos;
using CursoCSharp.EstruturaDeControle;
using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {

            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e constantes- Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia- Fundamentos", Inferencia.Executar},
                {"Interpolação- Fundamentos", Interpolacao.Executar},
                {"Notação ponto- Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados- Fundamentos", LendoDados.Executar},
                {"Formatando Número- Fundamentos", FormatandoNumero.Executar},
                {"conversões- Fundamentos", Conversoes.Executar},
                {"Operadores aritiméticos- Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais- Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores lógicos- Fundamentos", OperadoreLogicos.Executar},
                {"Operadores Atribuição- Fundamentos", OperadoresAtribucao.Executar },
                {"Operadores Unários- Fundamentos",  OperadoresUnarios.Executar },
                {"Operadores Ternários- Fundamentos",  OperadorTernario.Executar },
                
                //estrutura de controle
                {"estrutura If - Estrutura de Contole",  EstruturaIf.Executar },
                {"estrutura If / Else - Estrutura de Contole",  EstruturaIfElse.Executar },
                {"estrutura If / Else/ If - Estrutura de Contole",  EstruturaIfElseIf.Executar },
                {"estrutura Switch - Estrutura de Contole",  EstruturaSwitch.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}
