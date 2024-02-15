using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Dijkstra
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("A = 0");
			Console.WriteLine("B = 1");
			Console.WriteLine("C = 2");
			Console.WriteLine("D = 3");

			Dijkstra d = new Dijkstra();
			Nodo n = new Nodo();
			d.GeneraMatrice();
			d.Aggiungi();
		}
	}
}
