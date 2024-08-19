using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Ejercicios
{
	public class EjercicioProductoyPrecioDictionary
	{
		public void Ejercicio()
		{
			Dictionary<string, decimal> Products = new Dictionary<string, decimal>();

			Console.WriteLine("Ingrese alguno de los numeros correspondientes para avanzar con la operación");
			Console.WriteLine("1. Ingrese un nombre para el producto, y su precio");
			Console.WriteLine("2. Buscar precio para un producto");
			Console.WriteLine("3. Mostrar todos los productos");
			Console.WriteLine("4. Salir");
			string option = Console.ReadLine();

			if (option == "1")
			{
				Console.WriteLine("Ingrese el nombre del producto");
				string name = Console.ReadLine();
				Console.WriteLine("Ingrese el precio del producto");
				decimal precio = Convert.ToDecimal(Console.ReadLine());
				Products[name] = precio;
				Console.WriteLine("producto agregado correctamente");
			}
			//else if(option == "2") {
			//	Console.WriteLine()

			//}

		}
	}
}
