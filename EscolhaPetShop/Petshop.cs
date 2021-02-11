using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolhaPetShop
{

    public class PetShop
    {
        public String Nome;
        public double Distancia;
        public double FdsPrecoPequeno;
        public double DiaUtilPrecoPequeno;
        public double FdsPrecoGrande;
        public double DiaUtilPrecoGrande;


        public Pedido CalcularPedido(DayOfWeek diaDaSemana, int qtdPequeno, int qtdGrande)
        {
            bool isWeekend = diaDaSemana == DayOfWeek.Saturday || diaDaSemana == DayOfWeek.Sunday;

            double valorTotalPequeno;
            double valorTotalGrande;

            if (isWeekend)
            {
                valorTotalPequeno = qtdPequeno * FdsPrecoPequeno;
                valorTotalGrande = qtdGrande * FdsPrecoGrande;
            }
            else
            {
                valorTotalPequeno = qtdPequeno * DiaUtilPrecoPequeno;
                valorTotalGrande = qtdGrande * DiaUtilPrecoGrande;
            }


            return new Pedido
            {
                QtdPequenos = qtdPequeno,
                QtdGrandes = qtdGrande,
                DiaDaSemana = diaDaSemana,
                ValorTotalPequeno = valorTotalPequeno,
                ValorTotalGrande = valorTotalGrande,
                Distancia = this.Distancia,
                ValorTotal = valorTotalGrande + valorTotalPequeno,
                NomePetShop = this.Nome
            };
        }
    }
 }
