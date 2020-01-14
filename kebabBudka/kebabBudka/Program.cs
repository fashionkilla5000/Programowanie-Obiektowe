using System;

namespace kebabBudka
{
    class Program
    {
        static void Main(string[] args)
        {
            Kebab malegoPoproszeKebaba = new Mały();
            malegoPoproszeKebaba = new naCienkim(malegoPoproszeKebaba);
            Console.WriteLine("{0} kosztuje {1} zł", malegoPoproszeKebaba.Opis(), malegoPoproszeKebaba.Cena() );
            Console.ReadKey();
        }
        public abstract class Kebab
        {
            public abstract double Cena();
            public abstract string Opis();
        }
        public class Mały : Kebab
        {
            public override double Cena()
            {
                return 10.00;
            }
            public override string Opis()
            {
                return "mały kebab";
            }
        }
        public class Mega : Kebab
        {
            public override double Cena()
            {
                return 13.00;
            }
            public override string Opis()
            {
                return "mega kebab";
            }
        }
        public class Giga : Kebab
        {
            public override double Cena()
            {
                return 16.00;
            }
            public override string Opis()
            {
                return "giga kebab";
            }
        }
        public class KebabDekorator: Kebab
        {
            protected Kebab _kebab;
            public KebabDekorator(Kebab kebab)
            {
                _kebab = kebab;
            }
            public override double Cena()
            {
                return _kebab.Cena();
            }
            public override string Opis()
            {
                return _kebab.Opis();
            }
        }
        public class naGrubym : KebabDekorator
        {
            public naGrubym(Kebab kebab) : base(kebab)
            {
            }
            public override double Cena()
            {
                return base.Cena();
            }
            public override string Opis()
            {
                return base.Opis() + " ,na Grubym ";
            }
        }
        public class naCienkim : KebabDekorator
        {
            public naCienkim(Kebab kebab) : base(kebab)
            {
            }
            public override double Cena()
            {
                return base.Cena();
            }
            public override string Opis()
            {
                return base.Opis() + " ,na Cienkim ";
            }
        }
    }
}
