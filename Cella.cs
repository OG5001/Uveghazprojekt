using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazprojekt
{
	internal class Cella
	{
		Pozicio pozicio;
		NovenyFaj novegyFaj;
		int egyedSzam;
		List<Szenzor> szenzorok;
		List<Riasztas> riasztasok;

		public Cella(int x, int y)
		{
			this.pozicio = new Pozicio(x, y);
			this.novegyFaj = null;
			this.egyedSzam = 0;
			this.szenzorok = new List<Szenzor>();
			this.riasztasok = new List<Riasztas>();
		}

		public int EgyedSzam { get => egyedSzam; set => egyedSzam = value; }
		internal Pozicio Pozicio { get => pozicio; set => pozicio = value; }
		internal NovenyFaj NovegyFaj { get => novegyFaj; set => novegyFaj = value; }
		internal List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }
		internal List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }
		public bool UresE
		{
			get
			{
				return this.novegyFaj == null;
			}
		}
		public bool Telepit(NovenyFaj noveny, int mennyiseg)
		{
			bool sikeres = false;
			if (mennyiseg > 0 && !UresE)
			{
				this.novegyFaj = noveny;
				this.egyedSzam = mennyiseg;
				Console.WriteLine($"{novegyFaj.Nev} telepítése sikeresen megtörtént!");
				sikeres = true;
			}
			else if (mennyiseg > 0 && this.novegyFaj.Equals(noveny))
			{
				Noveles(mennyiseg);
			}
			return sikeres;
		}
		public void Noveles(int mennyiseg)
		{
			this.egyedSzam += mennyiseg;
		}
		public void Csokkentes(int mennyiseg)
		{
			this.egyedSzam -= mennyiseg;
			if (egyedSzam <= 0)
			{
				Urites();
			}
		}
		public void Urites()
		{
			this.novegyFaj = null;
			this.egyedSzam = 0;
		}
	}	
}
