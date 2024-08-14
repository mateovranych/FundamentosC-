using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Models
{
	public class Cerveza : Bebidas, IBebidaAcoholica
	{
		public int Alcohol { get; set; }
		public string Marca { get; set; }

		public void MaxRecomendado()
		{
			Console.WriteLine("El máximo permitido de una cerveza es 10");
		}
		public Cerveza(int alcohol,string Nombre, float Cantidad, string Marca) : base(Nombre, Cantidad)
		{
		}

		
	}
}
