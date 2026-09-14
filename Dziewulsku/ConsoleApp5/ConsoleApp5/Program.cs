using System.Reflection.Metadata;

namespace ConsoleApp5
{
    internal class Kosc
    {
        public static int LiczbaInstancji;
        public string[] NazwyPlikow =
        {
            "kosc0.png",
            "kosc1.png",
            "kosc2.png",
            "kosc3.png",
            "kosc4.png",
            "kosc5.png",
            "kosc6.png",
        };
        public int LiczbaOczek;
        public int idPliku;
        public bool Dostepna;
        private static Random los = new Random();

        public Kosc(int wartosc)
        {
            if (wartosc < 0 || wartosc > 6)
            {
                wartosc = 0;
            }
            LiczbaOczek = wartosc;
            idPliku = wartosc;
            Dostepna = true;
            LiczbaInstancji++;
        }

        public Kosc()
        {
            int wartosc = los.Next(1, 7);
            LiczbaOczek = wartosc;
            idPliku = wartosc;
            Dostepna = true;
            LiczbaInstancji++;
        }

        public void rzut()
        {
            if (Dostepna)
            {
                int wartosc = los.Next(1, 7);
                LiczbaOczek = wartosc;
                idPliku = wartosc;
            }
        }

        public void zablokuj()
        {
            Dostepna = false;
        }

        public string tekst()
        {
            switch (idPliku)
            {
                case 1:
                    return "jeden";
                case 2:
                    return "dwa";
                case 3:
                    return "trzy";
                case 4:
                    return "cztery";
                case 5:
                    return "piec";
                case 6:
                    return "szesc";
                default:
                    return "zero";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kosc BezArgumentow = new Kosc();

            Console.WriteLine("Podaj wartosc (1-6)");
            int input = int.Parse(Console.ReadLine());
            Kosc ZArgumentem = new Kosc(input);

            Console.WriteLine("##################################################");

            Console.WriteLine("Kosc bez argumentow");
            Console.WriteLine($"Liczba instancji {Kosc.LiczbaInstancji}");
            Console.WriteLine($"Liczba oczek {BezArgumentow.LiczbaOczek} ({BezArgumentow.tekst()})");
            Console.WriteLine($"Nazwa pliku {BezArgumentow.NazwyPlikow[BezArgumentow.LiczbaOczek]}");

            Console.WriteLine("##################################################");

            Console.WriteLine("Kosc z argumentem");
            Console.WriteLine($"Liczba instancji {Kosc.LiczbaInstancji}");
            Console.WriteLine($"Liczba oczek {ZArgumentem.LiczbaOczek} ({ZArgumentem.tekst()})");
            Console.WriteLine($"Nazwa pliku {ZArgumentem.NazwyPlikow[ZArgumentem.LiczbaOczek]}");

            Console.WriteLine("##################################################");

            Console.WriteLine("blokuje kosc bez argumentow...");
            BezArgumentow.zablokuj();

            Console.WriteLine("##################################################");

            Console.WriteLine("Test rzutu kosci z argumentem...");
            Console.WriteLine($"Przed rzutem liczba oczek to {ZArgumentem.LiczbaOczek}");
            ZArgumentem.rzut();
            Console.WriteLine($"Po rzucie liczba oczek to {ZArgumentem.LiczbaOczek}");

        }
    }
}
