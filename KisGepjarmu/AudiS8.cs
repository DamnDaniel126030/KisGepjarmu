using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisGepjarmu
{
	internal class AudiS8 : Jarmu
	{
		private bool lezerblokkolo;

		public AudiS8(bool lezerblokkolo, int sebesseg, string rendszam) : base(sebesseg, rendszam)
		{
			this.lezerblokkolo = lezerblokkolo;
		}

		public override bool GyorshajtottE(int sebessegKorlat)
		{
			if (this.lezerblokkolo)
			{
				return false;
			}
			else
			{
				return this.sebesseg > sebessegKorlat;
			}
		}

		public override string ToString()
		{
			return "Audi: " + base.ToString();
		}
	}
}
