using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisGepjarmu
{
	internal class Robogo : Jarmu
	{

		private int maxSebesseg;

		public Robogo(int maxSebesseg, int sebesseg, string rendszam) : base(sebesseg, rendszam)
		{
			this.maxSebesseg = maxSebesseg;
		}

		public override bool GyorshajtottE(int sebessegKorlat)
		{
			return this.sebesseg <= sebessegKorlat;
		}

		public override bool HaladhatItt(int sebessegKorlat)
		{
			return maxSebesseg < sebessegKorlat;
		}

		public override string ToString()
		{
			return "Robogó: " + base.ToString();
		}

	}
}
