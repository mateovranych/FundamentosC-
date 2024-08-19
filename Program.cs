using FundamentosC_.Ejercicios;
using FundamentosC_.Models;
using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{

		while (true)
		{
			Console.WriteLine("Elige un ejercicio para ejecutar:");
			Console.WriteLine("1. Contar la frecuencia de palabras");
			Console.WriteLine("2. Almacenar información de productos");
			Console.WriteLine("3. Diccionario de traducciones");
			Console.WriteLine("4. Salir");
			string option = Console.ReadLine();

			switch (option)
			{
				case "1":
					var ejercicio1 = new EjercicioFrecuenciaPalabras();
					ejercicio1.Ejecutar();
					break;
				case "2":
					var ejercicio2 = new EjercicioProductoyPrecioDictionary();
					ejercicio2.Ejercicio();
					break;
				//case "3":
				//	var ejercicio3 = new Ejercicios.Ejercicio3();
				//	ejercicio3.Ejecutar();
				//	break;
				case "4":
					return;
				default:
					Console.WriteLine("Opción no válida.");
					break;
			}

			Console.WriteLine();
		}




		//double estatura;
		//do
		//{
		//	Console.WriteLine("Ingresa estatura: ");
		//	estatura = Convert.ToDouble(Console.ReadLine());
		//	if (estatura > 1.75)
		//	{
		//		Console.WriteLine("Debe ser menor a 1.75");
		//	}

		//} while (estatura > 1.75);
		//{
		//Console.WriteLine("Altura ingresada correctamente");

		//};



		//int num = 3;

		//while (num < 10) 
		//{
		//	Console.WriteLine("Valor actual : {0}", num);
		//	num++;
		//}
		//Console.WriteLine("El bucle ha terminado");





		//TypeOf, NameOf y Operador de Coalescencia

		//TYPE OF
		//Console.WriteLine(typeof(string));
		//Console.WriteLine(typeof(int));
		//Console.WriteLine(typeof(bool));
		//Console.WriteLine(typeof(float));
		//NAME OF
		//int edadPersona = 21;
		//Console.WriteLine(nameof(edadPersona));
		//string Changename = (nameof(edadPersona));
		//Console.WriteLine(Changename);

		//OPERADOR DE COALESCENCIA
		//double? numero1 = 44;
		//double? numero2 = 15.33;
		//double numero3;

		//numero3 = numero1 ?? 30.33;

		//Console.WriteLine("El numero es " + numero3);




		//string nombre;

		//Console.WriteLine("Ingrese su nombre completo");

		//nombre = Console.ReadLine();
		//Console.WriteLine(nombre);


		//int edad;

		//Console.WriteLine("Ingrese su edad");

		//edad=int.Parse(Console.ReadLine());

		//Console.WriteLine(edad);


		//List<Bar> bars = new List<Bar>()
		//{ new Bar ("Pacero"),
		//  new Bar ("Bola 8"),
		//  new Bar ("Reduvia")
		//};

		//foreach (Bar bar in bars) 
		//{
		//	Console.WriteLine(bar.Nombre);
		//}		

		/*
		int promedio = 4;

		if (promedio >= 17)
		{
			Console.WriteLine("Excelente");
		}
		else if (promedio >= 11) 
		{
			Console.WriteLine("Aprobado");
		}
		else
		{
			if(promedio >= 8)
			{
				Console.WriteLine("Puede ir a recuperacion");
			}
			else
			{
				Console.WriteLine("Desaprobado definitivamente");
			}
		}

		*/


		/*
		int nota = 4;

		if ( nota > 6)
		{
			Console.WriteLine("Aprobaste");
		}
		else if(nota == 6)
		{
			Console.WriteLine("Aprobaste de pedo");
		}
		else
		{
			Console.WriteLine("No aprobaste");
		}

		*/


		//int edad = 18;

		//if (edad >= 18)
		//{
		//	Console.WriteLine("Puede conducir");
		//}
		//else
		//{
		//	Console.WriteLine("No puede conducir es menor de edad");
		//}



		//string texto1,texto2;
		//int numero;
		//numero = 30;
		//texto1 = "Prueba";
		//texto2 = " Concatenacion ";


		//Console.WriteLine(texto1 + texto2);


		//string resultado = texto1 + texto2 +numero;

		//Console.WriteLine(resultado);


		//string miTexto;
		//miTexto = String.Concat(texto1, texto2);
		//Console.WriteLine(miTexto);



		//List<int> numeros = new List<int>() {33,44,11,665,234,624 };

		//for(int x = -1; x <= 999; x++)
		//{
		//	Console.WriteLine(numeros);
		//}


		//Clase math y sus funcionalidades
		//Console.WriteLine(Math.Max(30,39));
		//Console.WriteLine(Math.Min(33,64));
		////potenciacion
		//Console.WriteLine(Math.Pow(5, 3));
		////raiz cuadrada
		//Console.WriteLine(Math.Sqrt(16));

		//double numero = 3.45681;
		////redondeado
		//Console.WriteLine(Math.Round(numero));
		////redondeo para arriba
		//Console.WriteLine(Math.Ceiling(numero));
		////redondeo hacia abajo
		//Console.WriteLine(Math.Floor(numero));

		//Console.WriteLine(Math.Abs(-126));


		//int numeroEdad = 14;


		//Console.WriteLine(numeroEdad >= 18 ? "Si podes manejar" : "no podes manejar");




		//if (numeroEdad >= 18)
		//{
		//	Console.WriteLine("Podes manejar");
		//}
		//else 
		//{
		//	Console.WriteLine("No podes manejar");
		//}

		//Console.WriteLine(DateTime.Now);

		//int age = 14;

		//Console.WriteLine(age >= 18 ? "Es mayor de edad puede manejar" : "Es menor de edad no puede manejar");




		//bool af = true;
		//bool fa = false;


		//Console.WriteLine(af == af);

		//int num1 = 13 ; int num2 = 13;



		//Console.WriteLine(num1 || num2);
		//Console.WriteLine(num1 && num2);
		//Console.WriteLine(num1 <= num2);
		//Console.WriteLine(num1 >= num2);


		//int numero = 44;
		//numero++;


		//Console.WriteLine(numero);



		//List<Bar> bars = new List<Bar>() 
		//{ 
		//	new Bar("Parcereo")
		//	{
		//		cervezas = new List<Cerveza>()
		//		{
		//			new Cerveza(3,"Fiera",500,"Heineken"),
		//			new Cerveza(6,"Corona",500,"Solcito"),
		//		}
		//	},
		//	new Bar("Pelado")
		//	{
		//		cervezas = new List<Cerveza>()
		//		{
		//			new Cerveza(3,"Rica cerveza",500,"Heinequeen"),
		//			new Cerveza(6,"Chess",500,"Stoulder"),
		//		}
		//	},
		//	new Bar("Bola 8")
		//	{
		//		cervezas = new List<Cerveza>()
		//		{
		//			new Cerveza(3,"Rica cerveza",500,"Heinequeen"),
		//			new Cerveza(6,"Chess",500,"Stoulder"),
		//		}
		//	}
		//};


		//foreach (Bar bar in bars) 
		//{
		//	Console.WriteLine(bar.Nombre);
		//}




		//List<Cerveza> cervezas = new List<Cerveza>()
		//{
		//	new Cerveza(3,"Fiera",500,"Heineken"),
		//	new Cerveza(6,"Corona",500,"asd"),
		//	new Cerveza(7,"Ipa",500,"Andes"),
		//	new Cerveza( 7,"Apa",500,"Andes" ),
		//};

		//var cervezasor = from b in cervezas
		//				 where b.Nombre == "Corona" 
		//				 orderby b.Nombre
		//				 select b;

		//foreach (var c in cervezasor)
		//{
		//	Console.WriteLine($"{c.Nombre}{c.Marca}");
		//}








		//List<int> list = new List<int>() {106 ,66,1, 2, 3, 4, 5, 6, 7 };

		//var nro = list.Where(x => x == 9).FirstOrDefault();
		//var numerosOrdenados = list.OrderBy(x => x);

		//var average = list.Average(x => x);


		//Console.WriteLine(average);

		//foreach(var lista in numerosOrdenados)
		//{
		//	Console.WriteLine(lista);	
		//}


	}
}

