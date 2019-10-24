using System;
using System.Collections.Generic;
using System.Text;

namespace uczę_się
{
	public class Car
	{
		static int iloscKol;
		private double pojemnoscSilnika;
		private string marka;
		public Car(double pojemnoscSilnika, string marka)
		{
			
			this.pojemnoscSilnika = pojemnoscSilnika;
			this.marka = marka;
		}
		static public Car Create(double pojemnoscSilnika, string marka)
		{
			return new Car(pojemnoscSilnika, marka);
		}
		~Car()
		{
			Console.WriteLine("Zwalniam pamięć");
			Console.ReadKey();
		}
		static Car()
		{
			iloscKol = 4;
		}
		public void wypisz()
		{
			Console.WriteLine("pojemnosc: " + this.pojemnoscSilnika + "marka: " + this.marka + "iloscKol: "+iloscKol);
		}
	}
}
