using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace EscolhaPetShop
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // Cria variáveis que serão utilizadas
            int qtdPequenos;
            int qtdGrandes;
            DayOfWeek diaDaSemana;

            // Cria novos petshops e atribui informações
            List<PetShop> listPetShop = new List<PetShop>()
            {
                new PetShop {
                    Nome="Meu Canino Feliz",
                    Distancia = 2.0,
                    DiaUtilPrecoPequeno = 20.0,
                    DiaUtilPrecoGrande = 40.0,
                    FdsPrecoPequeno = 20.0 + 20.0 * 0.2,
                    FdsPrecoGrande = 40 + 40 * 0.2
                },

                new PetShop {
                    Nome = "Vai Rex",
                    Distancia = 1.7,
                    DiaUtilPrecoPequeno = 15.0,
                    DiaUtilPrecoGrande = 50.0,
                    FdsPrecoPequeno = 20.0,
                    FdsPrecoGrande = 55.00
                },

                new PetShop {
                    Nome = "ChowChawgas",
                    Distancia = 0.8,
                    DiaUtilPrecoPequeno = 30.0,
                    DiaUtilPrecoGrande = 45.0,
                    FdsPrecoPequeno = 30.0,
                    FdsPrecoGrande = 45.0
                }
            };

            // Atribui os métodos as variáveis criadas
            Console.WriteLine("Bora levar os doguinhos para tomar um banho?");
            diaDaSemana = LeituraDiaDaSemana();
            qtdPequenos = LeituraQtdCaes("pequenos");
            qtdGrandes = LeituraQtdCaes("grandes");

            var orcamentoFinal = FazerCalculo(listPetShop, qtdPequenos, qtdGrandes, diaDaSemana);

            exibeOrcamentoFinal(orcamentoFinal);

        }

        private static void exibeOrcamentoFinal(IEnumerable<Pedido> orcamentoFinal)
        {
            // Retorna o orçamento final
            var orcamento = orcamentoFinal.ToList();
            Console.WriteLine($"\nO PetShop mais em conta para o dia escolhido é o {orcamento[0].NomePetShop} e o valor total é R${ orcamento[0].ValorTotal}");
        }

        private static int LeituraQtdCaes(string tamanhoCao)
        {
            // Recebe a quantidade de cães
            Console.WriteLine($"Escreva a quantidade de cães {tamanhoCao}: ");

            // Verifica se foi recebido um número inteiro
            bool conversaoOk = int.TryParse(Console.ReadLine(), out int returnQtdCaes);
            
            if (!conversaoOk && returnQtdCaes == 0)
            {
                Console.WriteLine("\nValor inválido, favor digitar um valor inteiro.");
                return LeituraQtdCaes(tamanhoCao);
            }

            return returnQtdCaes;

        }

        private static DayOfWeek LeituraDiaDaSemana()
        {
            // Faz a leitura do dia da semana
            Console.WriteLine("Digite a data no formado dd/mm/aaaa:");
            String dateInput = Console.ReadLine();

            // Faz o parse da data recebida
            var cultureInfo = new CultureInfo("pt-BR");
            var parsedDate = DateTime.Parse(dateInput, cultureInfo);

            // Encontra e retorna o dia da semana
            DayOfWeek dayOfWeek = parsedDate.DayOfWeek;

            return dayOfWeek;
        }

        public static IEnumerable<Pedido> FazerCalculo(List<PetShop> listPetShop, int qtdPequeno, int qtdGrande, DayOfWeek diaDaSemana)
        {
            bool isWeekend = false;
            List<Pedido> pedido = new List<Pedido>();

            // Verifica se a data é um dia útil ou fim de semana e calcula os valores
            if (diaDaSemana == DayOfWeek.Saturday || diaDaSemana == DayOfWeek.Sunday)
            {
                isWeekend = true;
            };

            foreach (var list in listPetShop)
            {
                double valorTotalPequeno;
                double valorTotalGrande;

                if (isWeekend)
                {
                    valorTotalPequeno = qtdPequeno * list.FdsPrecoPequeno;
                    valorTotalGrande = qtdGrande * list.FdsPrecoGrande;
                }
                else
                {
                    valorTotalPequeno = qtdPequeno * list.DiaUtilPrecoPequeno;
                    valorTotalGrande = qtdGrande * list.DiaUtilPrecoGrande;
                }

                // Adiciona novo pedido
                pedido.Add(new Pedido
                {
                    QtdPequenos = qtdPequeno,
                    QtdGrandes = qtdGrande,
                    DiaDaSemana = diaDaSemana,
                    ValorTotalPequeno = valorTotalPequeno,
                    ValorTotalGrande = valorTotalGrande,
                    Distancia = list.Distancia,
                    ValorTotal = valorTotalGrande + valorTotalPequeno,
                    NomePetShop = list.Nome

                });
            };

            // Encontra o menor valor
            double menorValor = pedido.Min(x => x.ValorTotal);

            var listaMenorValor = pedido.Where(x => x.ValorTotal == menorValor);

            if (listaMenorValor.Count() > 1)
            {
                var distanciaMinima = pedido.Min(x => x.Distancia);
                listaMenorValor = pedido.Where(x => x.ValorTotal == menorValor && x.Distancia == distanciaMinima);
                return listaMenorValor;

            }

            return listaMenorValor;
        }
    }
}
