using System;
using System.Collections.Generic;
using System.Linq;

namespace zadania_kolos
{
    class Program
    {
        static void Main(string[] args)
        {
            Liga Ekstraklasa = new Liga("Ekstraklasa");
            Drużyna OrłyiKruki = new Drużyna(Ekstraklasa, "Orły i Kruki");
            Ekstraklasa.DodajDruzyne(OrłyiKruki);
            Zawodnik z1 = new Zawodnik(1234, "Marko", Pozycja.Bramkarz, 1.00);
            Zawodnik z2 = new Zawodnik(1234, "Marko", Pozycja.Obrońca, 1.50);
            Zawodnik z3 = new Zawodnik(1234, "Marko", Pozycja.Obrońca, 2.00);
            Zawodnik z4 = new Zawodnik(1234, "Marko", Pozycja.Obrońca, 3.00);
            Zawodnik z5 = new Zawodnik(1234, "Marko", Pozycja.Obrońca, 1.20);
            Zawodnik z6 = new Zawodnik(1234, "Marko", Pozycja.Pomocnik, 2.20);
            Zawodnik z7 = new Zawodnik(1234, "Marko", Pozycja.Pomocnik, 3.20);
            Zawodnik z8 = new Zawodnik(1234, "Marko", Pozycja.Pomocnik, 4.20);
            Zawodnik z9 = new Zawodnik(1234, "Marko", Pozycja.Pomocnik, 5.20);
            Zawodnik z10 = new Zawodnik(1234, "Marko", Pozycja.Napastnik, 6.20);
            Zawodnik z11 = new Zawodnik(1234, "Marko", Pozycja.Napastnik, 7.20);

            OrłyiKruki.DodajZawodnika(z1);
            OrłyiKruki.DodajZawodnika(z2);
            OrłyiKruki.DodajZawodnika(z3);
            OrłyiKruki.DodajZawodnika(z4);
            OrłyiKruki.DodajZawodnika(z5);
            OrłyiKruki.DodajZawodnika(z6);
            OrłyiKruki.DodajZawodnika(z7);
            OrłyiKruki.DodajZawodnika(z8);
            OrłyiKruki.DodajZawodnika(z9);
            OrłyiKruki.DodajZawodnika(z10);
            OrłyiKruki.DodajZawodnika(z11);

            Console.WriteLine(" wartość = {0}",OrłyiKruki.obliczWartosc());
            Console.ReadKey();
        }
    }
    class Drużyna
    {
        Liga liga;
        string Nazwa;
        List<Zawodnik> zawodnicy = new List<Zawodnik>();

        public Drużyna(Liga liga, string nazwa)
        {
            this.liga = liga;
            Nazwa = nazwa;
        }

        public void DodajZawodnika(Zawodnik z)
        {
            zawodnicy.Add(z);
        }
        
        public double obliczWartosc()
        {
            
            double suma = 0;
            for(int i =0; i< zawodnicy.Count; i++)
            {
                double wartosc = zawodnicy[i].wartosc;
                suma += wartosc;
            }
            return suma;
        }
    }
    class Liga
    {
        List<Drużyna> druzyny = new List<Drużyna>();
        string Nazwa;

        public Liga(string nazwa)
        {
            this.Nazwa = nazwa;
        }

        public void DodajDruzyne(Drużyna d)
        {
            druzyny.Add(d);
        }
        
    }
    enum Pozycja { Bramkarz, Obrońca, Pomocnik, Napastnik };
    class Zawodnik
    {
        long id;
        string Name;
        
        Pozycja pozycja;
        public double wartosc;

        public Zawodnik(long id, string name, Pozycja pozycja, double wartosc)
        {
            this.id = id;
            Name = name;
            this.pozycja = pozycja;
            this.wartosc = wartosc;
        }
    }
    
}
