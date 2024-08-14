using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Models
{
	class Vino : Bebidas, IBebidaAcoholica
	{
		public int Alcohol { get; set; }

		public void MaxRecomendado()
		{
			Console.WriteLine("El máximo permitido son 3 copas");
		}
		public Vino(string Nombre, float Cantidad) : base(Nombre, Cantidad)
		{
		}


	}
}
