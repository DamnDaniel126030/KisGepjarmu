using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisGepjarmu
{
	internal abstract class Jarmu : IKisGepjarmu
	{
		protected int sebesseg;
		private string rendszam;


		public Jarmu(int sebesseg, string rendszam)
		{
			this.sebesseg = sebesseg;
			this.rendszam = rendszam;
		}

		public virtual bool HaladhatItt(int sebessegKorlat)
		{
			return this.sebesseg <= sebessegKorlat;
		}

		public abstract bool GyorshajtottE(int sebessegKorlat);

		public override string ToString()
		{
			return $"{this.rendszam} - {this.sebesseg} km/h";
		}
	}
}
