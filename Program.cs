using System;

namespace uczę_się
{
	class Program
	{
		static void Main(string[] args)
		{
			Car pierwszy = new Car(1.9, "Focus");
			Car drugi = new Car(2.0, "Mazda");

			pierwszy.wypisz();
		}
	}
}
