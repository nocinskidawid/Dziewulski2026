namespace ConsoleApp1
{

    public class Produkt
    {
        private string _nazwa;
        private int _cena;
        private int _ilosc;

        public Produkt(string nazwa, int cena, int ilosc)
        {
            Console.WriteLine("Konstruktor z argumentami");
            this._nazwa = nazwa;
            if (cena <= 0) {
                Console.WriteLine("BLAD: Cena mniejsza lub rowna 0");
                return;
            }
            else
            {
                this._cena = cena;
            }
            if (ilosc <= 0)
            {
                Console.WriteLine("BLAD: Ilosc mniejsza lub rowna 0");
                return;
            }
            else
            {
                this._ilosc = ilosc;
            }
        }

        public float WartoscMagazynowa()
        {
            return _cena * _ilosc;
        }

        public string nazwa { get { return _nazwa; } set { _nazwa = value; } }
        public int cena { get { return _cena; } set { _cena = value; } }
        public int ilosc { get { return _ilosc; } set { _ilosc = value; } }
    }

    public class Pracownik
    {
        public string imie;
        public string nazwisko;
        private float _wynagrodzenie;

        public Pracownik(string imie, string nazwisko, float wynagrodzenie)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this._wynagrodzenie = wynagrodzenie;

            if (_wynagrodzenie < 0)
            {
                Console.WriteLine("BLAD: wynagrodzenie mniejsze od 0 (rozwaz zatrudnienie ukrainca)");
                return;
            }
        }

        public void podwyzka(float podwyzka)
        {
            _wynagrodzenie *= podwyzka/100;
        }

        public float wynagrodzenie { get { return _wynagrodzenie;} }
    }

    internal class Program
    {
        static void Main(string[] args)
        { 
            Produkt p = new Produkt("Myszka komputerowa", -1, 2);

            Console.WriteLine($"Produkt: {p.nazwa}, cena: {p.cena}, ilosc: {p.ilosc}, wartosc magazynowa: {p.WartoscMagazynowa()}");

            Pracownik pr = new Pracownik("Kamil", "Kovalenko", 100000);
            Console.WriteLine($"Imie: {pr.imie}, Nazwisko: {pr.nazwisko}, wynagrodzenie: {pr.wynagrodzenie}");
            pr.podwyzka(200);
            Console.WriteLine($"Wynagrodzenie po podwyzce 200% {pr.wynagrodzenie}");



        }
    }
}
