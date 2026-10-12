namespace ConsoleApp7
{

    public class BrakSrodkowException : Exception
    {
        public BrakSrodkowException(string message) : base(message) { }
    }

    public class KontoBankowe
    {
        public int saldo = 250;
        
        public void wyplac(int kasa)
        {
            if(kasa > saldo)
            {
                throw new BrakSrodkowException("Probojesz wyplacic wiecej niz masz");
            }
        }
    }
    internal class Program
    {

        public class Osoba
        {
            private int _wiek;
            public int wiek
            {
                get
                {
                    return this._wiek;
                }
                set
                {
                    if (value < 18)
                    {
                        throw new ArgumentOutOfRangeException("wiek nie moze byc mniejszy od 18 lat");
                    }
                    this._wiek = value;
                }
            }
        
        public Osoba(int wiek)
            {
                this._wiek = wiek;
            }
        
        }

        static void Main(string[] args)
        {

            KontoBankowe Konto = new KontoBankowe();
            Konto.wyplac(300);

            //Osoba Marcin = new Osoba(25);

            //try
            //{
            //    Marcin.wiek = 14;
            //    Console.WriteLine($"Marcin jest teraz nielegalny i ma teraz {Marcin.wiek} lat");
            //}
            //catch(ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message );
            //    Console.WriteLine("Marcin jest nielegalny");
            //}


            //try
            //{
            //    Console.WriteLine("Podaj liczbe a");
            //    int a = int.Parse(Console.ReadLine() ?? "");

            //    Console.WriteLine();

            //    Console.WriteLine("Podaj liczbe b");
            //    int b = int.Parse(Console.ReadLine() ?? "");

            //    int wynik = a / b;
            //    Console.WriteLine(wynik);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine($"{ex.Message} \n podaj poprawna liczbe");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"{ex.Message} \n nie dzielimy przez zero");
            //}
            //catch(OverflowException ex)
            //{
            //    Console.WriteLine($"{ex.Message} \n za duza liczba");
            //}

            //Console.WriteLine("koniec dzialania aplikacji
        }
    }
}
