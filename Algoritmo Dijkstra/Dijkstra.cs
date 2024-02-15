using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Dijkstra
{
	public class Dijkstra
	{
		public int[,] mat = new int[4,4];
		private List<int> _lista;
		public List<int> Lista
		{
			get { return _lista; }
			set { _lista = value; }
		}
		public void GeneraMatrice()
		{
			//int[,] mat = new int[4, 4];

			for (int i = 0; i < 4; i++)
			{

				for (int j = 0; j < 4; j++)
				{
			
					if (i == j)
					{
						mat[i, j] = 0;
					}

					else
					{
						if (mat[i,j] == 0)
						{
							Console.WriteLine("Inserisci distanza in posizione " + i + " " + j);
							mat[i, j] = int.Parse(Console.ReadLine());
							mat[j, i] = mat[i, j];
						}
						
						
					}
			

				}
		
			}
			//stampa
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					Console.Write(mat[i, j] + " " + "\t");

				}

				Console.WriteLine();

			}



		}
		public void Aggiungi()
		{
			for (int j = 0; j < 4; j++)
			{
				Lista.Add(mat[0, j]);
				Lista.Sort();

			}
			for (int i = 0; i < Lista.Count; i++)
			{
				Console.WriteLine(Lista[i]);
			}

		}


	}
}

