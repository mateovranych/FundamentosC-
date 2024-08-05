using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundamentosC_.Models;


namespace FundamentosC_
{
	class Program
	{
		static void Main(string[] args)
		{



			string text = "Mateo";
			string textResult = "";


			for (int i= text.Length-1; i>= 0; i--)
			{
				textResult += text[i];
			}
			Console.WriteLine(textResult);
			Console.ReadLine();



			//IEnumerable<int> list = new List<int>()
			//{
			//	1,2,3,4,5,6
			//};

			//var numeroGrande = from x in list
			//				   orderby x descending
			//				   select x;


			//foreach(var x in list)
			//{
			//	Console.WriteLine(x);
			//}
			//Console.ReadLine();




			//var beers = new List<Beer>()
			//{
			//	new Beer() { Nombre="Red",Brand="Budweiser", Acohol = 1m},
			//    new Beer() { Nombre = "Budweiser", Brand = "Model", Acohol = 2m },
			//	new Beer() { Nombre="Blonde",Brand="Heineken", Acohol = 5m},
			//	new Beer() { Nombre="Malta",Brand="Ipa", Acohol = 3m},
			//	new Beer() { Nombre="BlackBeer",Brand="Ipa", Acohol = 9m},
			//};

			//var names = from b in beers
			//			where b.Brand == "Ipa" || b.Acohol >= 10
			//			select new { b.Nombre, b.Brand };	


			//foreach(var b in names) 
			//{
			//	Console.WriteLine(b.Nombre);
			//}


			//Console.ReadLine();

			
			
			
			//IEnumerable<int> numeros = new List<int>() 
			//{
			// 1,2,3,4 
			//};

			//var ordenarNrosMenor = from x in numeros
			//					   orderby x descending
			//					   select x;

			//foreach(var n in numeros)
			//Console.WriteLine(n);
			//Console.ReadLine();



			//Recorrer algo
			//string result = "";
			//for (int i = 0; i < 10; i++)
			//	result += i + ",";

			//Console.WriteLine(result);	
			//Console.ReadLine();


			//List<perros> perros = new List<perros>() { new perros("Tiara",30) };
			//perros.Add(new perros("Gina", 25));
			//perros Gala = new perros("Gala", 100);
			//perros.Add(Gala);

			//Gala.Lipo(30);


			//foreach(var perro in perros)
			//{
			//	Console.WriteLine(perro.name);
			//	Console.WriteLine(perro.weight);
			//}


			//Console.ReadLine();







			//List<vodkas> vodkas = new List<vodkas>() { new vodkas(1,"asdads") };
			//vodkas.Add(new vodkas(500,"one"));
			//vodkas sky = new vodkas(1000, "Sky");
			//vodkas.Add(sky);

			//foreach (var v  in vodkas)
			//{
			//	Console.WriteLine("Estos son los vodkas disponibles "+v.nombre+ " Ml de la bebida " +v.cantidad+" example");
			//}


			//#region

			//List<whisky> whiskies = new List<whisky>() { new whisky("Whisky-Blue Label", 1000) };
			//whiskies.Add(new whisky("Red-Label", 500));
			//whisky greenLabel = new whisky("Green-Label", 1000);
			//whiskies.Add(greenLabel);

			//foreach(var w in whiskies)
			//{
			//	Console.WriteLine("Estos son los wishkies disponibles "+w.name);				
			//}

			//Console.ReadLine();

			//#endregion

		}
		
	}	
}
