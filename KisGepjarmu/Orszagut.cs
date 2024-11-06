using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisGepjarmu
{
	internal class Orszagut
	{
		private List<Jarmu> jarmuvek;

		public Orszagut(List<Jarmu> jarmuvek)
		{
			this.jarmuvek = jarmuvek;
		}

		public void JarmuvekJonnek(string fajlNev)
		{
			try
			{
				StreamReader r = new StreamReader(fajlNev);
				while (!r.EndOfStream)
				{
					string[] adatok = r.ReadLine().Split(';');

                    if (int.TryParse(adatok[3], out int maxSebesseg))
					{
						this.jarmuvek.Add(new Robogo(maxSebesseg, int.Parse(adatok[2]), adatok[1]));
					}
					else
					{
						this.jarmuvek.Add(new AudiS8(bool.Parse(adatok[3]), int.Parse(adatok[2]), adatok[1]));
					}

				}
			}
			catch (IOException ioex)
			{
                Console.WriteLine("Sikertelen fájlolvasás" + ioex);
            }
			catch (Exception ex)
			{
                Console.WriteLine("Sikertelen fájlolvasás" + ex);
            }
		}

		public void KiketMertunkBe()
		{
			try
			{
				StreamWriter w = new StreamWriter("buntetes.txt");
                foreach (Jarmu jarmu in jarmuvek)
                {
					if (jarmu.GetType() == typeof(AudiS8))
					{
						w.WriteLine($"{jarmu} {(jarmu.GyorshajtottE(90) ? "Gyorshajtott" : "Nem hajtott gyorsan")}");
					}
					else
					{
						w.WriteLine($"{jarmu} {(jarmu.HaladhatItt(90) ? "Haladhat itt" : "Nem haladhat itt")}");
					}
                }
				w.Close();
            }
			catch(IOException ioex)
			{
                Console.WriteLine("Sikertelen fájlírás" + ioex);
            }
			catch(Exception ex)
			{
                Console.WriteLine("Sikertelej fájlírás" + ex);
            }
		}
	}
}
