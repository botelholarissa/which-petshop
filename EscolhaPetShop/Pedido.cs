using System;

public class Pedido
{
	public int QtdPequenos { get; set; }
	public int QtdGrandes { get; set; }
	public DayOfWeek DiaDaSemana { get; set; }
	public double ValorTotalPequeno { get; set; }
	public double ValorTotalGrande { get; set; }
	public double ValorTotal { get; set; }
	public double Distancia { get; set; }
	public string NomePetShop { get; set; }
}
 