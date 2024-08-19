using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Ejercicios
{
	public class EjercicioFrecuenciaPalabras
	{
		public void Ejecutar()
		{
			Console.WriteLine("Ingrese el texto");
			string sentence = Console.ReadLine();

			string[] words = sentence.Split(' ');

			Dictionary<string, int> wordCount = new Dictionary<string, int>();

			foreach (var word in words)
			{
				if (wordCount.ContainsKey(word))
				{
					wordCount[word]++;
				}
				else
				{
					wordCount.Add(word, 1);
				}
			}

			Console.WriteLine("Frecuencia de palabras");
			foreach (var pair in wordCount)
			{
				Console.WriteLine($"{pair.Key}: {pair.Value}");
			}
		}
    }
}
