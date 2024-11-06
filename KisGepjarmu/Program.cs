using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisGepjarmu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Orszagut orszagut = new Orszagut(new List<Jarmu>());
			orszagut.JarmuvekJonnek("jarmuvek.txt");
			orszagut.KiketMertunkBe();
		}
	}
}
