using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Algoritmo_Dijkstra
{
	public class Nodo : Dijkstra
	{
		
		private string _nomenodo;
		private int _peso;
		private string _predecessore;

		public string Nomenodo
		{
			get { return _nomenodo; }
			set { _nomenodo = value; }
		}
		public int Peso
		{
			get { return _peso; }
			set { _peso = value; }
		}
		public string Predecessore
		{
			get { return _predecessore; }
			set { _predecessore = value; }
		}
		
		public Nodo()
		{
			Nomenodo = string.Empty;
			Predecessore = string.Empty;
			Peso = 0;
			Lista = new List<int>();
			
		}
	  
		
	}
}
