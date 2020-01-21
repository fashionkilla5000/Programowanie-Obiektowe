using System;

namespace zadania_kolos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba p1 = new Student("Jerzy","Jerzowski",1);
            Osoba p2 = new Wykładowca("Piotr", "Piotrowski", 2);
            System.GenerujUsera(p1);
            System.GenerujUsera(p2);
            Console.ReadKey();
        }
    }
    abstract class Osoba
    {
        public string Imie;
        public string Nazwisko;
        public int id;

        protected Osoba(string imie, string nazwisko, int id)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            this.id = id;
        }
    }
    class Student:Osoba
    {
        public Student(string Imie, string Nazwisko, int id):base(Imie,Nazwisko,id)
        {
            
        }
    }
    class Wykładowca : Osoba
    {
        public Wykładowca(string Imie, string Nazwisko, int id) : base(Imie, Nazwisko, id)
        {

        }
    }
    class System
    {
        public static void GenerujUsera(Osoba o)
        {
            if(o.GetType() == typeof(Student)) //Piotrek mówił że łatwiej if(o is Student)
            {
                Console.WriteLine("w{0}_{1}.{2}",o.id, o.Imie, o.Nazwisko);
            }
            else
            {
                Console.WriteLine("s{0}_{1}.{2}", o.id, o.Imie, o.Nazwisko);
            }
        }
    }
}
