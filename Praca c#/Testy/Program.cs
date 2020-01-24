using System;
using System.Threading;

namespace Testy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dostałeś Pracę: " +
            "\nPomoc Panoramixowi przy tworzeniu Magicznego Napoju");

            Console.WriteLine("\nPanoramix zdradził Ci skład magicznego napoju:" +
                        "\nJemioła, Korzenie, Homar, Czterolistna Koniczyna, Ryba" +
                        "\nMarchew, Ropa Naftowa, Sól");

            Console.WriteLine("\nTwoim zadaniem jest zdobyć Czterolistną Koniczynę," +
                        "\nkupić Świeżą Rybę(Pamiętaj, byle nie u Ahigieniksa)" +
                        "\ni pozbierać Marchew (przynajmniej 4) ");
            Console.WriteLine("\nWciśnij klawisz kiedy będziesz gotowy");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n1.Zbieraj marchew" +
                        "\n2.Kup rybę u Ahigeniksa" +
                        "\n3.Sam złów rybę");
            
            int i = 1;
            while (i <= 2)
            {
                switch (Console.ReadLine())
                { 
                    case "1":
                        int suma = 1;
                        while (suma <= 4)
                        {
                            if (4 - suma == 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Jeszcze {0} (Wciśnij klawisz)", 4 - suma);
                                Console.ReadLine();
                                suma += 1;
                            }
                        }
                        Console.WriteLine("Zdobyłeś już wszystkie (Wciśnij klawisz żeby przejść dalej)");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\nCo zrobić dalej ?");
                        Console.WriteLine("\n2.Kup rybę u Ahigeniksa" +
                        "\n3.Sam złów rybę");
                        i++;
                    break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Ale Panoramix się wkurzy..., może powininienem jednak sam złowić rybę?");
                        Console.WriteLine("\n2.Kup rybę u Ahigeniksa" +
                        "\n3.Sam złów rybę");
                        break;
                    case "3":
                        Console.WriteLine("Brawo Ja!");
                        i++;
                        break;
                }

            }
            Console.WriteLine("Udało Ci się wykonać zadanie! Zyskujesz + ???? zł");
        }
    }
}
