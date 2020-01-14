using System;

namespace dekorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Napoj poproszeKawe = new małaKawa();
            Console.WriteLine(poproszeKawe.GetOpis() + " kosztuje: " + $"{ poproszeKawe.Koszt()}");

            poproszeKawe = new Mleko(poproszeKawe);
            Console.WriteLine(poproszeKawe.GetOpis() + " kosztuje: " + $"{ poproszeKawe.Koszt()}");

            poproszeKawe = new Czekolada(poproszeKawe);
            Console.WriteLine(poproszeKawe.GetOpis() + " kosztuje: " + $"{ poproszeKawe.Koszt()}");

            Napoj poproszeKakao = new kakao();
            poproszeKakao = new Cukier(poproszeKakao);
            Console.WriteLine(poproszeKakao.GetOpis() + " kosztuje: " + $"{ poproszeKakao.Koszt()}");

            Console.ReadKey();
        }
        public abstract class Napoj
        {
            public abstract double Koszt();
            public abstract string GetOpis();
        }
        public class małaKawa : Napoj
        {
            public override double Koszt()
            {
                return 2.00;
            }
            public override string GetOpis()
            {
                return "małaKawa";
            }
        }
        public class sredniaKawa : Napoj
        {
            public override double Koszt()
            {
                return 3.50;
            }
            public override string GetOpis()
            {
                return "sredniaKawa";
            }
        }
        public class duzaKawa : Napoj
        {
            public override double Koszt()
            {
                return 5.00;
            }
            public override string GetOpis()
            {
                return "duzaKawa";
            }
        }
        public class kakao : Napoj
        {
            public override double Koszt()
            {
                return 2.00;
            }
            public override string GetOpis()
            {
                return "kakao";
            }
        }
        public class herbata : Napoj
        {
            public override double Koszt()
            {
                return 2.50;
            }
            public override string GetOpis()
            {
                return "herbata";
            }
        }

        public abstract class NapojDekorator : Napoj
        {
            protected Napoj napoj;
            public NapojDekorator(Napoj _napoj)
            {
                napoj = _napoj;
            }

            public override string GetOpis()
            {
                return napoj.GetOpis();
            }

            public override double Koszt()
            {
                return napoj.Koszt();
            }
        }
        class Mleko : NapojDekorator
        {
            public Mleko(Napoj _napoj) : base(_napoj)
            {
            }

            // zmieniamy sposób obliczania kosztu
            public override double Koszt()
            {
                return 0.50 + napoj.Koszt();
            }

            // oraz opis
            public override string GetOpis()
            {
                return napoj.GetOpis() + ", Mleko";
            }
        }

        class Czekolada : NapojDekorator
        {

            public Czekolada(Napoj _napoj) : base(_napoj)
            {
            }

            // zmieniamy sposób obliczania kosztu
            public override double Koszt()
            {
                return 0.80 + napoj.Koszt();
            }

            // oraz opis
            public override string GetOpis()
            {
                return napoj.GetOpis() + ", Czekolada";
            }
        }
        class MlekobezLaktozy: NapojDekorator
        {
            public MlekobezLaktozy (Napoj _napoj) : base(_napoj)
            {

            }
            public override double Koszt()
            {
                return 0.80 + napoj.Koszt();
            }

            // oraz opis
            public override string GetOpis()
            {
                return napoj.GetOpis() + ", mleko bez laktozy";
            }
        }
        class Cukier : NapojDekorator
        {
            public Cukier(Napoj _napoj) : base(_napoj)
            {

            }
            public override double Koszt()
            {
                return 0.20 + napoj.Koszt();
            }

            // oraz opis
            public override string GetOpis()
            {
                return napoj.GetOpis() + ", cukier";
            }
        }
    }
}
