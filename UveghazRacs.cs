using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazprojekt
{
	internal class UveghazRacs
	{
		int meret;
		Cella[,] agyasok;
		static Random r = new Random();
		public UveghazRacs(int meret)
		{
			this.meret = meret;
			this.agyasok = new Cella[meret, meret];
		}
		public void Parcellazas()
		{
			for (int i = 0; i < meret; i++) //sorok
			{
				for (int j = 0; j < meret; j++) //oszlopok
				{
					agyasok[i, j] = new Cella(i, j);
				}
			}
		}

		public void Ultetes(List<NovenyFaj>novenyek)
		{
			int index = 0;
			for (int i = 0; i < meret; i++) //sorok
			{
				for (int j = 0; j < meret; j++) //oszlopok
				{
					if (index < novenyek.Count)
					{
						agyasok[i, j].Telepit(novenyek[index++], r.Next(-1, 15));
					}
				}
			}
		}
		public void MatrixKiir()
		{
			for (int i = 0; i < meret; i++)
			{
				Console.WriteLine("------------------------------------------------------------");
				for (int j = 0; j < meret; j++) 
				{
					Console.Write(agyasok[i,j]+"\t");
				}
				Console.WriteLine();
				Console.WriteLine("------------------------------------------------------------");
			}
		}
	}
}
